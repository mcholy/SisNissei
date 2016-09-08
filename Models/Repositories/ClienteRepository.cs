using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace Models.Repositories
{
    public class ClienteRepository : BaseRepository<ClienteEntity>
    {
        public string Guardar(ClienteEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Cliente_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@paterno", item.Paterno);
                cmd.Parameters.AddWithValue("@materno", item.Materno);
                cmd.Parameters.AddWithValue("@dni", item.Dni);
                cmd.Parameters.AddWithValue("@sexo", item.Sexo);
                cmd.Parameters.AddWithValue("@idapoderado", item.Idapoderado);
                cmd.Parameters.AddWithValue("@iddistrito", item.Iddistrito);
                cmd.Parameters.AddWithValue("@fechanacimiento", item.Fechanacimiento);
                cmd.Parameters.AddWithValue("@celular", item.Celular);
                cmd.Parameters.AddWithValue("@telefono", item.Telefono);
                cmd.Parameters.AddWithValue("@direccion", item.Direccion);
                cmd.Parameters.AddWithValue("@alergia", item.Alergia);
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
        public List<ClienteEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Cliente_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<ClienteEntity> lista = new List<ClienteEntity>();

                    while (reader.Read())
                    {
                        ClienteEntity item = new ClienteEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Paterno = reader["paterno"].ToString();
                        item.Materno = reader["materno"].ToString();
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Dni =Int32.Parse(reader["dni"].ToString());
                        item.Sexo=Boolean.Parse(reader["sexo"].ToString());
                        item.Nombresexo = reader["nombresexo"].ToString();
                        item.Idapoderado = Int32.Parse(reader["idapoderado"].ToString());
                        item.Nombreapoderado = reader["nombreapoderado"].ToString();
                        item.Fechanacimiento = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Iddistrito = Int32.Parse(reader["iddistrito"].ToString());
                        item.Nombredistrito = reader["nombredistrito"].ToString();
                        item.Celular = Int32.Parse(reader["celular"].ToString());
                        item.Telefono = Int32.Parse(reader["telefono"].ToString());
                        item.Direccion = reader["direccion"].ToString();
                        item.Alergia = reader["alergia"].ToString();
                        lista.Add(item);
                                              
                    }
                    return lista;
                }

            }

        }


        public string Eliminar(ClienteEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Cliente_Eliminar";
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
