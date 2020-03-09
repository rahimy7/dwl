using DataBase;
using Generales;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSystem.Models
{
    [BindProperties]
    public class Login: Database
    {
        [Required(ErrorMessage = "Correo Requerido")]
        [EmailAddress]
        public string Correo { get; set; }

        private string password;
        [Required(ErrorMessage = "Contraseña Requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get => password; set => password = value.StringToMD5(); }

        [Display(Name ="Recordar Contraseña")]
        public bool RememberMe { get; set; }
    }
}
