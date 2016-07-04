using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;


namespace Models.Repositories
{
    public class TipoInscripcionSocioRepository:BaseRepository<TipoInscripcionSocioEntity>
    {
        public string Guardar(TipoInscripcionSocioEntity item)
        {
            using (var conn=new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd=conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandText="sis_TipoInscripcionSocio_Guardar";
                cmd.Parameters.AddWithValue("@id",item.Id);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                cmd.Parameters.AddWithValue("@costo", item.Costo);
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
        public string Eliminar(TipoInscripcionSocioEntity item)
        {
            using (var conn=new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoInscripcionSocio_Eliminar";
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

        

        public List<TipoInscripcionSocioEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_TipoInscripcionSocio_Detalle";
                using (var reader = cmd.ExecuteReader())
                {
                    List<TipoInscripcionSocioEntity> lista = new List<TipoInscripcionSocioEntity>();
                    while (reader.Read())
                    {
                        TipoInscripcionSocioEntity item = new TipoInscripcionSocioEntity();
                        item.Id = Int32.Parse(reader["id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Costo = Double.Parse(reader["costo"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }
            }
        }
        public List<TipoInscripcionSocioEntity> Listar()
        {
            return base.Listar("sis_TipoInscripcionSocio_Listar");
        }
    }
}
