#pragma checksum "C:\Users\DONG\Desktop\.Net-Core\EffortManager\Views\RevenueExpenditureType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6596226874b13b8a49390b1688866f469dfff1bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RevenueExpenditureType_Index), @"mvc.1.0.view", @"/Views/RevenueExpenditureType/Index.cshtml")]
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
#line 1 "C:\Users\DONG\Desktop\.Net-Core\EffortManager\Views\_ViewImports.cshtml"
using SomeThingManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DONG\Desktop\.Net-Core\EffortManager\Views\_ViewImports.cshtml"
using SomeThingManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DONG\Desktop\.Net-Core\EffortManager\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6596226874b13b8a49390b1688866f469dfff1bc", @"/Views/RevenueExpenditureType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c49c39ce48e804e81e5980b7d05584d9d7681", @"/Views/_ViewImports.cshtml")]
    public class Views_RevenueExpenditureType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\DONG\Desktop\.Net-Core\EffortManager\Views\RevenueExpenditureType\Index.cshtml"
  ViewData["Title"]="Loại thu chi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""display-6"">Loại thu chi</h2>
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
    <!--add-->
    <div id=""add_type"" class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6596226874b13b8a49390b1688866f469dfff1bc5896", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 673, "\"", 680, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 681, "\"", 686, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Mã\">\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 758, "\"", 765, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 766, "\"", 771, 0);
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
            WriteLiteral("\r\n        <hr>\r\n    </div>\r\n    <!--find-->\r\n    <div id=\"find_type\" class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6596226874b13b8a49390b1688866f469dfff1bc8452", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1097, "\"", 1104, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1105, "\"", 1110, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Mã\">\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1182, "\"", 1189, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1190, "\"", 1195, 0);
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
                <div class=""modal-content col-sm-8 offset-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6596226874b13b8a49390b1688866f469dfff1bc11198", async() => {
                WriteLiteral(@"
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""my-modal-title"">Thông tin chi tiết</h5>
                            <button class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                        </div>
                        <div class=""modal-body form-inline"">
                            <div class=""form-group"">
                                <label for=""SID"">Mã</label>
                                <input id=""SID"" style=""margin: 10px;"" class=""form-control"" type=""text"" readonly name=""SID"">
                            </div>
                            <div class=""form-group"">
                                <label for=""name"">Tên</label>
                                <input id=""name"" style=""margin: 10px;"" class=""form-control"" type=""text"" name=""name"">
                            </di");
                WriteLiteral("v>\r\n\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <input class=\"btn btn-success\" type=\"submit\" value=\"Lưu\">\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <table class=""table table-sm table-bordered table-hover text-center"">
            <thead class=""thead-light"">
                <tr>
                    <th width=1>Mã</th>
                    <th>Tên</th>
                    <th width=1></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td data-toggle=""modal"" data-target=""#my-modal"">1</td>
                    <td data-toggle=""modal"" data-target=""#my-modal"">Lương</td>
                    <td>
                        <a href=""#"" onclick=""return confirm_delete()"">
                            <i id=""delete"" class=""material-icons"">delete</i>
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div id=""card"">");
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
