#pragma checksum "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74a91e30f6f05ffc0d61a5339f5d8244e0308a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Details.cshtml", typeof(AspNetCore.Views_Blog_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74a91e30f6f05ffc0d61a5339f5d8244e0308a7", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2884299c828049a43a7b948125a4d4905f3c7ebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/download.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteReply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(58, 282, true);
            WriteLiteral(@"
<!-- Blog Start -->
<div class=""blog-details-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""blog-details"">
                    <div class=""blog-details-img"">
                        ");
            EndContext();
            BeginContext(340, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9549543716d94996908374132b04b4dd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 350, "~/img/blog/", 350, 11, true);
#line 13 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 361, Model.Blog.Image, 361, 17, false);

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
            BeginContext(399, 114, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog-details-content\">\r\n                        <h2>");
            EndContext();
            BeginContext(514, 32, false);
#line 16 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                       Write(Html.Raw(Model.Blog.Description));

#line default
#line hidden
            EndContext();
            BeginContext(546, 130, true);
            WriteLiteral("</h2>\r\n                        <h6>By Alex  /  June 20, 2017  /  <i class=\"fa fa-comments-o\"></i> 4</h6>\r\n                        ");
            EndContext();
            BeginContext(677, 26, false);
#line 18 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.Blog.About));

#line default
#line hidden
            EndContext();
            BeginContext(703, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                     foreach (Reply reply in ViewBag.Replies)
                    {

#line default
#line hidden
            BeginContext(819, 191, true);
            WriteLiteral("                        <div class=\"row mb-100\">\r\n                            <div class=\"col-md-2\">\r\n                                <div class=\"image\">\r\n                                    ");
            EndContext();
            BeginContext(1010, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1f3f287b25c479c8cf583c4ac925697", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1047, 283, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-7"">
                                <div class=""d-flex date"" style=""margin-left: 30px;"">
                                    <p style=""margin-bottom: 5px;"">");
            EndContext();
            BeginContext(1331, 22, false);
#line 30 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                                              Write(reply.AppUser.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 45, true);
            WriteLiteral("</p>\r\n                                    <p>");
            EndContext();
            BeginContext(1399, 10, false);
#line 31 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                  Write(reply.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 241, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"reply-message\" style=\"margin-top: 15px;\">\r\n                                    <p style=\"margin-left:-30px\" >\r\n                                        ");
            EndContext();
            BeginContext(1651, 13, false);
#line 35 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                   Write(reply.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1664, 120, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 39 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                             if (ViewBag.Role == "Admin")
                            {

#line default
#line hidden
            BeginContext(1874, 84, true);
            WriteLiteral("                            <div class=\"col-md-1\">\r\n                                ");
            EndContext();
            BeginContext(1958, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f576a7dd3840e68ade9af3a1c41cb9", async() => {
                BeginContext(2033, 151, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-times text-danger\" style=\"margin-top:20px;font-size:30px\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                                                                    WriteLiteral(reply.Id);

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
            BeginContext(2188, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 46 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(2257, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 48 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2312, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 49 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
            BeginContext(2400, 555, true);
            WriteLiteral(@"                            <div class=""reply-area"">
                                <h3>LEAVE A REPLY</h3>
                                <p>
                                    I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br>
                                    the is lder of human happinescias unde omnis iste natus error sit volptatem
                                </p>
                                <div class=""row"" id=""replies"">
                                    <input type=""hidden"" id=""blog""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2955, "\"", 2977, 1);
#line 58 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
WriteAttributeValue("", 2963, Model.Blog.Id, 2963, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2978, 77, true);
            WriteLiteral(" />\r\n                                </div>\r\n                                ");
            EndContext();
            BeginContext(3055, 590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d3bca0ebf347d7a0d51de71447fe7e", async() => {
                BeginContext(3094, 226, true);
                WriteLiteral("\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-md-12\">\r\n                                            <p>Message</p>\r\n                                            ");
                EndContext();
                BeginContext(3320, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee03baeae6d244f5a40dedc40bc2dbcf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 64 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                BeginContext(3392, 246, true);
                WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <button type=\"submit\" class=\"btn btn-primary col-md-4 mr-2\">Leave a Reply</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
            BeginContext(3645, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 70 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(3710, 285, true);
            WriteLiteral(@"                    </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget detail-category mb-47"">
                        <h3>categories</h3>
                        <ul>
");
            EndContext();
#line 78 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                             foreach (Category item in Model.Categories)
                            {

#line default
#line hidden
            BeginContext(4100, 66, true);
            WriteLiteral("                            <li>\r\n                                ");
            EndContext();
            BeginContext(4166, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ffd14973884fbba5fdbe8fc0dce344", async() => {
                BeginContext(4239, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4278, 27, false);
#line 82 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                               Write(Html.Raw(item.CategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(4305, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(4308, 55, false);
#line 82 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                                             Write(Model.Blogs.Where(b => b.CategoryId == item.Id).Count());

#line default
#line hidden
                EndContext();
                BeginContext(4363, 35, true);
                WriteLiteral(")\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
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
            BeginContext(4402, 54, true);
            WriteLiteral("\r\n                                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4456, "\"", 4472, 1);
#line 84 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
WriteAttributeValue("", 4464, item.Id, 4464, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4473, 52, true);
            WriteLiteral(" id=\"DataId\" />\r\n                            </li>\r\n");
            EndContext();
#line 86 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"

                            }

#line default
#line hidden
            BeginContext(4558, 243, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-47\">\r\n                        <div class=\"single-blog-banner\">\r\n                            <a href=\"blog-details.html\" id=\"blog\">");
            EndContext();
            BeginContext(4801, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7ce9726832164cbe927acf4754cf3a54", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4847, 239, true);
            WriteLiteral("</a>\r\n                            <h2>best<br> eductaion<br> theme</h2>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-47\">\r\n                        <h3>latest post</h3>\r\n");
            EndContext();
#line 98 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                         foreach (Blog item in Model.Blogs.TakeLast(3))
                        {

#line default
#line hidden
            BeginContext(5186, 230, true);
            WriteLiteral("                            <div class=\"single-post mb-30\">\r\n                                <div class=\"single-post-img\">\r\n                                    <a href=\"blog-details.html\">\r\n                                        ");
            EndContext();
            BeginContext(5416, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77f180d1bb3e46c9a4b4ec3232dcd253", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5426, "~/img/blog/", 5426, 11, true);
#line 103 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 5437, item.Image, 5437, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5481, 405, true);
            WriteLiteral(@"
                                        <div class=""blog-hover"">
                                            <i class=""fa fa-link""></i>
                                        </div>
                                    </a>
                                </div>
                                <div class=""single-post-content"">
                                    <h4><a href=""blog-details.html"">");
            EndContext();
            BeginContext(5887, 26, false);
#line 110 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                                               Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5913, 157, true);
            WriteLiteral("</a></h4>\r\n                                    <p>By Alex  /  June 20, 2017</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 114 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"

                        }

#line default
#line hidden
            BeginContext(6099, 173, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"single-blog-widget\">\r\n                        <h3>tags</h3>\r\n                        <div class=\"single-tag\">\r\n");
            EndContext();
#line 121 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                             foreach (Tag item in Model.Tags)
                            {

#line default
#line hidden
            BeginContext(6366, 80, true);
            WriteLiteral("                                <a href=\"blog-details.html\" class=\"mr-10 mb-10\">");
            EndContext();
            BeginContext(6447, 12, false);
#line 123 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                                                                           Write(item.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(6459, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 124 "C:\Users\Code\Desktop\Back-End Project\Project\Project\Views\Blog\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(6496, 159, true);
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