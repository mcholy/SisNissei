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
    public class IngresoRepository : BaseRepository<IngresoEntity>
    {
        private ResultadoEntity resultado;
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
        public string Codigo(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ingreso_Codigo";

                string codigo = "";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codigo = reader["Codigo"].ToString();
                }
                return codigo;
            }
        }
        public List<IngresoEntity> PagosPendientes(int idCliente, int idTipoIngreso, int nropago, int idCurso)
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
                cmd.Parameters.AddWithValue("@idcurso", idCurso);
                //cmd.Parameters.AddWithValue("@valor",valor);
                using (var reader = cmd.ExecuteReader())
                {
                    List<IngresoEntity> lista = new List<IngresoEntity>();

                    while (reader.Read())
                    {
                        IngresoEntity item = new IngresoEntity();


                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Monto = Double.Parse(reader["montopagar"].ToString());
                        lista.Add(item);
                    }
                    return lista;
                }

            }
        }
        public ResultadoEntity Guardar(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ingreso_Guardar";
                cmd.Parameters.AddWithValue("@idcliente", item.Idcliente);
                cmd.Parameters.AddWithValue("@nombrerecibo", item.Nombre);
                cmd.Parameters.AddWithValue("@tipocomprobante", item.Tipocomprobante);
                cmd.Parameters.AddWithValue("@montototal", item.Monto);

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


        public ResultadoEntity GuardarDetalle(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_IngresoDetalle_Guardar";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@idregistro", item.Idfactura);
                cmd.Parameters.AddWithValue("@nombreoperaciondetalle", item.Nombre);
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

        public ResultadoEntity GuadarPagoPendiente(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_PagoPendienteGuarda";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@monto", item.Monto);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
                resultado = new ResultadoEntity();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultado.Respuesta = reader["respuesta"].ToString();
                }
                return resultado;
            }


        }
        public ResultadoEntity GuardarAdelanto(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_AdelantoGuarda";
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@monto", item.Monto);
                cmd.Parameters.AddWithValue("@nombre", item.Nombre);
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
        public ResultadoEntity EliminarPagoPendiente(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_PagoPendienteEliminar";
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



        public List<IngresoEntity> Detalle()
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ingreso_Listar";
                //cmd.Parameters.AddWithValue("@valor",valor);

                using (var reader = cmd.ExecuteReader())
                {
                    List<IngresoEntity> lista = new List<IngresoEntity>();

                    while (reader.Read())
                    {
                        IngresoEntity item = new IngresoEntity();
                        item.Id = Int32.Parse(reader["Id"].ToString());
                        item.Nombreusuario = reader["nombrecliente"].ToString();
                        item.Nombrerecibo = reader["nombrerecibo"].ToString();
                        item.Nombre = reader["nombreoperaciondetalle"].ToString();
                        item.Monto = Double.Parse(reader["montototal"].ToString());
                        item.Fecharegistro = DateTime.Parse(reader["fecharegistro"].ToString());
                        lista.Add(item);

                    }
                    return lista;
                }

            }

        }

        public string Eliminar(IngresoEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ingreso_Eliminar";
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
