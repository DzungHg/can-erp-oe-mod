#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6624eb8985400fea21d32c3db550d9c395a61e"
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
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
using Radzen;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-gn-address-books")]
    public partial class TblGnAddressBooks : CanErp2.Pages.TblGnAddressBooksComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Gn Address Books");
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
#line 15 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                     getTblGnAddressBooksResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblGnAddressBook>(this, 
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                              Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(28);
                    __builder3.AddAttribute(29, "Property", "AddressBook_SEQ");
                    __builder3.AddAttribute(30, "Title", "Address Book SEQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(32);
                    __builder3.AddAttribute(33, "Property", "AddressBook_ID");
                    __builder3.AddAttribute(34, "Title", "Address Book ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(36);
                    __builder3.AddAttribute(37, "Property", "AddressBookType_FK");
                    __builder3.AddAttribute(38, "SortProperty", "TblGnAddressBookType.AddressBookType_ID");
                    __builder3.AddAttribute(39, "FilterProperty", "TblGnAddressBookType.AddressBookType_ID");
                    __builder3.AddAttribute(40, "Title", "Tbl Gn Address Book Type");
                    __builder3.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(42, "\n              ");
                        __builder4.AddContent(43, 
#line 25 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                data.TblGnAddressBookType?.AddressBookType_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(44, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(46);
                    __builder3.AddAttribute(47, "Property", "LastName");
                    __builder3.AddAttribute(48, "Title", "Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(50);
                    __builder3.AddAttribute(51, "Property", "FirstName");
                    __builder3.AddAttribute(52, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(54);
                    __builder3.AddAttribute(55, "Property", "Gender_FK");
                    __builder3.AddAttribute(56, "SortProperty", "TblGnGender.Gender_ID");
                    __builder3.AddAttribute(57, "FilterProperty", "TblGnGender.Gender_ID");
                    __builder3.AddAttribute(58, "Title", "Tbl Gn Gender");
                    __builder3.AddAttribute(59, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(60, "\n              ");
                        __builder4.AddContent(61, 
#line 34 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                data.TblGnGender?.Gender_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(62, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(64);
                    __builder3.AddAttribute(65, "Property", "DOB");
                    __builder3.AddAttribute(66, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(67, "Title", "DOB");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(69);
                    __builder3.AddAttribute(70, "Property", "Origin");
                    __builder3.AddAttribute(71, "Title", "Origin");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(73);
                    __builder3.AddAttribute(74, "Property", "IDNumber");
                    __builder3.AddAttribute(75, "Title", "ID Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(77);
                    __builder3.AddAttribute(78, "Property", "TaxIDNumber");
                    __builder3.AddAttribute(79, "Title", "Tax ID Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(81);
                    __builder3.AddAttribute(82, "Property", "OrganizationName");
                    __builder3.AddAttribute(83, "Title", "Organization Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(85);
                    __builder3.AddAttribute(86, "Property", "JobPosition");
                    __builder3.AddAttribute(87, "Title", "Job Position");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(89);
                    __builder3.AddAttribute(90, "Property", "Address");
                    __builder3.AddAttribute(91, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(93);
                    __builder3.AddAttribute(94, "Property", "City_FK");
                    __builder3.AddAttribute(95, "SortProperty", "TblHpTinhTp.TinhTP_Name");
                    __builder3.AddAttribute(96, "FilterProperty", "TblHpTinhTp.TinhTP_Name");
                    __builder3.AddAttribute(97, "Title", "Tbl Hp Tinh Tp");
                    __builder3.AddAttribute(98, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(99, "\n              ");
                        __builder4.AddContent(100, 
#line 53 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                data.TblHpTinhTp?.TinhTP_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(101, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblGnAddressBook>>(103);
                    __builder3.AddAttribute(104, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                           false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(105, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                            false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(106, "Width", "70px");
                    __builder3.AddAttribute(107, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 56 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                           TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(108, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblGnAddressBook>)((canErp2ModelsDbAtVdc2TblGnAddressBook) => (__builder4) => {
                        __builder4.AddMarkupContent(109, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(110);
                        __builder4.AddAttribute(111, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(112, "Icon", "close");
                        __builder4.AddAttribute(113, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 58 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(114, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblGnAddressBook)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(115, "onclick", 
#line 58 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                                                     true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(116, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(118, (__value) => {
#line 17 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblGnAddressBooks.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblGnAddressBook>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
