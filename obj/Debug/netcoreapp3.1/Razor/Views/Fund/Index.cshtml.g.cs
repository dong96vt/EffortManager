#pragma checksum "c:\Users\NTQ\Desktop\DongNT\SomeThingManager\Views\Fund\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5e31ec9fc67fec57b3108f68ef7d6b009eb262e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fund_Index), @"mvc.1.0.view", @"/Views/Fund/Index.cshtml")]
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
#line 1 "c:\Users\NTQ\Desktop\DongNT\SomeThingManager\Views\_ViewImports.cshtml"
using SomeThingManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\NTQ\Desktop\DongNT\SomeThingManager\Views\_ViewImports.cshtml"
using SomeThingManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5e31ec9fc67fec57b3108f68ef7d6b009eb262e", @"/Views/Fund/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afad224501e30ee98d832197872b9927e68f1bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Fund_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\NTQ\Desktop\DongNT\SomeThingManager\Views\Fund\Index.cshtml"
   ViewData["Title"] = "Quỹ"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""display-6"">Quản lý quỹ</h2>
<hr>
<div class=""card text-center"">
    <div class=""card-header"">
        <ul class=""nav nav-tabs card-header-tabs"">
            <li class=""nav-item"">
                <a id=""nav_find_type"" class=""nav-link"" href=""#"">Tìm kiếm</a>
            </li>
            <li class=""nav-item"">
                <a id=""nav_add_type"" class=""nav-link"" href=""#"">Thêm</a>
            </li>
        </ul>
    </div>
    <div id=""add_type"" class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e31ec9fc67fec57b3108f68ef7d6b009eb262e5237", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 653, "\"", 660, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 661, "\"", 666, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Mã\">\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 738, "\"", 745, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 746, "\"", 751, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tên\">\r\n            <input type=\"submit\" class=\"btn btn-success\" value=\"Thêm\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr>\r\n    </div>\r\n    <div id=\"find_type\" class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e31ec9fc67fec57b3108f68ef7d6b009eb262e7774", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1060, "\"", 1067, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1068, "\"", 1073, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Mã\">\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1145, "\"", 1152, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1153, "\"", 1158, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tên\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Tìm kiếm\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <hr>
        <div id=""my-modal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""my-modal-title"">Thông tin chi tiết</h5>
                        <button class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                    </div>
                    <div class=""modal-body"">
                        <p>Content</p>
                    </div>
                    <div class=""modal-footer"">
                        Footer
                    </div>
                </div>
            </div>
        </div>
        <table class=""table table-sm table-bordered table-hover text-center"">
            <thead class=""thead-ligh");
            WriteLiteral(@"t"">
                <tr>
                    <th width=1>Mã</th>
                    <th>Tên</th>
                    <th width=200>Giá trị (VNĐ)</th>
                    <th width=1></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td data-toggle=""modal"" data-target=""#my-modal"">1</td>
                    <td data-toggle=""modal"" data-target=""#my-modal"">Lương</td>
                    <td data-toggle=""modal"" data-target=""#my-modal"">7,000,000</td>
                    <td>
                        <a href=""#"" onclick=""return confirm_delete()"">
                            <i id=""delete"" class=""material-icons"">delete</i>
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
