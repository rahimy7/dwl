using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using DataBase;
using Newtonsoft.Json;

namespace Generales
{
    class clave
    {
        public string Clave { get; set; }
    }
    public static class Generales
    {

        private static string codigicacion()
        {
            return "0123456789abcdABCD";
        }
        public static string StringToMD5(this string value)
        {
            try
            {
                if (value == null)
                {
                    return string.Empty;
                }
                var db = new Database();
                return JsonConvert.DeserializeObject<List<clave>>(db.Select(string.Format("SELECT MD5('{0}')Clave", value))).FirstOrDefault().Clave;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string ObjToJson(this object value)
        {
            try
            {
                return JsonConvert.SerializeObject(value);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static T JsonToObj<T>(this string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch
            {
                return default(T);
            }
        }
    }
}