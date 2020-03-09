using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace DataBase
{
    public class Database
    {
        MySqlConnection Conexion = new MySqlConnection("server=localhost;database=salesystem;user id=root;password=;");

        /// <summary>
        /// Usa la conexion Local
        /// </summary>
        public Database()
        {
        }
        /// <summary>
        /// Usar la conexion enviada
        /// </summary>
        /// <param name="conexionString">String de Conexion</param>
        public Database(string conexionString)
        {
            Conexion = new MySqlConnection(conexionString);
        }
        /// <summary>
        /// Excepciones de procesos
        /// </summary>
        public List<Exception> Exception = new List<Exception>();
        //public bool HasErrors() => Exception.Count > 0;
        public string Error() => Exception != null ? Exception.FirstOrDefault() != null ? Exception.FirstOrDefault().Message : "" : "";

        private bool Open()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed) Conexion.Open();
                return true;
            }
            catch (Exception e)
            {
                this.Exception.Add(e);
                return false;
            }
        }
        private void Close()
        {
            try
            {
                if (Conexion.State != ConnectionState.Closed) Conexion.Close();
            }
            catch (Exception e)
            {
                this.Exception.Add(e);
            }
        }

        public async Task<bool> SaveChanges()
        {
            try
            {
                await Task.Run(() =>
                {
                    var query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})",
                        GetTableName(this),
                        string.Join(",", GetObjColumns(this, false)),
                        string.Format("'{0}'",
                            string.Join("','",
                                GetObjValues(this)))).Replace("''", "null");

                    Open();
                    new MySqlCommand(query, Conexion).ExecuteNonQuery();;
                    Close();
                });
                return true;
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return false;
            }
        }
        public async Task<bool> Insert()
        {
            try
            {
                await Task.Run(() =>
                {
                    var query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})",
                        GetTableName(this),
                        string.Join(",", GetObjColumns(this, false)),
                        string.Format("'{0}'",
                            string.Join("','",
                                GetObjValues(this)))).Replace("''", "null");

                    Open();
                    new MySqlCommand(query, Conexion).ExecuteNonQuery(); ;
                    Close();
                });
                return true;
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return false;
            }
        }
        //public DataTable getAll(ref DataTable tabla)
        //{
        //    try
        //    {
        //        var query = string.Format("SELECT {0} FROM {1}", string.Join(",", getObjColumns(this)), tabla.TableName);
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexion);
        //        Open();
        //        DataTable dt = new DataTable();
        //        //DataSet ds = new DataSet();
        //        adapter.Fill(dt);
        //        //adapter.Fill(ds);
        //        dt.AcceptChanges();
        //        Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Exception.Add(ex);
        //        Close();
        //        return null;
        //    }
        //}

        public string Select(string query)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexion);
                Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Close();
                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return null;
            }
        }

        public string GetAll(bool activos = true)
        {
            try
            {
                var query = string.Format("SELECT {0} FROM {1} {2}", string.Join(",", GetObjColumns(this)), GetTableName(this), activos ? "WHERE status=1" : "");
                return Select(query);
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return null;
            }
        }

        public string GetAllById(int id)
        {
            try
            {
                var query = string.Format("SELECT {0} FROM {1} WHERE id = {2}", string.Join(",", GetObjColumns(this)), GetTableName(this), id);
                return Select(query);
                //return JsonConvert.SerializeObject(dt).Replace("[", "").Replace("]", "");
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return null;
            }
        }
        /// <summary>
        /// Obtener registros condicionalmente
        /// </summary>
        /// <param name="where">Lista de condiciones</param>
        /// <returns></returns>
        public string GetAllBy(string where)
        {
            try
            {
                where = (where == null || where.Length == 0) ? "" : " WHERE " + where;

                var query = string.Format("SELECT {0} FROM {1} {2}", string.Join(",", GetObjColumns(this)), GetTableName(this), where);

                return Select(query);
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return null;
            }
        }
        public async Task<bool> Exist(string where)
        {
            try
            {
                string data = null;
                await Task.Run(() =>
                {
                    where = (where == null || where.Length == 0) ? "" : " WHERE " + where;

                    var query = string.Format("SELECT {0} FROM {1} {2}", string.Join(",", GetObjColumns(this)), GetTableName(this), where);

                    data = Select(query);
                });
                return string.IsNullOrWhiteSpace(data);
            }
            catch (Exception ex)
            {
                this.Exception.Add(ex);
                Close();
                return false;
            }
        }
        //public void getAllById(string id)
        //{
        //    try
        //    {
        //        var obj = this;
        //        var query = string.Format("SELECT {2} FROM {0} WHERE id = {1}", getTableName(obj), id);

        //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexion);
        //        if (!Open()) throw new Exception("Error al abrir conexion");

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        dt.AcceptChanges();
        //        Close();

        //        foreach(var item in getObjColumns(obj))
        //        {
        //            obj.GetType().GetProperty(item).SetValue(obj, dt.Rows[0][item]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = ex.Message;
        //    }
        //}

        private string GetTableName(object obj)
        {
            return obj.GetType().Name;
        }
        //private object getProperty(object obj, string property)
        //{
        //    return obj.GetType().GetProperty(property).GetValue(obj);

        //}

        public List<PropertyInfo> ObjProperties(object obj, bool NullValue = false)
        {
            return obj.GetType().GetProperties().Where(x => x.GetCustomAttributes(false).Where(j => j.GetType() == typeof(NotMappedAttribute)).Count() <= 0)
                .Where(x => NullValue || (x.GetValue(obj) != null)).ToList();
        }

        private List<string> GetObjColumns(object obj, bool NullValue = true)
        {
            return ObjProperties(this, NullValue).Select(x => x.Name).ToList();
            //{
            //    var attr = item.GetCustomAttributes(false).ToDictionary(a => a.GetType().Name, a => a);
            //    //foreach(var at in attr)
            //    //{
            //    //    var f =  at;
            //    //}
            //}
            ////return obj.GetType().GetProperties().Select(x => x.GetCustomAttributes(true).Where x.Name).ToList();
            //return null;
        }

        private List<object> GetObjValues(object obj, bool NullValue = false)
        {
            return ObjProperties(this, NullValue)
                .Select(x => x.GetValue(obj)).ToList();
        }
    }
}