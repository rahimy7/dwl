using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SaleSystem.Models;
using Microsoft.AspNetCore.Authorization;
using static SaleSystem.Program;

namespace SaleSystem.Controllers
{
    public class LoginController : Controller
    {
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        //public LoginController(UserManager<IdentityUser>userManager,
        //    SignInManager<IdentityUser>signInManager)
        //{
        //    this.userManager = userManager;
        //    this.signInManager = signInManager;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            VariablesGlobales.LogOut();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Login model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception("Correo o Contraseña incorrectos.");
                var users = JsonConvert.DeserializeObject<List<usuarios>>(new usuarios().GetAllBy(string.Format("correo = '{0}' and password = '{1}'", model.Correo, model.Password)));
                if (users.Count == 0) throw new Exception("Correo o Contraseña incorrectos.");

                VariablesGlobales.LogUser = users.FirstOrDefault();
                if (VariablesGlobales.Menu == null)
                {
                    VariablesGlobales.Menu = VariablesGlobales.LogUser.getMenu();
                }
                if (VariablesGlobales.UserRoles == null)
                {
                    VariablesGlobales.UserRoles = VariablesGlobales.LogUser.getRoles();
                }
                VariablesGlobales.LastMove = DateTime.Now;
                return Redirect("/Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(model);
        }
        public IActionResult Registrar()
        {
            return View(new usuarios());
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarData(usuarios model)
        {
            if (ModelState.IsValid)
            {
                if (await model.Insert())
                    return Redirect("/Login");
                else
                    return View("Registrar", model);
            }
            else
            {
                TempData["requeridos"] = string.Join(",",ModelState.Values.SelectMany(x => x.Errors)
                    .Select(e=> e.ErrorMessage));  
            }
            return View("Registrar", model);
        }
        public IActionResult LockScreen()
        {
            return View(VariablesGlobales.LogUser);
        }
    }
}