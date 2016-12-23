using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Models.Repositories
{
    public class ReporteAlquilerRepository:ReporteInscripcionAlquilerEntity
    {
        public DatosAlquiler ReporteAlquiler(ReporteInscripcionAlquilerEntity item2)
        {
            DatosAlquiler dal = new DatosAlquiler();
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionAlquiler_Reporte";
                cmd.Parameters.AddWithValue("@id", item2.Id);
                using (var reader = cmd.ExecuteReader())
                {

                    ReporteInscripcionAlquilerEntity item = new ReporteInscripcionAlquilerEntity();
                    while (reader.Read())
                    {
                        item.Id = int.Parse(reader["id"].ToString());
                        item.Nombre=reader["nombre"].ToString();
                        item.Fechadia = reader["fechadia"].ToString();
                        item.Nombrecompleto = reader["nombrecompleto"].ToString();
                        item.Dni = int.Parse(reader["dni"].ToString());
                        item.Direccion = reader["direccion"].ToString();
                        item.Telefono = int.Parse(reader["telefono"].ToString());
                        item.Celular = int.Parse(reader["celular"].ToString());
                        item.Ambiente = reader["ambiente"].ToString();
                        item.Inicioalquilerdia = reader["inicioalquilerdia"].ToString();
                        item.Inicioalquilerhora = reader["inicioalquilerhora"].ToString();
                        item.Finalalquilerdia = reader["finalalquilerdia"].ToString();
                        item.Finalalquilerhora = reader["finalalquilerhora"].ToString();
                        item.Nombregarante = reader["nombregarante"].ToString();
                        item.Dnigarante = int.Parse(reader["dnigarante"].ToString());
                        item.Tipoevento = reader["tipoevento"].ToString();
                        item.Salonactos = reader["salonactos"].ToString();
                        item.Campodeportivo = reader["campodeportivo"].ToString();
                        item.Garantiaporambiente = reader["garantia"].ToString();
                        item.Derechocorcho = reader["derechocorcho"].ToString();
                        item.Derecholimpieza = reader["limpieza"].ToString();
                        item.Acuenta = reader["acuenta"].ToString();
                        item.Saldo = reader["saldo"].ToString();
                        dal.Tables["TablaAlquiler"].Rows.Add(new Object[] { item.Id, item.Nombre, item.Fechadia,item.Nombre, item.Nombrecompleto, 
                        item.Dni,item.Direccion,item.Telefono,item.Celular,item.Ambiente});
                    }

                }
                return dal;
            }

        }
    }
}
