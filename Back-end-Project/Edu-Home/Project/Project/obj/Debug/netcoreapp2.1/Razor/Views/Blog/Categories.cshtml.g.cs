#pragma checksum "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dcdf7dd8c85f0ce1a9e47cfc8b89722dc1579d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Categories), @"mvc.1.0.view", @"/Views/Blog/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Categories.cshtml", typeof(AspNetCore.Views_Blog_Categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcdf7dd8c85f0ce1a9e47cfc8b89722dc1579d9", @"/Views/Blog/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2884299c828049a43a7b948125a4d4905f3c7ebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
  
    ViewData["Title"] = "Categories";

#line default
#line hidden
            BeginContext(61, 168, true);
            WriteLiteral("\r\n<div class=\"blog-area pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                     foreach (Blog item in Model.Blogs.Take(6))
                    {

#line default
#line hidden
            BeginContext(317, 220, true);
            WriteLiteral("                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            <div class=\"single-blog mb-60\">\r\n                                <div class=\"blog-img\">\r\n                                    ");
            EndContext();
            BeginContext(537, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eefeb1e2dc414170b6b4b1f57719c171", async() => {
                BeginContext(607, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(649, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "610d010d45a346ff9a7d741ffbf8adbb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 659, "~/img/blog/", 659, 11, true);
#line 17 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
AddHtmlAttributeValue("", 670, item.Image, 670, 11, false);

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
                BeginContext(694, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
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
            BeginContext(736, 382, true);
            WriteLiteral(@"
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-top"">
                                        <p>By ");
            EndContext();
            BeginContext(1119, 11, false);
#line 25 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                         Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(1136, 35, false);
#line 25 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                          Write(item.Date.ToString("dd, MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 195, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i>4</p>\r\n                                    </div>\r\n                                    <div class=\"blog-bottom\">\r\n                                        <h2>");
            EndContext();
            BeginContext(1366, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701f30f03a9540b78a925631a9b4b11d", async() => {
                BeginContext(1437, 26, false);
#line 28 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                                                                             Write(Html.Raw(item.Description));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
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
            BeginContext(1467, 47, true);
            WriteLiteral("</h2>\r\n                                        ");
            EndContext();
            BeginContext(1514, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c42580fbe257485a8e584f5c2f044e38", async() => {
                BeginContext(1584, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
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
            BeginContext(1597, 154, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 34 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"

                    }

#line default
#line hidden
            BeginContext(1776, 129, true);
            WriteLiteral("                    <div class=\"col-md-12\">\r\n                        <div class=\"pagination\">\r\n                            <ul>\r\n");
            EndContext();
#line 39 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                 if (Math.Ceiling(ViewBag.BlogCount / 6 > 1))
                                {
                                    

#line default
#line hidden
#line 41 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                     for (int i = 1; i <= Math.Ceiling((decimal)ViewBag.BlogCount / 6); i++)
                                    {

#line default
#line hidden
            BeginContext(2168, 44, true);
            WriteLiteral("                                        <li>");
            EndContext();
            BeginContext(2212, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8bb350b514b4243a2d1d10cab386747", async() => {
                BeginContext(2275, 1, false);
#line 43 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                                                          WriteLiteral(i);

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
            BeginContext(2280, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 44 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                    }

#line default
#line hidden
#line 44 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(2361, 362, true);
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>

            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>categories</h3>
                        <ul>
");
            EndContext();
#line 57 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                         foreach (Category item in Model.Categories)
                        {

#line default
#line hidden
            BeginContext(2820, 66, true);
            WriteLiteral("                            <li>\r\n                                ");
            EndContext();
            BeginContext(2886, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8323445fd3ef4a80b43adc7495dfdb9d", async() => {
                BeginContext(2959, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2998, 27, false);
#line 61 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                               Write(Html.Raw(item.CategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(3025, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(3028, 53, false);
#line 61 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                             Write(Model.All.Where(b => b.CategoryId == item.Id).Count());

#line default
#line hidden
                EndContext();
                BeginContext(3081, 35, true);
                WriteLiteral(")\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
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
            BeginContext(3120, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 64 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                        }                        

#line default
#line hidden
            BeginContext(3208, 243, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <div class=\"single-blog-banner\">\r\n                            <a href=\"blog-details.html\" id=\"blog\">");
            EndContext();
            BeginContext(3451, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e43a54200d14c5ca535d63ca75e4012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3497, 239, true);
            WriteLiteral("</a>\r\n                            <h2>best<br> eductaion<br> theme</h2>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>latest post</h3>\r\n");
            EndContext();
#line 75 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                         foreach (Blog item in Model.Blogs.TakeLast(3))
                        {

#line default
#line hidden
            BeginContext(3836, 230, true);
            WriteLiteral("                            <div class=\"single-post mb-30\">\r\n                                <div class=\"single-post-img\">\r\n                                    <a href=\"blog-details.html\">\r\n                                        ");
            EndContext();
            BeginContext(4066, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "099354e5b5cd44deade3d8524759009f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4076, "~/img/blog/", 4076, 11, true);
#line 80 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
AddHtmlAttributeValue("", 4087, item.Image, 4087, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4131, 405, true);
            WriteLiteral(@"
                                        <div class=""blog-hover"">
                                            <i class=""fa fa-link""></i>
                                        </div>
                                    </a>
                                </div>
                                <div class=""single-post-content"">
                                    <h4><a href=""blog-details.html"">");
            EndContext();
            BeginContext(4537, 26, false);
#line 87 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                               Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4563, 157, true);
            WriteLiteral("</a></h4>\r\n                                    <p>By Alex  /  June 20, 2017</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 91 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"

                        }

#line default
#line hidden
            BeginContext(4749, 171, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"single-blog-widget\">\r\n                        <h3>tags</h3>\r\n                        <div class=\"single-tag\">\r\n");
            EndContext();
#line 97 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                             foreach (Tag item in Model.Tags)
                            {

#line default
#line hidden
            BeginContext(5014, 80, true);
            WriteLiteral("                                <a href=\"blog-details.html\" class=\"mr-10 mb-10\">");
            EndContext();
            BeginContext(5095, 12, false);
#line 99 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                                                                           Write(item.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(5107, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 100 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Categories.cshtml"
                            }

#line default
#line hidden
            BeginContext(5144, 159, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591