#pragma checksum "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e421c30991e874c42ac48d2ec6d47a67d43079f"
// <auto-generated/>
#pragma warning disable 1591
namespace TeleApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using TeleApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using TeleApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using TeleApp.Shared.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using TeleApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Faso.Blazor.SpinKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class CultureChooser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<strong>Ngôn ngữ: </strong>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
                   Culture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Culture = __value, Culture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 10 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
         foreach (var culture in SupportedCultures)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
                            culture

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
                                      culture.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 13 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\ngocd\source\repos\TeleApp\Client\Shared\CultureChooser.razor"
      
    private protected readonly CultureInfo[] SupportedCultures = new[]
       {
            new CultureInfo("en"),
            new CultureInfo("vi")
        };

    // based on https://github.com/pranavkm/LocSample
    private protected CultureInfo Culture
    {
        get => CultureInfo.CurrentUICulture;
        set
        {
            if (CultureInfo.CurrentUICulture != value)
            {
                var jsRuntime = (IJSInProcessRuntime)JSRuntime;
                jsRuntime.InvokeVoid("blazorCulture.set", value.Name);

                NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
