#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db5fd350e763f1a4cc39a4f7373fd951238f4ac"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-rr-order-details")]
    public partial class TblPoRrOrderDetails : CanErp2.Pages.TblPoRrOrderDetailsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Rr Order Details");
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
#line 14 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                     getTblPoRrOrderDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                                  Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "RR_FK");
                    __builder3.AddAttribute(30, "SortProperty", "TblPoRecReport.PO_ID");
                    __builder3.AddAttribute(31, "FilterProperty", "TblPoRecReport.PO_ID");
                    __builder3.AddAttribute(32, "Title", "Tbl Po Rec Report");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\n              ");
                        __builder4.AddContent(35, 
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                data.TblPoRecReport?.PO_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(36, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(38);
                    __builder3.AddAttribute(39, "Property", "Inventory_FK");
                    __builder3.AddAttribute(40, "SortProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(41, "FilterProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(42, "Title", "Tbl Ic Inventory");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(44, "\n              ");
                        __builder4.AddContent(45, 
#line 25 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                data.TblIcInventory?.Warehouse_FK

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(46, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(48);
                    __builder3.AddAttribute(49, "Property", "Unit_Price");
                    __builder3.AddAttribute(50, "Title", "Unit Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(52);
                    __builder3.AddAttribute(53, "Property", "QtyOrdered");
                    __builder3.AddAttribute(54, "Title", "Qty Ordered");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(56);
                    __builder3.AddAttribute(57, "Property", "QtyReceived");
                    __builder3.AddAttribute(58, "Title", "Qty Received");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(60);
                    __builder3.AddAttribute(61, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 34 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 34 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "Width", "70px");
                    __builder3.AddAttribute(64, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 34 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                               TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>)((canErp2ModelsDbAtVdc2TblPoRrOrderDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(66, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(67);
                        __builder4.AddAttribute(68, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(69, "Icon", "close");
                        __builder4.AddAttribute(70, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(71, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblPoRrOrderDetail)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(72, "onclick", 
#line 36 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                                                       true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(73, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(75, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoRrOrderDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
