#pragma checksum "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe3864a93d091f7812a186e8c3f5af9e9114d3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\_ViewImports.cshtml"
using SaleSystem;

#line default
#line hidden
#line 2 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\_ViewImports.cshtml"
using SaleSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3864a93d091f7812a186e8c3f5af9e9114d3c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52e2794f46840820f273a615553d24d2736b018", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";

#line default
#line hidden
            BeginContext(40, 6274, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">Inicio</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                    <li class=""breadcrumb-item active"">Inicio</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">

            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
         ");
            WriteLiteral(@"               <h3>Facturación</h3>

                        <p>Detalle de Facturación</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-money-bill-alt""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">Detalles <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>150</h3>
                        <p>Ordenes Pendientes</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">Detalles <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <d");
            WriteLiteral(@"iv class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>CxC</h3>

                        <p>Cuentas x Cobrar</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-file-invoice-dollar""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">Detalles <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>CxP</h3>

                        <p>Cuentas x Pagar</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-money-check-alt""></i>
                    </div>
           ");
            WriteLiteral(@"         <a href=""#"" class=""small-box-footer"">Detalles <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <section class=""col-lg-12 connectedSortable"">
                <!-- solid sales graph -->
                <div class=""card bg-gradient-info"">
                    <div class=""card-header border-0"">
                        <h3 class=""card-title"">
                            <i class=""fas fa-th mr-1""></i>
                            Venta Ultima Semana
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn bg-info btn-sm"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn bg-");
            WriteLiteral(@"info btn-sm"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <canvas class=""chart"" id=""line-chart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer bg-transparent"">
                        <div class=""row"">
                            <div class=""col-4 text-center"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""20"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""text-white"">Mail-Orders</div>
                            </div>
                            <!-- ./col -->
                            <div class=");
            WriteLiteral(@"""col-4 text-center"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""50"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""text-white"">Online</div>
                            </div>
                            <!-- ./col -->
                            <div class=""col-4 text-center"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""30"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""text-white"">In-Store</div>
                            </div>
                            <!-- ./col -->
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- /.card-footer -->
                </div>
                <!-- /.card -->
            </section>
            <!-- /.Lef");
            WriteLiteral("t col -->\r\n        </div>\r\n        <!-- /.row (main row) -->\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n<!-- /.content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591