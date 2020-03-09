using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SaleSystem.Models;
using Newtonsoft.Json;
using System;
using Generales;
using static SaleSystem.Program;

namespace SaleSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return VariablesGlobales.View(View(VariablesGlobales.LogUser), "Administrator");
        }
    }
}
