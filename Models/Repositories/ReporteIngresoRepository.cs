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
    public class ReporteIngresoRepository:ReporteIngresoEntity
    {
        public DatosIngreso ReporteIngreso(ReporteIngresoEntity item2)
        {
            DatosIngreso dai = new DatosIngreso();
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Ingreso_Reporte";
                cmd.Parameters.AddWithValue("@id", item2.Id);
                using (var reader = cmd.ExecuteReader())
                {

                    ReporteIngresoEntity item = new ReporteIngresoEntity();
                    while (reader.Read())
                    {
                        item.Id = int.Parse(reader["id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Nombretipocomprobante = reader["nombretipocomprobante"].ToString();
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Dni = reader["dni"].ToString();
                        item.Direccion = reader["direccion"].ToString();
                        item.Fechapago = reader["fechapago"].ToString();
                        item.Detallepago = reader["detallepago"].ToString();
                        item.Detallemonto = reader["detallemonto"].ToString();
                        item.Montototal = reader["montototal"].ToString();

                        dai.Tables["TablaIngreso"].Rows.Add(new Object[] { item.Id, item.Nombre, item.Nombretipocomprobante, item.Nombrecliente ,
                        item.Dni,item.Direccion,item.Fechapago,item.Detallepago,item.Detallemonto,item.Montototal});
                    }

                }
                return dai;
            }

        }
    }
}
