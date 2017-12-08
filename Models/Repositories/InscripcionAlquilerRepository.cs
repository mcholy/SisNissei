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
    public class InscripcionAlquilerRepository:BaseRepository<InscripcionAlquilerEntity>
    {
        public string Guardar(InscripcionAlquilerEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlquiler_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                cmd.Parameters.AddWithValue("@idgarante", item.Idgarante);
                cmd.Parameters.AddWithValue("@tipoevento", item.Tipoevento);
                cmd.Parameters.AddWithValue("@fechahorainicio", item.Horainicio);
                cmd.Parameters.AddWithValue("@fechahorafin", item.Horafin);

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
        public string Eliminar(InscripcionAlquilerEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlquiler_Eliminar";
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
        public string Codigo(InscripcionAlquilerEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlquiler_Codigo";

                string codigo = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codigo = reader["Codigo"].ToString();
                }
                return codigo;
            }
        }
        public List<InscripcionAlquilerEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlquiler_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<InscripcionAlquilerEntity> lista = new List<InscripcionAlquilerEntity>();

                    while (reader.Read())
                    {
                        InscripcionAlquilerEntity item = new InscripcionAlquilerEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Idcliente = Int32.Parse(reader["idcliente"].ToString());
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Idgarante = Int32.Parse(reader["idgarante"].ToString());
                        item.Nombregarante = reader["nombregarante"].ToString();
                                             
                        item.Fechainicioalquiler = reader["fechahorainicio"].ToString();
                        item.Tipoevento = reader["tipoevento"].ToString();
                        item.Fechafinalquiler = reader["fechahorafin"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }
        }
    }
}
