#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9af54b8dbcbf6238a0182179ffaeaea8f6d450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9af54b8dbcbf6238a0182179ffaeaea8f6d450", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Write message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 793, true);
            WriteLiteral(@"

<!-- contact-area start  -->
<div class=""contact-area"">
    <div class=""title"">
        <h2>Contact Us</h2>
    </div>
    <div class=""description"">
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
    </div>
    <div class=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""contact-box"">
                        <div class=""contact-icon"">
                            <i class=""fas fa-map-marker-alt""></i>
                        </div>
                        <div class=""contact-title"">
                            <h4>Office Adress</h4>
                        </div>
                        <div class=""contact-text"">
                            <p>");
            EndContext();
            BeginContext(853, 17, false);
#line 27 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                          Write(Model.Bio.Address);

#line default
#line hidden
            EndContext();
            BeginContext(870, 535, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""contact-box"">
                        <div class=""contact-icon"">
                            <i class=""fas fa-phone-alt""></i>
                        </div>
                        <div class=""contact-title"">
                            <h4>Phone</h4>
                        </div>
                        <div class=""contact-text"">
                            <p>");
            EndContext();
            BeginContext(1406, 15, false);
#line 40 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                          Write(Model.Bio.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 541, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""contact-box"">
                        <div class=""contact-icon"">
                            <i class=""far fa-envelope""></i>
                        </div>
                        <div class=""contact-title"">
                            <h4>Email Adress</h4>
                        </div>
                        <div class=""contact-text"">
                            <p>");
            EndContext();
            BeginContext(1963, 15, false);
#line 53 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                          Write(Model.Bio.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1978, 529, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""contact-box"">
                        <div class=""contact-icon"">
                            <i class=""fas fa-globe""></i>
                        </div>
                        <div class=""contact-title"">
                            <h4>Web</h4>
                        </div>
                        <div class=""contact-text"">
                            <p>");
            EndContext();
            BeginContext(2508, 13, false);
#line 66 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                          Write(Model.Bio.Web);

#line default
#line hidden
            EndContext();
            BeginContext(2521, 142, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(2663, 2050, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d27040553b4fbea77e6b69af4d7bfe", async() => {
                BeginContext(2713, 126, true);
                WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-8\">\r\n                    ");
                EndContext();
                BeginContext(2839, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c4cb2668dc44bf9f0648b0782722df", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 77 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2934, 1772, true);
                WriteLiteral(@"
                    <button class=""btn-send"">Send Message</button>
                </div>
                <div class=""col-lg-4"">
                    <div class=""job-info"">
                        <h5>Opening Hours</h5>
                            <ul>
                                <li>
                                    <strong>Sunday</strong>
                                    <span>Closed</span>
                                </li>
                                <li>
                                    <strong>Monday</strong>
                                    <span>10AM-8PM</span>
                                </li>
                                <li>
                                    <strong>Tuesday</strong>
                                    <span>10AM-8PM</span>
                                </li>
                                <li>
                                    <strong>Wednesday</strong>
                                    <span>10AM-8PM</span>
             ");
                WriteLiteral(@"                   </li>
                                <li>
                                    <strong>Thrusday</strong>
                                    <span>10AM-8PM</span>
                                </li>
                                <li>
                                    <strong>Friday</strong>
                                    <span>10AM-8PM</span>
                                </li>
                                <li>
                                    <strong>Saturday</strong>
                                    <span>10AM-8PM</span>
                                </li>
                            </ul>
                    </div>
                </div>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4713, 38, true);
            WriteLiteral("\r\n</div>\r\n<!-- contact-area end  -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591