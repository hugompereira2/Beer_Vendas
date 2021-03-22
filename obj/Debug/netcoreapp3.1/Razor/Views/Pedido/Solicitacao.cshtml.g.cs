#pragma checksum "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4891f9586c3214de3a2b4adedea50eed419d83a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Solicitacao), @"mvc.1.0.view", @"/Views/Pedido/Solicitacao.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\_ViewImports.cshtml"
using Beer_Vendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\_ViewImports.cshtml"
using Beer_Vendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4891f9586c3214de3a2b4adedea50eed419d83a", @"/Views/Pedido/Solicitacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a54942ea83ada8c95363c4b3ffbc0a8c1ae1c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Solicitacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Beer_Vendas.Models.Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
  
    ViewData["Title"] = "Solicitacao";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    var pedidos = ViewBag.pedidos.Result;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Page Content -->
<div class=""container-fluid"">
    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Listagem de Solicitações</h1>
    </div>

    <div class=""table-responsive"">
        <table class=""table table-sm table-bordered table-hover text-center datatable-custom"" id=""table-result"">
            <thead class=""thead-light"">
                <tr class=""bg-light"">
                    <th class=""align-middle"">
                        #
                    </th>
                    <th class=""align-middle"">
                        Cliente
                    </th>
                    <th class=""align-middle"">
                        Data
                    </th>
                    <th class=""align-middle"">
                        Valor
                    </th>
                    <th class=""align-middle"">
                        Quantidade
                    </th>
              ");
            WriteLiteral(@"      <th class=""align-middle"">
                        Situação
                    </th>
                    <th class=""align-middle"">
                        Ações
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                 foreach (var item in pedidos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr data-codigo=\"");
#nullable restore
#line 46 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                                Write(item.ped_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-ds=\"");
#nullable restore
#line 46 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                                                       Write(item.ped_cli_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td class=\"text-center active\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-left\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_cli_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-left\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_dtinclusao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_vltotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_qtditens);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                       Write(item.ped_situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
            WriteLiteral(@"                        <td>
                            <button type=""button"" class=""btn btn-secondary btn-sm dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Ações <span class=""caret""></span>
                            </button>
                            <ul class=""dropdown-menu dropdown-menu-right"">
                                <li class=""text-center"">
                                    <a class=""alterarStatus"" style=""cursor: pointer;""> Alterar Status</a>
");
            WriteLiteral("                                </li>\r\n                            </ul>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 90 "C:\Users\User\Documents\GitHub\Beer_Vendas\Views\Pedido\Solicitacao.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot></tfoot>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n<script>\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Beer_Vendas.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
