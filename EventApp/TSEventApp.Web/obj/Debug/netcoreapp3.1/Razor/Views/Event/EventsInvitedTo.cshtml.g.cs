#pragma checksum "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1656f8ad8de2fbcf60c6f1371035c396cb55e460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EventsInvitedTo), @"mvc.1.0.view", @"/Views/Event/EventsInvitedTo.cshtml")]
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
#line 1 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1656f8ad8de2fbcf60c6f1371035c396cb55e460", @"/Views/Event/EventsInvitedTo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f7bda16d04c17c874f43def7e82c0711463476", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Event_EventsInvitedTo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<EventViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EventDetailsIndexPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
  
    ViewData["Title"] = "Invited Events";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = user != null ? user.Email : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"home-container p-4\">\n");
#nullable restore
#line 13 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col\">\n                <h3 class=\"text-info\">Not invited yet to any event</h3>\n            </div>\n        </div>\n");
#nullable restore
#line 20 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <h1 class=""text-center"">Events Invited To</h1>
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link active"" id=""past-tab"" data-bs-toggle=""tab"" data-bs-target=""#past"" type=""button"" role=""tab"" aria-controls=""past"" aria-selected=""true"">Past</button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""upcoming-tab"" data-bs-toggle=""tab"" data-bs-target=""#upcoming"" type=""button"" role=""tab"" aria-controls=""upcoming"" aria-selected=""false"">Upcoming</button>
                </li>
            </ul>
            <div class=""tab-content"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""past"" role=""tabpanel"" aria-labelledby=""past-tab"">
                    <ul class=""list-group pt-4"">
");
#nullable restore
#line 36 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                           int eventIterator = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                         foreach (var bookEvent in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                             if (bookEvent.InviteByEmail != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                 if (bookEvent.InviteByEmail.Split(',').Contains(email) && bookEvent.Date < DateTime.Now)
                                {
                                    ViewData["PositionFromStart"] = ++eventIterator;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1656f8ad8de2fbcf60c6f1371035c396cb55e4607412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 45 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                             


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n                <div class=\"tab-pane fade\" id=\"upcoming\" role=\"tabpanel\" aria-labelledby=\"upcoming-tab\">\n                    <ul class=\"list-group pt-4\">\n");
#nullable restore
#line 54 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                           eventIterator = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                         foreach (var bookEvent in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                             if (bookEvent.InviteByEmail != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                 if (bookEvent.InviteByEmail.Split(',').Contains(email) && bookEvent.Date > DateTime.Now)
                                {
                                    ViewData["PositionFromStart"] = ++eventIterator;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1656f8ad8de2fbcf60c6f1371035c396cb55e46011865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 62 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 62 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 63 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n\n        </div>\n");
#nullable restore
#line 71 "C:\Users\gautamkumar02\Desktop\JALSA_EXPANSE\Project\EventApp\TSEventApp.Web\Views\Event\EventsInvitedTo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<EventViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
