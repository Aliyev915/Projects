#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42fddeaec286698993aa611c30e19e2826826537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Index))]
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
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.DAL;

#line default
#line hidden
#line 4 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fddeaec286698993aa611c30e19e2826826537", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fbc412a9b80f975e64d958d20b3c68ffdd86e4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 894, true);
            WriteLiteral(@"
    <div class=""right-side"">
        <h4>User List</h4>
        <div class=""users"">
            <div class=""user-nav"">
                <div class=""time"">
                    <span class=""actived"" data-id=""today"">Active Users</span>
                    <span data-id=""month"">Deleted Users</span>
                </div>
            </div>
            <div class=""userList"" data-id=""today"">
                <div class=""manage"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">Username</th>
                                <th scope=""col"">Email</th>
                                <th scope=""col"">Role</th>
                                <th scope=""col"">Setting</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 28 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                             foreach (AppUser item in Model.Where(user=>user.IsDeleted==false))
                            {

#line default
#line hidden
            BeginContext(1130, 343, true);
            WriteLiteral(@"                                <tr>
                                    <th scope=""row"">
                                        <div class=""job"">
                                            <div class=""job-info"">
                                                <div class=""name"">
                                                    <h4>");
            EndContext();
            BeginContext(1474, 13, false);
#line 35 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 246, true);
            WriteLiteral("</h4>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </th>\r\n                                    <td>");
            EndContext();
            BeginContext(1734, 10, false);
#line 40 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 42 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                          
                                            UserManager<AppUser> manager = ViewBag.manager;
                                        

#line default
#line hidden
            BeginContext(1973, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2015, 38, false);
#line 45 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                    Write((await manager.GetRolesAsync(item))[0]);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2181, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6456529d16f424bb81df90fddde4b04", async() => {
                BeginContext(2260, 115, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-edit\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                                                                           WriteLiteral(item.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2379, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2421, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d1e7284a3341448ede9f9d985e84db", async() => {
                BeginContext(2502, 116, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-trash\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                                                                             WriteLiteral(item.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2622, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2737, 661, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""userList d-none"" data-id=""month"">
                <div class=""manage"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">Username</th>
                                <th scope=""col"">Email</th>
                                <th scope=""col"">Role</th>
                                <th scope=""col"">Setting</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 73 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                             foreach (AppUser item in Model.Where(user=>user.IsDeleted==true))
                            {

#line default
#line hidden
            BeginContext(3525, 343, true);
            WriteLiteral(@"                                <tr>
                                    <th scope=""row"">
                                        <div class=""job"">
                                            <div class=""job-info"">
                                                <div class=""name"">
                                                    <h4>");
            EndContext();
            BeginContext(3869, 13, false);
#line 80 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3882, 246, true);
            WriteLiteral("</h4>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </th>\r\n                                    <td>");
            EndContext();
            BeginContext(4129, 10, false);
#line 85 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 87 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                          
                                            UserManager<AppUser> manager = ViewBag.manager;
                                        

#line default
#line hidden
            BeginContext(4368, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(4410, 38, false);
#line 90 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                    Write((await manager.GetRolesAsync(item))[0]);

#line default
#line hidden
            EndContext();
            BeginContext(4449, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4576, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6abf8bc70f794017b2a212c86f6fb9a9", async() => {
                BeginContext(4657, 116, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-check\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                                                                                             WriteLiteral(item.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4777, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 98 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4892, 293, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""copyright"">
            <p>© 2018 Theme Vessel. Trademarks and brands are the property of their respective owners.</p>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591