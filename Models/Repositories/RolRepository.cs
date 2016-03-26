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
    public class RolRepository : BaseRepository<RolEntity>
    {
        public string Guardar(RolEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                item.Nombre = item.Nombre.TrimEnd('.');
                item.Nombre = item.Nombre.TrimStart('.');
                cmd.CommandText = "sis_rol_Guardar";
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
        public List<RolEntity> Listar()
        {
            return base.Listar("sis_Rol_Listar");
        }
    }
}
