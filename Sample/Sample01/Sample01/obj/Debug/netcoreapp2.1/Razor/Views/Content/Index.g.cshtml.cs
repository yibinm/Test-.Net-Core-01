#pragma checksum "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102e7d5c8a4d49a336efedbcc83eeb5d8e444826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 1 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\_ViewImports.cshtml"
using Sample01;

#line default
#line hidden
#line 2 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\_ViewImports.cshtml"
using Sample01.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102e7d5c8a4d49a336efedbcc83eeb5d8e444826", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ae4c732be53154422bdd74665f5c4478a5c6fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容页";

#line default
#line hidden
            BeginContext(66, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(146, 17, false);
#line 8 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(163, 314, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
            EndContext();
#line 21 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(535, 112, true);
            WriteLiteral("            <tr>\r\n                <td><input type=\"checkbox\" class=\"done-checkbox\" /></td>\r\n                <td>");
            EndContext();
            BeginContext(648, 7, false);
#line 25 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(655, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(683, 10, false);
#line 26 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(693, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(721, 12, false);
#line 27 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.content);

#line default
#line hidden
            EndContext();
            BeginContext(733, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(761, 13, false);
#line 28 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.add_time);

#line default
#line hidden
            EndContext();
            BeginContext(774, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\MyProgram\TestProgram\Sample\Sample01\Sample01\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(813, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
