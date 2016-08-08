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
    public class InscripcionAlumnoRepository : BaseRepository<InscripcionAlumnoEntity>
    {
        public string Guardar(InscripcionAlumnoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlumno_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                cmd.Parameters.AddWithValue("@idapoderado", item.Idapoderado);
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
        public string Eliminar(InscripcionAlumnoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlumno_Eliminar";
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
        public string Codigo(InscripcionAlumnoEntity item)
        { using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlumno_Codigo";
                
                string codigo = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codigo = reader["Codigo"].ToString();
                }
                return codigo;
            }
        }

        public List<InscripcionAlumnoEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlumno_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<InscripcionAlumnoEntity> lista = new List<InscripcionAlumnoEntity>();

                    while (reader.Read())
                    {
                        InscripcionAlumnoEntity item = new InscripcionAlumnoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Idcliente = Int32.Parse(reader["idcliente"].ToString());
                        item.Nombrecliente=reader["nombrecliente"].ToString();
                        item.Idapoderado = Int32.Parse(reader["idapoderado"].ToString());
                        item.Nombreapoderado = reader["nombreapoderado"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }
        }

    }
}
