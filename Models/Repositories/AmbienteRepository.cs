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
    public class AmbienteRepository : BaseRepository<AmbienteEntity>
    {
        public string Guardar(AmbienteEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ambiente_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@Costo", item.Costo);
                cmd.Parameters.AddWithValue("@tipocliente", item.Tipocliente);
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
        public List<AmbienteEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ambiente_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<AmbienteEntity> lista = new List<AmbienteEntity>();

                    while (reader.Read())
                    {
                        AmbienteEntity item = new AmbienteEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Costo = Double.Parse(reader["Costo"].ToString());
                        item.Nombretipocliente = reader["nombretipocliente"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }


        public string Eliminar(AmbienteEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ambiente_Eliminar";
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

        public List<AmbienteEntity> Listar(int idActual)
        {
            using (var conn=new SqlConnection (Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ambiente_Listar";
                cmd.Parameters.AddWithValue("@idActual", idActual);
                using (var reader = cmd.ExecuteReader())
                {
                    List<AmbienteEntity> lista = new List<AmbienteEntity>();
                    while (reader.Read())
                    {
                        AmbienteEntity item = new AmbienteEntity();
                        item.Id=Int32.Parse(reader["id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        lista.Add(item);

                    }
                    return lista;
                }
            }
           
        }
    }
}
