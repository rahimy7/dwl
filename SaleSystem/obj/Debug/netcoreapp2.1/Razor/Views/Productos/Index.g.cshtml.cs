#pragma checksum "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8239391df1c12acd67857ad5c2881571c0b90f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Index), @"mvc.1.0.view", @"/Views/Productos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productos/Index.cshtml", typeof(AspNetCore.Views_Productos_Index))]
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
#line 1 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\_ViewImports.cshtml"
using SaleSystem;

#line default
#line hidden
#line 3 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
using SaleSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8239391df1c12acd67857ad5c2881571c0b90f9", @"/Views/Productos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52e2794f46840820f273a615553d24d2736b018", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<productos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
            BeginContext(93, 1330, true);
            WriteLiteral(@"        <!-- Content Header (Page header) -->
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Gestionar Productos</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Productos</a></li>
                    <li class=""breadcrumb-item active"">Gestionar</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""card"">
            <div class=""card-body"">
                <table id=""example1"" class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>Cantidad</th>
                            <th>Codigo</th>
   ");
            WriteLiteral(@"                         <th>Nombre</th>
                            <th>Costo</th>
                            <th>Precio</th>
                            <th>Estatus</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 41 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                         foreach (var producto in Model)
                        {

#line default
#line hidden
            BeginContext(1508, 112, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1620, "\"", 1639, 1);
#line 45 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
WriteAttributeValue("", 1626, producto.img, 1626, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1640, 130, true);
            WriteLiteral(" alt=\"Product 1\" class=\"img-circle img-size-32 mr-2\">\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(1771, 17, false);
#line 47 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.cantidad);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1832, 15, false);
#line 48 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.codigo);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1891, 15, false);
#line 49 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1906, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1950, 14, false);
#line 50 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.costo);

#line default
#line hidden
            EndContext();
            BeginContext(1964, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2008, 15, false);
#line 51 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.precio);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2067, 15, false);
#line 52 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                               Write(producto.status);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 168, true);
            WriteLiteral("</td>\r\n                                <td class=\"project-actions text-center\">\r\n                                    <a class=\"btn btn-primary btn-sm sendEdit\" href=\"#\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2250, "\"", 2267, 1);
#line 54 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
WriteAttributeValue("", 2255, producto.id, 2255, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2268, 379, true);
            WriteLiteral(@">
                                        <i class=""fas fa-eye""></i>
                                    </a>
                                    <a class=""btn btn-danger btn-sm"" href=""#"">
                                        <i class=""fas fa-trash""></i>
                                    </a>
                                </td>
                            </tr>
");
            EndContext();
#line 62 "C:\Users\Luis David Uribe\Source\Repos\rahimy7\dwl\SaleSystem\Views\Productos\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2674, 30, true);
            WriteLiteral("                    </tbody>\r\n");
            EndContext();
            BeginContext(3179, 164, true);
            WriteLiteral("                </table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n<!-- /.content -->\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3360, 417, true);
                WriteLiteral(@"
    <script>
        $(""#example1"").DataTable();
        $(document).ready(() => {
            $('a.sendEdit').click(function () {
                var form = $('<form method=""post"" action=""Productos/Detalle""></form>').append('<input type=""hidden"" value=""' + $(this)[0].id + '"" name=""id""/>');
                $('body').append(form);
                form.submit();
            });
        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
