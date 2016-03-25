using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace Models.Repositories
{
    public class DistritoRepository : DbContext
    {
        public string Guardar(DistritoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                //item.Nombre = item.Nombre.TrimEnd('.');
                //item.Nombre = item.Nombre.TrimStart('.'); codigo para limpiar el inicio y fin de una cadena dependiendo de caracter
                cmd.CommandText = "sis_distrito_Guardar";
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                // ResultModels r_obj = null;
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                    //    r_obj = new ResultModels { Message = reader["msj"].ToString(), Result = reader["Indica"].ToString(), data = reader["data"].ToString() };
                }
                //  return r_obj;
                return respuesta;

            }
        }







    }
}
