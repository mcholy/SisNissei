using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Models.Repositories
{
    public class AmbienteDetalleRepository :BaseRepository<AmbienteDetalleEntity>
    {
        public string Guardar(AmbienteDetalleEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_AmbienteDetalle_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@idambiente", item.IdAmbiente);
                cmd.Parameters.AddWithValue("@tipocliente", item.TipoCliente1);
                cmd.Parameters.AddWithValue("@costo",item.Costo);
                cmd.Parameters.AddWithValue("@derechocorcho", item.Derechocorcho);
                cmd.Parameters.AddWithValue("@limpieza", item.Limpieza);
                cmd.Parameters.AddWithValue("@garantia", item.Garantia);
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

        public List<AmbienteDetalleEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_AmbienteDetalle_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<AmbienteDetalleEntity> lista = new List<AmbienteDetalleEntity>();

                    while (reader.Read())
                    {
                        AmbienteDetalleEntity item = new AmbienteDetalleEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.NombreTipoCliente1 = reader["NombreTipoCliente"].ToString();
                        item.Costo = Int32.Parse(reader["costo"].ToString());
                        item.Derechocorcho = Int32.Parse(reader["derechocorcho"].ToString());
                        item.Limpieza = Int32.Parse(reader["limpieza"].ToString());
                        item.Garantia = Int32.Parse(reader["garantia"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }
        public string Eliminar(AmbienteDetalleEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_AmbienteDetalle_Eliminar";
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
