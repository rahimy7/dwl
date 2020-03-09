using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataBase;
namespace SaleSystem.Models
{
    public class menu: Database
    {
        public menu()
        {

        }
        public int id { get; set; }
        public string nombre { get; set; }
        public string icono { get; set; }
        public int nivel { get; set; }
        public int? padre { get; set; }
        public string action { get; set; }
        public int status { get; set; }
        public int orden { get; set; }
    }
}