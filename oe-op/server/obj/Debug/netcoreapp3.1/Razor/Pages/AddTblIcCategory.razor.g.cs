#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e66c4d387284584759ad286f0500088d10417f1"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-ic-category")]
    public partial class AddTblIcCategory : CanErp2.Pages.AddTblIcCategoryComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErp2.Models.DbAtVdc2.TblIcCategory>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErp2.Models.DbAtVdc2.TblIcCategory>(
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                   tbliccategory

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                             tbliccategory != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblIcCategory>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblIcCategory>(this, 
#line 12 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
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
                    __builder3.AddAttribute(24, "Text", "Category Id");
                    __builder3.AddAttribute(25, "Component", "Category_ID");
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
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                          5

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Category_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                                                                tbliccategory.Category_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbliccategory.Category_ID = __value, tbliccategory.Category_ID))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tbliccategory.Category_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Category_ID");
                    __builder3.AddAttribute(42, "Text", "Category_ID is required");
                    __builder3.AddAttribute(43, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Category Text");
                    __builder3.AddAttribute(56, "Component", "CategoryText");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.AddAttribute(66, "Name", "CategoryText");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                                                 tbliccategory.CategoryText

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbliccategory.CategoryText = __value, tbliccategory.CategoryText))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tbliccategory.CategoryText));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(75, "class", "row");
                    __builder3.AddMarkupContent(76, "\n              ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-3");
                    __builder3.AddMarkupContent(79, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(80);
                    __builder3.AddAttribute(81, "Text", "Inactive");
                    __builder3.AddAttribute(82, "Component", "Inactive");
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblIcCategory.TypeInference.CreateRadzenCheckBox_0(__builder3, 89, 90, 
#line 42 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                          true

#line default
#line hidden
                    , 91, "Inactive", 92, 
#line 42 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                               tbliccategory.Inactive

#line default
#line hidden
                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbliccategory.Inactive = __value, tbliccategory.Inactive)), 94, () => tbliccategory.Inactive);
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "row");
                    __builder3.AddMarkupContent(100, "\n              ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(103, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(104);
                    __builder3.AddAttribute(105, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 48 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(106, "Icon", "save");
                    __builder3.AddAttribute(107, "Text", "Save");
                    __builder3.AddAttribute(108, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(110);
                    __builder3.AddAttribute(111, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 50 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(112, "Text", "Cancel");
                    __builder3.AddAttribute(113, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 50 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\AddTblIcCategory.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErp2.Pages.AddTblIcCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "TriState", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591