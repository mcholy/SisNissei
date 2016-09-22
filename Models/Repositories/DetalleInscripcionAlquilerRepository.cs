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
    public class DetalleInscripcionAlquilerRepository : BaseDetalleRepository<DetalleInscripcionAlquilerEntity>
    {
        public string Guardar(DetalleInscripcionAlquilerEntity itemdetalle)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleInscripcionAlquiler_Guardar";
                cmd.Parameters.AddWithValue("@id", itemdetalle.Id);
                cmd.Parameters.AddWithValue("@idalquiler", itemdetalle.Idalquiler);
                cmd.Parameters.AddWithValue("@idambientes", itemdetalle.Idambientes);
                cmd.Parameters.AddWithValue("@costo", itemdetalle.Costos);

                cmd.Parameters.AddWithValue("@regmoddetalle", itemdetalle.Regmoddetalle);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                }
                return respuesta;
            }
        }

        public string Eliminar(DetalleInscripcionAlquilerEntity itemdetalle)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleInscripcionAlquiler_Eliminar";
                cmd.Parameters.AddWithValue("@id", itemdetalle.Id);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                }
                return respuesta;
            }
        }

        public List<DetalleInscripcionAlquilerEntity> Detalle(int idActual)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sis_DetalleInscripcionAlquiler_Detalle";

                cmd.Parameters.AddWithValue("@idactual", idActual);
                //cmd.Parameters.AddWithValue("@valor",valor);
                using (var reader = cmd.ExecuteReader())
                {
                    List<DetalleInscripcionAlquilerEntity> lista = new List<DetalleInscripcionAlquilerEntity>();

                    while (reader.Read())
                    {
                        DetalleInscripcionAlquilerEntity itemdetalle = new DetalleInscripcionAlquilerEntity();


                        itemdetalle.Id = Int32.Parse(reader["Id"].ToString());
                        itemdetalle.Idalquiler = Int32.Parse(reader["idalquiler"].ToString());
                        itemdetalle.Idambientes = Int32.Parse(reader["idambientes"].ToString());
                        itemdetalle.Costos = Double.Parse(reader["costos"].ToString());

                        itemdetalle.Nombreambientes = reader["nombreambientes"].ToString();

                        lista.Add(itemdetalle);
                    }
                    return lista;
                }


            }

        }
    }
}
