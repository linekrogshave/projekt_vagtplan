#pragma checksum "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f96a4f86356412c54948a1787a574aaa78d0356f"
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
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
using vagtplanen.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
using vagtplanen.Client.Components.Volunteer_components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/volunteerpage")]
    public partial class VolunteerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                  vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "h1");
                __builder2.AddContent(4, "Velkommen ");
                __builder2.AddContent(5, 
#nullable restore
#line 7 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                   vol.first_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(7);
                __builder2.AddAttribute(8, "Style", "width:922px;");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "class", "row");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(12);
                    __builder3.AddAttribute(13, "Style", "width:300px;");
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(15, "div");
                        __builder4.AddAttribute(16, "class", "row");
                        __builder4.AddMarkupContent(17, "<div class=\"col-md-10\"><b>Ledige vagter:</b>\r\n                        <div>Her kan du ser tilgængelige ledige vagter</div></div>\r\n                    ");
                        __builder4.OpenElement(18, "div");
                        __builder4.AddAttribute(19, "class", "col-md-6");
                        __builder4.OpenElement(20, "button");
                        __builder4.AddAttribute(21, "class", "btn btn-success");
                        __builder4.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                  () => OpenAvailableShiftsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(23, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(25);
                    __builder3.AddAttribute(26, "Style", "width:300px;");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(28, "div");
                        __builder4.AddAttribute(29, "class", "row");
                        __builder4.AddMarkupContent(30, "<div class=\"col-md-10\"><b>Alle kuponer</b>\r\n                        <div>Her kan du ser alle tilgængelige kuponer</div></div>\r\n                    ");
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "col-md-6");
                        __builder4.OpenElement(33, "button");
                        __builder4.AddAttribute(34, "class", "btn btn-success");
                        __builder4.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                  () => OpenAllCouponsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(36, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(38);
                    __builder3.AddAttribute(39, "Style", "width:300px;");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(41, "div");
                        __builder4.AddAttribute(42, "class", "row");
                        __builder4.AddMarkupContent(43, "<div class=\"col-md-10\"><b>Mine kuponer:</b>\r\n                        <div>Her kan du se alle dine købte kuponer</div></div>\r\n                    ");
                        __builder4.OpenElement(44, "div");
                        __builder4.AddAttribute(45, "class", "col-md-6");
                        __builder4.OpenElement(46, "button");
                        __builder4.AddAttribute(47, "class", "btn btn-success");
                        __builder4.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                  () => OpenMyCouponsDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(49, "Se");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(51);
                    __builder3.AddAttribute(52, "Style", "width:300px;");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(54, "div");
                        __builder4.AddAttribute(55, "class", "row");
                        __builder4.AddMarkupContent(56, "<div class=\"col-md-10\"><b>Se skema på vagt:</b>\r\n                        <div>Se hvem du skal arbejde sammen med</div></div>\r\n                    ");
                        __builder4.OpenElement(57, "div");
                        __builder4.AddAttribute(58, "class", "col-md-6");
                        __builder4.OpenElement(59, "button");
                        __builder4.AddAttribute(60, "class", "btn btn-success");
                        __builder4.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                  () => OpenShiftsSchemeDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(62, "Se");
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
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Shift>>(64);
                __builder2.AddAttribute(65, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 60 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                                                                                        FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shift>>(
#nullable restore
#line 61 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                            vol.shifts

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "Style", "width:922px");
                __builder2.AddAttribute(71, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(72);
                    __builder3.AddAttribute(73, "Property", "description");
                    __builder3.AddAttribute(74, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(76);
                    __builder3.AddAttribute(77, "Property", "start_time");
                    __builder3.AddAttribute(78, "Title", "Start tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(80);
                    __builder3.AddAttribute(81, "Property", "end_time");
                    __builder3.AddAttribute(82, "Title", "Slut tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(84);
                    __builder3.AddAttribute(85, "Property", "job.area");
                    __builder3.AddAttribute(86, "Title", "Jobområde");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 71 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
 if (AvailableShiftsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AvailableShifts>(87);
            __builder.AddAttribute(88, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 73 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                               OnAvailableShiftsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 74 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
 if (AllCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AllCoupons>(89);
            __builder.AddAttribute(90, "vol", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 78 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                     vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 78 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                                   OnAllCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 79 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
 if (MyCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.MyCoupons>(92);
            __builder.AddAttribute(93, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 83 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                         OnMyCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 84 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
 if (ShiftsSchemeDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.ShiftsScheme>(94);
            __builder.AddAttribute(95, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 88 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
                            OnShiftsSchemeDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 89 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Semesterprojekt\vagtplan\vagtplanen\Client\Pages\VolunteerPage.razor"
       

    [Parameter] public Volunteer vol { get; set; }



    // Kode til AvailableShifts Modal Dialog
    public bool AvailableShiftsDialogOpen { get; set; }

    public void OpenAvailableShiftsDialog()
    {
        AvailableShiftsDialogOpen = true;
        StateHasChanged();
    }

    public void OnAvailableShiftsDialogClose(bool accepted)
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591