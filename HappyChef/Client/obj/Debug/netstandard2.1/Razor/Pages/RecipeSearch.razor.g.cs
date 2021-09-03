#pragma checksum "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfcc4ffedfe617050cbbc59eaa5575feada559e"
// <auto-generated/>
#pragma warning disable 1591
namespace HappyChef.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
using HappyChef.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
using HappyChef.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipesearch")]
    public partial class RecipeSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search recipes</h3>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Recipe Name");
            __builder.AddAttribute(3, "class", "round");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                                          (val) => RecipeSearching(val)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n<br>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
 if (searchresult != null && searchresult.hits != null)
{




#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 31 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
         foreach (var item in searchresult.hits)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-header");
            __builder.AddContent(19, 
#nullable restore
#line 35 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                              item.Recipe.Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-footer");
            __builder.AddContent(23, "Calories : ");
            __builder.AddContent(24, 
#nullable restore
#line 36 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                                         item.Recipe.Calories

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-footer");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenComponent<HappyChef.Client.Components.RecipeDetailsComponent>(29);
            __builder.AddAttribute(30, "Recipe", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HappyChef.Client.Models.Recipe>(
#nullable restore
#line 38 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                                                                     item.Recipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-footer");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "submit");
            __builder.AddAttribute(38, "class", "btn btn-success");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                                                               () => CreateFavourite(item.Recipe)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Add to favourites");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "submit");
            __builder.AddAttribute(44, "class", "btn btn-success");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
                                                                               () => GetFavorite()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Get Site favorites");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    <br>\r\n\r\n\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                <br>\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            <br>\r\n");
#nullable restore
#line 67 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 71 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\RecipeSearch.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal user { get; set; }

    private List<Recipe> recipeList;
    private HappyChef.Client.Models.GetRecipeModel searchresult { get; set; }


    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationStateTask).User;
    }


    private async Task RecipeSearching(ChangeEventArgs val)
    {
        string title = val.Value.ToString();

        var url = String.Format(@"https://api.edamam.com/search?q={0}&app_id=b7d7673f&app_key=165ba23ed5126d12ecfe3cd57091d539&from=0&to=6", title);
        searchresult = await httpClient.GetFromJsonAsync<HappyChef.Client.Models.GetRecipeModel>(url);
        recipeList = new List<Recipe>();
        if (searchresult != null)
        {
            foreach (var item in searchresult.hits)
            {
                recipeList.Add(item.Recipe);
            }
        }
        this.StateHasChanged();
    }



    private async Task CreateFavourite(Recipe recipe)
    {

        FavouritesModel favourite = new FavouritesModel()
        {
            RecipeUri = recipe.Uri,
            FavouriteLabel = recipe.Label,
            FavouriteCalories = recipe.Calories,
            FavouriteTotalTime = recipe.TotalTime
        };
        await httpClient.PostAsJsonAsync("api/favourites", favourite);
        Toaster.Success($"{recipe.Label} added to favs");
    }

    private async Task GetFavorite()
    {
        var recipes = await httpClient.GetStringAsync("api/favourites/GetFavoriteSummary");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Sotsera.Blazor.Toaster.IToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
