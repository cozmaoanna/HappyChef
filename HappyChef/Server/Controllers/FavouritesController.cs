using HappyChef.Server.Data;
using HappyChef.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavouritesController : ControllerBase
    {
        private readonly ApplicationDbContext contextfav;

        public FavouritesController(ApplicationDbContext context)
        {
            this.contextfav = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<FavouritesModel>>> Get()
        {
            return await contextfav.FavouritesList.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetFav")]

        public async Task<ActionResult<FavouritesModel>> Get(int id)
        {
            return await contextfav.FavouritesList.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(FavouritesModel favourites)
        {
            contextfav.Add(favourites);
            await contextfav.SaveChangesAsync();
            return new CreatedAtRouteResult("GetFav", new { id = favourites.Id }, favourites);
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
