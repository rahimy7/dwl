#pragma checksum "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Productos\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1fe2e32a91e96d5229079bae5c8fd520d83c2a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Detalle), @"mvc.1.0.view", @"/Views/Productos/Detalle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productos/Detalle.cshtml", typeof(AspNetCore.Views_Productos_Detalle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fe2e32a91e96d5229079bae5c8fd520d83c2a3", @"/Views/Productos/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52e2794f46840820f273a615553d24d2736b018", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<productos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Productos\Detalle.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
            BeginContext(61, 209, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <h4 class=\"no-margin\">");
            EndContext();
            BeginContext(271, 12, false);
#line 10 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Productos\Detalle.cshtml"
                                 Write(Model.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(283, 19679, true);
            WriteLiteral(@"</h4>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""/Productos"">Productos</a></li>
                    <li class=""breadcrumb-item active"">Detalle</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""card"">
                <div class=""card-header"">
                    <h1 class=""card-title""><i class=""fa fa-list""></i> Detalles</h1>
                    <div class=""card-tools"">
                        <button type=""button"" id=""editar"" class=""btn btn-primary btn-xs"" data-toggle=""tooltip"" title=""Editar"">
                            <i class=""fas fa-pen""></i>
                            Editar
                        </button>
                        <button type=""button"" id=""delete"" class");
            WriteLiteral(@"=""btn btn-danger btn-xs"" data-toggle=""tooltip"" title=""Eliminar"">
                            <i class=""fas fa-trash""></i>
                            Eliminar
                        </button>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-12 col-md-12 col-lg-8 order-2 order-md-1"">
                            <div class=""row"">
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Estimated budget</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">2300</span>
                                        </div>
                                    </div>
                                <");
            WriteLiteral(@"/div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Total amount spent</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">2000</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Estimated project duration</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">20 </spa");
            WriteLiteral(@"n>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <h4>Recent Activity</h4>
                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user1-128x128.jpg"" alt=""user image"">
                                            <span class=""username"">
                                                <a href=""#"">Jonathan Burke Jr.</a>
                                            </span>
                                            <span class=""description"">Shared publicly - 7:45 PM today</span>
                                        </div>
                                        <!-- /.user-block -->");
            WriteLiteral(@"
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>

                                        <p>
                                            <a href=""#"" class=""link-black text-sm""><i class=""fas fa-link mr-1""></i> Demo File 1 v2</a>
                                        </p>
                                    </div>

                                    <div class=""post clearfix"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user7-128x128.jpg"" alt=""User Image"">
                                            <span class=""username"">
                           ");
            WriteLiteral(@"                     <a href=""#"">Sarah Ross</a>
                                            </span>
                                            <span class=""description"">Sent you a message - 3 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>
                                        <p>
                                            <a href=""#"" class=""link-black text-sm""><i class=""fas fa-link mr-1""></i> Demo File 2</a>
                                        </p>
                                    </div>

                                    <div class=""post""");
            WriteLiteral(@">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user1-128x128.jpg"" alt=""user image"">
                                            <span class=""username"">
                                                <a href=""#"">Jonathan Burke Jr.</a>
                                            </span>
                                            <span class=""description"">Shared publicly - 5 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>

         ");
            WriteLiteral(@"                               <p>
                                            <a href=""#"" class=""link-black text-sm""><i class=""fas fa-link mr-1""></i> Demo File 1 v1</a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-md-12 col-lg-4 order-1 order-md-2"">
                            <h3 class=""text-primary""><i class=""fas fa-paint-brush""></i> AdminLTE v3</h3>
                            <p class=""text-muted"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terr.</p>
                            <br>
                            <div class=""text-muted"">
                                <p class=""text-sm"">
                                    Client Company
                                   ");
            WriteLiteral(@" <b class=""d-block"">Deveint Inc</b>
                                </p>
                                <p class=""text-sm"">
                                    Project Leader
                                    <b class=""d-block"">Tony Chicken</b>
                                </p>
                            </div>

                            <h5 class=""mt-5 text-muted"">Project files</h5>
                            <ul class=""list-unstyled"">
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-word""></i> Functional-requirements.docx</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-pdf""></i> UAT.pdf</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""");
            WriteLiteral(@"far fa-fw fa-envelope""></i> Email-from-flatbal.mln</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-image ""></i> Logo.png</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-word""></i> Contract-10_12_2014.docx</a>
                                </li>
                            </ul>
                            <div class=""text-center mt-5 mb-3"">
                                <a href=""#"" class=""btn btn-sm btn-primary"">Add files</a>
                                <a href=""#"" class=""btn btn-sm btn-warning"">Report contact</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.card-body -->
            </div>

            <div class=""card"">
 ");
            WriteLiteral(@"               <div class=""card-header"">
                    <h3 class=""card-title"">Projects Detail</h3>

                    <div class=""card-tools"">
                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                            <i class=""fas fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-12 col-md-12 col-lg-8 order-2 order-md-1"">
                            <div class=""row"">
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Estimated budget</span>
                                            <span cla");
            WriteLiteral(@"ss=""info-box-number text-center text-muted mb-0"">2300</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Total amount spent</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">2000</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span cla");
            WriteLiteral(@"ss=""info-box-text text-center text-muted"">Estimated project duration</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">20 </span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <h4>Recent Activity</h4>
                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user1-128x128.jpg"" alt=""user image"">
                                            <span class=""username"">
                                                <a href=""#"">Jonathan Burke Jr.</a>
                                            </span>
                                ");
            WriteLiteral(@"            <span class=""description"">Shared publicly - 7:45 PM today</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>

                                        <p>
                                            <a href=""#"" class=""link-black text-sm""><i class=""fas fa-link mr-1""></i> Demo File 1 v2</a>
                                        </p>
                                    </div>

                                    <div class=""post clearfix"">
                                        <div class=""user-block"">
                                            <img cl");
            WriteLiteral(@"ass=""img-circle img-bordered-sm"" src=""../../dist/img/user7-128x128.jpg"" alt=""User Image"">
                                            <span class=""username"">
                                                <a href=""#"">Sarah Ross</a>
                                            </span>
                                            <span class=""description"">Sent you a message - 3 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>
                                        <p>
                                            <a href=""#"" class=""link-black text-sm""><i class");
            WriteLiteral(@"=""fas fa-link mr-1""></i> Demo File 2</a>
                                        </p>
                                    </div>

                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user1-128x128.jpg"" alt=""user image"">
                                            <span class=""username"">
                                                <a href=""#"">Jonathan Burke Jr.</a>
                                            </span>
                                            <span class=""description"">Shared publicly - 5 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typograp");
            WriteLiteral(@"hers and the like. Some people hate it and argue for
                                            its demise, but others ignore.
                                        </p>

                                        <p>
                                            <a href=""#"" class=""link-black text-sm""><i class=""fas fa-link mr-1""></i> Demo File 1 v1</a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-md-12 col-lg-4 order-1 order-md-2"">
                            <h3 class=""text-primary""><i class=""fas fa-paint-brush""></i> AdminLTE v3</h3>
                            <p class=""text-muted"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terr.</p>
                            <br>
       ");
            WriteLiteral(@"                     <div class=""text-muted"">
                                <p class=""text-sm"">
                                    Client Company
                                    <b class=""d-block"">Deveint Inc</b>
                                </p>
                                <p class=""text-sm"">
                                    Project Leader
                                    <b class=""d-block"">Tony Chicken</b>
                                </p>
                            </div>

                            <h5 class=""mt-5 text-muted"">Project files</h5>
                            <ul class=""list-unstyled"">
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-word""></i> Functional-requirements.docx</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-pd");
            WriteLiteral(@"f""></i> UAT.pdf</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-envelope""></i> Email-from-flatbal.mln</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-image ""></i> Logo.png</a>
                                </li>
                                <li>
                                    <a href="""" class=""btn-link text-secondary""><i class=""far fa-fw fa-file-word""></i> Contract-10_12_2014.docx</a>
                                </li>
                            </ul>
                            <div class=""text-center mt-5 mb-3"">
                                <a href=""#"" class=""btn btn-sm btn-primary"">Add files</a>
                                <a href=""#"" class=""btn btn-sm btn-warning"">Report contact</a>
                          ");
            WriteLiteral("  </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card -->\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(19979, 170, true);
                WriteLiteral("\r\n    <script>\r\n        $(\'#editar\').click(() => {\r\n            var form = $(\'<form method=\"post\" action=\"/Productos/add\"></form>\').append(\'<input type=\"hidden\" value=\"\'+");
                EndContext();
                BeginContext(20150, 8, false);
#line 329 "C:\Users\Luis David Uribe\source\repos\SaleSystem\SaleSystem\Views\Productos\Detalle.cshtml"
                                                                                                                 Write(Model.id);

#line default
#line hidden
                EndContext();
                BeginContext(20158, 164, true);
                WriteLiteral("+\'\" name=\"id\"/>\');\r\n            $(\'body\').append(form);\r\n            form.submit();\r\n        });\r\n        $(\'#delete\').click(() => {\r\n\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<productos> Html { get; private set; }
    }
}
#pragma warning restore 1591