using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SaleSystem.Models;

namespace SaleSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static class VariablesGlobales
        {
            public static List<menu> Menu { get; set; }
            public static usuarios LogUser { get; set; }
            public static List<Roles> UserRoles { get; set; }
            public static IActionResult CurrentView { get; set; }
            //public static DateTime LastMove { get => lastmove; set => lastmove = value; }
            public static DateTime LastMove { get; set; } = DateTime.Now;
            public static IActionResult View(IActionResult value, params string[] RolList)
            {
                CurrentView = value;
                IActionResult view = null;
                try
                {
                    if (LogUser == null || !LogUser.id.HasValue)
                        view = new RedirectResult("/Login");

                    else if (SessionActiva())
                    {
                        view = new RedirectResult("/Login/LockScreen");
                    }
                    else
                    {

                        UserRoles = UserRoles ?? new List<Roles>();
                        if (RolList.Count() > 0) if (UserRoles.Where(x => RolList.Contains(x.name)).Count() <= 0)
                            {
                                //view = new ViewResult() {  ViewName = "Home", ViewData = new ViewDataDictionary() { { "error", "No tiene permisos suficientes" } } };
                                view = new RedirectToActionResult("Acceso", "Generales", new { Mensaje = "No tiene permisos suficientes" });
                                //throw new Exception("No tiene permisos suficientes");
                            }
                            else
                            {
                                LastMove = DateTime.Now;
                            }
                    }
                    if (view == null) view = value;
                }
                catch (Exception e)
                {
                    view = new RedirectToActionResult("Index", "Generales", new { Mensaje = e.Message });
                }
                return view;
            }
            public static IActionResult View(ViewResult value)
            {
                IActionResult view = null;
                try
                {
                    if (LogUser == null || !LogUser.id.HasValue)
                        view = new RedirectResult("/Login");
                    else if (SessionActiva())
                    {
                        view = new RedirectResult("/Login/LockScreen");
                    }
                    if (view == null) view = value;
                }
                catch (Exception e)
                {
                    view = new RedirectToActionResult("Index", "Generales", new { Mensaje = e.Message });
                }
                return view;
            }
            public static bool SessionActiva()
            {
                try
                {
                    //return LastMove != null && (DateTime.Now.Ticks - ((DateTime)LastMove).Ticks) > (5 * 60 * 10000000);
                    return LastMove != null && (DateTime.Now.Ticks - LastMove.Ticks) > 3000000000;
                }
                catch
                {
                    return false;
                }
            }
            public static void LogOut()
            {
                Menu = null;
                LogUser = null;
                UserRoles = null;
                CurrentView = null;
                DateTime LastMove = DateTime.Now;
            }
        }
    }
}