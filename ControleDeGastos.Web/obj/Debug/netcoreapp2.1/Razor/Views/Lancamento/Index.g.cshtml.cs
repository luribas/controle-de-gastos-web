#pragma checksum "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fee6457d01f22c2891f536d2cb583ea88eb5d6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lancamento_Index), @"mvc.1.0.view", @"/Views/Lancamento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lancamento/Index.cshtml", typeof(AspNetCore.Views_Lancamento_Index))]
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
#line 1 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web;

#line default
#line hidden
#line 2 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Domain;

#line default
#line hidden
#line 3 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Service;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fee6457d01f22c2891f536d2cb583ea88eb5d6c0", @"/Views/Lancamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Lancamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blockquote blockquote-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor: pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edicao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
  
    ViewData["Title"] = "CdG - Meus lançamentos";

#line default
#line hidden
            BeginContext(60, 491, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 100%;"">
                <div class=""card-header"">
                    <h5 style=""text-align: center;""><small>Estes são os lançamentos que você cadastrou. </br> Você pode adicionar um novo clicando no botão ao lado.</small></h5>
                    <div class=""row"" style=""margin-left: 5px; margin-top: -80px; text-transform: uppercase;"">
                        ");
            EndContext();
            BeginContext(551, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5b26254d498483fa594e70ccf511aef", async() => {
                BeginContext(638, 39, true);
                WriteLiteral("<small><b>+ Novo lancamento</b></small>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(681, 97, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 18 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                     if (ViewBag.Lancamentos.Count == 0)
                    {

#line default
#line hidden
            BeginContext(859, 117, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ LANÇAMENTOS CADASTRADOS</b></p>\r\n");
            EndContext();
#line 21 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1048, 640, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                    <th>Valor</th>
                                    <th>Lançado em</th>
                                    <th>Descrição</th>
                                    <th>Categoria</th>
                                    <th>Qtd. parcela</th>
                                    <th>Cartão</th>
                                    <th>Cadastro</th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 36 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                     foreach (Lancamento item in ViewBag.Lancamentos)
                                    {

#line default
#line hidden
            BeginContext(1814, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(1909, 10, false);
#line 39 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1975, 42, false);
#line 40 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.DataLancamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2073, 14, false);
#line 41 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2087, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2143, 14, false);
#line 42 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2213, 13, false);
#line 43 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.Parcelas);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2282, 11, false);
#line 44 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.Cartao);

#line default
#line hidden
            EndContext();
            BeginContext(2293, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2349, 40, false);
#line 45 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2444, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05791fb56ca7471d8c2575b9b176136c", async() => {
                BeginContext(2535, 34, true);
                WriteLiteral("<big><big><big>✎</big></big></big>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idLancamento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                                                                                           WriteLiteral(item.IdLancamento);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLancamento"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLancamento", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLancamento"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2573, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2666, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 52 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Lancamento\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2801, 84, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
