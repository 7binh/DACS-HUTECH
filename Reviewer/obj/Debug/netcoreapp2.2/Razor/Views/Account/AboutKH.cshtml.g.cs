#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27de5922fb489458f647abf86ff5193c28df7a9566f395d9ada5674c92bc4267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AboutKH), @"mvc.1.0.view", @"/Views/Account/AboutKH.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AboutKH.cshtml", typeof(AspNetCore.Views_Account_AboutKH))]
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
#line 1 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer.Models;

#line default
#line hidden
#line 1 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
using Reviewer.Models.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"27de5922fb489458f647abf86ff5193c28df7a9566f395d9ada5674c92bc4267", @"/Views/Account/AboutKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AboutKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
  
    ViewData["Title"] = "Thông Tin Cá Nhân";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(167, 295, true);
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery.min.js""></script>
<style>
    label.error {
        color: red;
    }
</style>
<div class=""panel panel-default"">
    <div class=""panel-heading"" style=""margin-top:30px;text-align:center"">THÔNG TIN REVIEWER</div>
    <div class=""panel-body"">
");
            EndContext();
#line 17 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
          
            Author au = Context.Session.Get<Author>("AU");
        

#line default
#line hidden
            BeginContext(545, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(553, 1828, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27de5922fb489458f647abf86ff5193c28df7a9566f395d9ada5674c92bc42676224", async() => {
                BeginContext(638, 264, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""control-label col-sm-3"" for=""username"">Tên đăng nhập:</label>
                <div class=""col-sm-9"">
                    <input type=""text"" disabled class=""form-control"" id=""user"" name=""TenDN""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 902, "\"", 924, 1);
#line 24 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
WriteAttributeValue("", 910, au.UsernameRe, 910, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(925, 352, true);
                WriteLiteral(@">
                    <p id=""messageUser""></p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-3"" for=""pass"">Mật khẩu:</label>
                <div class=""col-sm-9"">
                    <input type=""password"" disabled class=""form-control"" id=""pass"" name=""Matkhau""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1277, "\"", 1299, 1);
#line 31 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
WriteAttributeValue("", 1285, au.PasswordRe, 1285, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1300, 302, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-3"" for=""hoten"">Họ tên:</label>
                <div class=""col-sm-9"">
                    <input type=""text"" disabled class=""form-control"" id=""hoten"" name=""hotenkh""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1602, "\"", 1624, 1);
#line 37 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
WriteAttributeValue("", 1610, au.FullnameRe, 1610, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1625, 304, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-3"" for=""diachi"">Địa chỉ:</label>
                <div class=""col-sm-9"">
                    <input type=""text"" disabled class=""form-control"" id=""diachi"" name=""Diachi""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1929, "\"", 1949, 1);
#line 43 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
WriteAttributeValue("", 1937, au.DiaChiRe, 1937, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1950, 302, true);
                WriteLiteral(@">
                </div>
            </div>

            <div class=""form-group"">
                <label class=""control-label col-sm-3"" for=""email"">Email:</label>
                <div class=""col-sm-9"">
                    <input type=""email"" disabled class=""form-control"" id=""email"" name=""email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2252, "\"", 2271, 1);
#line 50 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\AboutKH.cshtml"
WriteAttributeValue("", 2260, au.EmailRe, 2260, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2272, 102, true);
                WriteLiteral(">\r\n                    <p id=\"messageEmail\"></p>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(2381, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
