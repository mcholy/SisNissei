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
    class InscripcionAlumnoRepository : BaseRepository<InscripcionAlumnoEntity>
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
                cmd.Parameters.AddWithValue("@idcurso", item.Idcurso);
                cmd.Parameters.AddWithValue("@idhorario", item.Idhorario);
                cmd.Parameters.AddWithValue("@idempresa", item.Idempresa);
                cmd.Parameters.AddWithValue("@idperiodo", item.Idperiodo);
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
                        item.Idcurso = Int32.Parse(reader["idcurso"].ToString());
                        item.Nombrecurso = reader["nombrecurso"].ToString();
                        item.Idhorario = Int32.Parse(reader["idhorario"].ToString());
                        item.Nombrehorario = reader["nombrehorario"].ToString();
                        item.Idempresa = Int32.Parse(reader["idempresa"].ToString());
                        item.Nombreempresa = reader["nombreempresa"].ToString();
                        item.Idperiodo = Int32.Parse(reader["idperiodo"].ToString());
                        item.Nombreperiodo = reader["nombreperiodo"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }
        }
    }
}
