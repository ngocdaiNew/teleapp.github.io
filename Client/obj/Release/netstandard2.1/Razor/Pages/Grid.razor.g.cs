#pragma checksum "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "837d73525f696464b0fe20019e14573c8277d293"
// <auto-generated/>
#pragma warning disable 1591
namespace TeleApp.Client.Pages
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
#line 5 "C:\Users\ngocd\source\repos\TeleApp\Client\_Imports.razor"
using Microsoft.JSInterop;

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
#line 3 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
using TeleApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
using TeleApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grid")]
    public partial class Grid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row my-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 col-lg-9 border-right");
            __builder.AddMarkupContent(8, "\r\n            ");
            __Blazor.TeleApp.Client.Pages.Grid.TypeInference.CreateTelerikGrid_0(__builder, 9, 10, 
#nullable restore
#line 10 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                forecasts

#line default
#line hidden
#nullable disable
            , 11, "550px", 12, 
#nullable restore
#line 10 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                       GridFilterMode.FilterMenu

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                   true

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                   true

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                   20

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 11 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                    UpdateHandler

#line default
#line hidden
#nullable disable
            ), 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                              DeleteHandler

#line default
#line hidden
#nullable disable
            ), 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                        CreateHandler

#line default
#line hidden
#nullable disable
            ), 22, 
#nullable restore
#line 12 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                                                  GridEditMode.Inline

