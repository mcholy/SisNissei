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
    public class ReporteAlumnoRepository:ReporteInscripcionAlumnoEntity
    {
        public DatosAlumno ReporteAlumno(ReporteInscripcionAlumnoEntity item2)
        {
            DatosAlumno da = new DatosAlumno();
            using(var conn=new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
              
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_InscripcionALumno_Reporte";
                cmd.Parameters.AddWithValue("@id", item2.Id);
                using (var reader = cmd.ExecuteReader())
                {
                  
                    ReporteInscripcionAlumnoEntity item = new ReporteInscripcionAlumnoEntity();
                    while (reader.Read())
                    {
                        item.Id = int.Parse(reader["id"].ToString());
                        item.Nombre = reader["nombre"].ToString();
                        item.Apellidocliente = reader["apellidocliente"].ToString();
                        item.Nombrecliente = reader["nombrecliente"].ToString();
                        item.Fechadenacimiento = reader["fechanacimiento"].ToString();
                        item.Distrito1 = reader["distrito"].ToString();
                        item.Direccion = reader["direccion"].ToString();
                        item.Dni = reader["dni"].ToString();
                        item.Nombreapoderado = reader["nombreapoderado"].ToString();
                        item.Curso = reader["curso"].ToString();
                        item.Empresa = reader["empresa"].ToString();
                        item.Horario = reader["horario"].ToString();
                        item.Periodo = reader["periodo"].ToString();
                        item.Fechaincripcioncurso = reader["fechainscripcioncurso"].ToString();
                        item.Fechadia = reader["fechadia"].ToString();
                        da.Tables["TablaAlumno"].Rows.Add(new Object[] {item.Id,item.Nombre,item.Apellidocliente,
                        item.Nombrecliente,item.Fechadenacimiento,item.Distrito1,item.Direccion,item.Dni,
                        item.Nombreapoderado,item.Curso,item.Horario,item.Empresa,item.Periodo,item.Fechaincripcioncurso,item.Fechadia});
                    }
                   
                }
                return da;
            }
        
        }
    }
}
