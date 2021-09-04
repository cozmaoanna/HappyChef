#pragma checksum "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ed5123bc1ce099e8f4257436e9b99799f72a76"
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
#line 13 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

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
#line 4 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
using HappyChef.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/favourites")]
    public partial class Favourites : FavouriteBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Favourites</h3>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
  

    switch (viewstate)
    {
        case ReceipeViewState.List:
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
             if (favourites == null)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, " Loading");
#nullable restore
#line 19 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                     
            }
            else if (favourites.Length == 0)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, " You dont have any favourites yet, search for a recipe and add it as a favourite");
#nullable restore
#line 23 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                                                             
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "                ");
            __Blazor.HappyChef.Client.Pages.Favourites.TypeInference.CreateDxDataGrid_0(__builder, 4, 5, 
#nullable restore
#line 27 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                   favourites

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 27 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                          true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 27 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 27 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(11);
                __builder2.AddAttribute(12, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                              nameof(FavouritesModel.FavouriteLabel)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Caption", "Recipe Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(15);
                __builder2.AddAttribute(16, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                              nameof(FavouritesModel.FavouriteCalories)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Caption", "Calories");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(19);
                __builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                              nameof(FavouritesModel.FavouriteTotalTime)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Caption", "Prep Time (min)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(23);
                __builder2.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                              nameof(FavouritesModel.FavouriteTotalTime)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Caption", "Actions");
                __builder2.AddAttribute(26, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n");
#nullable restore
#line 33 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                              

                                var favourite = context as FavouritesModel;
                            

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(28, "                            ");
                    __builder3.OpenElement(29, "button");
                    __builder3.AddAttribute(30, "type", "submit");
                    __builder3.AddAttribute(31, "class", "btn btn-warning");
                    __builder3.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                                      () => RemoveRecipe(favourite)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(33, "Remove");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                            ");
                    __builder3.OpenElement(35, "button");
                    __builder3.AddAttribute(36, "type", "submit");
                    __builder3.AddAttribute(37, "class", "btn btn-success");
                    __builder3.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                                      () => ShowRecipe(favourite.RecipeUri)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(39, "View Recipe");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 42 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
             
            break;
        case ReceipeViewState.View:


#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-sm btn-primary mb-3");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                   BackToFavourites

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, " Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenComponent<HappyChef.Client.Components.RecipeDetailsComponent>(49);
            __builder.AddAttribute(50, "Recipe", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HappyChef.Client.Models.Recipe>(
#nullable restore
#line 48 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
                                                                         viewrecipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 50 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
            break;
        default:
            break;
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Favourites.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal user { get; set; }

    FavouritesModel[] favourites { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadFavourites();
    }

    async Task LoadFavourites()
    {
        favourites = await http.GetFromJsonAsync<FavouritesModel[]>("api/favourites/GetMyFavourites");
        this.StateHasChanged();

    }


    private async Task RemoveRecipe(FavouritesModel favourite)
    {
        var result = await http.DeleteAsync($"api/favourites/{favourite.Id}");
        Toaster.Success("Favourite was deleted");
        await LoadFavourites();
    }

    async Task ShowRecipe(string recipeUri)
    {
        viewrecipe = await LoadRecipe(recipeUri);
        viewstate = ReceipeViewState.View;
        this.StateHasChanged();
    }

   






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Sotsera.Blazor.Toaster.IToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.HappyChef.Client.Pages.Favourites
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ShowPager", __arg1);
        __builder.AddAttribute(__seq2, "AllowSort", __arg2);
        __builder.AddAttribute(__seq3, "ShowFilterRow", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
