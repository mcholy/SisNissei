using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using Entities;


namespace Models.Repositories
{
    class TipoEmpleadoRepository : BaseRepository<TipoEmpleadoEntity>
    {
        public string Guardar(TipoEmpleadoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEmpleado_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@porcentajemensual", item.Porcentajemensual);
                cmd.Parameters.AddWithValue("@porcentajematricula", item.Porcentajematricula);
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
        public List<TipoEmpleadoEntity> Listar()
        {
            return base.Listar("sis_TipoEmpleado_Listar");
        }
        public List<TipoEmpleadoEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEmpleado_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<TipoEmpleadoEntity> lista = new List<TipoEmpleadoEntity>();

                    while (reader.Read())
                    {
                        TipoEmpleadoEntity item = new TipoEmpleadoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Porcentajematricula = Double.Parse(reader["porcentajematricula"].ToString());
                        item.Porcentajematricula = item.Porcentajematricula * 100;
                        item.Porcentajemensual = Double.Parse(reader["porcentajemensual"].ToString());
                        item.Porcentajemensual = item.Porcentajemensual * 100;
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Estado = Boolean.Parse(reader["estado"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }
        public string Eliminar(TipoEmpleadoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEmpleado_Eliminar";
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
