using HappyChef.Server.Data;
using HappyChef.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavouritesController : ControllerBase
    {
        private readonly ApplicationDbContext contextfav;
        private object sqlParams;

        public FavouritesController(ApplicationDbContext context)
        {
            this.contextfav = context;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> IAmHere()
        {
            return Ok("I am here");
        }


        [HttpGet]
        public async Task<ActionResult<List<FavouritesModel>>> Get()
        {
            return await contextfav.FavouritesList.ToListAsync();
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<FavouritesModel>>> GetMyFavourites(int userId)
        {
            return await contextfav.FavouritesList.Where(x => x.UserId == userId).ToListAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<String>> GetFavoriteSummary(int userId)
        {
            var query = @"select FavouriteLabel, RecipeUri, COUNT(RecipeUri) as total from FavouritesList
            group by RecipeUri, FavouriteLabel
            order by total desc";
            return ExecuteSql(query);

            //  return await contextfav.FavouritesList.Where(x => x.UserId == userId).ToListAsync();
        }




        






        private string ExecuteSql(string query)
        {



            var conn = contextfav.Database.GetDbConnection() as SqlConnection;
            
            using (SqlCommand command = new SqlCommand(query, conn))

            {
                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }
                using (DataTable dt = new DataTable())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt); List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                        Dictionary<string, object> row;
                        foreach (DataRow dr in dt.Rows)
                        {
                            row = new Dictionary<string, object>();
                            foreach (DataColumn col in dt.Columns)
                            {
                                row.Add(col.ColumnName, dr[col]);
                            }
                            rows.Add(row);
                        }
                        return JsonConvert.SerializeObject(rows);
                    }
                }
            }
        }




        [HttpGet("{id}", Name = "GetFav")]

        public async Task<ActionResult<FavouritesModel>> Get(int id)
        {
            return await contextfav.FavouritesList.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FavouritesModel favourite)
        {

            var favItem = contextfav.FavouritesList.FirstOrDefault(x => x.UserId == favourite.UserId && x.RecipeUri == favourite.RecipeUri);
            if (favItem == null)
            {
                contextfav.Add(favourite);
                await contextfav.SaveChangesAsync();
                return Ok(new { favourite = favourite, msg = "Added to favourites" });
            }
            //return new CreatedAtRouteResult("GetFav", new { id = favourites.Id }, favourites);
            return Ok(new { favourite = favItem, msg = "Not added because already in list" });
        }

        [HttpPut]
        public async Task<ActionResult> Put(FavouritesModel favourites)
        {
            contextfav.Entry(favourites).State = EntityState.Modified;
            await contextfav.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var favourite = new FavouritesModel { Id = id };
            contextfav.Remove(favourite);
            await contextfav.SaveChangesAsync();
            return NoContent();
        }






    }


}
