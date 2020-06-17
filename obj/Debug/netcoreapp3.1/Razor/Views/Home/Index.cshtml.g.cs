#pragma checksum "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5029a58c5e4814f69082577b1eb11e9b4ab0040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\_ViewImports.cshtml"
using Beer_Vendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\_ViewImports.cshtml"
using Beer_Vendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5029a58c5e4814f69082577b1eb11e9b4ab0040", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a54942ea83ada8c95363c4b3ffbc0a8c1ae1c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Beer_Vendas.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var produtos = ViewBag.Produtos.Result;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .container img {
        max-width: 150px;
        max-height: 150px;
        width: auto;
        height: auto;
        top: 50%;
        left: 50%;
    }
</style>
<div class=""container"">
    <div class=""card-deck mb-3 text-center"">
");
#nullable restore
#line 19 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
         foreach (var item in produtos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-4 shadow-sm\">\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"my-0 font-weight-normal\">");
#nullable restore
#line 23 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
                                                   Write(item.pro_nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <div style=\"margin-top:1em;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 729, "\"", 774, 2);
            WriteAttributeValue("", 735, "data:image/jpeg;base64,", 735, 23, true);
#nullable restore
#line 25 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
WriteAttributeValue("", 758, item.pro_imagem, 758, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-body\" id=\"headingOne\">\r\n                    <h1 class=\"card-title pricing-card-title\"><small class=\"text-muted\">R$ ");
#nullable restore
#line 29 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
                                                                                      Write(item.pro_valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h1>\r\n                    <div>\r\n                        <a type=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1130, 1);
#nullable restore
#line 31 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
WriteAttributeValue("", 1084, Url.Action("Index", new { id = item.pro_id }), 1084, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-lg btn-block btn-outline-primary\">Comprar</a>\r\n                        <button type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 32 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
                                                                                       Write(item.pro_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1320, "\"", 1357, 2);
            WriteAttributeValue("", 1336, "collapse_", 1336, 9, true);
#nullable restore
#line 32 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
WriteAttributeValue("", 1345, item.pro_id, 1345, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-block btn-outline-primary\">Detalhes</button>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1479, "\"", 1505, 2);
            WriteAttributeValue("", 1484, "collapse_", 1484, 9, true);
#nullable restore
#line 34 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
WriteAttributeValue("", 1493, item.pro_id, 1493, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#headingOne\">\r\n                        <div class=\"card-body\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
                       Write(item.pro_descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card mb-4 shadow-sm"">
            <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">Free</h4>
            </div>
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">$0 <small class=""text-muted"">/ mo</small></h1>
                <ul class=""list-unstyled mt-3 mb-4"">
                    <li>10 users included</li>
                    <li>2 GB of storage</li>
                    <li>Email support</li>
                    <li>Help center access</li>
                </ul>
                <button type=""button"" class=""btn btn-lg btn-block btn-outline-primary"">Sign up for free</button>
            </div>
        </div>
    </div>
</div>
<script>



</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Beer_Vendas.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
