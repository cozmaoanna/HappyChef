#pragma checksum "C:\Users\Cornel\Documents\Projects\HappyChef\HappyChef\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1929d4c07fb5024dc21bdc31f1416c12fdf2e1a5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Eat n Track </h1>\r\n<br>\r\nLet\'s start by saying you won\'t spend too much time finding a quick and easy recipe from our thousands of options.\r\n<br>\r\n");
            __builder.OpenComponent<HappyChef.Client.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "F");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<HappyChef.Client.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
