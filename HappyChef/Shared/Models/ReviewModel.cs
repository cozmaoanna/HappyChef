using System;
using System.Collections.Generic;
using System.Text;

namespace HappyChef.Shared.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RecipeUri { get; set; }
        public string ReviewText { get; set; }
        public int Stars { get; set; }
        public DateTime DateStamp { get; set; }
    }
}
