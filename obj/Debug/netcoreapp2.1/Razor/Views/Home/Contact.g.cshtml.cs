#pragma checksum "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff87120bd29c9f48f85288eb2c1725d35369f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\_ViewImports.cshtml"
using CaixaEletronicoCode;

#line default
#line hidden
#line 2 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\_ViewImports.cshtml"
using CaixaEletronicoCode.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff87120bd29c9f48f85288eb2c1725d35369f81", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909a279ecee9a98628d2339ec2dd5100dd5f1205", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 24, true);
            WriteLiteral("</h3>\r\n\r\n<address>\r\n    ");
            EndContext();
            BeginContext(121, 10, false);
#line 8 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(131, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(142, 12, false);
#line 9 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
Write(Model.Street);

#line default
#line hidden
            EndContext();
            BeginContext(154, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(165, 10, false);
#line 10 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(175, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(178, 11, false);
#line 10 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
            Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(191, 16, false);
#line 10 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Contact.cshtml"
                         Write(Model.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(207, 287, true);
            WriteLiteral(@"<br>
    <abbr title=""Phone"">P:</abbr> 425.555.0100
</address>

<address>
    <strong>Suporte:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
