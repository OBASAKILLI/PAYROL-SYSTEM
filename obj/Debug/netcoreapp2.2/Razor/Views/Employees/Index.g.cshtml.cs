#pragma checksum "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c0e0e62975f499eadb2da95a23a79feaf1c42d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
#line 1 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\_ViewImports.cshtml"
using PAYROL_SYSTEM;

#line default
#line hidden
#line 2 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\_ViewImports.cshtml"
using PAYROL_SYSTEM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c0e0e62975f499eadb2da95a23a79feaf1c42d", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012057b431f1ce43ee29d273cb9f613b4a5ac98b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateNewEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#072652;color:white;padding:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
  
   

    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Dashboard.cshtml";

#line default
#line hidden
            BeginContext(160, 713, true);
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"" style=""margin:10px"">
        <div class=""col-6"">
            <h1 style=""font-weight:bold;font-family:Calibri;color:#072652"">Employee</h1>

        </div>

    </div>
    <div class=""row"" style=""margin:10px"">
        <div class=""col-6"">
            <div style=""text-align:start;margin-top:8px"">
                <div style=""font-size:large"">
                    All Employees Details
                </div>
                <div style=""font-size:small;color:gray"">
                    List of all employees in ECAN CRF
                </div>
            </div>

        </div>
        <div class=""col-6"" style=""text-align:end"">
            ");
            EndContext();
            BeginContext(873, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c0e0e62975f499eadb2da95a23a79feaf1c42d5963", async() => {
                BeginContext(992, 49, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Register New  Employee");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1045, 36, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 39 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
     if (TempData["successs"] != null)
    {

#line default
#line hidden
            BeginContext(1128, 83, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <strong>Success!!..</strong>");
            EndContext();
            BeginContext(1212, 20, false);
#line 42 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                                   Write(TempData["successs"]);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 44 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1257, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 45 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
     if (TempData["Err"] != null)
    {

#line default
#line hidden
            BeginContext(1299, 81, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Whoops!!..</strong>");
            EndContext();
            BeginContext(1381, 15, false);
#line 48 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                                  Write(TempData["Err"]);

#line default
#line hidden
            EndContext();
            BeginContext(1396, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 50 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1421, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1425, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6c0e0e62975f499eadb2da95a23a79feaf1c42d9583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1451, 802, true);
            WriteLiteral(@"
    <table class=""table table-responsive-sm  table-striped table-bordered  table-sm"" style=""color:black"">
        <thead style=""background-color:#072652;color:white"">

            <tr>
                <th>
                   Full name
                </th>
                <th>
                   Id No
                </th>
                <th>
                    KRA Pin
                </th>
                <th>
                   Department
                </th>
                <th>
                   Phone No
                </th>
                <th>
                 Active status
                </th>
                <th>
                    Gender
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody id=""myUL"">
");
            EndContext();
#line 81 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
             foreach (var item in await _unitofwork.employeeRepo.GetAll())
            {

                Departments d = await _unitofwork.departmentRepo.GetById(item.strDetartmentId);
                var depid = "";
                if (d != null)
                {
                    depid = d.strDepartmentId;

                }

                


#line default
#line hidden
            BeginContext(2618, 76, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td style=\"font-size:medium\"><b>");
            EndContext();
            BeginContext(2695, 16, false);
#line 96 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                                               Write(item.strFullName);

#line default
#line hidden
            EndContext();
            BeginContext(2711, 61, true);
            WriteLiteral("</b></td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2773, 42, false);
#line 98 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.strIdNo));

#line default
#line hidden
            EndContext();
            BeginContext(2815, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2895, 46, false);
#line 101 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.strIdKRAPIN));

#line default
#line hidden
            EndContext();
            BeginContext(2941, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(3023, 5, false);
#line 105 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(depid);

#line default
#line hidden
            EndContext();
            BeginContext(3028, 81, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3110, 45, false);
#line 109 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.strPhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3235, 51, false);
#line 112 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.strActive_Status));

#line default
#line hidden
            EndContext();
            BeginContext(3286, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3366, 44, false);
#line 115 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.strGender));

#line default
#line hidden
            EndContext();
            BeginContext(3410, 77, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                      ");
            EndContext();
            BeginContext(3487, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c0e0e62975f499eadb2da95a23a79feaf1c42d15361", async() => {
                BeginContext(3570, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                                                                                WriteLiteral(item.strId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3578, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3607, 71, false);
#line 119 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3678, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3707, 69, false);
#line 120 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3776, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 123 "D:\PROJECTS\PAYROL_SYSTEM\PAYROL_SYSTEM\Views\Employees\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3843, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PAYROL_SYSTEM.Interfaces.IUnitOfWork _unitofwork { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
