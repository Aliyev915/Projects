#pragma checksum "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a15354c65df3dff5cd63c8588df3dd9f551299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 2 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#line 3 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\_ViewImports.cshtml"
using Project.DAL;

#line default
#line hidden
#line 4 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\_ViewImports.cshtml"
using Project.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a15354c65df3dff5cd63c8588df3dd9f551299", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2884299c828049a43a7b948125a4d4905f3c7ebc", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(57, 234, true);
            WriteLiteral("\r\n<!-- About Start -->\r\n<div class=\"about-area pt-145 pb-155\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-content\">\r\n                    <h2>");
            EndContext();
            BeginContext(292, 29, false);
#line 12 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                   Write(Html.Raw(Model.Content.Title));

#line default
#line hidden
            EndContext();
            BeginContext(321, 30, true);
            WriteLiteral("</h2>\r\n                    <p>");
            EndContext();
            BeginContext(352, 35, false);
#line 13 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                  Write(Html.Raw(Model.Content.Description));

#line default
#line hidden
            EndContext();
            BeginContext(387, 220, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>\r\n                    ");
            EndContext();
            BeginContext(607, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "945a8592d58842f68e81ad4a4a0d2098", async() => {
                BeginContext(654, 12, true);
                WriteLiteral("view courses");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(670, 152, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            EndContext();
            BeginContext(822, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1b49b4df55d479f8826db0b09b3df99", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 832, "~/img/about/", 832, 12, true);
#line 20 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 844, Model.Content.Image, 844, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(878, 331, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            EndContext();
            BeginContext(1209, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25bf87e616284c138e42cf35a66ba8da", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1256, 132, true);
            WriteLiteral("\r\n                    <h2>Our Teachers</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 39 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
             foreach (Teacher item in Model.Teachers)
            {

#line default
#line hidden
            BeginContext(1458, 195, true);
            WriteLiteral("                <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-teacher\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            EndContext();
            BeginContext(1653, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0911da6a390c47318e32d51bf1ebff2b", async() => {
                BeginContext(1726, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f7884716429f4706856885d6f1f897f6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1736, "~/img/teacher/", 1736, 14, true);
#line 44 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1750, item.Image, 1750, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1781, 171, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2><a href=\"teacher-details.html\">");
            EndContext();
            BeginContext(1953, 9, false);
#line 47 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1962, 43, true);
            WriteLiteral("</a></h2>\r\n                            <h4>");
            EndContext();
            BeginContext(2006, 15, false);
#line 48 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                           Write(item.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(2021, 88, true);
            WriteLiteral("</h4>\r\n                            <ul>\r\n                                <li><a href=\"\">");
            EndContext();
            BeginContext(2110, 28, false);
#line 50 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                          Write(Html.Raw(Model.Bio.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 58, true);
            WriteLiteral("</a></li>\r\n                                <li><a href=\"\">");
            EndContext();
            BeginContext(2197, 29, false);
#line 51 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                          Write(Html.Raw(Model.Bio.Pinterest));

#line default
#line hidden
            EndContext();
            BeginContext(2226, 58, true);
            WriteLiteral("</a></li>\r\n                                <li><a href=\"\">");
            EndContext();
            BeginContext(2285, 25, false);
#line 52 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                          Write(Html.Raw(Model.Bio.Vimeo));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 58, true);
            WriteLiteral("</a></li>\r\n                                <li><a href=\"\">");
            EndContext();
            BeginContext(2369, 27, false);
#line 53 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                          Write(Html.Raw(Model.Bio.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2396, 132, true);
            WriteLiteral("</a></li>\r\n\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 59 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(2545, 542, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3087, "\"", 3131, 2);
            WriteAttributeValue("", 3093, "img/testimonial/", 3093, 16, true);
#line 74 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
WriteAttributeValue("", 3109, Model.Imotional.Image, 3109, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3132, 155, true);
            WriteLiteral(" alt=\"testimonial\">\r\n                            </div>\r\n                            <div class=\"testimonial-content\">\r\n                                <p>");
            EndContext();
            BeginContext(3288, 15, false);
#line 77 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                              Write(Model.Imotional);

#line default
#line hidden
            EndContext();
            BeginContext(3303, 43, true);
            WriteLiteral(".</p>\r\n                                <h4>");
            EndContext();
            BeginContext(3347, 20, false);
#line 78 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                               Write(Model.Imotional.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3367, 43, true);
            WriteLiteral("</h4>\r\n                                <h5>");
            EndContext();
            BeginContext(3411, 26, false);
#line 79 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                               Write(Model.Imotional.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(3437, 1005, true);
            WriteLiteral(@"</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href="""">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>");
            EndContext();
            BeginContext(4443, 27, false);
#line 107 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                   Write(Model.Notices.First().Title);

#line default
#line hidden
            EndContext();
            BeginContext(4470, 54, true);
            WriteLiteral("</h3>\r\n                    <div class=\"notice-left\">\r\n");
            EndContext();
#line 109 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                         foreach (Notice item in Model.Notices)
                        {

#line default
#line hidden
            BeginContext(4616, 110, true);
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
            EndContext();
            BeginContext(4727, 9, false);
#line 112 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                               Write(item.Time);

#line default
#line hidden
            EndContext();
            BeginContext(4736, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(4779, 16, false);
#line 113 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4795, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 115 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4864, 159, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Notice End -->\r\n<!-- Subscribe Start -->\r\n");
            EndContext();
#line 124 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(5063, 505, true);
            WriteLiteral(@"    <div class=""subscribe-area pt-58 pb-70"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 col-md-offset-2"">
                    <div class=""subscribe-content section-title text-center"">
                        <h2>subscribe our newsletter</h2>
                        <p>I must explain to you how all this mistaken idea </p>
                    </div>
                    <div class=""newsletter-form mc_embed_signup"">
                        ");
            EndContext();
            BeginContext(5568, 1171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc7bc54fc984c06a1e469fba1c294a7", async() => {
                BeginContext(5610, 357, true);
                WriteLiteral(@"
                            <div id=""mc_embed_signup_scroll"" class=""mc-form"">
                                <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                                <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name="""" tabindex=""-1"" value=""""></div>
");
                EndContext();
#line 139 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                  
                                    AppUser user = ViewBag.User;
                                

#line default
#line hidden
                BeginContext(6104, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 142 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                 if (user.IsSubscribed)
                                {

#line default
#line hidden
                BeginContext(6196, 195, true);
                WriteLiteral("                                    <button id=\"mc-embedded-subscribe\" class=\"default-btn justify-content-center\" style=\"background-color:#2c2b5e\" type=\"submit\"><span>subscribed</span></button>\r\n");
                EndContext();
#line 145 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6499, 138, true);
                WriteLiteral("                                    <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\"><span>subscribe</span></button>\r\n");
                EndContext();
#line 149 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(6672, 60, true);
                WriteLiteral("                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6739, 595, true);
            WriteLiteral(@"
                        <!-- mailchimp-alerts Start -->
                        <div class=""mailchimp-alerts"">
                            <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                            <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                            <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                        </div>
                        <!-- mailchimp-alerts end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 164 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\About\Index.cshtml"
}

#line default
#line hidden
            BeginContext(7337, 24, true);
            WriteLiteral("<!-- Subscribe End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
