#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b397d1479a4c9e73544416df9182896e3f2fea"
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
    public partial class MyCoupons : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h3>Mine kuponer</h3>\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                  vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Coupon>>(24);
                __builder2.AddAttribute(25, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                                                                                     FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Coupon>>(
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                           vol.coupons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(31);
                    __builder3.AddAttribute(32, "Property", "description");
                    __builder3.AddAttribute(33, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(35);
                    __builder3.AddAttribute(36, "Property", "coupon_id");
                    __builder3.AddAttribute(37, "Title", "Brug");
                    __builder3.AddAttribute(38, "Width", "60px");
                    __builder3.AddAttribute(39, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                                                                            false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                                                                                             false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Coupon>)((coupon) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(42);
                        __builder4.AddAttribute(43, "Icon", "done");
                        __builder4.AddAttribute(44, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                      args => OnUse(coupon)

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
                __builder2.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                                    grid = (Radzen.Blazor.RadzenDataGrid<Coupon>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-footer");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Volunteer components/MyCoupons.razor"
       

    [Parameter]
    public Volunteer vol { get; set; }
    RadzenDataGrid<Coupon> grid;

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

    async Task OnUse(Coupon c)
    {
        vol.coupons.Remove(c);
        await Http.PostAsJsonAsync($"api/method/usecoupon/{vol.volunteer_id}/{c.coupon_id}", c);
        await grid.Reload();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
