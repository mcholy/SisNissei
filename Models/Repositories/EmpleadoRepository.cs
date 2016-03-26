using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace Models.Repositories
{
    class EmpleadoRepository:BaseRepository<EmpleadoEntity>
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
    }
}
