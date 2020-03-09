using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generales;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SaleSystem.Models;
using static SaleSystem.Program;

namespace SaleSystem.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            List<productos> productos = JsonConvert.DeserializeObject<List<productos>>(new productos().GetAll());
            return VariablesGlobales.View(View(productos));
        }
        public IActionResult Detalle(productos model)
        {
            if (!model.id.HasValue)
                return Redirect("/Productos");

            model = model.GetAllById(model.id.Value).JsonToObj<List<productos>>().FirstOrDefault();

            return VariablesGlobales.View(View(model), "Administrator");
        }
        public IActionResult Add(productos model)
        {
            if (model.id.HasValue)
                model = new productos().GetAllById(model.id.Value).JsonToObj<List<productos>>().FirstOrDefault();
            return VariablesGlobales.View(View(model), "Administrator");
        }
    }
}