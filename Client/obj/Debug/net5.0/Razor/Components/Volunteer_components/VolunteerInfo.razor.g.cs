#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9211bdf00cc774b238b1a21c85f8952175504b9"
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
#line 1 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    public partial class VolunteerInfo : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(12, "<h3>Ret valgte data her</h3>\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
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
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                  vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "<label>Fornavn:</label>\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.first_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.first_name = __value, vol.first_name))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.first_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 18 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.first_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group ");
                __builder2.OpenElement(41, "div");
                __builder2.AddMarkupContent(42, "<label>Efternavn:</label>\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.last_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.last_name = __value, vol.last_name))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.last_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_1(__builder2, 49, 50, 
#nullable restore
#line 27 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.last_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group ");
                __builder2.OpenElement(54, "div");
                __builder2.AddMarkupContent(55, "<label>Mobilnummer:</label>\n                            ");
                __builder2.OpenElement(56, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.mobile = __value, vol.mobile))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.mobile));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_2(__builder2, 62, 63, 
#nullable restore
#line 36 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.mobile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "<label>Email:</label>\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.email = __value, vol.email))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_3(__builder2, 75, 76, 
#nullable restore
#line 45 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n                    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group ");
                __builder2.OpenElement(80, "div");
                __builder2.AddMarkupContent(81, "<label>Adresse:</label>\n                            ");
                __builder2.OpenElement(82, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.address = __value, vol.address))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_4(__builder2, 88, 89, 
#nullable restore
#line 54 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\n                    ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group ");
                __builder2.OpenElement(93, "div");
                __builder2.AddMarkupContent(94, "<label>CPR-nummer:</label>\n                            ");
                __builder2.OpenElement(95, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.cpr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.cpr = __value, vol.cpr))));
                __builder2.AddAttribute(99, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.cpr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_5(__builder2, 101, 102, 
#nullable restore
#line 63 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.cpr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n                    ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group ");
                __builder2.OpenElement(106, "div");
                __builder2.AddMarkupContent(107, "<label>Køn:</label>\n                            ");
                __builder2.OpenElement(108, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(109);
                __builder2.AddAttribute(110, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                         vol.gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vol.gender = __value, vol.gender))));
                __builder2.AddAttribute(112, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vol.gender));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\n                                ");
                __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo.TypeInference.CreateValidationMessage_6(__builder2, 114, 115, 
#nullable restore
#line 72 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                          () => vol.gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\n            ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "modal-footer");
            __builder.OpenElement(119, "button");
            __builder.AddAttribute(120, "type", "button");
            __builder.AddAttribute(121, "class", "btn btn-primary");
            __builder.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(123, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/line-vagtplan/projekt_vagtplan/Client/Components/Volunteer_components/VolunteerInfo.razor"
       

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
namespace __Blazor.vagtplanen.Client.Components.Volunteer_components.VolunteerInfo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
