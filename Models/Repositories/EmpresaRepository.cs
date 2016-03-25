using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities;
using System.Data.Entity;

namespace Models.Repositories
{
    class EmpresaRepository : DbContext
    {
        public string Guardar(EmpresaEntity item)
        { 
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Empresa_Guardar";
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@descuento", item.Descuento.ToString());
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