#line default
#line hidden
#nullable disable
            , 23, (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(25);
                __builder2.AddAttribute(26, "Field", "Id");
                __builder2.AddAttribute(27, "Title", "Id");
                __builder2.AddAttribute(28, "Width", "100px");
                __builder2.AddAttribute(29, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Groupable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(32);
                __builder2.AddAttribute(33, "Field", "Date");
                __builder2.AddAttribute(34, "Width", "220px");
                __builder2.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n                            ");
                    __builder3.AddContent(37, 
#nullable restore
#line 17 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                              (context as WeatherForecast).Date.ToString("dddd, dd MMM yyyy")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(38, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(40);
                __builder2.AddAttribute(41, "Field", "TemperatureC");
                __builder2.AddAttribute(42, "Title", "Temp. C");
                __builder2.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(44, "\r\n                            ");
                    __builder3.AddContent(45, 
#nullable restore
#line 22 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                              (context as WeatherForecast).TemperatureC.ToString("N1")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(46, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(48);
                __builder2.AddAttribute(49, "Field", "TemperatureF");
                __builder2.AddAttribute(50, "Title", "Temp. F");
                __builder2.AddAttribute(51, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                            ");
                    __builder3.AddContent(53, 
#nullable restore
#line 27 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                              (context as WeatherForecast).TemperatureF.ToString("N1")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(54, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(56);
                __builder2.AddAttribute(57, "Field", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(59);
                __builder2.AddAttribute(60, "Width", "200px");
                __builder2.AddAttribute(61, "Resizable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(63, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(64);
                    __builder3.AddAttribute(65, "Command", "Save");
                    __builder3.AddAttribute(66, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                 IconName.Save

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "ShowInEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(69, "Update");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(71);
                    __builder3.AddAttribute(72, "Command", "Edit");
                    __builder3.AddAttribute(73, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                 IconName.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Primary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(76, "Edit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(78);
                    __builder3.AddAttribute(79, "Command", "Delete");
                    __builder3.AddAttribute(80, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                   IconName.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(82, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(84);
                    __builder3.AddAttribute(85, "Command", "Cancel");
                    __builder3.AddAttribute(86, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                   IconName.Cancel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "ShowInEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(89, "Cancel");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                ");
            }
            , 92, (__builder2) => {
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(94);
                __builder2.AddAttribute(95, "Command", "Add");
                __builder2.AddAttribute(96, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                            IconName.Plus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "Primary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(99, "Add Forecast");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(101);
                __builder2.AddAttribute(102, "Command", "ExcelExport");
                __builder2.AddAttribute(103, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                    IconName.FileExcel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(105, "Export to Excel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                ");
            }
            , 107, (__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridExcelExport>(109);
                __builder2.AddAttribute(110, "FileName", "weather-forecasts");
                __builder2.AddAttribute(111, "AllPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.AddMarkupContent(115, @"<div class=""col-12 col-lg-3 mt-3 mt-lg-0"">
            <h3>Telerik UI for Blazor Grid</h3>
            <p>
                The Telerik UI for Blazor Data Grid includes a comprehensive set of ready-to-use
                <a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/grid/overview"">features</a> covering
                everything from paging, sorting, filtering, editing, and grouping to row virtualization and
                accessibility/keyboard support.
            </p>

            <p>
                This example demonstrates CRUD operations with data from a service. In a real application, you would
                probably replace the service with something suitable (for example, EF for a server-side app or HTTP endpoints
                for a WASM app). Depending on how you store the grid data, you may also need to update the view model data -
                read more about this in the code comments.
            </p>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ngocd\source\repos\TeleApp\Client\Pages\Grid.razor"
       
    List<WeatherForecast> forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetForecasts();
    }

    async Task GetForecasts()
    {
        forecasts = await ForecastService.GetForecastListAsync(DateTime.Now);
    }

    // Sample CUD operations below that call a service
    // they also update the local view data - this is required when the grid data is not tied
    // directly to an IQueriable that fetches from an EF context (possible only in server blazor)
    // this sample uses the item from the grid immediately, but in a real app
    // you may return an updated/inserted/deleted item data from the service and use that instead
    // or add code to fetch all the grid data anew (which might be a performance hit but for data that updates often may be helpful)

    public async Task DeleteHandler(GridCommandEventArgs args)
    {
        WeatherForecast currItem = args.Item as WeatherForecast;

        await ForecastService.DeleteForecastAsync(currItem);

        // update the view data
        forecasts.Remove(currItem);
    }

    public async Task CreateHandler(GridCommandEventArgs args)
    {
        WeatherForecast currItem = args.Item as WeatherForecast;

        await ForecastService.InsertForecastAsync(currItem);

        // update the view data
        currItem.Id = forecasts.Count + 1;
        forecasts.Insert(0, currItem);
    }

    public async Task UpdateHandler(GridCommandEventArgs args)
    {
        WeatherForecast currItem = args.Item as WeatherForecast;

        await ForecastService.UpdateForecastAsync(currItem);

        // update the view data
        var matchingItem = forecasts.FirstOrDefault(c => c.Id == currItem.Id);
        if (matchingItem != null)
        {
            matchingItem.Summary = currItem.Summary;
            matchingItem.TemperatureC = currItem.TemperatureC;
            matchingItem.Date = currItem.Date;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.TeleApp.Client.Pages.Grid
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Telerik.Blazor.GridFilterMode __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<global::Telerik.Blazor.Components.GridCommandEventArgs> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<global::Telerik.Blazor.Components.GridCommandEventArgs> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.EventCallback<global::Telerik.Blazor.Components.GridCommandEventArgs> __arg11, int __seq12, global::Telerik.Blazor.GridEditMode __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13, int __seq14, global::Microsoft.AspNetCore.Components.RenderFragment __arg14, int __seq15, global::Microsoft.AspNetCore.Components.RenderFragment __arg15)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Height", __arg1);
        __builder.AddAttribute(__seq2, "FilterMode", __arg2);
        __builder.AddAttribute(__seq3, "Sortable", __arg3);
        __builder.AddAttribute(__seq4, "Pageable", __arg4);
        __builder.AddAttribute(__seq5, "PageSize", __arg5);
        __builder.AddAttribute(__seq6, "Groupable", __arg6);
        __builder.AddAttribute(__seq7, "Resizable", __arg7);
        __builder.AddAttribute(__seq8, "Reorderable", __arg8);
        __builder.AddAttribute(__seq9, "OnUpdate", __arg9);
        __builder.AddAttribute(__seq10, "OnDelete", __arg10);
        __builder.AddAttribute(__seq11, "OnCreate", __arg11);
        __builder.AddAttribute(__seq12, "EditMode", __arg12);
        __builder.AddAttribute(__seq13, "GridColumns", __arg13);
        __builder.AddAttribute(__seq14, "GridToolBar", __arg14);
        __builder.AddAttribute(__seq15, "GridExport", __arg15);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
