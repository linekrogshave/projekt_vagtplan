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
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\Login.razor"
using vagtplanen.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\Login.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\Login.razor"
       
    public int page_access = -1;
    public bool isLoading = false;

    public Volunteer vol = new();
    public Coordinator coor = new();

    async Task OnLogin(LoginArgs args)
    {
        isLoading = true;
        try
        {
            int res = await Http.GetFromJsonAsync<int>($"api/method/login/{args.Username}/{args.Password}");
            if (res == 0)
            {
                vol = await Http.GetFromJsonAsync<Volunteer>($"api/volunteer/{args.Username}");
                isLoading = false;
                page_access = vol.access;
            }
            else if (res == 1)
            {
                coor = await Http.GetFromJsonAsync<Coordinator>($"api/coordinator/{args.Username}");
                page_access = coor.access;
                isLoading = false;
            }
        }
        catch (Exception e)
        {
            isLoading = false;
            Console.WriteLine(e.Message);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
