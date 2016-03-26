using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace Models.Repositories
{
    class EmpleadoRepository : BaseRepository<EmpleadoEntity>
    {
        public string Guardar(EmpleadoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Empleado_Guardar";
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@paterno", item.Paterno);
                cmd.Parameters.AddWithValue("@materno", item.Materno);
                cmd.Parameters.AddWithValue("@dni", item.Dni);
                cmd.Parameters.AddWithValue("@sueldobase", item.Sueldobase);
                cmd.Parameters.AddWithValue("@idtipoempleado", item.Idtipoempleado);
                cmd.Parameters.AddWithValue("@celular", item.Celular);
                cmd.Parameters.AddWithValue("@telefono", item.Telefono);
                cmd.Parameters.AddWithValue("@direccion", item.Direccion);
                string respuesta = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = reader["respuesta"].ToString();
                }
                return respuesta;

            }
        }


        public List<EmpleadoEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_empleado_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<EmpleadoEntity> lista = new List<EmpleadoEntity>();

                    while (reader.Read())
                    {
                        EmpleadoEntity item = new EmpleadoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Paterno = reader["paterno"].ToString();
                        item.Materno = reader["materno"].ToString();
                        item.Dni = reader["dni"].ToString();
                        item.Celular = reader["direccion"].ToString();
                        item.Telefono = reader["telefono"].ToString();
                        item.Sueldobase = Double.Parse(reader["sueldobase"].ToString());
                        item.Idtipoempleado = Int32.Parse(reader["idtipoempleado"].ToString());
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
