#pragma checksum "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432aeb6b4df4cf33629fd03fcf5b58fafd96e33b"
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
#line 1 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\_ViewImports.cshtml"
using SystemCashMachineWeb;

#line default
#line hidden
#line 2 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\_ViewImports.cshtml"
using SystemCashMachineWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432aeb6b4df4cf33629fd03fcf5b58fafd96e33b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da459188893392e679850a0fe549280970dfa64", @"/Views/_ViewImports.cshtml")]
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
#line 1 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 1574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "294fde3b61a241f3b2c610ed9ea3db2b", async() => {
                BeginContext(72, 1561, true);
                WriteLiteral(@"
    <style>
        table {
            border-collapse: inherit;
            border: 2px solid black;
            border-radius: 7px;
            padding: 2px;
            background-color: rgb(238, 232, 232);
        }

        th {
            background-color: black;
            padding: 3px;
            color: rgb(255, 255, 255);
            width: 150px;
            text-align: center;
        }

        button {
            box-shadow: 0 2px 3px 0 rgba(0,0,0,0.2), 0 2px 3px 0 rgba(0,0,0,0.19);
            border: none;
            padding: 3px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 4px 2px;
            cursor: pointer;
            background-color: #ebdfdf;
            color: black;
            border-radius: 3px;
            border: 0.5px solid #858585;
        }

        .transation {
            color: black;
            background-color: white;
");
                WriteLiteral(@"            border: 2px solid black;
            border-radius: 13px;
            padding: 6px;
        }

        input {
            border-radius: 5px;
            border-color: black;
        }

        .deposit, .withdraw {
            background-color: rgb(250, 228, 199);
            padding: 13px;
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
            BeginContext(1640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1642, 4073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0956d060c64ecbbe35c7d8fdc28547", async() => {
                BeginContext(1648, 190, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <h2>Caixa Eletrônico</h2>\r\n    </div>\r\n    <div class=\"deposit\">\r\n        <div>\r\n            <br>\r\n            <h4>Deposito</h4>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(1838, 261, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9ee14c70f140d9b8b72b6d97489bc9", async() => {
                    BeginContext(1873, 219, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorDeposita\">Deposite o valor:</label>\r\n                <input type=\"text\" id=\"ValorDeposita\" name=\"valorDep\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
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
                BeginContext(2099, 133, true);
                WriteLiteral("\r\n        <button id=\"Depositar\">Depositar</button>\r\n        <div>\r\n            <br>\r\n            <p>Saldo total: <b id=\"saldoTotal\">");
                EndContext();
                BeginContext(2233, 16, false);
#line 82 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                          Write(Model.SaldoFinal);

#line default
#line hidden
                EndContext();
                BeginContext(2249, 151, true);
                WriteLiteral("</b></p>\r\n        </div>\r\n    </div>\r\n    <div class=\"withdraw\">\r\n        <div>\r\n            <br>\r\n            <h4>Saque</h4>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(2400, 257, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e7d52ba20449108199c3c061bfec7b", async() => {
                    BeginContext(2435, 215, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorSaque\">Valor a ser sacado:</label>\r\n                <input type=\"text\" id=\"ValorSaque\" name=\"valorSaq\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
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
                BeginContext(2657, 379, true);
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
                    <td name=""nota100"" id=""nota100"" style=""text-align:center"">");
                EndContext();
                BeginContext(3037, 10, false);
#line 106 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                         Write(Model.N100);

#line default
#line hidden
                EndContext();
                BeginContext(3047, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 50</td>\r\n                    <td name=\"nota50\" id=\"nota50\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3217, 9, false);
#line 110 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N50);

#line default
#line hidden
                EndContext();
                BeginContext(3226, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 20</td>\r\n                    <td name=\"nota20\" id=\"nota20\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3396, 9, false);
#line 114 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N20);

#line default
#line hidden
                EndContext();
                BeginContext(3405, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 10</td>\r\n                    <td name=\"nota10\" id=\"nota10\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3575, 9, false);
#line 118 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N10);

#line default
#line hidden
                EndContext();
                BeginContext(3584, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 5</td>\r\n                    <td name=\"nota5\" id=\"nota5\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3751, 8, false);
#line 122 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N5);

#line default
#line hidden
                EndContext();
                BeginContext(3759, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 2</td>\r\n                    <td name=\"nota2\" id=\"nota2\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3926, 8, false);
#line 126 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N2);

#line default
#line hidden
                EndContext();
                BeginContext(3934, 164, true);
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n            <div>\r\n                <br>\r\n                <b class=\"transation\" id=\"valid\">\r\n                    ");
                EndContext();
                BeginContext(4099, 11, false);
#line 132 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
               Write(Model.Valid);

#line default
#line hidden
                EndContext();
                BeginContext(4110, 284, true);
                WriteLiteral(@"
                </b>
                <!--Somente sinalizar se saque for inválido-->
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function(){
            $(""#Sacar"").click(function(){
                $.ajax({
                    url: '");
                EndContext();
                BeginContext(4395, 26, false);
#line 142 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("CalculaSaque"));

#line default
#line hidden
                EndContext();
                BeginContext(4421, 868, true);
                WriteLiteral(@"',
                    type: ""POST"",
                    dataType: ""json"",
                    data: {valorSaq: $(""#ValorSaque"").val()},
                    success: function(r){
                        console.log(""Botão funcionou"");
                        $(""#nota100"").html(r.n100);
                        $(""#nota50"").html(r.n50);
                        $(""#nota20"").html(r.n20);
                        $(""#nota10"").html(r.n10);
                        $(""#nota5"").html(r.n5);
                        $(""#nota2"").html(r.n2);
                        $(""#saldoTotal"").html(r.saldoFinal);
                        $(""#valid"").html(r.valid);
                    }
                })
            })
        })
        $(document).ready(function(){
            $(""#Depositar"").click(function(){
                $.ajax({
                    url: '");
                EndContext();
                BeginContext(5290, 27, false);
#line 163 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("DepositaValor"));

#line default
#line hidden
                EndContext();
                BeginContext(5317, 391, true);
                WriteLiteral(@"',
                    type: ""POST"",
                    dataType: ""json"",
                    data: {valorDep: $(""#ValorDeposita"").val()},
                    success: function(dep){
                        console.log(""Depositando"");
                        $(""#saldoTotal"").html(dep.saldoFinal)
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
