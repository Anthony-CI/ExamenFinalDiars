#pragma checksum "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c5b96a71aea99211ee611e74dc14a59b050a1da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search__Index), @"mvc.1.0.view", @"/Views/Search/_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b96a71aea99211ee611e74dc14a59b050a1da", @"/Views/Search/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d97e0196a76be4bf878855faacfbdc3d553b105", @"/Views/_ViewImports.cshtml")]
    public class Views_Search__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
  
    ViewData["Title"] = "_Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <h3 class=\"card-header\"><a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 183, "\"", 218, 2);
            WriteAttributeValue("", 190, "/Nota/VerDetalle?id=", 190, 20, true);
#nullable restore
#line 10 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
WriteAttributeValue("", 210, item.Id, 210, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
                                                                                            Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<strong>Tags</strong>\r\n<hr />\r\n");
#nullable restore
#line 16 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
 foreach (var item in ViewBag.que)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <a style=\"margin:5px\" class=\"bg-light\">");
#nullable restore
#line 19 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
                                          Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\alciS\Desktop\AnthonyCoronadoIpanaqué\AnthonyCoronadoIpanaqué\Views\Search\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
