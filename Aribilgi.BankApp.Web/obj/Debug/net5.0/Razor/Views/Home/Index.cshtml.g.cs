#pragma checksum "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4c32fbda4776a65516904b6892942a31d33563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
using Aribilgi.BankApp.Web.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4c32fbda4776a65516904b6892942a31d33563", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2adbb954a04d7c4ea4d6a75010a947f29e91ea7e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUser>>
    #nullable disable
    {
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
        private global::Aribilgi.BankApp.Web.TagHelpers.GetBankAccountCount __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <table class=""mt-3 table table-hover table-bordered"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Account Count</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
              
                foreach (ApplicationUser item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
                       Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getAccountCount", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a4c32fbda4776a65516904b6892942a31d335634424", async() => {
            }
            );
            __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount = CreateTagHelper<global::Aribilgi.BankApp.Web.TagHelpers.GetBankAccountCount>();
            __tagHelperExecutionContext.Add(__Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount);
#nullable restore
#line 24 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
__Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount.ApplicationUserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("application-user-id", __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount.ApplicationUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 866, 2);
            WriteAttributeValue("", 836, "/Account/Index?UserId=", 836, 22, true);
#nullable restore
#line 27 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 858, item.Id, 858, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-primary\">Create New Account</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\murat\Desktop\CORE\Aribilgi.BankApp\Aribilgi.BankApp.Web\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
