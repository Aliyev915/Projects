#pragma checksum "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "821e5c26f2d4c6120b189c043a5e6633c50c311b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Details), @"mvc.1.0.view", @"/Views/Teacher/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Details.cshtml", typeof(AspNetCore.Views_Teacher_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821e5c26f2d4c6120b189c043a5e6633c50c311b", @"/Views/Teacher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2884299c828049a43a7b948125a4d4905f3c7ebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(59, 257, true);
            WriteLiteral(@"
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            EndContext();
            BeginContext(316, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1a457ca0e214c50bfef2e6712768fb1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 326, "~/img/teacher/", 326, 14, true);
#line 12 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
AddHtmlAttributeValue("", 340, Model.Photo, 340, 12, false);

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
            BeginContext(368, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
            EndContext();
            BeginContext(555, 10, false);
#line 17 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(565, 31, true);
            WriteLiteral("</h2>\r\n                    <h5>");
            EndContext();
            BeginContext(597, 16, false);
#line 18 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(613, 569, true);
            WriteLiteral(@"</h5>
                    <h4>about me</h4>
                    <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human
                    happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque
                    ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam
                    voluptatem quia voluptas </p>
                    <ul>
                        <li><span>degree: </span>");
            EndContext();
            BeginContext(1183, 24, false);
#line 25 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                            Write(Model.TeacherInfo.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
            EndContext();
            BeginContext(1268, 28, false);
#line 26 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                Write(Model.TeacherInfo.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
            EndContext();
            BeginContext(1354, 23, false);
#line 27 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                             Write(Model.TeacherInfo.Hobby);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
            EndContext();
            BeginContext(1435, 25, false);
#line 28 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                             Write(Model.TeacherInfo.Faculty);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 309, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
            EndContext();
            BeginContext(1770, 23, false);
#line 37 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                         Write(Model.TeacherInfo.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1793, 56, true);
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
            EndContext();
            BeginContext(1850, 23, false);
#line 38 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                             Write(Model.TeacherInfo.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1873, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
            EndContext();
            BeginContext(1924, 23, false);
#line 39 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                       Write(Model.TeacherInfo.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 1090, true);
            WriteLiteral(@"</p>
                    <ul>
                        <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                        <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                        <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                     ");
            WriteLiteral("               <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3037, "\"", 3173, 11);
            WriteAttributeValue("", 3045, "width:", 3045, 6, true);
#line 58 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 3051, Model.Skill.Language, 3052, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3073, "%;", 3073, 2, true);
            WriteAttributeValue(" ", 3075, "visibility:", 3076, 12, true);
            WriteAttributeValue(" ", 3087, "visible;", 3088, 9, true);
            WriteAttributeValue(" ", 3096, "animation-duration:", 3097, 20, true);
            WriteAttributeValue(" ", 3116, "1.5s;", 3117, 6, true);
            WriteAttributeValue(" ", 3122, "animation-delay:", 3123, 17, true);
            WriteAttributeValue(" ", 3139, "1.2s;", 3140, 6, true);
            WriteAttributeValue(" ", 3145, "animation-name:", 3146, 16, true);
            WriteAttributeValue(" ", 3161, "fadeInLeft;", 3162, 12, true);
            EndWriteAttribute();
            BeginContext(3174, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(3297, 20, false);
#line 59 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3317, 469, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3786, "\"", 3925, 11);
            WriteAttributeValue("", 3794, "width:", 3794, 6, true);
#line 68 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue("  ", 3800, Model.Skill.TeamLeader, 3802, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3825, "%;", 3825, 2, true);
            WriteAttributeValue(" ", 3827, "visibility:", 3828, 12, true);
            WriteAttributeValue(" ", 3839, "visible;", 3840, 9, true);
            WriteAttributeValue(" ", 3848, "animation-duration:", 3849, 20, true);
            WriteAttributeValue(" ", 3868, "1.5s;", 3869, 6, true);
            WriteAttributeValue(" ", 3874, "animation-delay:", 3875, 17, true);
            WriteAttributeValue(" ", 3891, "1.2s;", 3892, 6, true);
            WriteAttributeValue(" ", 3897, "animation-name:", 3898, 16, true);
            WriteAttributeValue(" ", 3913, "fadeInLeft;", 3914, 12, true);
            EndWriteAttribute();
            BeginContext(3926, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(4049, 22, false);
#line 69 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4071, 469, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4540, "\"", 4680, 11);
            WriteAttributeValue("", 4548, "width:", 4548, 6, true);
#line 78 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue("  ", 4554, Model.Skill.Development, 4556, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 4580, "%;", 4580, 2, true);
            WriteAttributeValue(" ", 4582, "visibility:", 4583, 12, true);
            WriteAttributeValue(" ", 4594, "visible;", 4595, 9, true);
            WriteAttributeValue(" ", 4603, "animation-duration:", 4604, 20, true);
            WriteAttributeValue(" ", 4623, "1.5s;", 4624, 6, true);
            WriteAttributeValue(" ", 4629, "animation-delay:", 4630, 17, true);
            WriteAttributeValue(" ", 4646, "1.2s;", 4647, 6, true);
            WriteAttributeValue(" ", 4652, "animation-name:", 4653, 16, true);
            WriteAttributeValue(" ", 4668, "fadeInLeft;", 4669, 12, true);
            EndWriteAttribute();
            BeginContext(4681, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(4804, 23, false);
#line 79 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(4827, 464, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5291, "\"", 5426, 11);
            WriteAttributeValue("", 5299, "width:", 5299, 6, true);
#line 88 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue("  ", 5305, Model.Skill.Design, 5307, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 5326, "%;", 5326, 2, true);
            WriteAttributeValue(" ", 5328, "visibility:", 5329, 12, true);
            WriteAttributeValue(" ", 5340, "visible;", 5341, 9, true);
            WriteAttributeValue(" ", 5349, "animation-duration:", 5350, 20, true);
            WriteAttributeValue(" ", 5369, "1.5s;", 5370, 6, true);
            WriteAttributeValue(" ", 5375, "animation-delay:", 5376, 17, true);
            WriteAttributeValue(" ", 5392, "1.2s;", 5393, 6, true);
            WriteAttributeValue(" ", 5398, "animation-name:", 5399, 16, true);
            WriteAttributeValue(" ", 5414, "fadeInLeft;", 5415, 12, true);
            EndWriteAttribute();
            BeginContext(5427, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(5550, 18, false);
#line 89 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5568, 468, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6036, "\"", 6175, 11);
            WriteAttributeValue("", 6044, "width:", 6044, 6, true);
#line 98 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue("  ", 6050, Model.Skill.Innovation, 6052, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 6075, "%;", 6075, 2, true);
            WriteAttributeValue(" ", 6077, "visibility:", 6078, 12, true);
            WriteAttributeValue(" ", 6089, "visible;", 6090, 9, true);
            WriteAttributeValue(" ", 6098, "animation-duration:", 6099, 20, true);
            WriteAttributeValue(" ", 6118, "1.5s;", 6119, 6, true);
            WriteAttributeValue(" ", 6124, "animation-delay:", 6125, 17, true);
            WriteAttributeValue(" ", 6141, "1.2s;", 6142, 6, true);
            WriteAttributeValue(" ", 6147, "animation-name:", 6148, 16, true);
            WriteAttributeValue(" ", 6163, "fadeInLeft;", 6164, 12, true);
            EndWriteAttribute();
            BeginContext(6176, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(6299, 22, false);
#line 99 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6321, 471, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6792, "\"", 6934, 11);
            WriteAttributeValue("", 6800, "width:", 6800, 6, true);
#line 108 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
WriteAttributeValue("  ", 6806, Model.Skill.Communication, 6808, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 6834, "%;", 6834, 2, true);
            WriteAttributeValue(" ", 6836, "visibility:", 6837, 12, true);
            WriteAttributeValue(" ", 6848, "visible;", 6849, 9, true);
            WriteAttributeValue(" ", 6857, "animation-duration:", 6858, 20, true);
            WriteAttributeValue(" ", 6877, "1.5s;", 6878, 6, true);
            WriteAttributeValue(" ", 6883, "animation-delay:", 6884, 17, true);
            WriteAttributeValue(" ", 6900, "1.2s;", 6901, 6, true);
            WriteAttributeValue(" ", 6906, "animation-name:", 6907, 16, true);
            WriteAttributeValue(" ", 6922, "fadeInLeft;", 6923, 12, true);
            EndWriteAttribute();
            BeginContext(6935, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(7058, 25, false);
#line 109 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Teacher\Details.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(7083, 292, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
