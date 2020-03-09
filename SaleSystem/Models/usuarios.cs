using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Generales;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSystem.Models
{
    [BindProperties]
    public class usuarios: Database
    {
        public int? id { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        public string nombre { get; set; }

        public string apellido { get; set; }

        [Required(ErrorMessage = "Cedula Requerida")]
        public string cedula { get; set; }

        [Required(ErrorMessage = "Correo Requerido")]
        [EmailAddress]
        public string correo { get; set; }

        private string Password;
        [Required(ErrorMessage = "Contraseña Requerida")]
        [DataType(DataType.Password)]
        public string password { get=> Password; set => Password = value.StringToMD5(); }

        private string conifrmPassword;
        [NotMapped, Required(ErrorMessage = "Contraseña Requerida"), DataType(DataType.Password)]
        [Compare("password", ErrorMessage ="Las Contraseñas no Coinciden")]
        public string ConifrmPassword { get=> conifrmPassword; set => conifrmPassword= value.StringToMD5(); }

        public string direccion { get; set; }

        public String img { get; set; }

        public DateTime creado { get; set; }
        public DateTime modificado { get; set; }

        public List<menu> getMenu()
        {
            try
            {
                if (id == null) return null;
                menu men = new menu();
                var query = "SELECT m.* from menu m INNER JOIN menurol mr on m.id = mr.menuid LEFT JOIN roles r on mr.id = r.id left OUTER JOIN rolesusuarios ru on ru.id = r.id inner JOIN usuarios u WHERE u.id = {0}";
                return JsonConvert.DeserializeObject<List<menu>>(Select(string.Format(query, id)));
            }
            catch 
            {
                return null;
            }
        }
        public List<Roles> getRoles()
        {
            try
            {
                if (id == null) return null;
                menu men = new menu();
                var query = "SELECT r.* FROM roles r INNER JOIN rolesusuarios ru on r.id = ru.rolid inner JOIN usuarios u ON u.id = ru.usuarioid WHERE u.id = {0}";
                return JsonConvert.DeserializeObject<List<Roles>>(Select(string.Format(query, id)));
            }
            catch
            {
                return null;
            }
        }
    }
}