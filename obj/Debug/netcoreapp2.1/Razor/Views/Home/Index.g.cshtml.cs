#pragma checksum "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a00096d1b8e8b7e6395a842b2d49fc425950160"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a00096d1b8e8b7e6395a842b2d49fc425950160", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da459188893392e679850a0fe549280970dfa64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValoresNotas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("LogOut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formDep"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formWith"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2826, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f3df04021f4efd867d8e828862328e", async() => {
                BeginContext(72, 2813, true);
                WriteLiteral(@"
    <style>
        body{
            width:100%;
        }
        .header {
            color: black;
            text-align: justify;
            text-decoration: overline;
            font-size: x-large;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }

        .deposit, .withdraw {
            background-color: rgb(230 , 230 , 208 );
            padding: 15px;
            border: 3px groove rgb(51, 51, 51);
            border-radius: 5px;
        }

        table {
            border-collapse: inherit;
            border: 2px solid black;
            border-radius: 7px;
            padding: 2px;
            background-color: rgb(240, 240, 240);
        }

        th {
            background-color: black;
            padding: 3px;
            color: rgb(255, 255, 255);
            width: 150px;
            text-align: center;
        }
        .thRight{
            border-top-right-radius:5px;");
                WriteLiteral(@"
        }
        .thLeft {
            border-top-left-radius: 5px;
        }

        button {
            box-shadow: 0 2px 3px 0 rgba(0,0,0,0.2), 0 2px 3px 0 rgba(0,0,0,0.19);
            border: none;
            padding: 3px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            font-weight: bold;
            color: rgb(40, 40, 40);
            margin: 4px 2px;
            cursor: pointer;
            background-color: rgb(150, 150, 150);
            border-radius: 3px;
            border: 0.5px solid #858585;
        }
        .logout {
            border: 2px solid rgb(131, 131, 131);
            padding: 2px 7px;
            background-color: rgb(51, 51, 51);
            color: white;
            border: 0.5px solid black;
        }

        input {
            border-radius: 5px;
            border-color: black;
        }
        .transation {
            color: black;
  ");
                WriteLiteral(@"          background-color: white;
            border: 2px solid black;
            border-radius: 12px;
            padding: 6px;
        }

        .balance {
            font-size: medium;
            font-style: italic;
            font-weight: 500;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif font-weight: 600;
            color: rgb(49, 49, 49);
            border: 3px groove rgb(51, 51, 51);
            padding: 3px;
            background-color:white;
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
            BeginContext(2892, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2894, 4437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032aecee7c2e40e3b1995a3b28e40b7a", async() => {
                BeginContext(2900, 68, true);
                WriteLiteral("\r\n    \r\n    <div class=\"header\">\r\n        WEB CASH MACHINE\r\n        ");
                EndContext();
                BeginContext(2968, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4ed39d15d5433d89811b362ebabd38", async() => {
                    BeginContext(3003, 62, true);
                    WriteLiteral("\r\n            <button class=\"logout\">LogOut</button>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3072, 111, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"deposit\">\r\n        <div>\r\n            <h3>Deposito</h3>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(3183, 274, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df882ea71e344ee083d9befdb5f7d5e5", async() => {
                    BeginContext(3231, 219, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorDeposita\">Deposite o valor:</label>\r\n                <input type=\"text\" id=\"ValorDeposita\" name=\"valorDep\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                BeginContext(3457, 173, true);
                WriteLiteral("\r\n        <button id=\"Depositar\">Depositar</button>\r\n        <div>\r\n            <br>\r\n            <p class=\"balance\">Saldo total: <b id=\"saldoTotal\" style=\"color:darkgreen\">");
                EndContext();
                BeginContext(3631, 16, false);
#line 122 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                                  Write(Model.SaldoFinal);

#line default
#line hidden
                EndContext();
                BeginContext(3647, 133, true);
                WriteLiteral("</b></p>\r\n        </div>\r\n    </div>\r\n    <div class=\"withdraw\">\r\n        <div>\r\n            <h3>Saque</h3>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(3780, 271, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ed95ef60ce74fbbb8f98c1ef4cc6b3b", async() => {
                    BeginContext(3829, 215, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorSaque\">Valor a ser sacado:</label>\r\n                <input type=\"text\" id=\"ValorSaque\" name=\"valorSaq\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                BeginContext(4051, 410, true);
                WriteLiteral(@"
        <button id=""Sacar"">Sacar</button>
        <div>
            <h4>Notas</h4>
            <table>
                <tr>
                    <th class=""thLeft"">Valor Notas</th>
                    <th class=""thRight"">Quantidade</th>
                </tr>
                <tr>
                    <td>Nota de 100</td>
                    <td name=""nota100"" id=""nota100"" style=""text-align:center"">");
                EndContext();
                BeginContext(4462, 10, false);
#line 145 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                         Write(Model.N100);

#line default
#line hidden
                EndContext();
                BeginContext(4472, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 50</td>\r\n                    <td name=\"nota50\" id=\"nota50\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4642, 9, false);
#line 149 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N50);

#line default
#line hidden
                EndContext();
                BeginContext(4651, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 20</td>\r\n                    <td name=\"nota20\" id=\"nota20\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4821, 9, false);
#line 153 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N20);

#line default
#line hidden
                EndContext();
                BeginContext(4830, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 10</td>\r\n                    <td name=\"nota10\" id=\"nota10\" style=\"text-align:center\">");
                EndContext();
                BeginContext(5000, 9, false);
#line 157 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N10);

#line default
#line hidden
                EndContext();
                BeginContext(5009, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 5</td>\r\n                    <td name=\"nota5\" id=\"nota5\" style=\"text-align:center\">");
                EndContext();
                BeginContext(5176, 8, false);
#line 161 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N5);

#line default
#line hidden
                EndContext();
                BeginContext(5184, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 2</td>\r\n                    <td name=\"nota2\" id=\"nota2\" style=\"text-align:center\">");
                EndContext();
                BeginContext(5351, 8, false);
#line 165 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N2);

#line default
#line hidden
                EndContext();
                BeginContext(5359, 164, true);
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n            <div>\r\n                <br>\r\n                <b class=\"transation\" id=\"valid\">\r\n                    ");
                EndContext();
                BeginContext(5524, 11, false);
#line 171 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
               Write(Model.Valid);

#line default
#line hidden
                EndContext();
                BeginContext(5535, 284, true);
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
                BeginContext(5820, 26, false);
#line 181 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("CalculaSaque"));

#line default
#line hidden
                EndContext();
                BeginContext(5846, 819, true);
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
            $(""#Depositar"").click(function () {
                $.ajax({
                    url: '");
                EndContext();
                BeginContext(6666, 27, false);
#line 200 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("DepositaValor"));

#line default
#line hidden
                EndContext();
                BeginContext(6693, 631, true);
                WriteLiteral(@"',
                    type: ""POST"",
                    dataType: ""json"",
                    data: { valorDep: $(""#ValorDeposita"").val() },
                    success: function (dep) {
                        console.log(""Depositando"");
                        $(""#saldoTotal"").html(dep.saldoFinal)
                    }
                })
            });
            $(""#formDep"").on(""submit"", function (event) {
                event.preventDefault();
            });
            $(""#formWith"").on(""submit"", function (event) {
                event.preventDefault();
            });
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
