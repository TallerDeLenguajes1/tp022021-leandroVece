#pragma checksum "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5161a9e32e0d267ac36eecf938872b3026017faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataEmpleado), @"mvc.1.0.view", @"/Views/Home/DataEmpleado.cshtml")]
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
#line 1 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\_ViewImports.cshtml"
using tp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\_ViewImports.cshtml"
using tp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5161a9e32e0d267ac36eecf938872b3026017faf", @"/Views/Home/DataEmpleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8632e6abe4348705fc39bac87a42672596859b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DataEmpleado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Datos Del empleado</h2>\r\n<h3>Nombre: ");
#nullable restore
#line 7 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
       Write(ViewBag.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Apelliddo: ");
#nullable restore
#line 8 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
          Write(ViewBag.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Direccion: ");
#nullable restore
#line 9 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
          Write(ViewBag.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>DNI: ");
#nullable restore
#line 10 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
    Write(ViewBag.dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Edad de ingreso: ");
#nullable restore
#line 11 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
                Write(ViewBag.edadIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Edad actual: ");
#nullable restore
#line 12 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
            Write(ViewBag.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Antiguedad: ");
#nullable restore
#line 13 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
           Write(ViewBag.antiguedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Salario: ");
#nullable restore
#line 14 "D:\taller2\tp022021-leandroVece\tp2\tp2\Views\Home\DataEmpleado.cshtml"
        Write(ViewBag.salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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