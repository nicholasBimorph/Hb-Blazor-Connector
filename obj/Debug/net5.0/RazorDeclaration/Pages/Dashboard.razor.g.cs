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
#nullable restore
#line 3 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HB.RestAPI.Core.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HB.RestAPI.Core.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HB.RestAPI.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HbBlazorConnector.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using System.Diagnostics.Eventing.Reader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HB.RestAPI.Core.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using HB.RestAPI.Core.Models.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Workshops\HbBlazorConnector\Pages\Dashboard.razor"
       

    ApplicationDataContainer _receivedData;

    readonly IList<HbArea> _areaObjects = null;

    private IList<string> _categoryTypes = null;

    protected override async Task OnInitializedAsync()
    {

        string response = await HbApiClient.GetRequest(HbApiEndPoints.GetLatestEndPoint);

        _receivedData =  Serializer.Deserialize<ApplicationDataContainer>(response);

        var hbObjects = HbObjectFactory.Create(_receivedData.ApplicationData);

        _categoryTypes = ExtractCategoriesForTable(hbObjects);

    }

    /// <summary>
    /// Extracts all the column header categories that will be available
    /// </summary>
    /// <returns></returns>
    private IList<string> ExtractCategoriesForTable(IList<IHbObject> hbObjects)
    {
        IList<string> categoryTypesTemp = new List<string>();

        foreach (var hbObject in hbObjects)
        {
            if (hbObject is HbArea hbArea)
            {
                var properties = hbArea.Properties;

                foreach (var parameter in properties)
                {
                    string categoryNameCamelcase = parameter.Name;

                    if (!categoryTypesTemp.Contains(categoryNameCamelcase))
                        categoryTypesTemp.Add(categoryNameCamelcase);
                }
            }
        }

        return categoryTypesTemp;
    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHbFactory HbObjectFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISerializer Serializer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HbApiEndPoints HbApiEndPoints { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HBApiClient HbApiClient { get; set; }
    }
}
#pragma warning restore 1591