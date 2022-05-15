#pragma checksum "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05e7ff57013e7f56d079a78830e801dc9201bf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Torta_Index), @"mvc.1.0.view", @"/Views/Torta/Index.cshtml")]
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
#line 1 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\_ViewImports.cshtml"
using Doceria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\_ViewImports.cshtml"
using Doceria.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\_ViewImports.cshtml"
using Doceria.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05e7ff57013e7f56d079a78830e801dc9201bf4", @"/Views/Torta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4ce6a3812209a10dc24074ff86948dbe98e2ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Torta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TortaListaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Tortas</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
 if (Model.Lista.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        Não há nenhuma torta cadastrada!\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
     foreach (var torta in Model.Lista)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-secondary m-2\" style=\"width: 18rem;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
                                  Write(torta.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
                                Write(torta.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">Preço: R$ ");
#nullable restore
#line 20 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
                                                     Write(torta.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">Vegana? <span style=\"font-weight: bold\">");
#nullable restore
#line 21 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
                                                                                    Write(torta.IsVegana ? "Sim" : "Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ancaroline\source\repos\ProjetoMVC\Doceria\Views\Torta\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TortaListaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591