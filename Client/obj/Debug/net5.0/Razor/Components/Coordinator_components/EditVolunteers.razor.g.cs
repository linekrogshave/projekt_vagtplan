#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80407b0a15799b9f4ba37e0deffd08eb6219cf8d"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Components.Coordinator_components
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
    public partial class EditVolunteers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show modal-lg");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block;");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog modal-dialog-centered modal-dialog-scrollable modal-lg");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h3>Alle ledige vagter</h3>\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                 if (shifts == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Shift>>(22);
            __builder.AddAttribute(23, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 17 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                                                                                        FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shift>>(
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                            shifts.Where(x => x.taken == false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(29);
                __builder2.AddAttribute(30, "Property", "shift_id");
                __builder2.AddAttribute(31, "Title", "ID");
                __builder2.AddAttribute(32, "Width", "70px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(34);
                __builder2.AddAttribute(35, "Property", "description");
                __builder2.AddAttribute(36, "Title", "Beskrivelse");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(38);
                __builder2.AddAttribute(39, "Property", "start_time");
                __builder2.AddAttribute(40, "Title", "Start tidspunkt");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(42);
                __builder2.AddAttribute(43, "Property", "end_time");
                __builder2.AddAttribute(44, "Title", "Slut tidspunkt");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(46);
                __builder2.AddAttribute(47, "Property", "job.area");
                __builder2.AddAttribute(48, "Title", "Jobområde");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-footer");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/EditVolunteers.razor"
       

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
