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
<<<<<<< HEAD
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 1 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 2 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 3 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 4 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 5 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 6 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 7 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 8 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 9 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 10 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 10 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 11 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
=======
#line 12 "C:\Users\sisse\Desktop\vagtplanopgave\Client\_Imports.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class VolunteerInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 85 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
=======
#line 85 "C:\Users\sisse\Desktop\vagtplanopgave\Client\Components\Volunteer_components\VolunteerInfo.razor"
>>>>>>> 7a1fe0ccc5ac9ec3aa3a2ca83a6a6e0772a01c6c
       

    [Parameter]
    public Volunteer vol { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private async Task ModalOk()
    {
        await Http.PutAsJsonAsync<Volunteer>("api/volunteer", vol);
        await OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
