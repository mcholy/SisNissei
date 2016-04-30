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
    public class InscripcionSocioRepository:BaseRepository<InscripcionSocioEntity>
    {
        public string Guardar(InscripcionSocioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionSocio_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                cmd.Parameters.AddWithValue("@idconyugue", item.Idconyugue);
                cmd.Parameters.AddWithValue("@idpatrocinador", item.Idpatrocinador);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@trabajo", item.Trabajo);
                cmd.Parameters.AddWithValue("@cargo", item.Cargo);
                cmd.Parameters.AddWithValue("@hijosmayores", item.Hijosmayores);
                cmd.Parameters.AddWithValue("@hijosmenores", item.Hijosmenores);
                cmd.Parameters.AddWithValue("@familiarjapon", item.Familiarjapon);
                cmd.Parameters.AddWithValue("@familiareeuu", item.Familiareeuu);
                cmd.Parameters.AddWithValue("@familiaritalia", item.Familiaritalia);
                cmd.Parameters.AddWithValue("@familiarotros", item.Familiarotros);
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
        public List<InscripcionSocioEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionSocio_Detalle";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<InscripcionSocioEntity> lista = new List<InscripcionSocioEntity>();

                    while (reader.Read())
                    {
                        InscripcionSocioEntity item = new InscripcionSocioEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Idcliente = Int32.Parse(reader["idcliente"].ToString());
                        item.Idconyugue = Int32.Parse(reader["idconyugue"].ToString());
                        item.Idpatrocinador = Int32.Parse(reader["idpatrocinador"].ToString());
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Nombreconyugue = reader["nombreconyugue"].ToString();
                        item.Nombrepatrocinador = reader["nombrepatrocinador"].ToString();
                        item.Trabajo = reader["trabajo"].ToString();
                        item.Cargo = reader["cargo"].ToString();
                        item.Hijosmayores = Int32.Parse(reader["hijosmayores"].ToString());
                        item.Hijosmenores = Int32.Parse(reader["hijosmenores"].ToString());
                        item.Familiarjapon = Int32.Parse(reader["familiarjapon"].ToString());
                        item.Familiareeuu = Int32.Parse(reader["familiareeuu"].ToString());
                        item.Familiaritalia = Int32.Parse(reader["familiaritalia"].ToString());
                        item.Familiarotros = Int32.Parse(reader["familiarotros"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }

        }


        public string Eliminar(InscripcionSocioEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionSocio_Eliminar";
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
