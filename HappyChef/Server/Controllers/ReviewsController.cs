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
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext contextreview;
        private object sqlParams;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReviewsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,IHttpContextAccessor haccess)
        {
            this.contextreview = context;
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
        public async Task<ActionResult<List<FavouritesModel>>> GetRecipeReviews(string recipeUri)
        {
            return default;
            //return await contextreview.FavouritesList.Where(x => x.UserId == userId).ToListAsync();
            //   return await contextfav.FavouritesList.ToListAsync();
        }

    }


}
