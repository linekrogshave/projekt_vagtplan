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
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Pages/Login.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Pages/Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Pages/Login.razor"
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
#line 34 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Pages/Login.razor"
       
    public int page_access = -1;
    public bool isLoading = false;

    public Volunteer vol = new();
    public Coordinator coor = new();
    public Team tea = new();

    async Task OnLogin(LoginArgs args)
    {
        isLoading = true;
        try
        {
            int res = await Http.GetFromJsonAsync<int>($"api/method/login/{args.Username}/{args.Password}");
            if (res == 0)
            {

                vol = await Http.GetFromJsonAsync<Volunteer>($"api/volunteer/{args.Username}");
                page_access = vol.access;
                isLoading = false;
            }
            else if (res == 10)
            {
                coor = await Http.GetFromJsonAsync<Coordinator>($"api/coordinator/{args.Username}");
                page_access = coor.access;
                isLoading = false;
            }
            else if (res == 1)
            {
                tea = await Http.GetFromJsonAsync<Team>($"api/team/{args.Username}");
                page_access = tea.access;
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
