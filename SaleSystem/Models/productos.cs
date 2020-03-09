using DataBase;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSystem.Models
{
    [BindProperties]
    public class productos : Database
    {
        public int? id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }
        public string img { get; set; }
        public DateTime creado { get; set; }
        public DateTime modificado { get; set; }
        public int status { get; set; }
    }
}
