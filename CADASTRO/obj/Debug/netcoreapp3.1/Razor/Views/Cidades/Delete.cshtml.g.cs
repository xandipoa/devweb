#pragma checksum "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9188bbb8dc2235fb794fc0b61bc0e2d6ea1cf8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidades_Delete), @"mvc.1.0.view", @"/Views/Cidades/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cidades/Delete.cshtml", typeof(AspNetCore.Views_Cidades_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9188bbb8dc2235fb794fc0b61bc0e2d6ea1cf8a", @"/Views/Cidades/Delete.cshtml")]
    public class Views_Cidades_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CADASTRO.Modelos.Entidades.Cidade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 176, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Cidade</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(263, 38, false);
#line 15 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(301, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(365, 34, false);
#line 18 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(399, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(462, 46, false);
#line 21 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeCidade));

#line default
#line hidden
            EndContext();
            BeginContext(508, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 42, false);
#line 24 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeCidade));

#line default
#line hidden
            EndContext();
            BeginContext(614, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(677, 38, false);
#line 27 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
            EndContext();
            BeginContext(715, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 34, false);
#line 30 "C:\DEV\devweb\CADASTRO\Views\Cidades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UF));

#line default
#line hidden
            EndContext();
            BeginContext(813, 222, true);
            WriteLiteral("\r\n            \r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CADASTRO.Modelos.Entidades.Cidade> Html { get; private set; }
    }
}
#pragma warning restore 1591
