#pragma checksum "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c699e9dbbc6da28c2b8fad7f9e19978582f7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\_ViewImports.cshtml"
using MDTasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\_ViewImports.cshtml"
using MDTasks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c699e9dbbc6da28c2b8fad7f9e19978582f7a8", @"/Views/Employee/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bce9213955e3dc9de0c5fa0472714bbceedf19d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MDTasks.Models.EmployeeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-material mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-breadcrumb"">
    <div class=""row align-items-center"">
        <div class=""col-md-6 col-8 align-self-center"">
            <h3 class=""page-title mb-0 p-0"">Employee</h3>
            <div class=""d-flex align-items-center"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item"" aria-current=""page"">Employee</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Detail</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c699e9dbbc6da28c2b8fad7f9e19978582f7a86637", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1202, "\"", 1219, 1);
#nullable restore
#line 32 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 1210, Model.Id, 1210, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 33 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                         if(!string.IsNullOrEmpty(Model.EmployeeID)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"col-md-12 mb-0\">Employee ID</label>\r\n                            <div class=\"col-md-12\">\r\n                                <input name=\"EmployeeID\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1546, "\"", 1571, 1);
#nullable restore
#line 37 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 1554, Model.EmployeeID, 1554, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled\r\n                                       class=\"form-control ps-0 form-control-line\">\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 41 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"col-md-12 mb-0\">Employee Name</label>\r\n                            <div class=\"col-md-12\">\r\n                                <input name=\"FullName\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2013, "\"", 2036, 1);
#nullable restore
#line 45 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 2021, Model.FullName, 2021, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                       class=""form-control ps-0 form-control-line"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-12 mb-0"">Department Name</label>
                            <div class=""col-sm-12 border-bottom"">
                                <select name=""DepartmentID"" class=""form-select shadow-none ps-0 border-0 form-control-line"">
");
#nullable restore
#line 53 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                     foreach (var department in ViewBag.Departments)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                         if(department.Id == Model.DepartmentID)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c699e9dbbc6da28c2b8fad7f9e19978582f7a810597", async() => {
#nullable restore
#line 57 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                                                               Write(department.DepartmentName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                               WriteLiteral(department.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                        }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c699e9dbbc6da28c2b8fad7f9e19978582f7a813200", async() => {
#nullable restore
#line 59 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                                                      Write(department.DepartmentName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                               WriteLiteral(department.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""row"">
                                <label class=""col-md-6 mb-0"">Birthday</label>
                                <label class=""col-md-6 mb-0"">Email</label>
                                <div class=""col-md-6"">
                                    <input name=""Birthday"" type=""date""");
                BeginWriteAttribute("value", " value=\"", 3620, "\"", 3646, 1);
#nullable restore
#line 70 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 3628, Model.StrBirthday, 3628, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                           class=\"form-control ps-0 form-control-line\">\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <input name=\"Email\" type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 3902, "\"", 3922, 1);
#nullable restore
#line 74 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 3910, Model.Email, 3910, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                           class=""form-control ps-0 form-control-line"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""row"">
                                <label class=""col-md-6 mb-0"">Phone</label>
                                <label class=""col-md-6 mb-0"">Position</label>
                                <div class=""col-md-6"">
                                    <input name=""Phone"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4497, "\"", 4517, 1);
#nullable restore
#line 84 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 4505, Model.Phone, 4505, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                           class=""form-control ps-0 form-control-line"">
                                </div>
                                <div class=""col-md-6"">
                                    <input name=""Position"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4775, "\"", 4798, 1);
#nullable restore
#line 88 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 4783, Model.Position, 4783, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                           class=""form-control ps-0 form-control-line"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-12 d-flex"">
                                <button class=""btn btn-success text-white"" style=""margin-right:10px"">
                                    Update
                                </button>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c699e9dbbc6da28c2b8fad7f9e19978582f7a819441", async() => {
                    WriteLiteral("\r\n                                    Cancel\r\n                                ");
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
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MDTasks.Models.EmployeeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
