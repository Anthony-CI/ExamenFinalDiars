#pragma checksum "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c1bc3f798522ddfe5fafa9d8558818bf208148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\_ViewImports.cshtml"
using AnthonyCoronadoIpanaqué;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\_ViewImports.cshtml"
using AnthonyCoronadoIpanaqué.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c1bc3f798522ddfe5fafa9d8558818bf208148", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d97e0196a76be4bf878855faacfbdc3d553b105", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function (e) {
        $.get(""/Search/_Index?busqueda="" + $(""#busqueda"").val(), function (respuesta) {
            $(""#tbody"").html(respuesta);
        });
        e.preventDefault();
    });
</script>

<h1>Buscar</h1>
<input id=""busqueda"" name=""busqueda"" />
<button class=""btn btn-primary"" id=""btn"">Busca</button>


<div id=""tbody"">

</div>
<script>
    $(""#busqueda"").keyup(function (e) {
        $.get(""/Search/_Index?busqueda="" + $(""#busqueda"").val(), function (respuesta) {
            $(""#tbody"").html(respuesta);
        });
        e.preventDefault();
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
