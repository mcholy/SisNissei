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
    class TipoEmpleadoRepository : DbContext
    {
        public string Guardar(TipoEmpleadoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoEmpleado_Guardar";
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@porcentajemensual", item.Porcentajemensual);
                cmd.Parameters.AddWithValue("@porcentajematricula", item.Porcentajematricula);
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
