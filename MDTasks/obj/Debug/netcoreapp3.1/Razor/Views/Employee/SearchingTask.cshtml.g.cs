#pragma checksum "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3afde08d7b1c3bcac8313cee147af90626883f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_SearchingTask), @"mvc.1.0.view", @"/Views/Employee/SearchingTask.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3afde08d7b1c3bcac8313cee147af90626883f7b", @"/Views/Employee/SearchingTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bce9213955e3dc9de0c5fa0472714bbceedf19d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_SearchingTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MDTasks.Models.ResultEmployeeTask>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
  
    ViewData["Title"] = "SearchingTask";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <h3>Task Search Result</h3>\r\n</div>\r\n<div class=\"row\">\r\n    <table class=\"table\" id=\"tblData\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
               Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\HuyBin\Documents\Zalo Received Files\MDTasks\MDTasks\MDTasks\Views\Employee\SearchingTask.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MDTasks.Models.ResultEmployeeTask>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591