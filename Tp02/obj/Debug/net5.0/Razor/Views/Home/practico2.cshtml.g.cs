#pragma checksum "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\Home\practico2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5658ed4d1cd53fc49ff3d8953dc554136ee20658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_practico2), @"mvc.1.0.view", @"/Views/Home/practico2.cshtml")]
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
#line 1 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\_ViewImports.cshtml"
using Tp02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\_ViewImports.cshtml"
using Tp02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5658ed4d1cd53fc49ff3d8953dc554136ee20658", @"/Views/Home/practico2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4363e3bf6563c4b0dee20fc7bd5c5945f0c434cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_practico2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tp02.Models.Empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Empleado</h1>
<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <td>Nombre</td>
            <td>Apellido</td>
            <td>Edad</td>
            <td>Antiguedad</td>
            <td>Salario</td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 19 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\Home\practico2.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\Home\practico2.cshtml"
           Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\Home\practico2.cshtml"
           Write(Model.Antiguedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Taller 2\Trabajos Practicos\tp022021-araasilva\Tp02\Views\Home\practico2.cshtml"
           Write(Model.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tp02.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
