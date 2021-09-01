// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HappyChef.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using HappyChef.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\Pages\Favourites.razor"
using HappyChef.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\Pages\Favourites.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/favourites")]
    public partial class Favourites : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\CozmaO\source\repos\HappyChef\HappyChef\Client\Pages\Favourites.razor"
       
    FavouritesModel[] favourites { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadFavourites();
    }

    async Task LoadFavourites()
    {
        favourites = await http.GetFromJsonAsync<FavouritesModel[]>("api/favourites");


    }





    private async Task RemoveRecipe(Recipe recipe)
    {
        FavouritesModel favourite = new FavouritesModel() { RecipeUri = recipe.Uri, FavouriteLabel = recipe.Label, FavouriteCalories = recipe.Calories, UserId = 1 };
        await http.PostAsJsonAsync("api/favourites", favourite);

    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
