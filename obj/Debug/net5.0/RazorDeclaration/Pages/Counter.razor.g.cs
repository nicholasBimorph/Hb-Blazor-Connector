// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HbBlazorConnector.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using HbBlazorConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using HbBlazorConnector.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\_Imports.razor"
using HB.RestAPI.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Counter.razor"
       


    public MatTheme BlazorConnectorTheme;

    private int _currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; }

    private bool Hide { get; set; } = false;

    private void IncrementCount()
    {

        _currentCount += IncrementAmount;
    }

    private void Clear()
    {
        _currentCount = 0;

        this.IncrementAmount = 0;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
