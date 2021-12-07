// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace vagtplanen.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
using vagtplanen.Client.Components.Volunteer_components;

#line default
#line hidden
#nullable disable
    public partial class TeamPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
       

    [Parameter] public Team tea { get; set; }

    // Kode til AvailableShifts Modal Dialog
    public bool AvailableShiftsDialogOpen { get; set; }

    public void OpenAvailableShiftsDialog()
    {
        AvailableShiftsDialogOpen = true;
        StateHasChanged();
    }

    public void OnAvailableShiftsDialogClose(bool accepted, Shift s)
    {
        AvailableShiftsDialogOpen = false;
        StateHasChanged();
    }

    // Kode til AllCoupons Modal Dialog
    public bool AllCouponsDialogOpen { get; set; }

    public void OpenAllCouponsDialog()
    {
        AllCouponsDialogOpen = true;
        StateHasChanged();
    }

    public void OnAllCouponsDialogClose(bool accepted)
    {
        AllCouponsDialogOpen = false;
        StateHasChanged();
    }


    // Kode til MyCoupons Modal Dialog
    public bool MyCouponsDialogOpen { get; set; }

    public void OpenMyCouponsDialog()
    {
        MyCouponsDialogOpen = true;
        StateHasChanged();
    }

    public void OnMyCouponsDialogClose(bool accepted)
    {
        MyCouponsDialogOpen = false;
        StateHasChanged();
    }

    // Kode til ShiftsScheme Modal Dialog
    public bool ShiftsSchemeDialogOpen { get; set; }

    public void OpenShiftsSchemeDialog()
    {
        ShiftsSchemeDialogOpen = true;
        StateHasChanged();
    }

    public void OnShiftsSchemeDialogClose(bool accepted)
    {
        ShiftsSchemeDialogOpen = false;
        StateHasChanged();
    }

    public void Reload()
    {
        uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
        tea = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591