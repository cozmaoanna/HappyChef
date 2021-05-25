using System;
using System.Collections.Generic;
using System.Text;

namespace HappyChef.Shared.Models
{
    public class FavouritesModel
    {
        public int Id { get; set; }
        public string FavouriteLabel { get; set; }
        public float FavouriteCalories { get; set; }
        public float FavouriteTotalTime { get; set; }

    }
}
