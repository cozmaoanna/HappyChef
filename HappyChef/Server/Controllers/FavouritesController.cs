using HappyChef.Server.Data;
using HappyChef.Server.Models;
using HappyChef.Shared.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
using System.Security.Claims;

namespace HappyChef.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavouritesController : ControllerBase
    {
        private readonly ApplicationDbContext contextfav;
        private object sqlParams;
        private readonly UserManager<ApplicationUser> _userManager;

        public FavouritesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,IHttpContextAccessor haccess)
        {
            this.contextfav = context;
            this._userManager = userManager;
            
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> IAmHere()
        {
            return Ok("I am here");
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<FavouritesModel>>> GetMyFavourites()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await contextfav.FavouritesList.Where(x => x.UserId == userId).ToListAsync();
            //   return await contextfav.FavouritesList.ToListAsync();
        }


        //[HttpGet]
        //[Route("[action]")]
        //public async Task<ActionResult<List<FavouritesModel>>> GetMyFavourites(string userId)
        //{
        //    return await contextfav.FavouritesList.Where(x => x.UserId == userId).ToListAsync();
        //}

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetFavoriteSummary()
        {
            var results = await contextfav.FavouritesList
                .GroupBy(x => new { x.RecipeUri, x.FavouriteLabel , x.FavouriteCalories, x.FavouriteTotalTime })
                .Select(group => new
                {
                    RecipeUri = group.Key.RecipeUri,
                    FavouriteLabel = group.Key.FavouriteLabel,
                    FavouriteCalories = group.Key.FavouriteCalories,
                    FavouriteTotalTime = group.Key.FavouriteTotalTime,
                    Total = group.Count()
                })
                .OrderByDescending( x=> x.Total)
                .Where( x=> x.Total > 1) // Only bring back a recipe if it has more than 1 like
                .ToListAsync();

            return Ok(results);
        }


        [HttpGet("{id}", Name = "GetFav")]

        public async Task<ActionResult<FavouritesModel>> Get(int id)
        {
            return await contextfav.FavouritesList.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FavouritesModel favourite)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            favourite.UserId = userId;

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
            var favourite = contextfav.FavouritesList.FirstOrDefault(x => x.Id == id);
            if(favourite != null)
            {
                contextfav.Remove(favourite);
                await contextfav.SaveChangesAsync();
            }
           
            return Ok("Favourite was removed");
        }






    }


}
