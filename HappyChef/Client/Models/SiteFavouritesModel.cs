using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Client.Models
{
    public class SiteFavouritesModel
    {
        public string RecipeUri { get; set; }
        public string FavouriteLabel { get; set; }
        public float FavouriteCalories { get; set; }
        public float FavouriteTotalTime { get; set; }
        public int Total { get; set; }
    }
}
