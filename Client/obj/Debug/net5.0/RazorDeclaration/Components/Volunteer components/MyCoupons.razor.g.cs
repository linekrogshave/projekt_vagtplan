// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace vagtplanen.Client.Components.Volunteer_components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MyCoupons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Components\Volunteer components\MyCoupons.razor"
       

    public Shift[] shifts;

    protected async override Task OnInitializedAsync()
    {
        shifts = await Http.GetFromJsonAsync<Shift[]>("api/shift");
    }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
