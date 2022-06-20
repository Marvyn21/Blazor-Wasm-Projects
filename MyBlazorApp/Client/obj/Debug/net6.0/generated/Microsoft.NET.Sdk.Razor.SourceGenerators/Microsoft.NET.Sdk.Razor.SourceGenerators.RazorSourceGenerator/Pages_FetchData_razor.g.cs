﻿#pragma checksum "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57466a27fe7139c8e8359bd632b8b2f8462da2ae2799f4ec31fa77a0cc2a4393"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using MyBlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using MyBlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\_Imports.razor"
using MyBlazorApp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
using MyBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Weather forecast");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(5, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 11 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 27 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line (30,26)-(30,59) 25 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(13, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line (31,26)-(31,47) 25 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(16, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line (32,26)-(32,47) 25 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(19, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line (33,26)-(33,42) 25 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(22, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Pages\FetchData.razor"
       
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
