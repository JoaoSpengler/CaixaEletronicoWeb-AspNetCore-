#pragma checksum "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be1d3ab44fa72bc591f506d6ae26c1c8855ec44"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be1d3ab44fa72bc591f506d6ae26c1c8855ec44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da459188893392e679850a0fe549280970dfa64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValoresNotas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("LogOut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSaque"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be66b583541544159771984dcc12fd9a", async() => {
                BeginContext(72, 2102, true);
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

        .logout {
            box-shadow: 0 2px 3px 0 rgba(0,0,0,0.2), 0 2px 3px 0 rgba(0,0,0,0.19);
            border: 2px solid rgb(131, 131, 131);
            border-radius: 7px;
            padding: 2px 7px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 4px 2px;
            cursor: pointer;
            background-color: rgb(51, 51, 51);
            color: white;
            border: 0.5px solid black;
        }

        .deposit, .withdraw {
            background-color: rgb(250, 228, 199);
            padding: 13px;
        }
    </style>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""");
                WriteLiteral("\n            crossorigin=\"anonymous\">\r\n    </script>\r\n");
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
            BeginContext(2181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2183, 4258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d07a4a4cee4e86a8c91671b2f45894", async() => {
                BeginContext(2189, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2195, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0defff935f42df9e5b598d17f98171", async() => {
                    BeginContext(2230, 54, true);
                    WriteLiteral("\r\n        <button class=\"logout\">LogOut</button>\r\n    ");
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
                BeginContext(2291, 190, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <h2>Caixa Eletrônico</h2>\r\n    </div>\r\n    <div class=\"deposit\">\r\n        <div>\r\n            <br>\r\n            <h4>Deposito</h4>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(2481, 261, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b1b8dd83c045aea151baf22684511a", async() => {
                    BeginContext(2516, 219, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorDeposita\">Deposite o valor:</label>\r\n                <input type=\"text\" id=\"ValorDeposita\" name=\"valorDep\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2742, 133, true);
                WriteLiteral("\r\n        <button id=\"Depositar\">Depositar</button>\r\n        <div>\r\n            <br>\r\n            <p>Saldo total: <b id=\"saldoTotal\">");
                EndContext();
                BeginContext(2876, 16, false);
#line 101 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                          Write(Model.SaldoFinal);

#line default
#line hidden
                EndContext();
                BeginContext(2892, 151, true);
                WriteLiteral("</b></p>\r\n        </div>\r\n    </div>\r\n    <div class=\"withdraw\">\r\n        <div>\r\n            <br>\r\n            <h4>Saque</h4>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(3043, 272, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86e57dd506df4c619e3afd46fe38f0b9", async() => {
                    BeginContext(3093, 215, true);
                    WriteLiteral("\r\n            <div>\r\n                <label for=\"ValorSaque\">Valor a ser sacado:</label>\r\n                <input type=\"text\" id=\"ValorSaque\" name=\"valorSaq\" placeholder=\"Insira aqui\" />\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3315, 379, true);
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
                BeginContext(3695, 10, false);
#line 125 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                         Write(Model.N100);

#line default
#line hidden
                EndContext();
                BeginContext(3705, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 50</td>\r\n                    <td name=\"nota50\" id=\"nota50\" style=\"text-align:center\">");
                EndContext();
                BeginContext(3875, 9, false);
#line 129 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N50);

#line default
#line hidden
                EndContext();
                BeginContext(3884, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 20</td>\r\n                    <td name=\"nota20\" id=\"nota20\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4054, 9, false);
#line 133 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N20);

#line default
#line hidden
                EndContext();
                BeginContext(4063, 169, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 10</td>\r\n                    <td name=\"nota10\" id=\"nota10\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4233, 9, false);
#line 137 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                       Write(Model.N10);

#line default
#line hidden
                EndContext();
                BeginContext(4242, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 5</td>\r\n                    <td name=\"nota5\" id=\"nota5\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4409, 8, false);
#line 141 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N5);

#line default
#line hidden
                EndContext();
                BeginContext(4417, 166, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Nota de 2</td>\r\n                    <td name=\"nota2\" id=\"nota2\" style=\"text-align:center\">");
                EndContext();
                BeginContext(4584, 8, false);
#line 145 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                                                                     Write(Model.N2);

#line default
#line hidden
                EndContext();
                BeginContext(4592, 164, true);
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n            <div>\r\n                <br>\r\n                <b class=\"transation\" id=\"valid\">\r\n                    ");
                EndContext();
                BeginContext(4757, 11, false);
#line 151 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
               Write(Model.Valid);

#line default
#line hidden
                EndContext();
                BeginContext(4768, 284, true);
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
                BeginContext(5053, 26, false);
#line 161 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("CalculaSaque"));

#line default
#line hidden
                EndContext();
                BeginContext(5079, 819, true);
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
                BeginContext(5899, 27, false);
#line 180 "C:\Users\joao.spengler\source\repos\SystemCashMachineWeb\SystemCashMachineWeb\Views\Home\Index.cshtml"
                     Write(Url.Action("DepositaValor"));

#line default
#line hidden
                EndContext();
                BeginContext(5926, 508, true);
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
            $(""form"").on(""submit"", function (event) {
                event.preventDefault();
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
