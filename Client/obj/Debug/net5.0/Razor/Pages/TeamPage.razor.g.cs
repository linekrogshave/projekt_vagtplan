#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1614574afe09e5c873aa73e80c5419213e26cd4"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                  tea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "h1");
                __builder2.AddContent(4, "Velkommen ");
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
__builder2.AddContent(5, tea.name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\n\n    ");
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
                        __builder4.AddMarkupContent(17, "<div class=\"col-md-10\"><b>Ledige vagter:</b>\n                        <div>Her kan du ser tilgængelige ledige vagter</div></div>\n                    ");
                        __builder4.OpenElement(18, "div");
                        __builder4.AddAttribute(19, "class", "col-md-6");
                        __builder4.OpenElement(20, "button");
                        __builder4.AddAttribute(21, "class", "btn btn-success");
                        __builder4.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
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
                    __builder3.AddMarkupContent(24, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(25);
                    __builder3.AddAttribute(26, "Style", "width:300px;");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(28, "div");
                        __builder4.AddAttribute(29, "class", "row");
                        __builder4.AddMarkupContent(30, "<div class=\"col-md-10\"><b>Alle kuponer</b>\n                        <div>Her kan du ser alle tilgængelige kuponer</div></div>\n                    ");
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "col-md-6");
                        __builder4.OpenElement(33, "button");
                        __builder4.AddAttribute(34, "class", "btn btn-success");
                        __builder4.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
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
                    __builder3.AddMarkupContent(37, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(38);
                    __builder3.AddAttribute(39, "Style", "width:300px;");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(41, "div");
                        __builder4.AddAttribute(42, "class", "row");
                        __builder4.AddMarkupContent(43, "<div class=\"col-md-10\"><b>Mine kuponer:</b>\n                        <div>Her kan du se alle dine købte kuponer</div></div>\n                    ");
                        __builder4.OpenElement(44, "div");
                        __builder4.AddAttribute(45, "class", "col-md-6");
                        __builder4.OpenElement(46, "button");
                        __builder4.AddAttribute(47, "class", "btn btn-success");
                        __builder4.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
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
                    __builder3.AddMarkupContent(50, "\n\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(51);
                    __builder3.AddAttribute(52, "Style", "width:300px;");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(54, "div");
                        __builder4.AddAttribute(55, "class", "row");
                        __builder4.AddMarkupContent(56, "<div class=\"col-md-10\"><b>Se skema på vagt:</b>\n                        <div>Se hvem du skal arbejde sammen med</div></div>\n                    ");
                        __builder4.OpenElement(57, "div");
                        __builder4.AddAttribute(58, "class", "col-md-6");
                        __builder4.OpenElement(59, "button");
                        __builder4.AddAttribute(60, "class", "btn btn-success");
                        __builder4.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
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
                __builder2.AddMarkupContent(63, "\n    ");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "type", "button");
                __builder2.AddAttribute(66, "class", "btn btn-primary");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                             Reload

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(68, "Log ud");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 73 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (AvailableShiftsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AvailableShifts>(69);
            __builder.AddAttribute(70, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<(System.Boolean, Shift)>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<(System.Boolean, Shift)>(this, 
#nullable restore
#line 75 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                (args)=> OnAvailableShiftsDialogClose(args.Item1,args.Item2)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 76 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (AllCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.AllCoupons>(71);
            __builder.AddAttribute(72, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 80 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                          OnAllCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 81 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (MyCouponsDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.MyCoupons>(73);
            __builder.AddAttribute(74, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 85 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                         OnMyCouponsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 86 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (ShiftsSchemeDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Volunteer_components.ShiftsScheme>(75);
            __builder.AddAttribute(76, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 90 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                            OnShiftsSchemeDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 91 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
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