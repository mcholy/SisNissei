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
    class GrupoEtarioRepository : BaseRepository<GrupoEtarioEntity>
    {
        public string Guardar(GrupoEtarioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_GrupoEtario_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
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
        public List<GrupoEtarioEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_GrupoEtario_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<GrupoEtarioEntity> lista = new List<GrupoEtarioEntity>();

                    while (reader.Read())
                    {
                        GrupoEtarioEntity item = new GrupoEtarioEntity();
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
        public string Eliminar(GrupoEtarioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_GrupoEtario_Eliminar";
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
    }
}
