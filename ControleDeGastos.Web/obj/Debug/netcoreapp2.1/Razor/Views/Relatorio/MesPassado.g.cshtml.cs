#pragma checksum "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd625350c25a27b66a647742aad7e1e58f817489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_MesPassado), @"mvc.1.0.view", @"/Views/Relatorio/MesPassado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorio/MesPassado.cshtml", typeof(AspNetCore.Views_Relatorio_MesPassado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd625350c25a27b66a647742aad7e1e58f817489", @"/Views/Relatorio/MesPassado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_MesPassado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
  
    ViewData["Title"] = "Relatório do Mês Passado";

#line default
#line hidden
            BeginContext(60, 285, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 80%;"">
                <div class=""card-body"">
                    <div class=""card-header"">
                        <h5 class=""card-title"">Relatório do mês ");
            EndContext();
            BeginContext(346, 32, false);
#line 11 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                                           Write(DateTime.Now.ToString("MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(378, 35, true);
            WriteLiteral("</h5>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(472, 76, true);
            WriteLiteral("                    <div class=\"row\" style=\"width: 97%; margin-left: 2%;\">\r\n");
            EndContext();
#line 15 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                         if (ViewBag.Lancamentos.Count == 0)
                        {

#line default
#line hidden
            BeginContext(637, 131, true);
            WriteLiteral("                            <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ LANÇAMENTOS CADASTRADOS NESTE MÊS</b></p>\r\n");
            EndContext();
#line 18 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(852, 860, true);
            WriteLiteral(@"                            <div class=""card-header"">
                                <h5 class=""card-title text-warning"">LANÇAMENTOS</h5>
                            </div>
                            <div class=""table-responsive"" style=""overflow: hidden;"">
                                <table class=""table"">
                                    <thead class=""text-dark"">
                                    <th>Valor</th>
                                    <th>Lançamento</th>
                                    <th>Descrição</th>
                                    <th>Categoria</th>
                                    <th>Qtd. parcela</th>
                                    <th>Cartão</th>
                                    <th>Cadastro</th>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 36 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                         foreach (Lancamento item in ViewBag.Lancamentos)
                                        {

#line default
#line hidden
            BeginContext(1846, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(1949, 10, false);
#line 39 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1959, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2019, 42, false);
#line 40 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataLancamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2121, 14, false);
#line 41 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2195, 17, false);
#line 42 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(ViewBag.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(2212, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2272, 13, false);
#line 43 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Parcelas);

#line default
#line hidden
            EndContext();
            BeginContext(2285, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2345, 14, false);
#line 44 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(ViewBag.Cartao);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2419, 40, false);
#line 45 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2459, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 47 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2560, 339, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""stats text-warning"" style=""margin-left: 45%; margin-top: -3%;"">
                                <hr>
                                <i class=""nc-icon nc-spaceship""></i> R$ ");
            EndContext();
            BeginContext(2900, 26, false);
#line 53 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                                                   Write(ViewBag.CalculoLancamentos);

#line default
#line hidden
            EndContext();
            BeginContext(2926, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 55 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }

#line default
#line hidden
            BeginContext(2991, 34, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n");
            EndContext();
            BeginContext(3085, 76, true);
            WriteLiteral("                    <div class=\"row\" style=\"width: 97%; margin-left: 2%;\">\r\n");
            EndContext();
#line 62 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                         if (ViewBag.Recebimentos.Count == 0)
                        {

#line default
#line hidden
            BeginContext(3251, 132, true);
            WriteLiteral("                            <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ RECEBIMENTOS CADASTRADOS NESTE MÊS</b></p>\r\n");
            EndContext();
#line 65 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3467, 767, true);
            WriteLiteral(@"                            <div class=""card-header"">
                                <h5 class=""card-title text-success"">RECEBIMENTOS</h5>
                            </div>
                            <div class=""table-responsive"" style=""overflow: hidden;"">
                                <table class=""table"">
                                    <thead class=""text-dark"">
                                    <th>Fornecedor</th>
                                    <th>Descricao</th>
                                    <th>Valor</th>
                                    <th>Data de Recebimento</th>
                                    <th>Data de cadastro</th>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 81 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                         foreach (Recebimento item in ViewBag.Recebimentos)
                                        {

#line default
#line hidden
            BeginContext(4370, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(4473, 15, false);
#line 84 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Fornecedor);

#line default
#line hidden
            EndContext();
            BeginContext(4488, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4548, 14, false);
#line 85 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(4562, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4622, 10, false);
#line 86 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(4632, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4692, 43, false);
#line 87 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataRecebimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4735, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4795, 40, false);
#line 88 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4835, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 90 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4936, 341, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""stats text-success"" style=""margin-left: 45%; margin-top: -3%;"">
                                <hr>
                                <i class=""nc-icon nc-money-coins""></i> R$ ");
            EndContext();
            BeginContext(5278, 27, false);
#line 96 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                                                     Write(ViewBag.CalculoRecebimentos);

#line default
#line hidden
            EndContext();
            BeginContext(5305, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 98 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }

#line default
#line hidden
            BeginContext(5370, 30, true);
            WriteLiteral("                    </div>\r\n\r\n");
            EndContext();
            BeginContext(5456, 76, true);
            WriteLiteral("                    <div class=\"row\" style=\"width: 97%; margin-left: 2%;\">\r\n");
            EndContext();
#line 103 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                         if (ViewBag.Depositos.Count == 0)
                        {

#line default
#line hidden
            BeginContext(5619, 132, true);
            WriteLiteral("                            <p class=\"text-danger\" style=\"text-align:center;\"><b>VOCÊ NÃO DEPOSITOU NENHUM VALOR NESTE MÊS</b></p>\r\n");
            EndContext();
#line 106 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5835, 699, true);
            WriteLiteral(@"                            <div class=""card-header"">
                                <h5 class=""card-title text-primary"">POUPANÇA</h5>
                            </div>
                            <div class=""table-responsive"" style=""overflow: hidden;"">
                                <table class=""table"">
                                    <thead class=""text-dark"">
                                    <th>Banco</th>
                                    <th>Valor</th>
                                    <th>Data do Depósito</th>
                                    <th>Data de Cadastro</th>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 121 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                         foreach (Poupanca item in ViewBag.Depositos)
                                        {

#line default
#line hidden
            BeginContext(6664, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(6767, 21, false);
#line 124 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(ViewBag.BancoPoupanca);

#line default
#line hidden
            EndContext();
            BeginContext(6788, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(6848, 10, false);
#line 125 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(6858, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(6918, 40, false);
#line 126 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataDeposito.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6958, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(7018, 40, false);
#line 127 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                               Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7058, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 129 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7159, 338, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""stats text-success"" style=""margin-left: 45%;  margin-top: -3%;"">
                                <hr>
                                <i class=""nc-icon nc-diamond""></i> R$ ");
            EndContext();
            BeginContext(7498, 24, false);
#line 135 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                                                                 Write(ViewBag.CalculoDepositos);

#line default
#line hidden
            EndContext();
            BeginContext(7522, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 137 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Relatorio\MesPassado.cshtml"
                        }

#line default
#line hidden
            BeginContext(7587, 108, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
