#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc0f42bc755fb318173dd11458616ca015ccb94"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using CanErp2.Shared;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-gn-gender")]
    public partial class AddTblGnGender : CanErp2.Pages.AddTblGnGenderComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErp2.Models.DbAtVdc2.TblGnGender>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErp2.Models.DbAtVdc2.TblGnGender>(
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                   tblgngender

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                           tblgngender != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblGnGender>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblGnGender>(this, 
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                                                                                                      Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Gender Id");
                    __builder3.AddAttribute(25, "Component", "Gender_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                          6

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "Gender_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                                                tblgngender.Gender_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgngender.Gender_ID = __value, tblgngender.Gender_ID))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblgngender.Gender_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(44, "class", "row");
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-3");
                    __builder3.AddMarkupContent(48, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", "Gender");
                    __builder3.AddAttribute(51, "Component", "Gender");
                    __builder3.AddAttribute(52, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-9");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(58);
                    __builder3.AddAttribute(59, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "style", "width: 100%");
                    __builder3.AddAttribute(61, "Name", "Gender");
                    __builder3.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                                                 tblgngender.Gender

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgngender.Gender = __value, tblgngender.Gender))));
                    __builder3.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblgngender.Gender));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "row");
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(73, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(74);
                    __builder3.AddAttribute(75, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(76, "Icon", "save");
                    __builder3.AddAttribute(77, "Text", "Save");
                    __builder3.AddAttribute(78, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(80);
                    __builder3.AddAttribute(81, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(82, "Text", "Cancel");
                    __builder3.AddAttribute(83, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblGnGender.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
