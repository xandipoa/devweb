#pragma checksum "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1b09a352822d5b8edb0fe0e768bd7e31d9be24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidades_Index), @"mvc.1.0.view", @"/Views/Cidades/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cidades/Index.cshtml", typeof(AspNetCore.Views_Cidades_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1b09a352822d5b8edb0fe0e768bd7e31d9be24", @"/Views/Cidades/Index.cshtml")]
    public class Views_Cidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CADASTRO.Modelos.Entidades.Cidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 38, false);
#line 16 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 46, false);
#line 19 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeCidade));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 38, false);
#line 22 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
            EndContext();
            BeginContext(491, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(609, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(658, 37, false);
#line 31 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(695, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(751, 45, false);
#line 34 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCidade));

#line default
#line hidden
            EndContext();
            BeginContext(796, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(852, 37, false);
#line 37 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UF));

#line default
#line hidden
            EndContext();
            BeginContext(889, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(945, 78, false);
#line 40 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1044, 84, false);
#line 41 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1149, 82, false);
#line 42 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\DEV\devweb\CADASTRO\Views\Cidades\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1270, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CADASTRO.Modelos.Entidades.Cidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
