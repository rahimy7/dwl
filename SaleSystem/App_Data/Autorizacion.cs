using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Authorized
{
    public class Autorizacion : IAuthorizationRequirement
    {
        //public List<string> Clave { get; set; }
        //public string Message { get; set; }

        ////private readonly bool IsAuth = false;

        //private RedirectResult view;// = new RedirectResult();

        //public EvaluarEnum Evaluar { get; set; }

        //public enum EvaluarEnum
        //{
        //    All,
        //    Login,
        //    Moved
        //}


        //public bool AuthorizeCore(Microsoft.AspNetCore.Http.HttpContext httpContext)
        //{
        //    //if(Evaluar == EvaluarEnum.Moved)
        //    //{
        //    //    if ((DateTime.Now.Ticks - ((DateTime)httpContext.Session["lastMove"]).Ticks) > 50000000)
        //    //    {
        //    //        message = "Tiene que iniciar seccion";
        //    //        isAuth = false;
        //    //    }
        //    //    else
        //    //    {
        //    //        httpContext.Session["lastMove"] = DateTime.Now;
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    List<string> privilegios = (List<string>)httpContext.Session["rolls"] ?? new List<string>();
        //    //    isAuth = privilegios.Where(x => this.clave.IndexOf(x) > -1).Count() > 0;
        //    //}

        //    try
        //    {
        //        if (httpContext.Session.get < 1 || httpContext.Session["lastMove"] != null && (DateTime.Now.Ticks - ((DateTime)httpContext.Session["lastMove"]).Ticks) > (2*60*10000000))
        //        {
        //            //view = new ViewResult() { ViewName = "Login" };

        //            view = new RedirectResult("/Login");
        //            throw new Exception("Tiene que iniciar seccion");
        //        }
        //        else
        //        {
        //            httpContext.Session["lastMove"] = DateTime.Now;
        //        }

        //        if (Evaluar == EvaluarEnum.All)
        //        {
        //            List<string> privilegios = (List<string>)httpContext.Session["roles"] ?? new List<string>();
        //            if (privilegios.Where(x => this.Clave.IndexOf(x) > -1).Count() <= 0)
        //            {
        //                //view = new ViewResult() {  ViewName = "Home", ViewData = new ViewDataDictionary() { { "error", "No tiene permisos suficientes" } } };
        //                throw new Exception("No tiene permisos suficientes");
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Message = e.Message;
        //        return false;
        //    }
        //}

        //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //{
        //    //if (!isAuth)
        //    filterContext.Result = view;
        //}
        public int MinimumAge { get;}

        public Autorizacion(int minimumAge)
        {
            MinimumAge = minimumAge;
        }
    }
}