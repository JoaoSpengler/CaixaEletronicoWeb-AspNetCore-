#pragma checksum "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\RegisterUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f35de1b0eb18c45cd49bfded8cb5c227d4c441e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterUser), @"mvc.1.0.view", @"/Views/Home/RegisterUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegisterUser.cshtml", typeof(AspNetCore.Views_Home_RegisterUser))]
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
#line 1 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\_ViewImports.cshtml"
using SystemCashMachineWeb;

#line default
#line hidden
#line 2 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\_ViewImports.cshtml"
using SystemCashMachineWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35de1b0eb18c45cd49bfded8cb5c227d4c441e0", @"/Views/Home/RegisterUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da459188893392e679850a0fe549280970dfa64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\RegisterUser.cshtml"
  
    ViewData["Title"] = "Register Page";

#line default
#line hidden
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(51, 674, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e504ffe0e48289980ba4f562caf70", async() => {
                BeginContext(57, 661, true);
                WriteLiteral(@"
    <style>
        input {
            color: black;
            background-color: white;
            border: 2px solid rgb(188, 190, 192);
            border-radius: 7px;
            padding: 3px;
            width: 250px;
        }

        .account {
            box-shadow: 0 2px 3px 0 rgba(0,0,0,0.2), 0 2px 3px 0 rgba(0,0,0,0.19);
            color: black;
            background-color: darkgray;
            border: 2px solid rgb(131, 131, 131);
            border-radius: 7px;
            padding-left: 13px;
            padding-right: 13px;
            padding-top: 3px;
            padding-bottom: 3px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(725, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(727, 1062, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f367142641d48fdb3ba3ab4dbed400e", async() => {
                BeginContext(733, 61, true);
                WriteLiteral("\r\n    <div style=\"width: 100%;\" align=\"center\">\r\n        <h3>");
                EndContext();
                BeginContext(795, 19, false);
#line 31 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\RegisterUser.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(814, 71, true);
                WriteLiteral("</h3>\r\n        <h4>Cash Machine Web System</h4>\r\n        <br>\r\n        ");
                EndContext();
                BeginContext(885, 770, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13bf328f3064ae7a11b7af833d3806d", async() => {
                    BeginContext(927, 609, true);
                    WriteLiteral(@"
            <label>Email</label><br>
            <input type=""text"" id=""LoginUser"" name=""loginUser"" placeholder=""Insert a valid email"" /><br><br>
            <label>User Name</label><br>
            <input type=""text"" id=""UserNameId"" name=""userNameId"" placeholder=""Insert your name"" /><br><br>
            <label>Password</label><br>
            <input type=""password"" id=""PasswordId"" name=""passwordId"" placeholder=""Insert a password"" /><br><br>
            <input type=""password"" id=""PasswordConfirm"" name=""passwordConfirm"" placeholder=""Confirm your password"">


            <p style=""color:red;"">");
                    EndContext();
                    BeginContext(1537, 17, false);
#line 44 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\RegisterUser.cshtml"
                             Write(ViewData["Error"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1554, 94, true);
                    WriteLiteral("</p>\r\n            <input class=\"account\" id=\"btnSub\" type=\"submit\" value=\"Register\">\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1655, 127, true);
                WriteLiteral("\r\n        <br>\r\n        <br><br>\r\n        <p>\r\n            Have an account? <a href=\"/\">Sign in</a>\r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
