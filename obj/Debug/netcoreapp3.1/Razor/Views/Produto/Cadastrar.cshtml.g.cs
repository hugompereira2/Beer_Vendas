#pragma checksum "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Produto\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f17d712da3ec3bf201adf63ff8b6c903565a0115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastrar), @"mvc.1.0.view", @"/Views/Produto/Cadastrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17d712da3ec3bf201adf63ff8b6c903565a0115", @"/Views/Produto/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a54942ea83ada8c95363c4b3ffbc0a8c1ae1c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Produto\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Cadastrar Produto</h1>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f17d712da3ec3bf201adf63ff8b6c903565a01154973", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""col-md-8 mb-3"">
                <label for=""validationCustom01"">Nome do Produto:</label>
                <input autocomplete=""off"" type=""text"" class=""form-control"" id=""validationCustom01""
                       placeholder=""ex: Coca-Cola""");
                BeginWriteAttribute("value", " value=\"", 659, "\"", 667, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            </div>
            <div class=""col-md-4 mb-3"">
                <label for=""validationCustom01"">Quantidade:</label>
                <input autocomplete=""off"" type=""number"" min=""1"" class=""form-control"" id=""validationCustom01""
                       placeholder=""ex: 10""");
                BeginWriteAttribute("value", " value=\"", 963, "\"", 971, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            </div>
            <div class=""col-xl-12 mb-4"">
                <label for=""validationCustom02"">Descrição:</label>
                <textarea autocomplete=""off"" type=""text"" class=""form-control"" id=""validationCustom02""
                          placeholder=""Descrição""");
                BeginWriteAttribute("value", " value=\"", 1266, "\"", 1274, 0);
                EndWriteAttribute();
                WriteLiteral(@" required></textarea>
            </div>
            <div class=""w-100""></div>
            <div class=""col-md-12 custom-file"">
                <label for=""validationCustom03"">Escolha a imagem:</label>
                <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                       aria-describedby=""inputGroupFileAddon01"">
                <label class=""custom-file-label"" for=""inputGroupFile01"">Escolha o arquivo</label>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<footer class=\"mb-5\" style=\"margin-top:15%;\">\r\n    <button class=\"btn btn-danger float-left\" style=\"margin-left: 2%; width: 15%;\" id=\"btnCancelar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1937, "\"", 1991, 3);
            WriteAttributeValue("", 1947, "location.href=\'", 1947, 15, true);
#nullable restore
#line 42 "C:\Users\Hugo\Documents\GitHub\Beer_Vendas\Views\Produto\Cadastrar.cshtml"
WriteAttributeValue("", 1962, Url.Action("Index", "Home"), 1962, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1990, "\'", 1990, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        Cancelar <i class=\"fas fa-times\"></i>\r\n    </button>\r\n    <button class=\"btn btn-success float-right\" style=\"margin-right: 2%; width: 15%;\" id=\"btnConfirmar\">\r\n        Cadastrar <i class=\"fas fa-check\"></i>\r\n    </button>\r\n</footer>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f17d712da3ec3bf201adf63ff8b6c903565a01159482", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f17d712da3ec3bf201adf63ff8b6c903565a011510521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $('#btnConfirmar').click(function () {
        Swal.fire({
            reverseButtons: true,
            title: 'Atenção!',
            html: '<b>Confirmar Cadastro?</b>',
            icon: 'warning',
            confirmButtonText: 'Confirmar',
            showCancelButton: 'Cancelar'
        }).then((result) => {
            if (result.value)
                swal.fire(""Deleted!"", ""Your imaginary file has been deleted."", ""success"")
        })
    });

</script>");
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
