using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace Models.Repositories
{
    public class HorarioRepository : BaseRepository<HorarioEntity>
    {
        private ResultadoEntity resultado;
        public ResultadoEntity Guardar(HorarioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Horario_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@idcurso", item.Idcurso);
                cmd.Parameters.AddWithValue("@idgrupoetario", item.Idgrupoetario);
                cmd.Parameters.AddWithValue("@fechainicio", item.Fechainicio);
                cmd.Parameters.AddWithValue("@duracion", item.Duracion);
                cmd.Parameters.AddWithValue("@regmod", item.Regmod);
                resultado = new ResultadoEntity();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultado.Id = Int32.Parse(reader["Id"].ToString());
                    resultado.Respuesta = reader["respuesta"].ToString();


                }
                return resultado;
            }
        }
        public ResultadoEntity GuardarDetalle(HorarioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleHorario_Guardar";
                cmd.Parameters.AddWithValue("@id", item.IdHorario);
                cmd.Parameters.AddWithValue("@idhorario", item.IdHorario);
                cmd.Parameters.AddWithValue("@hora", item.Hora);
                cmd.Parameters.AddWithValue("@dia", item.Dia);
                //cmd.Parameters.AddWithValue("@regmod", item.Regmod);
                resultado = new ResultadoEntity();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultado.Respuesta = reader["respuesta"].ToString();
                }
                return resultado;
            }
        }
        public List<HorarioEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Horario_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<HorarioEntity> lista = new List<HorarioEntity>();

                    while (reader.Read())
                    {
                        HorarioEntity item = new HorarioEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Idcurso = Int32.Parse(reader["idcurso"].ToString());
                        item.Nombrecurso = reader["nombrecurso"].ToString();
                        item.Idgrupoetario = Int32.Parse(reader["idgrupoetario"].ToString());
                        item.Nombregrupoetario = reader["nombregrupoetario"].ToString();
                        item.Duracion = Int32.Parse(reader["duracion"].ToString());
                        item.Fechainicio = DateTime.Parse(reader["fechainicio"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Estado = Boolean.Parse(reader["estado"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }

        public List<HorarioEntity> DetalleHorario_Detalle(int id)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_DetalleHorario_Detalle";
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    List<HorarioEntity> lista = new List<HorarioEntity>();

                    while (reader.Read())
                    {
                        HorarioEntity item = new HorarioEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Dia = reader["dia"].ToString();
                        item.Hora = reader["hora"].ToString();
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        item.Estado = Boolean.Parse(reader["estado"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }

        public ResultadoEntity Eliminar(HorarioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Horario_Eliminar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                resultado = new ResultadoEntity();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultado.Respuesta = reader["respuesta"].ToString();
                }
                return resultado;
            }
        }
        public List<HorarioEntity> Listar(int idcurso)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_HorarioEtario_Listar";
                cmd.Parameters.AddWithValue("@idcurso",idcurso);

                using (var reader = cmd.ExecuteReader())
                {
                    List<HorarioEntity> lista = new List<HorarioEntity>();

                    while (reader.Read())
                    {
                        HorarioEntity item = new HorarioEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }

    }
}