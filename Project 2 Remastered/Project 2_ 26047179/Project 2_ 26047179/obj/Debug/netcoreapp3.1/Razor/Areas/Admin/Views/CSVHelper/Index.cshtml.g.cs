#pragma checksum "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c009287bdffbe74e4c3037714245269e131192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CSVHelper_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CSVHelper/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c009287bdffbe74e4c3037714245269e131192", @"/Areas/Admin/Views/CSVHelper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2a05fe263677031a4a58d0346c66cf7a1f7f57", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CSVHelper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project_2__26047179.Models.ViewModels.CSVViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<br />\r\n<div class=\"container row p-0 m-0\">\r\n    <!-- these are all bootstrap classes-->\r\n    <div class=\"col-9\">\r\n        <h2 class=\"text-info\">CSV</h2>\r\n    </div>\r\n\r\n    <div>\r\n");
#nullable restore
#line 13 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 30 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                       Write(Html.DisplayFor(m => item.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 33 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03c009287bdffbe74e4c3037714245269e1311926520", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 43 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Job Information exists...</p>\r\n");
#nullable restore
#line 47 "C:\Coding\CMPG 323\CMPG-323-Project-2\Project 2 Remastered\Project 2_ 26047179\Project 2_ 26047179\Areas\Admin\Views\CSVHelper\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project_2__26047179.Models.ViewModels.CSVViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
