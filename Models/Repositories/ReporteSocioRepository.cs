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
    public class ReporteSocioRepository : ReporteInscripcionSocioEntity
    {
        
        //DatosSocio ds = new DatosSocio();
        public DatosSocio ReporteSocio(ReporteInscripcionSocioEntity item2)
        {
            DatosSocio ds = new DatosSocio();
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionSocio_Reporte";
                cmd.Parameters.AddWithValue("@id", item2.Id);


                using (var reader = cmd.ExecuteReader())
                {
                    ReporteInscripcionSocioEntity item = new ReporteInscripcionSocioEntity();
                    while (reader.Read())
                    {
                        item.Id = int.Parse(reader["id"].ToString());
                        item.Nombre = reader["Nombre"].ToString();
                        item.Apellidocliente = reader["apellidocliente"].ToString();
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Fechanacimiento = DateTime.Parse(reader["fechanacimiento"].ToString());
                        item.Distrito = reader["distrito"].ToString();
                        item.Direccion = reader["direccion"].ToString();
                        item.Dni = int.Parse(reader["dni"].ToString());
                        item.Trabajo = reader["trabajo"].ToString();
                        item.Cargo = reader["cargo"].ToString();
                        item.Telefono = int.Parse(reader["telefono"].ToString());
                        item.Nombreconyugue = reader["Nombreconyugue"].ToString();
                        item.Hijos = int.Parse(reader["hijos"].ToString());
                        item.Hijosmayores = int.Parse(reader["Hijosmayores"].ToString());
                        item.Hijosmenores = int.Parse(reader["hijosmenores"].ToString());
                        item.Familiarjapon = int.Parse(reader["Familiarjapon"].ToString());
                        item.Familiareeuu = int.Parse(reader["Familiareeuu"].ToString());
                        item.Familiaritalia = int.Parse(reader["familiaritalia"].ToString());
                        item.Familiarotros = int.Parse(reader["familiarotros"].ToString());
                        item.Fecharegistro2 = reader["Fecharegistro2"].ToString();
                        item.Nombrepatrocinador = reader["nombrepatrocinador"].ToString();

                    }

                    ds.Tables["TablaSocio"].Rows.Add(new Object[] {item.Id,item.Nombre , item.Apellidocliente,item.Nombrecliente,item.Fechanacimiento,item.Distrito,item.Direccion,
                    item.Dni,item.Trabajo,item.Cargo,item.Telefono,item.Nombreconyugue,item.Hijos
                    ,item.Hijosmayores,item.Hijosmenores,item.Familiarjapon,item.Familiareeuu,item.Familiaritalia,item.Familiarotros,item.Fecharegistro2,item.Nombrepatrocinador});

                }
               
                return ds;
            }
        }
    }
}

        
      