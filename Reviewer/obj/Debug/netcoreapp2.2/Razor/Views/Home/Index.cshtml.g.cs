#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9678c6a15f1a962cf76935fdda30cbfda827c5da67aec23358385e60809aa370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9678c6a15f1a962cf76935fdda30cbfda827c5da67aec23358385e60809aa370", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sidebar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang Review về sản phẩm";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";


#line default
#line hidden
            BeginContext(115, 230, true);
            WriteLiteral("\r\n<section class=\"hp_banner_area section_padding\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n                <div class=\"hp_banner_box\">\r\n                    ");
            EndContext();
            BeginContext(346, 35, false);
#line 13 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("News"));

#line default
#line hidden
            EndContext();
            BeginContext(381, 528, true);
            WriteLiteral(@"
                </div>
        </div>
        
    </div>
</section>
<!-- ~~~=| Banner END |=~~~ -->
<!-- ~~~=| Main Wrapper END |=~~~ -->
<section class=""main_news_wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9 col-sm-9 col-xs-12"">
                <!-- ~~~=| SP area START |=~~~ -->
                <div class=""fashion_area"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            ");
            EndContext();
            BeginContext(910, 43, false);
#line 29 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml"
                       Write(await Component.InvokeAsync("IndexDanhMuc"));

#line default
#line hidden
            EndContext();
            BeginContext(953, 421, true);
            WriteLiteral(@"
                        </div>
                        
                    </div>
                </div>
                <!-- ~~~=| SP area END |=~~~ -->
            </div>
            <div class=""col-md-3 col-sm-3 col-xs-12"">
                <div class=""home_sidebar"">
                    <div class=""purchase_sidebar"">
                        <div class=""purchase_sidebar_img"">
                            ");
            EndContext();
            BeginContext(1374, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9678c6a15f1a962cf76935fdda30cbfda827c5da67aec23358385e60809aa3706494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 333, true);
            WriteLiteral(@"
                            <div class=""purchase_overlay""></div>
                            <div class=""purchase_sidebar_text"">
                                <h2>LBT TEK</h2>
                                <p>Cung cấp bài đánh giá sản phầm chất lượng tốt nhất</p>
                                <div class=""purchase_s""> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1749, "\"", 1756, 0);
            EndWriteAttribute();
            BeginContext(1757, 358, true);
            WriteLiteral(@">Xem</a> </div>
                            </div>
                        </div>
                    </div>
                    <div class=""follow_us_side"">
                        <h2>Follow Us</h2>
                        <div class=""all_single_follow"">
                            <div class=""single_follow_us"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2115, "\"", 2122, 0);
            EndWriteAttribute();
            BeginContext(2123, 336, true);
            WriteLiteral(@">
                                    <i class=""fa fa-facebook""></i><br>
                                    9999<br>
                                    Fans
                                </a>
                            </div>
                            <div class=""single_follow_us twit"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2459, "\"", 2466, 0);
            EndWriteAttribute();
            BeginContext(2467, 336, true);
            WriteLiteral(@">
                                    <i class=""fa fa-twitter""></i><br>
                                    5697<br>
                                    Fans
                                </a>
                            </div>
                            <div class=""single_follow_us goopl"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2803, "\"", 2810, 0);
            EndWriteAttribute();
            BeginContext(2811, 343, true);
            WriteLiteral(@">
                                    <i class=""fa fa-google-plus""></i><br>
                                    8386<br>
                                    Fans
                                </a>
                            </div>
                            <div class=""single_follow_us last_one"">
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3154, "\"", 3161, 0);
            EndWriteAttribute();
            BeginContext(3162, 317, true);
            WriteLiteral(@">
                                    <i class=""fa fa-dribbble""></i><br>
                                    5638<br>
                                    Fans
                                </a>
                            </div>
                        </div>
                    </div>
                    ");
            EndContext();
            BeginContext(3480, 39, false);
#line 82 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("XemNhieu"));

#line default
#line hidden
            EndContext();
            BeginContext(3519, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3542, 36, false);
#line 83 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Image"));

#line default
#line hidden
            EndContext();
            BeginContext(3578, 88, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
