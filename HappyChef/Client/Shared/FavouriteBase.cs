using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HappyChef.Client.Models;
using Microsoft.AspNetCore.Components;

namespace HappyChef.Client.Shared
{
    public class FavouriteBase : ComponentBase
    {
        public Recipe viewrecipe { get; set; }
        public ReceipeViewState viewstate = ReceipeViewState.List;

        [Inject]
        HttpClient http { get; set; }
        public FavouriteBase()
        {
            
        }
        public async Task<Recipe> LoadRecipe(string recipeUri)
        {
            var recipeId = recipeUri.Split("_")[1];
            var apiUri = $"https://api.edamam.com/api/recipes/v2/{recipeId}?app_id=b7d7673f&app_key=165ba23ed5126d12ecfe3cd57091d539&type=public";
            var recipeResult = await http.GetFromJsonAsync<HappyChef.Client.Models.RecipeResult>(apiUri);
            return recipeResult.Recipe;
        }

        public  Task BackToFavourites()
        {
            viewstate = ReceipeViewState.List;
            this.StateHasChanged();
            return Task.CompletedTask;

        }
    }
}
