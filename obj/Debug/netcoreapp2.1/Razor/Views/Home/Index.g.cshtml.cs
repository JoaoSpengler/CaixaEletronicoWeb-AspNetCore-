#pragma checksum "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ebd60fb672a11c2cd194b983acebef0655aecf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebd60fb672a11c2cd194b983acebef0655aecf6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909a279ecee9a98628d2339ec2dd5100dd5f1205", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValoresNotas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 1027, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b00f8b1db3644eaa529921bfac2804c", async() => {
                BeginContext(72, 1014, true);
                WriteLiteral(@"
    <style>
        table {
            border-collapse: inherit;
            border: 2px solid black;
            padding: 2px;
        }
        th {
            background-color: black;
            color: white;
            width:150px;
            text-align:center;
        }
        button{
            box-shadow: 0 2px 3px 0 rgba(0,0,0,0.2), 0 2px 3px 0 rgba(0,0,0,0.19);
            border: none;
            padding: 3px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 4px 2px;
            cursor: pointer;
            background-color: #e7e7e7;
            color: black;
            border-radius: 3px;
            border: 0.5px solid #8c8c8c;
        }
    </style>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous"">
    </script>    
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
            BeginContext(1093, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1095, 3045, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380cdfbe02ca439b9246848b73a347f8", async() => {
                BeginContext(1101, 143, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <h2>Caixa Eletrônico</h2>\r\n    </div>\r\n    <div>\r\n        <br>\r\n        <h4>Deposito</h4>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(1244, 291, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbaa612495dd458facef4d52b3a18758", async() => {
                    BeginContext(1279, 249, true);
                    WriteLiteral("\r\n        <div>\r\n            <label for=\"ValorDeposita\">Deposite o valor:</label>\r\n            <input type=\"text\" name=\"ValorDeposita\" value=\"\" placeholder=\"Insira aqui\" />\r\n            <button id=\"Depositar\">Depositar</button>\r\n        </div>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1535, 157, true);
                WriteLiteral("\r\n    <div>\r\n        <br>\r\n        <p>Saldo total: <b id=\"SaldoTotal\"></b></p>\r\n    </div>\r\n    <div>\r\n        <br>\r\n        <h4>Saque</h4>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(1692, 253, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470596a340584ec39505ad97eccd318b", async() => {
                    BeginContext(1727, 211, true);
                    WriteLiteral("\r\n        <div>\r\n            <label for=\"ValorSaque\">Valor a ser sacado:</label>\r\n            <input type=\"text\" name=\"ValorSaque\" id=\"ValorSaque\" placeholder=\"Insira aqui\" />\r\n            \r\n        </div>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1945, 320, true);
                WriteLiteral(@"
    <button id=""Sacar"">Sacar</button>
    <div>
        <h3>Notas</h3>
        <table>
            <tr>
                <th>Valor Notas</th>
                <th>Quantidade</th>
            </tr>
            <tr>
                <td>Nota de 100</td>
                <td id=""nota100"" style=""text-align:center"">");
                EndContext();
                BeginContext(2266, 10, false);
#line 81 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                      Write(Model.N100);

#line default
#line hidden
                EndContext();
                BeginContext(2276, 139, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Nota de 50</td>\r\n                <td id=\"nota50\" style=\"text-align:center\">");
                EndContext();
                BeginContext(2416, 9, false);
#line 85 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                     Write(Model.N50);

#line default
#line hidden
                EndContext();
                BeginContext(2425, 139, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Nota de 20</td>\r\n                <td id=\"nota20\" style=\"text-align:center\">");
                EndContext();
                BeginContext(2565, 9, false);
#line 89 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                     Write(Model.N20);

#line default
#line hidden
                EndContext();
                BeginContext(2574, 139, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Nota de 10</td>\r\n                <td id=\"nota10\" style=\"text-align:center\">");
                EndContext();
                BeginContext(2714, 9, false);
#line 93 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                     Write(Model.N10);

#line default
#line hidden
                EndContext();
                BeginContext(2723, 137, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Nota de 5</td>\r\n                <td id=\"nota5\" style=\"text-align:center\">");
                EndContext();
                BeginContext(2861, 8, false);
#line 97 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                    Write(Model.N5);

#line default
#line hidden
                EndContext();
                BeginContext(2869, 137, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Nota de 2</td>\r\n                <td id=\"nota2\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3007, 8, false);
#line 101 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                                                    Write(Model.N2);

#line default
#line hidden
                EndContext();
                BeginContext(3015, 92, true);
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <div>\r\n            <br>\r\n            <b>");
                EndContext();
                BeginContext(3108, 41, false);
#line 106 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
          Write(Html.DisplayFor(modelItem => Model.Valid));

#line default
#line hidden
                EndContext();
                BeginContext(3149, 352, true);
                WriteLiteral(@"</b> 
            <!--Somente sinalizar se saque for inválido-->
        </div>
    </div>
    <!--Este ajax tem que ser modificado para a atualização da tabela-->
    <script>
        $(document).ready(function(){
            $(""#Sacar"").click(function(){
                $.ajax({
                    type: ""POST"",
                    url: '");
                EndContext();
                BeginContext(3502, 26, false);
#line 116 "C:\Users\joao.spengler\Desktop\CaixaEletronicoWeb-AspNetCore-\Views\Home\Index.cshtml"
                     Write(Url.Action("CalculaSaque"));

#line default
#line hidden
                EndContext();
                BeginContext(3528, 605, true);
                WriteLiteral(@"',
                    data: { value: $(""#ValorSaque"").val() },
                    contentType: ""application/json"",
                    success: function (r) {
                        console.log(""testando"");
                        $(""#nota100"").html(r.N100);
                        $(""#nota50"").html(r.n50);
                        $(""#nota20"").html(r.n20);
                        $(""#nota10"").html(r.n10);
                        $(""#nota5"").html(r.n5);
                        $(""#nota2"").html(r.n2);
                    }
                })
            })
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValoresNotas> Html { get; private set; }
    }
}
#pragma warning restore 1591
