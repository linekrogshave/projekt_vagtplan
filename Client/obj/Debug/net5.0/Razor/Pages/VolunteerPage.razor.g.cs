#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6e06fac84394389b4cf2cab884fad0ba5e4033"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
using vagtplanen.Client.Components.Volunteer_components;

#line default
#line hidden
#nullable disable
    public partial class VolunteerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row px-3");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "id", "right");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                        ReloadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Log ud");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                  vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "h1");
                __builder2.AddContent(13, "Velkommen ");
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
__builder2.AddContent(14, vol.first_name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(16);
                __builder2.AddAttribute(17, "class", "w-6");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "row");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(21);
                    __builder3.AddAttribute(22, "class", "w-7");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "row");
                        __builder4.AddMarkupContent(26, "<div class=\"col-md-10\"><b>Ledige vagter:</b>\n                        <div>Her kan du ser tilg??ngelige ledige vagter</div></div>\n                    ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "col-md-6");
                        __builder4.OpenElement(29, "button");
                        __builder4.AddAttribute(30, "class", "btn btn-success");
                        __builder4.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                  () => OpenAvailableShiftsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(32, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(34);
                    __builder3.AddAttribute(35, "class", "w-7");
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(37, "div");
                        __builder4.AddAttribute(38, "class", "row");
                        __builder4.AddMarkupContent(39, "<div class=\"col-md-10\"><b>Alle kuponer</b>\n                        <div>Her kan du ser alle tilg??ngelige kuponer</div></div>\n                    ");
                        __builder4.OpenElement(40, "div");
                        __builder4.AddAttribute(41, "class", "col-md-6");
                        __builder4.OpenElement(42, "button");
                        __builder4.AddAttribute(43, "class", "btn btn-success");
                        __builder4.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                  () => OpenAllCouponsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(45, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(47);
                    __builder3.AddAttribute(48, "class", "w-7");
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(50, "div");
                        __builder4.AddAttribute(51, "class", "row");
                        __builder4.AddMarkupContent(52, "<div class=\"col-md-10\"><b>Mine kuponer:</b>\n                        <div>Her kan du se alle dine k??bte kuponer</div></div>\n                    ");
                        __builder4.OpenElement(53, "div");
                        __builder4.AddAttribute(54, "class", "col-md-6");
                        __builder4.OpenElement(55, "button");
                        __builder4.AddAttribute(56, "class", "btn btn-success");
                        __builder4.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                  () => OpenMyCouponsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(58, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(60);
                    __builder3.AddAttribute(61, "class", "w-7");
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(63, "div");
                        __builder4.AddAttribute(64, "class", "row");
                        __builder4.AddMarkupContent(65, "<div class=\"col-md-10\"><b>Se skema p?? vagt:</b>\n                        <div>Se hvem du skal arbejde sammen med</div></div>\n                    ");
                        __builder4.OpenElement(66, "div");
                        __builder4.AddAttribute(67, "class", "col-md-6");
                        __builder4.OpenElement(68, "button");
                        __builder4.AddAttribute(69, "class", "btn btn-success");
                        __builder4.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                  () => OpenShiftsSchemeDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(71, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(73);
                    __builder3.AddAttribute(74, "class", "w-7");
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "row");
                        __builder4.AddMarkupContent(78, "<div class=\"col-md-10\"><b>Se din data:</b>\n                        <div>Se og ??ndre info vedr??rende dig</div></div>\n                    ");
                        __builder4.OpenElement(79, "div");
                        __builder4.AddAttribute(80, "class", "col-md-6");
                        __builder4.OpenElement(81, "button");
                        __builder4.AddAttribute(82, "class", "btn btn-success");
                        __builder4.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                  () => OpenVolunteerInfoDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(84, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "shifts");
#nullable restore
#line 76 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
         if (shifts == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(88, "<p><em>...Loading shifts</em></p>");
#nullable restore
#line 77 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                          }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Shift>>(89);
                __builder2.AddAttribute(90, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shift>>(
#nullable restore
#line 81 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                    shifts.Where(x => (x.end_time.Ticks > DateTime.Now.Ticks) && (x.volunteer.volunteer_id == vol.volunteer_id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "class", "vagter-ting");
                __builder2.AddAttribute(96, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(97);
                    __builder3.AddAttribute(98, "Property", "task.description");
                    __builder3.AddAttribute(99, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(101);
                    __builder3.AddAttribute(102, "Property", "start_time");
                    __builder3.AddAttribute(103, "Title", "Start tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(105);
                    __builder3.AddAttribute(106, "Property", "end_time");
                    __builder3.AddAttribute(107, "Title", "Slut tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(109);
                    __builder3.AddAttribute(110, "Property", "shift_id");
                    __builder3.AddAttribute(111, "Title", "Frigiv vagt");
                    __builder3.AddAttribute(112, "Width", "85px");
                    __builder3.AddAttribute(113, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 86 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                                                                         false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 86 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(115, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Shift>)((shift) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(116);
                        __builder4.AddAttribute(117, "Icon", "delete_forever");
                        __builder4.AddAttribute(118, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                                                        args => OnRelease(shift)

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
                __builder2.AddComponentReferenceCapture(119, (__value) => {
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                  grid = (Radzen.Blazor.RadzenDataGrid<Shift>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
#nullable restore
#line 93 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 98 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
 if (AvailableShiftsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AvailableShifts>(120);
            __builder.AddAttribute(121, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 100 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                           vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<(System.Boolean, Shift)>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<(System.Boolean, Shift)>(this, 
#nullable restore
#line 100 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                           (args)=> OnAvailableShiftsDialogClose(args.Item1,args.Item2)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 101 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
 if (AllCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AllCoupons>(123);
            __builder.AddAttribute(124, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 105 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                     vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 105 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                   OnAllCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 106 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
 if (MyCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.MyCoupons>(126);
            __builder.AddAttribute(127, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 110 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                     vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(128, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 110 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                    OnMyCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 111 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
 if (ShiftsSchemeDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.ShiftsScheme>(129);
            __builder.AddAttribute(130, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 115 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                        vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 115 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                       OnShiftsSchemeDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 116 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
 if (VolunteerInfoDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.VolunteerInfo>(132);
            __builder.AddAttribute(133, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 119 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                         vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 119 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
                                        OnVolunteerInfoDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 120 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/VolunteerPage.razor"
       

    [Parameter] public Volunteer vol { get; set; }
    RadzenDataGrid<Shift> grid;
    public List<Shift> shifts;

    protected override async Task OnInitializedAsync()
    {
        shifts = await Http.GetFromJsonAsync<List<Shift>>("api/shift");
    }



    // Kode til AvailableShifts Modal Dialog
    public bool AvailableShiftsDialogOpen { get; set; }

    public void OpenAvailableShiftsDialog()
    {
        AvailableShiftsDialogOpen = true;
        StateHasChanged();
    }

    public void OnAvailableShiftsDialogClose(bool accepted, Shift s)
    {
        if(s.shift_id != 0)
        {
            shifts.Add(s);
            vol.shifts.Add(s);
            grid.Reload();
        }
        AvailableShiftsDialogOpen = accepted;
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
        grid.Reload();
        StateHasChanged();
    }

    // Kode til AvailableShifts Modal Dialog
    public bool VolunteerInfoDialogOpen { get; set; }

    public void OpenVolunteerInfoDialog()
    {
        VolunteerInfoDialogOpen = true;
        StateHasChanged();
    }

    public void OnVolunteerInfoDialogClose(bool accepted)
    {
        VolunteerInfoDialogOpen = false;
        StateHasChanged();
    }

    public async void OnRelease(Shift s)
    {
        shifts.Remove(s);
        s.volunteer = vol;
        try
        {
            await Http.PostAsJsonAsync<Shift>($"api/method/deassignshift", s);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        s.taken = false;
        s.volunteer = new Volunteer();
        await grid.Reload();
    }

    public void ReloadPage()
    {
        uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
