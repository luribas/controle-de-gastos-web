#pragma checksum "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3de6f67f425216d30c3c486041b3fbdcda7d16a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Dashboard), @"mvc.1.0.view", @"/Views/Usuario/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Dashboard.cshtml", typeof(AspNetCore.Views_Usuario_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3de6f67f425216d30c3c486041b3fbdcda7d16a", @"/Views/Usuario/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lancamento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Relatorio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning btn-round btn-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edicao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard - Controle de Gastos";

#line default
#line hidden
            BeginContext(85, 48, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"row\">\r\n");
            EndContext();
            BeginContext(184, 339, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">

                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            EndContext();
            BeginContext(523, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7317a2a4ef84832bd40951ccfca1a8c", async() => {
                BeginContext(572, 117, true);
                WriteLiteral("\r\n                                    <i class=\"nc-icon nc-paper text-warning\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(693, 784, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Gerar relatório por período</p>
                                <p class=""card-title""><small><small>Clique no ícone ao lado</small></small><p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar""></i> Não se perca nas suas finanças!
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(1512, 691, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-spaceship text-danger""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Lançamentos</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(2204, 26, false);
#line 50 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoLancamentos);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 425, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(2691, 695, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-money-coins text-success""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Recebimentos</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(3387, 27, false);
#line 77 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoRecebimentos);

#line default
#line hidden
            EndContext();
            BeginContext(3414, 425, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(3871, 692, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-favourite-28 text-primary""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Poupança</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(4564, 24, false);
#line 104 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoDepositos);

#line default
#line hidden
            EndContext();
            BeginContext(4588, 764, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-header"">
                    <h5 class=""card-title"" style=""text-transform: uppercase;""><small>Últimos lançamentos <b>cadastrados</b></small></h5>
                </div>
");
            EndContext();
#line 128 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                 if (ViewBag.Lancamentos.Count == 0)
                {

#line default
#line hidden
            BeginContext(5425, 241, true);
            WriteLiteral("                    <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ LANÇAMENTOS CADASTRADOS</b></p>\r\n                    <p class=\"text-info\" style=\"text-align:center;\">No menu ao lado, clique em LANÇAMENTOS para cadastrar!</p>\r\n");
            EndContext();
#line 132 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5726, 609, true);
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead class=""text-primary"">
                            <th>Valor</th>
                            <th>Lançamento</th>
                            <th>Descrição</th>
                            <th>Categoria</th>
                            <th>Qtd. parcela</th>
                            <th>Cartão</th>
                            <th>Cadastro</th>
                            <th>Editar</th>
                            </thead>
                            <tbody>
");
            EndContext();
#line 148 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                 foreach (Lancamento item in ViewBag.Lancamentos)
                                {

#line default
#line hidden
            BeginContext(6453, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(6540, 10, false);
#line 151 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(6550, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6602, 42, false);
#line 152 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.DataLancamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6644, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6696, 14, false);
#line 153 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(6710, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6762, 17, false);
#line 154 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(ViewBag.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(6779, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6831, 13, false);
#line 155 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Parcelas);

#line default
#line hidden
            EndContext();
            BeginContext(6844, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6896, 14, false);
#line 156 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(ViewBag.Cartao);

#line default
#line hidden
            EndContext();
            BeginContext(6910, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6962, 40, false);
#line 157 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7002, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(7053, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f14122696b864965958066ba61778503", async() => {
                BeginContext(7178, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idLancamento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 158 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
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
            BeginContext(7208, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 160 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                }

#line default
#line hidden
            BeginContext(7293, 100, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            EndContext();
#line 164 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(7412, 309, true);
            WriteLiteral(@"            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-header"">
                    <h5 class=""card-title"" style=""text-transform: uppercase;""><small>Últimos recebimentos <b>cadastrados</b></small></h5>
                </div>
");
            EndContext();
#line 173 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                 if (ViewBag.Recebimentos.Count == 0)
                {

#line default
#line hidden
            BeginContext(7795, 243, true);
            WriteLiteral("                    <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ RECEBIMENTOS CADASTRADOS</b></p>\r\n                    <p class=\"text-info\" style=\"text-align:center;\">No menu ao lado, clique em RECEBIMENTOS para cadastrar!</p>\r\n");
            EndContext();
#line 177 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(8098, 531, true);
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead class=""text-primary"">
                            <th>Fornecedor</th>
                            <th>Descricao</th>
                            <th>Valor</th>
                            <th>Data de Recebimento</th>
                            <th>Data de cadastro</th>
                            <th>Editar</th>
                            </thead>
                            <tbody>
");
            EndContext();
#line 191 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                 foreach (Recebimento item in ViewBag.Recebimentos)
                                {

#line default
#line hidden
            BeginContext(8749, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(8836, 15, false);
#line 194 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Fornecedor);

#line default
#line hidden
            EndContext();
            BeginContext(8851, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(8903, 14, false);
#line 195 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(8917, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(8969, 10, false);
#line 196 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(8979, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(9031, 43, false);
#line 197 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.DataRecebimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(9074, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(9126, 40, false);
#line 198 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                       Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(9166, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(9217, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db6f92ef7e04887890fc034e286c6c3", async() => {
                BeginContext(9344, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idRecebimento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 199 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                                                                                                          WriteLiteral(item.IdRecebimento);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idRecebimento"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idRecebimento", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idRecebimento"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9374, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 201 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                }

#line default
#line hidden
            BeginContext(9459, 100, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            EndContext();
#line 205 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(9578, 50, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(9659, 481, true);
            WriteLiteral(@"    <div class=""col-md-6"">
        <div class=""card"" style=""height: 42%;"">
            <div class=""card-body"" style=""overflow: scroll; width: 98%; margin-left: 1%;"">
                <div class=""card-header"">
                    <h5 class=""card-title"" style=""text-transform: uppercase;""><small>Últimas notícias sobre <b>negócios</b> e <b>finanças</b></small></h5>
                    <p class=""text-danger"">Fique por dentro de todas as notícias...</p>
                </div>
");
            EndContext();
#line 218 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                 if (ViewBag.Artigos.Count == 0)
                {

#line default
#line hidden
            BeginContext(10209, 122, true);
            WriteLiteral("                    <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ NENHUMA NOTÍCIO PARA SER EXIBIDA</b></p>\r\n");
            EndContext();
#line 221 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                }
                else
                {

                    

#line default
#line hidden
#line 225 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                     foreach (var item in ViewBag.Artigos)
                    {

#line default
#line hidden
            BeginContext(10476, 173, true);
            WriteLiteral("                        <hr>\r\n                        <h6 class=\"card-title\" style=\"text-transform: uppercase;\">\r\n                            <i class=\"fa fa-bookmark\"></i> ");
            EndContext();
            BeginContext(10650, 10, false);
#line 229 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(10660, 156, true);
            WriteLiteral("\r\n                            <br />\r\n                        </h6>\r\n                        <p class=\"text-primary\"><i class=\"fa fa-pencil-square\"></i><b> ");
            EndContext();
            BeginContext(10817, 11, false);
#line 232 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                                                  Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(10828, 34, true);
            WriteLiteral(" - <i class=\"fa fa-calendar\"></i> ");
            EndContext();
            BeginContext(10863, 16, false);
#line 232 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                                                                                                Write(item.PublishedAt);

#line default
#line hidden
            EndContext();
            BeginContext(10879, 10, true);
            WriteLiteral("</b></p>\r\n");
            EndContext();
            BeginContext(10915, 205, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n                                <img style=\"overflow: hidden; width:150px; height: 150px; position: relative;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 11120, "\"", 11142, 1);
#line 236 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
WriteAttributeValue("", 11126, item.UrlToImage, 11126, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11143, 149, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"col-md-9\">\r\n                                <div class=\"text-black\">");
            EndContext();
            BeginContext(11293, 16, false);
#line 239 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(11309, 28, true);
            WriteLiteral(" ... <a class=\"text-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 11337, "\"", 11353, 1);
#line 239 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
WriteAttributeValue("", 11344, item.Url, 11344, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11354, 120, true);
            WriteLiteral(" target=\"_blank\"><b>CONTINUAR LENDO</b></a> </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 242 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                    }

#line default
#line hidden
#line 242 "C:\Users\LuizaM\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(11516, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lancamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
