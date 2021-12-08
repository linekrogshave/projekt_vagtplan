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
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/CoordinatorPage.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/CoordinatorPage.razor"
using vagtplanen.Client.Components.Coordinator_components;

#line default
#line hidden
#nullable disable
    public partial class CoordinatorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 141 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/CoordinatorPage.razor"
       
    [Parameter] public Coordinator coor { get; set; }

    // Kode til SeeShifts Modal Dialog
    public bool SeeShiftsDialogOpen { get; set; }

    public void OpenSeeShiftsDialog()
    {
        SeeShiftsDialogOpen = true;
        StateHasChanged();
    }

    public void OnSeeShiftsDialogClose(bool accepted)
    {
        SeeShiftsDialogOpen = false;
        StateHasChanged();
    }


    // Kode til CreateShifts Modal Dialog
    public bool CreateShiftsDialogOpen { get; set; }

    public void OpenCreateShiftsDialog()
    {
        CreateShiftsDialogOpen = true;
        StateHasChanged();
    }

    public void OnCreateShiftsDialogClose(bool accepted)
    {
        CreateShiftsDialogOpen = false;
        StateHasChanged();
    }


    // Kode til SeeVolunteers Modal Dialog
    public bool SeeVolunteersDialogOpen { get; set; }

    public void OpenSeeVolunteersDialog()
    {
        SeeVolunteersDialogOpen = true;
        StateHasChanged();
    }

    public void OnSeeVolunteersDialogClose(bool accepted)
    {
        SeeVolunteersDialogOpen = false;
        StateHasChanged();
    }

    // Kode til CreateVolunteers Modal Dialog
    public bool CreateVolunteersDialogOpen { get; set; }

    public void OpenCreateVolunteersDialog()
    {
        CreateVolunteersDialogOpen = true;
        StateHasChanged();
    }

    public void OnCreateVolunteersDialogClose(bool accepted)
    {
        CreateVolunteersDialogOpen = false;
        StateHasChanged();
    }

    // Kode til EditVolunteers Modal Dialog
    public bool EditVolunteersDialogOpen { get; set; }

    public void OpenEditVolunteersDialog()
    {
        EditVolunteersDialogOpen = true;
        StateHasChanged();
    }

    public void OnEditVolunteersDialogClose(bool accepted)
    {
        EditVolunteersDialogOpen = false;
        StateHasChanged();
    }

    // Kode til SeeCoordinators Modal Dialog
    public bool SeeCoordinatorsDialogOpen { get; set; }

    public void OpenSeeCoordinatorsDialog()
    {
        SeeCoordinatorsDialogOpen = true;
        StateHasChanged();
    }

    public void OnSeeCoordinatorsDialogClose(bool accepted)
    {
        SeeCoordinatorsDialogOpen = false;
        StateHasChanged();
    }

    // Kode til CreateCoordinators Modal Dialog
    public bool CreateCoordinatorsDialogOpen { get; set; }

    public void OpenCreateCoordinatorsDialog()
    {
        CreateCoordinatorsDialogOpen = true;
        StateHasChanged();
    }

    public void OnCreateCoordinatorsDialogClose(bool accepted)
    {
        CreateCoordinatorsDialogOpen = false;
        StateHasChanged();
    }

    // Kode til EditCoordinators Modal Dialog
    public bool EditCoordinatorsDialogOpen { get; set; }

    public void OpenEditCoordinatorsDialog()
    {
        EditCoordinatorsDialogOpen = true;
        StateHasChanged();
    }

    public void OnEditCoordinatorsDialogClose(bool accepted)
    {
        EditCoordinatorsDialogOpen = false;
        StateHasChanged();
    }


    // Kode til CreateCoupon Modal Dialog
    public bool CreateCouponDialogOpen { get; set; }

    public void OpenCreateCouponDialog()
    {
        CreateCouponDialogOpen = true;
        StateHasChanged();
    }

    public void Reload()
    {
        uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
        coor = null;
    }

    public void OnCreateCouponDialogClose(bool accepted)
    {
        CreateCouponDialogOpen = false;
        StateHasChanged();
    }
    
        // Kode til CoordinatorInfo Modal Dialog
    public bool CoordinatorInfoDialogOpen { get; set; }

    public void OpenCoordinatorInfoDialog()
    {
        CoordinatorInfoDialogOpen = true;
        StateHasChanged();
    }

    public void OnCoordinatorInfoDialogClose(bool accepted)
    {
        CoordinatorInfoDialogOpen = false;
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
