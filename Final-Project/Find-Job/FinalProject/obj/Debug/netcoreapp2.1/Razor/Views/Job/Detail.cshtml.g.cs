#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc81a13a3a94cf7bf347aacaf3109950a2053dfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Detail), @"mvc.1.0.view", @"/Views/Job/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Job/Detail.cshtml", typeof(AspNetCore.Views_Job_Detail))]
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
#line 1 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc81a13a3a94cf7bf347aacaf3109950a2053dfc", @"/Views/Job/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Write message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 419, true);
            WriteLiteral(@"
<!--job detail start  -->
<div class=""job-detail"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""left-section"">
                    <div class=""job-feature"">
                        <div class=""row"">
                            <div class=""col-2"">
                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(479, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af931c27bad74e6694de1e575a5571be", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 489, "~/img/company-logo/", 489, 19, true);
#line 16 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
AddHtmlAttributeValue("", 508, Model.Job.Company.Logo, 508, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(540, 276, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-10"">
                                <div class=""info"">
                                    <div class=""name"">
                                        ");
            EndContext();
            BeginContext(817, 14, false);
#line 22 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                   Write(Model.Job.Name);

#line default
#line hidden
            EndContext();
            BeginContext(831, 120, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <span><i class=\"fas fa-briefcase\"></i>");
            EndContext();
            BeginContext(952, 23, false);
#line 24 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                     Write(Model.Job.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(975, 88, true);
            WriteLiteral("</span>\r\n                                    <span><i class=\"fas fa-map-marker-alt\"></i>");
            EndContext();
            BeginContext(1064, 23, false);
#line 25 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                          Write(Model.Job.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 79, true);
            WriteLiteral("</span>\r\n                                    <span><i class=\"far fa-clock\"></i>");
            EndContext();
            BeginContext(1167, 19, false);
#line 26 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                 Write(Model.Job.Type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 297, true);
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""job-about"">
                        <h3>Job Description</h3>
                        <p>
                            ");
            EndContext();
            BeginContext(1484, 21, false);
#line 34 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                       Write(Model.Job.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1505, 224, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"job-experince\">\r\n                        <h3>Education + Experience</h3>\r\n                        <ul>\r\n                            ");
            EndContext();
            BeginContext(1730, 36, false);
#line 40 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                       Write(Html.Raw(Model.Job.Demand.Education));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 203, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"related-job\">\r\n                        <h3>Related Jobs</h3>\r\n                        <div class=\"job-list\">\r\n");
            EndContext();
#line 46 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                             foreach (Job item in ViewBag.Jobs)
                            {

#line default
#line hidden
            BeginContext(2065, 305, true);
            WriteLiteral(@"                                <div class=""job-about"">
                                    <div class=""row"">
                                        <div class=""col-lg-2 col-sm-4"">
                                            <div class=""company-logo"">
                                                ");
            EndContext();
            BeginContext(2370, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "289f8c0331204917ade388ca9ae6476f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2380, "~/img/company-logo/", 2380, 19, true);
#line 52 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
AddHtmlAttributeValue("", 2399, item.Company.Logo, 2399, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2430, 289, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-lg-6 col-sm"">
                                            <div class=""name"">
                                                <h5>");
            EndContext();
            BeginContext(2720, 9, false);
#line 57 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 281, true);
            WriteLiteral(@"</h5>
                                            </div>
                                            <div class=""add-info"">
                                                <div class=""row"">
                                                    <p><i class=""fas fa-briefcase""></i>");
            EndContext();
            BeginContext(3011, 18, false);
#line 61 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                                  Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3029, 98, true);
            WriteLiteral("</p>\r\n                                                    <p><i class=\"fas fa-map-marker-alt\"></i>");
            EndContext();
            BeginContext(3128, 18, false);
#line 62 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                                       Write(item.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3146, 89, true);
            WriteLiteral("</p>\r\n                                                    <p><i class=\"far fa-clock\"></i>");
            EndContext();
            BeginContext(3236, 14, false);
#line 63 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                              Write(item.Type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3250, 243, true);
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"deadline\">\r\n                                                <p>Deadline: ");
            EndContext();
            BeginContext(3494, 46, false);
#line 67 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                        Write(item.Deadline.ToString("MMMM").Substring(0, 3));

#line default
#line hidden
            EndContext();
            BeginContext(3540, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3542, 17, false);
#line 67 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                                                        Write(item.Deadline.Day);

#line default
#line hidden
            EndContext();
            BeginContext(3559, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(3562, 18, false);
#line 67 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                                                                                            Write(item.Deadline.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3580, 848, true);
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""row"">
                                                <div class=""favorite"">
                                                    <i class=""far fa-heart""></i>
                                                </div>
                                                <div class=""apply"">
                                                    <a href="""" class=""btn-apply"">Apply Now</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
            EndContext();
#line 82 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(4459, 1113, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""right-section"">
                    <div class=""save"">
                        <button class=""btn-save"">
                            Save Job
                        </button>
                    </div>
                    <div class=""download"">
                        <button class=""btn-download"">
                            Apply Now
                        </button>
                    </div>
                    <div class=""search-side"">
                        <div class=""overview"">
                            <h3>Job Overview</h3>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-hand-holding-usd""></i>
                                </div>
                                <div class=""col-9"">
                              ");
            WriteLiteral("      <h5 style=\"font-weight: bold;\">Salary</h5>\r\n                                    <p>");
            EndContext();
            BeginContext(5573, 23, false);
#line 108 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                  Write(Model.Job.Currency.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(5596, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5598, 16, false);
#line 108 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                                           Write(Model.Job.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(5614, 471, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-map-marker-alt""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Location</h5>
                                    <p>");
            EndContext();
            BeginContext(6086, 23, false);
#line 117 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                  Write(Model.Job.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6109, 466, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-briefcase""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Job Type</h5>
                                    <p>");
            EndContext();
            BeginContext(6576, 19, false);
#line 126 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                  Write(Model.Job.Type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6595, 469, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-chart-line""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Experience</h5>
                                    <p>");
            EndContext();
            BeginContext(7065, 20, false);
#line 135 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                  Write(Model.Job.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(7085, 253, true);
            WriteLiteral(" Years</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"quick-contact\">\r\n                            <h3>Quick Contact</h3>\r\n                            ");
            EndContext();
            BeginContext(7338, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edabf372dc3046088a6f36fe0c0e0429", async() => {
                BeginContext(7358, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(7392, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "645ebf7186eb4f728e116a4634663e6b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 142 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                BeginContext(7462, 61, true);
                WriteLiteral("\r\n                                <ul style=\"display:none\">\r\n");
                EndContext();
#line 144 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                     foreach (AppUser item in ViewBag.Users)
                                    {

#line default
#line hidden
                BeginContext(7640, 44, true);
                WriteLiteral("                                        <li>");
                EndContext();
                BeginContext(7685, 10, false);
#line 146 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                       Write(item.Email);

#line default
#line hidden
                EndContext();
                BeginContext(7695, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 147 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
                                    }

#line default
#line hidden
                BeginContext(7741, 71, true);
                WriteLiteral("                                </ul>\r\n                                ");
                EndContext();
                BeginContext(7812, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d4156f080e74d838872a2592e453508", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 149 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Job\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7885, 110, true);
                WriteLiteral("\r\n                                <button class=\"btn-send\">Send Message</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8002, 167, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--job detail end  -->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8187, 723, true);
                WriteLiteral(@"
<script>
    let lists = document.querySelectorAll('.quick-contact ul li');
    let input = document.querySelector('#name');
    input.onkeyup = function () {
        if (this.value.length != 0) {
            this.nextElementSibling.style.display = 'block';
        } else {
            this.nextElementSibling.style.display = 'none';
        }
    }
    for (let list of lists) {
        list.onclick = function () {
            this.parentElement.previousElementSibling.value = this.innerText;
            this.parentElement.style.display = 'none';
        }
    }
    document.querySelector('.quick-contact form').onsubmit = function () {
        alert('Message sent succesfully');
    }
</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
