#pragma checksum "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a0474ad3382b13b0d0b2dbca934c7ad49476b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentCourses_Index), @"mvc.1.0.view", @"/Views/StudentCourses/Index.cshtml")]
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
#line 1 "E:\Projects\__dotNet\AccFlex\Views\_ViewImports.cshtml"
using AccFlex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\__dotNet\AccFlex\Views\_ViewImports.cshtml"
using AccFlex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a0474ad3382b13b0d0b2dbca934c7ad49476b6", @"/Views/StudentCourses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1db8d8e1fc46ee2b0a60cb9704ae48f72154e1", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentCourses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccFlex.Models.StudentCourse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success bi-plus-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"text-muted text-center\">\r\n    <i class=\"bi bi-collection\"></i>\r\n    All Studends in Courses\r\n</h1>\r\n\r\n<p class=\"text-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a0474ad3382b13b0d0b2dbca934c7ad49476b64122", async() => {
                WriteLiteral(" Assign New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 18 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <i class=\"bi bi-exclamation-triangle\"></i>\r\n        Sorry Thers is no Assigned Now, back again !\r\n    </div>\r\n");
#nullable restore
#line 24 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n\r\n");
#nullable restore
#line 30 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
         foreach (var item in Model.GroupBy(n => n.Course.Name))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-hover"">
                <thead class=""table-dark"">
                    <tr>
                        <th>
                            <i class=""bi bi-arrow-bar-right""></i>
                            Students in
                            ");
#nullable restore
#line 38 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"text-light bi-toggle2-on \">\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n\r\n");
#nullable restore
#line 45 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
                 foreach (var item2 in Model.Where(m => m.Course.Name == item.Key))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item2.Student.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
                           Write(Html.ActionLink(" ", "Delete", new { item2.StudentID, item2.CourseID }, new { @class = "text-danger bi-trash-fill" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 57 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 59 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 61 "E:\Projects\__dotNet\AccFlex\Views\StudentCourses\Index.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccFlex.Models.StudentCourse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
