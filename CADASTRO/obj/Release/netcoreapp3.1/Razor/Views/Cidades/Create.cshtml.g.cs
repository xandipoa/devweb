#pragma checksum "C:\DEV\devweb\CADASTRO\Views\Cidades\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66511f19efb2b49a65f13c83e87e990aace799cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidades_Create), @"mvc.1.0.view", @"/Views/Cidades/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cidades/Create.cshtml", typeof(AspNetCore.Views_Cidades_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66511f19efb2b49a65f13c83e87e990aace799cc", @"/Views/Cidades/Create.cshtml")]
    public class Views_Cidades_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CADASTRO.Modelos.Entidades.Cidade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DEV\devweb\CADASTRO\Views\Cidades\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(86, 920, true);
            WriteLiteral(@"
<h1>Create</h1>

<h4>Cidade</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NomeCidade"" class=""control-label""></label>
                <input asp-for=""NomeCidade"" class=""form-control"" />
                <span asp-validation-for=""NomeCidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UF"" class=""control-label""></label>
                <select asp-for=""UF"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("asp-item", " asp-item=", 1006, "", 1033, 1);
#line 27 "C:\DEV\devweb\CADASTRO\Views\Cidades\Create.cshtml"
WriteAttributeValue("", 1016, ViewBag.UfCidade, 1016, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1033, 346, true);
            WriteLiteral(@" ></select>
                <span asp-validation-for=""UF"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1397, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\DEV\devweb\CADASTRO\Views\Cidades\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
