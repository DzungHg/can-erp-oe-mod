#pragma checksum "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e4d7dad27436a5e71174a71ce3021911995cd2"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-po-ap-invoices-detail/{Vendor_ID}/{Invoice_No}")]
    public partial class EditTblPoApInvoicesDetail : CanErp2.Pages.EditTblPoApInvoicesDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", true);
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n      ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-9");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", "Item no longer available.");
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                           !canEdit

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-3");
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                __builder2.AddAttribute(21, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-12");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>(
#line 22 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                         tblpoapinvoicesdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                           tblpoapinvoicesdetail != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoApInvoicesDetail>(this, 
#line 22 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                               Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Tbl Po Vendor");
                    __builder3.AddAttribute(50, "Component", "Vendor_ID");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_0(__builder3, 57, 58, 
#line 30 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                       getTblPoVendorsResult

#line default
#line hidden
                    , 59, "LastName", 60, "Vendor_ID", 61, "Choose TblPoVendor", 62, "display: block; width: 100%", 63, "Vendor_ID", 64, 
#line 30 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                    tblpoapinvoicesdetail.Vendor_ID

#line default
#line hidden
                    , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Vendor_ID = __value, tblpoapinvoicesdetail.Vendor_ID)), 66, () => tblpoapinvoicesdetail.Vendor_ID);
                    __builder3.AddMarkupContent(67, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(68);
                    __builder3.AddAttribute(69, "Component", "Vendor_ID");
                    __builder3.AddAttribute(70, "Text", "Vendor_ID is required");
                    __builder3.AddAttribute(71, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(77, "class", "row");
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-3");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(82);
                    __builder3.AddAttribute(83, "Text", "Invoice No");
                    __builder3.AddAttribute(84, "Component", "Invoice_No");
                    __builder3.AddAttribute(85, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-9");
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(91);
                    __builder3.AddAttribute(92, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                          15

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(94, "Name", "Invoice_No");
                    __builder3.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                 tblpoapinvoicesdetail.Invoice_No

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Invoice_No = __value, tblpoapinvoicesdetail.Invoice_No))));
                    __builder3.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblpoapinvoicesdetail.Invoice_No));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(99);
                    __builder3.AddAttribute(100, "Component", "Invoice_No");
                    __builder3.AddAttribute(101, "Text", "Invoice_No is required");
                    __builder3.AddAttribute(102, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-3");
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(113);
                    __builder3.AddAttribute(114, "Text", "Invoice Date");
                    __builder3.AddAttribute(115, "Component", "Invoice_Date");
                    __builder3.AddAttribute(116, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-md-9");
                    __builder3.AddMarkupContent(121, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDatePicker_1(__builder3, 122, 123, "dd/MM/yyyy", 124, "width: 100%", 125, "Invoice_Date", 126, 
#line 54 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                             tblpoapinvoicesdetail.Invoice_Date

#line default
#line hidden
                    , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Invoice_Date = __value, tblpoapinvoicesdetail.Invoice_Date)), 128, () => tblpoapinvoicesdetail.Invoice_Date);
                    __builder3.AddMarkupContent(129, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(134, "class", "row");
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-3");
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(139);
                    __builder3.AddAttribute(140, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(141, "Component", "Inventory_FK");
                    __builder3.AddAttribute(142, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.OpenElement(145, "div");
                    __builder3.AddAttribute(146, "class", "col-md-9");
                    __builder3.AddMarkupContent(147, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_2(__builder3, 148, 149, 
#line 64 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                       getTblIcInventoriesResult

#line default
#line hidden
                    , 150, "Warehouse_FK", 151, "Inventory_SEQ", 152, "Choose TblIcInventory", 153, "width: 100%", 154, "Inventory_FK", 155, 
#line 64 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                   tblpoapinvoicesdetail.Inventory_FK

#line default
#line hidden
                    , 156, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Inventory_FK = __value, tblpoapinvoicesdetail.Inventory_FK)), 157, () => tblpoapinvoicesdetail.Inventory_FK);
                    __builder3.AddMarkupContent(158, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(160, "\n            ");
                    __builder3.OpenElement(161, "div");
                    __builder3.AddAttribute(162, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(163, "class", "row");
                    __builder3.AddMarkupContent(164, "\n              ");
                    __builder3.OpenElement(165, "div");
                    __builder3.AddAttribute(166, "class", "col-md-3");
                    __builder3.AddMarkupContent(167, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(168);
                    __builder3.AddAttribute(169, "Text", "Tbl Ic Unit");
                    __builder3.AddAttribute(170, "Component", "Unit_FK");
                    __builder3.AddAttribute(171, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\n              ");
                    __builder3.OpenElement(174, "div");
                    __builder3.AddAttribute(175, "class", "col-md-9");
                    __builder3.AddMarkupContent(176, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_3(__builder3, 177, 178, 
#line 74 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                       getTblIcUnitsResult

#line default
#line hidden
                    , 179, "UnitText", 180, "Unit_SEQ", 181, "Choose TblIcUnit", 182, "width: 100%", 183, "Unit_FK", 184, 
#line 74 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                               tblpoapinvoicesdetail.Unit_FK

#line default
#line hidden
                    , 185, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Unit_FK = __value, tblpoapinvoicesdetail.Unit_FK)), 186, () => tblpoapinvoicesdetail.Unit_FK);
                    __builder3.AddMarkupContent(187, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(188, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(189, "\n            ");
                    __builder3.OpenElement(190, "div");
                    __builder3.AddAttribute(191, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(192, "class", "row");
                    __builder3.AddMarkupContent(193, "\n              ");
                    __builder3.OpenElement(194, "div");
                    __builder3.AddAttribute(195, "class", "col-md-3");
                    __builder3.AddMarkupContent(196, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(197);
                    __builder3.AddAttribute(198, "Text", "Unit Price");
                    __builder3.AddAttribute(199, "Component", "Unit_Price");
                    __builder3.AddAttribute(200, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(201, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(202, "\n              ");
                    __builder3.OpenElement(203, "div");
                    __builder3.AddAttribute(204, "class", "col-md-9");
                    __builder3.AddMarkupContent(205, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_4(__builder3, 206, 207, "width: 100%", 208, "Unit_Price", 209, 
#line 84 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                  tblpoapinvoicesdetail.Unit_Price

#line default
#line hidden
                    , 210, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Unit_Price = __value, tblpoapinvoicesdetail.Unit_Price)), 211, () => tblpoapinvoicesdetail.Unit_Price);
                    __builder3.AddMarkupContent(212, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(213, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(214, "\n            ");
                    __builder3.OpenElement(215, "div");
                    __builder3.AddAttribute(216, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(217, "class", "row");
                    __builder3.AddMarkupContent(218, "\n              ");
                    __builder3.OpenElement(219, "div");
                    __builder3.AddAttribute(220, "class", "col-md-3");
                    __builder3.AddMarkupContent(221, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(222);
                    __builder3.AddAttribute(223, "Text", "Qty Ordered");
                    __builder3.AddAttribute(224, "Component", "Qty_Ordered");
                    __builder3.AddAttribute(225, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(226, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(227, "\n              ");
                    __builder3.OpenElement(228, "div");
                    __builder3.AddAttribute(229, "class", "col-md-9");
                    __builder3.AddMarkupContent(230, "\n                ");
                    __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_5(__builder3, 231, 232, "width: 100%", 233, "Qty_Ordered", 234, 
#line 94 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                  tblpoapinvoicesdetail.Qty_Ordered

#line default
#line hidden
                    , 235, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Qty_Ordered = __value, tblpoapinvoicesdetail.Qty_Ordered)), 236, () => tblpoapinvoicesdetail.Qty_Ordered);
                    __builder3.AddMarkupContent(237, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(238, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(239, "\n            ");
                    __builder3.OpenElement(240, "div");
                    __builder3.AddAttribute(241, "class", "row");
                    __builder3.AddMarkupContent(242, "\n              ");
                    __builder3.OpenElement(243, "div");
                    __builder3.AddAttribute(244, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(245, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(246);
                    __builder3.AddAttribute(247, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 100 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(248, "Icon", "save");
                    __builder3.AddAttribute(249, "Text", "Save");
                    __builder3.AddAttribute(250, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 100 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(251, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(252);
                    __builder3.AddAttribute(253, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 102 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(254, "Text", "Cancel");
                    __builder3.AddAttribute(255, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 102 "C:\ZDung HDD\GitHub\can-erp-oe-mod\oe-op\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(256, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(257, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(258, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(259, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(260, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(261, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErp2.Pages.EditTblPoApInvoicesDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
