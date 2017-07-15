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
    public class EgresoRepository:BaseRepository<EgresoEntity>
    {
        public string Guardar(EgresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Egreso_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@idtipoegreso", item.Idtipoegreso);
                cmd.Parameters.AddWithValue("@idempleado", item.Idempleado);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@detalle", item.Detalle);
                cmd.Parameters.AddWithValue("@monto", item.Monto);
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
        public List<EgresoEntity> Detalle(int idtipoegreso)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Egreso_Detalle";
                cmd.Parameters.AddWithValue("@idtipoegreso", idtipoegreso);

                using (var reader = cmd.ExecuteReader())
                {
                    List<EgresoEntity> lista = new List<EgresoEntity>();

                    while (reader.Read())
                    {
                        EgresoEntity item = new EgresoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Idempleado = Int32.Parse(reader["idempleado"].ToString());
                        item.Nombreempleado = reader["nombreempleado"].ToString();
                        item.Idtipoegreso = Int32.Parse(reader["idtipoegreso"].ToString());
                        item.Tipoegreso =reader["tipoegreso"].ToString();
                        item.Detalle = reader["detalle"].ToString();
                        item.Monto = Double.Parse(reader["monto"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }

        public string Eliminar(EgresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Egreso_Eliminar";
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
