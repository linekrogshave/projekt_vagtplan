#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634113a46dcec731ab24ae60118d782307e7fb89"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Components.Volunteer_components
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
    public partial class AvailableShifts : Microsoft.AspNetCore.Components.ComponentBase
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
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
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
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                 if (shifts == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                      vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Shift>>(25);
                __builder2.AddAttribute(26, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                                                                        FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shift>>(
#nullable restore
#line 20 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                               MyShifts()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(32);
                    __builder3.AddAttribute(33, "Property", "task.description");
                    __builder3.AddAttribute(34, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(36);
                    __builder3.AddAttribute(37, "Property", "start_time");
                    __builder3.AddAttribute(38, "Title", "Start tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(40);
                    __builder3.AddAttribute(41, "Property", "end_time");
                    __builder3.AddAttribute(42, "Title", "Slut tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(44);
                    __builder3.AddAttribute(45, "Property", "shift_id");
                    __builder3.AddAttribute(46, "Title", "Tag vagt");
                    __builder3.AddAttribute(47, "Width", "75px");
                    __builder3.AddAttribute(48, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                                                                                   false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Shift>)((shift) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(51);
                        __builder4.AddAttribute(52, "Icon", "check_circle");
                        __builder4.AddAttribute(53, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                                  args => OnTake(shift)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(54, (__value) => {
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                    grid = (Radzen.Blazor.RadzenDataGrid<Shift>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-footer");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
       

    public List<Shift> shifts;

    [Parameter] public Volunteer vol { get; set; }
    RadzenDataGrid<Shift> grid;

    protected async override Task OnInitializedAsync()
    {
        shifts = await Http.GetFromJsonAsync<List<Shift>>("api/shift");
    }

    public List<Shift> MyShifts()
    {
        var allShifts = shifts;
        var myShifts = vol.shifts;

        List<Shift> availableShifts = new List<Shift>();

        bool available = true;

        foreach (Shift shift in allShifts)
        {
            foreach (Shift myShift in myShifts)
            {
                if (shift.start_time.Ticks < myShift.start_time.Ticks && shift.end_time.Ticks > myShift.start_time.Ticks)
                {
                    available = false;
                }
                if (shift.start_time.Ticks < myShift.end_time.Ticks && shift.end_time.Ticks > myShift.end_time.Ticks)
                {
                    available = false;
                }
            }
            if (available)
            {
                availableShifts.Add(shift);
            }
            else
            {
                available = true;
            }
        }
        return availableShifts.Where(x => x.taken == false && (x.start_time.Ticks > DateTime.Now.Ticks)).ToList();
    }

    [Parameter]
    public EventCallback<(bool, Shift)> OnClose { get; set; }

    public Shift takenShift;

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync((false, new Shift()));
    }

    private Task ModalOk()
    {
        return OnClose.InvokeAsync((true, takenShift));
    }

    async void OnTake(Shift s)
    {
        shifts.Remove(s);
        s.taken = true;
        takenShift = s;
        takenShift.volunteer = vol;
        await Http.PostAsJsonAsync($"api/method/assignshift", takenShift);
        await grid.Reload();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
