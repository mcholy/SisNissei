using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace Models.Repositories
{
    public class IngresoRepository:BaseRepository<IngresoEntity>
    {
        public string DatosFacDir(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sis_inscripciondatos";

                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                string direccion = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    direccion = reader["direccion"].ToString();
                }
                return direccion;
            }

        }
        public string DatosFacDni(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sis_inscripciondatos";

                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                string dni = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    dni = reader["dni"].ToString();
                }
                return dni;
            }

        }
        public List<IngresoEntity> ListarTipoIngreso()
        {
            return base.Listar("sis_TipoIngreso");
        }

        public List<IngresoEntity> PagosPendientes(int idCliente, int idTipoIngreso, int nropago)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                switch (idTipoIngreso)
                {
                    case 1:
                    cmd.CommandText = "sis_IngresoPagosPendientesSocio";
                    break;
                    case 2:
                    cmd.CommandText = "sis_IngresoPagosPendientesAlumno";
                    break;
                    case 3:
                    cmd.CommandText = "sis_IngresoPagosPendientesAlquiler";
                    break;
                }

                cmd.Parameters.AddWithValue("@idcliente", idCliente);
                cmd.Parameters.AddWithValue("@idtipoingreso", idTipoIngreso);
                cmd.Parameters.AddWithValue("@nropago", nropago);
                //cmd.Parameters.AddWithValue("@valor",valor);
                using (var reader = cmd.ExecuteReader())
                {
                    List<IngresoEntity> lista = new List<IngresoEntity>();

                    while (reader.Read())
                    {
                        IngresoEntity item = new IngresoEntity();


                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Monto =Double.Parse(reader["montopagar"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }
        }

    }
}
