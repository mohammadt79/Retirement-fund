#pragma checksum "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28bc41266ee807db585496e4a2befcf3be281c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CRequest), @"mvc.1.0.view", @"/Views/Admin/CRequest.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\_ViewImports.cshtml"
using Retirementfund_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\_ViewImports.cshtml"
using Retirementfund_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
using Retirementfund_MVC.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
using Retirementfund_MVC.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bc41266ee807db585496e4a2befcf3be281c82", @"/Views/Admin/CRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0a9ae928c5b6d19661d2f902fa67b83d9b39e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List< AdminCheckUserView>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <!-- ============ Body content start ============= -->\r\n    <div class=\"main-content-wrap sidenav-open d-flex flex-column\">\r\n        <div class=\"breadcrumb\">\r\n            <h1>Table</h1>\r\n            <ul>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 351, "\"", 358, 0);
            EndWriteAttribute();
            WriteLiteral(@">Componets</a></li>
                <li>Table</li>
            </ul>
        </div>

        <div class=""separator-breadcrumb border-top""></div>




        <div class=""row mb-4"">


            <div class=""col-md-12 mb-4"">
                <div class=""card text-left"">

                    <div class=""card-body"">
                        <h4 class=""card-title mb-3 float-right""> برسی درخواست ها </h4>

                        <div class=""table-responsive"">
                            <table class=""table table-hover table-dark "">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">نام و نام خانوادگی </th>
                                        <th scope=""col"">توضیحات</th>
                                        <th scope=""col"">مبلغ</th>
                                        <th scope=""col"">وصعیت</th>
                                       ");
            WriteLiteral(" <th scope=\"col\">تاریخ</th>\r\n                                        <th scope=\"col\">برسی</th>\r\n\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                    foreach (var item in Model)
                                      {
                                              


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">1</th>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                       Write(item.discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                       Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><span class=\"badge badge-success\">");
#nullable restore
#line 59 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                                                         Write(item.adminCheck);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                       Write(item.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td>
                                            <button type=""button"" class=""btn btn-success "">
                                                <i class=""nav-icon i-Pen-2 ""></i>
                                            </button>
                                            <button type=""button"" class=""btn btn-danger "">
                                                <i class=""nav-icon i-Close-Window ""></i>
                                            </button>
                                        </td>
                                    </tr>
");
#nullable restore
#line 70 "C:\Users\MohammadTPc\Documents\GitHub\Retirement-fund\Retirementfund_MVC\Retirementfund_MVC\Views\Admin\CRequest.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                   
                                </tbody>
                            </table>
                        </div>


                    </div>
                </div>
            </div>
            <!-- end of col-->

        </div>
        <!-- end of row-->








    </div>
    <!-- ============ Body content End ============= -->
<!--=============== End app-admin-wrap ================-->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List< AdminCheckUserView>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
