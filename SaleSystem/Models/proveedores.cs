using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DataBase;

namespace SaleSystem.Models
{
    public class proveedores: Database
    { 
        [BindProperty]
        public InputModel Input { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress(ErrorMessage = "Hay un error")]
            public string correo { get; set; }

             
            public string nombre { get; set; }
        }
    }
}
