#pragma checksum "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a0fe433775af8f346cc84fc836fb377a47fc27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Detail), @"mvc.1.0.view", @"/Views/Search/Detail.cshtml")]
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
#line 1 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\_ViewImports.cshtml"
using RitualCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\_ViewImports.cshtml"
using RitualCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\_ViewImports.cshtml"
using RitualCore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a0fe433775af8f346cc84fc836fb377a47fc27", @"/Views/Search/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe7c4cfb01e56c36e32c2bded39dca889c8d7ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
  
    ViewData["Title"] = Model.Video.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area"" style=""margin-top:10em"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                        <h5 class=""breadcrumb-title"">Ritual - ");
#nullable restore
#line 12 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                                                         Write(Model.Video.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-md-right"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Ana Səhifə</a></li>
");
            WriteLiteral(@"                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""my-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <iframe width=""100%"" height=""315""");
            BeginWriteAttribute("src", " src=\"", 1233, "\"", 1293, 2);
            WriteAttributeValue("", 1239, "https://www.youtube.com/embed/", 1239, 30, true);
#nullable restore
#line 32 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
WriteAttributeValue("", 1269, Model.Video.YoutubeLink, 1269, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n                <h2>");
#nullable restore
#line 33 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
               Write(Model.Video.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 34 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
              Write(Model.Video.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n               <div class=\"sidebar-category my-4\">\r\n                   <h5>Kateqoriyalar</h5>\r\n                   <ul class=\"list-group list-unstyled\">\r\n");
#nullable restore
#line 40 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                        foreach (var cat in Model.Categories)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <li>\r\n                               <a class=\"list-group-item\"");
            BeginWriteAttribute("href", " href=\"", 1916, "\"", 1944, 2);
            WriteAttributeValue("", 1923, "/Search/Index/", 1923, 14, true);
#nullable restore
#line 43 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
WriteAttributeValue("", 1937, cat.Id, 1937, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                                                                                  Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                           </li>\r\n");
#nullable restore
#line 45 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   </ul>\r\n               </div>\r\n\r\n                <div class=\"sidebar-widget mt-40px\">\r\n                    <h4 class=\"sidebar-title\">Recent Post</h4>\r\n\r\n                    <div class=\"recent-post-widget my-3\">\r\n");
#nullable restore
#line 54 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                         foreach (var video in Model.Videos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"recent-single-post my-3 d-flex\">\r\n                                <div class=\"thumb-side col-lg-4\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2521, "\"", 2552, 2);
            WriteAttributeValue("", 2528, "/Search/Detail/", 2528, 15, true);
#nullable restore
#line 58 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
WriteAttributeValue("", 2543, video.Id, 2543, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "91a0fe433775af8f346cc84fc836fb377a47fc279370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2582, "~/Uploads/", 2582, 10, true);
#nullable restore
#line 58 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
AddHtmlAttributeValue("", 2592, video.Picture.Url, 2592, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                </div>\r\n                                <div class=\"media-side\">\r\n                                    <h6>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2807, "\"", 2838, 2);
            WriteAttributeValue("", 2814, "/Search/Detail/", 2814, 15, true);
#nullable restore
#line 62 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
WriteAttributeValue("", 2829, video.Id, 2829, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                         ");
#nullable restore
#line 63 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"
                                     Write(video.Name.Length>50?video.Name.Substring(0,50):video.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </h6>\r\n                                    <span class=\"date\">APRIL 24, 2021</span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\Elxan\Desktop\RitualFinal\RitualCore\Views\Search\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
