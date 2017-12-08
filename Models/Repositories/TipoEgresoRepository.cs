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
    class TipoEgresoRepository : BaseRepository<TipoEgresoEntity>
    {
        public string Guardar(TipoEgresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEgreso_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@proveedor", item.Proveedor);
                cmd.Parameters.AddWithValue("@regmod", item.Regmod);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                }
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
                        item.Proveedor = bool.Parse(reader["proveedor"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Estado = Boolean.Parse(reader["estado"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }
        public string Eliminar(TipoEgresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEgreso_Eliminar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                }
                return respuesta;
            }
        }

        public List<TipoEgresoEntity> ListarTipoPago()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEgreso_Listar";

                using (var reader = cmd.ExecuteReader())
                {
                    List<TipoEgresoEntity> lista = new List<TipoEgresoEntity>();

                    while (reader.Read())
                    {
                        TipoEgresoEntity item = new TipoEgresoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }
    }
}
