#pragma checksum "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3aa24da8653f1fb30105db63bbc9210cac52c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
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
#line 1 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\_ViewImports.cshtml"
using Teacher_Student_Connect_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\_ViewImports.cshtml"
using Teacher_Student_Connect_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3aa24da8653f1fb30105db63bbc9210cac52c50", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0882c30e73bf6be674ea01db9b214ad86384ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Teacher_Student_Connect_Project.ViewModels.TeacherDataViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3aa24da8653f1fb30105db63bbc9210cac52c504099", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpecializationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PriorExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateofJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpecializationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriorExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateofJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 86 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 87 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\tonmo\OneDrive\Desktop\Solid Principles - Need for Design Patterns\Teacher_Student_Connect_Project\Teacher_Student_Connect_Project\Views\Teacher\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Teacher_Student_Connect_Project.ViewModels.TeacherDataViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591