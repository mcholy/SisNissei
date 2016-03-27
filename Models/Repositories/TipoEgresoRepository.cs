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
    class TipoEgresoRepository : DbContext
    {
        public string Guardar(TipoEgresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                item.Nombre = item.Nombre.TrimEnd('.');
                item.Nombre = item.Nombre.TrimStart('.');
                cmd.CommandText = "sis_TipoEgreso_Guardar";
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
        public List<TipoEgresoEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEgreso_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<TipoEgresoEntity> lista = new List<TipoEgresoEntity>();

                    while (reader.Read())
                    {
                        TipoEgresoEntity item = new TipoEgresoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Estado = Boolean.Parse(reader["estado"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }
    }
}
