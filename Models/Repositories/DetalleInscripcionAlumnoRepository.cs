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
    public class DetalleInscripcionAlumnoRepository : BaseDetalleRepository<DetalleInscripcionAlumnoEntity>
    {
        public string Guardar(DetalleInscripcionAlumnoEntity itemdetalle)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleInscripcionAlumno_Guardar";
                cmd.Parameters.AddWithValue("@id", itemdetalle.Id);
                cmd.Parameters.AddWithValue("@idactual", itemdetalle.Idinscripcionalumno);
                cmd.Parameters.AddWithValue("@idcurso", itemdetalle.Idcurso);
                cmd.Parameters.AddWithValue("@idhorario", itemdetalle.Idhorario);
                cmd.Parameters.AddWithValue("@idempresa", itemdetalle.Idempresa);
                cmd.Parameters.AddWithValue("@idperiodo", itemdetalle.Idperiodo);
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

        public string Eliminar(DetalleInscripcionAlumnoEntity itemdetalle)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleInscripcionAlumno_Eliminar";
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
        public List<DetalleInscripcionAlumnoEntity> Detalle(int idActual)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sis_DetalleInscripcionAlumno_Detalle";

                cmd.Parameters.AddWithValue("@idactual", idActual);
                //cmd.Parameters.AddWithValue("@valor",valor);
                using (var reader = cmd.ExecuteReader())
                {
                    List<DetalleInscripcionAlumnoEntity> lista = new List<DetalleInscripcionAlumnoEntity>();

                    while (reader.Read())
                    {
                        DetalleInscripcionAlumnoEntity itemdetalle = new DetalleInscripcionAlumnoEntity();
                        
                        
                        itemdetalle.Id = Int32.Parse(reader["Id"].ToString());
                        itemdetalle.Nombrecurso = reader["nombrecurso"].ToString();
                        itemdetalle.Idcurso = Int32.Parse(reader["idcurso"].ToString());
                        itemdetalle.Nombrehorario = reader["nombrehorario"].ToString();
                        itemdetalle.Idhorario=Int32.Parse(reader["idhorario"].ToString());
                        itemdetalle.Nombreempresa = reader["nombreempresa"].ToString();
                        itemdetalle.Idempresa=Int32.Parse(reader["idempresa"].ToString());
                        itemdetalle.Nombreperiodo = reader["nombreperiodo"].ToString();
                        itemdetalle.Idperiodo=Int32.Parse(reader["idperiodo"].ToString());
                        lista.Add(itemdetalle);
                    }
                    return lista;
                }

            }
        }
    }
}
