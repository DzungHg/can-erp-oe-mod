#pragma checksum "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b1f9d863df17d339379957c874648098b45fb1"
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
#line 1 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\_Imports.razor"
using CanErp2.Shared;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-ap-invoices-details")]
    public partial class TblPoApInvoicesDetails : CanErp2.Pages.TblPoApInvoicesDetailsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Po Ap Invoices Details");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                     getTblPoApInvoicesDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                                                        Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "Vendor_ID");
                    __builder3.AddAttribute(30, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(31, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(32, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\n              ");
                        __builder4.AddContent(35, 
#line 20 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(36, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(38);
                    __builder3.AddAttribute(39, "Property", "Invoice_No");
                    __builder3.AddAttribute(40, "Title", "Invoice No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(42);
                    __builder3.AddAttribute(43, "Property", "Invoice_Date");
                    __builder3.AddAttribute(44, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Invoice Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(47);
                    __builder3.AddAttribute(48, "Property", "Inventory_FK");
                    __builder3.AddAttribute(49, "SortProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(50, "FilterProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(51, "Title", "Tbl Ic Inventory");
                    __builder3.AddAttribute(52, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(53, "\n              ");
                        __builder4.AddContent(54, 
#line 29 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                data.TblIcInventory?.Warehouse_FK

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(55, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(57);
                    __builder3.AddAttribute(58, "Property", "Unit_FK");
                    __builder3.AddAttribute(59, "SortProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(60, "FilterProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(61, "Title", "Tbl Ic Unit");
                    __builder3.AddAttribute(62, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(63, "\n              ");
                        __builder4.AddContent(64, 
#line 34 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                data.TblIcUnit?.UnitText

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(65, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(67);
                    __builder3.AddAttribute(68, "Property", "Unit_Price");
                    __builder3.AddAttribute(69, "Title", "Unit Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(71);
                    __builder3.AddAttribute(72, "Property", "Qty_Ordered");
                    __builder3.AddAttribute(73, "Title", "Qty Ordered");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(75);
                    __builder3.AddAttribute(76, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(77, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(78, "Width", "70px");
                    __builder3.AddAttribute(79, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 41 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(80, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>)((canErp2ModelsDbAtVdc2TblPoApInvoicesDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(81, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(82);
                        __builder4.AddAttribute(83, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 43 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(84, "Icon", "close");
                        __builder4.AddAttribute(85, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 43 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(86, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblPoApInvoicesDetail)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(87, "onclick", 
#line 43 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                                                                          true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(90, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\TblPoApInvoicesDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591