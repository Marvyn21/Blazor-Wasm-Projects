#pragma checksum "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Components\MySecondComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ef5e4a5c959f161120bff7b45d3d2d4b0a3c43e2d8c01d416d39a455f1f2eb1"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlazorApp.Client.Components
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
    public partial class MySecondComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    CurrentCounterValue in MySecondComponent is ");
#nullable restore
#line (2,50)-(2,69) 24 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Components\MySecondComponent.razor"
__builder.AddContent(2, CurrentCounterValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\ASP .NET CORE\MyBlazorApp\MyBlazorApp\Client\Components\MySecondComponent.razor"
      
    [Parameter]
    public int CurrentCounterValue { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
