#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b3619eb9b11ba613bcbaea1aec7cd9063546d9968dbfff006b4ff75597fa6d90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Xoa2), @"mvc.1.0.view", @"/Views/Admin/Xoa2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Xoa2.cshtml", typeof(AspNetCore.Views_Admin_Xoa2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b3619eb9b11ba613bcbaea1aec7cd9063546d9968dbfff006b4ff75597fa6d90", @"/Views/Admin/Xoa2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Xoa2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reviewer.Models.Data.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QLKhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Xoa2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
  
    ViewData["Title"] = "Xoa2";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(133, 147, true);
            WriteLiteral("\r\n<h2>Xoá Khách Hàng</h2>\r\n<div>\r\n    <h3>Bạn có chắc chắn muốn xoá???</h3>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(281, 40, false);
#line 14 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 36, false);
#line 17 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(401, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(445, 46, false);
#line 20 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.UsernameKh));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(535, 42, false);
#line 23 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.UsernameKh));

#line default
#line hidden
            EndContext();
            BeginContext(577, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(621, 42, false);
#line 26 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.PassKh));

#line default
#line hidden
            EndContext();
            BeginContext(663, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(707, 38, false);
#line 29 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.PassKh));

#line default
#line hidden
            EndContext();
            BeginContext(745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(789, 43, false);
#line 32 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTenKh));

#line default
#line hidden
            EndContext();
            BeginContext(832, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(876, 39, false);
#line 35 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.HoTenKh));

#line default
#line hidden
            EndContext();
            BeginContext(915, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(959, 43, false);
#line 38 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailKh));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1046, 39, false);
#line 41 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.EmailKh));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 44, false);
#line 44 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayNameFor(model => model.AvatarKh));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1217, 40, false);
#line 47 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\Xoa2.cshtml"
       Write(Html.DisplayFor(model => model.AvatarKh));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1295, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3619eb9b11ba613bcbaea1aec7cd9063546d9968dbfff006b4ff75597fa6d909960", async() => {
                BeginContext(1319, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1403, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3619eb9b11ba613bcbaea1aec7cd9063546d9968dbfff006b4ff75597fa6d9010458", async() => {
                    BeginContext(1431, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
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
                EndContext();
                BeginContext(1447, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1460, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reviewer.Models.Data.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
