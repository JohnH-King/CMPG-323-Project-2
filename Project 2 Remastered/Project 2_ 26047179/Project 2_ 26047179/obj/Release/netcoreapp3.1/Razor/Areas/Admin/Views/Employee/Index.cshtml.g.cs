#pragma checksum "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e3c28cf3c3e46a1da8831d3c31444f834081c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Employee_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\_ViewImports.cshtml"
using Project_2__26047179;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\_ViewImports.cshtml"
using Project_2__26047179.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e3c28cf3c3e46a1da8831d3c31444f834081c3", @"/Areas/Admin/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2a05fe263677031a4a58d0346c66cf7a1f7f57", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Employee Index</h1>

<br/><br/>
<div class=""border"" style=""background-color: lightcyan; padding:10px;"">
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">Employee List</h2>
        </div>
        <div class=""col-6 text-right"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19e3c28cf3c3e46a1da8831d3c31444f834081c34551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <br/>\n    <div>\n");
#nullable restore
#line 24 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\n            <tr class=\"table-secondary\">\n                <th>\n                    ");
#nullable restore
#line 29 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 32 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 35 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 38 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 41 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 44 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 47 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n");
#nullable restore
#line 51 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 73 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(m => item.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19e3c28cf3c3e46a1da8831d3c31444f834081c311783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 76 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 79 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n");
#nullable restore
#line 81 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Employee exists...</p>\n");
#nullable restore
#line 85 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591