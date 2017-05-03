using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities;
namespace Models.Repositories
{
    public class ReporteAlumnosRepository
    {
        public List<ReporteAlumnosEntity> Detalle(ReporteAlumnosEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_Reporte_Alumnos";
                cmd.Parameters.AddWithValue("@mes", item.Mespago);
                cmd.Parameters.AddWithValue("@idcurso", item.Idcurso);
                cmd.Parameters.AddWithValue("@idperiodo", item.Idperiodo);

                using (var reader = cmd.ExecuteReader())
                {
                    List<ReporteAlumnosEntity> lista = new List<ReporteAlumnosEntity>();

                    while (reader.Read())
                    {
                        ReporteAlumnosEntity item2 = new ReporteAlumnosEntity();
                        item2.Nombrecliente = reader["nombrecliente"].ToString();
                        item2.Curso = reader["Curso"].ToString();
                        item2.Periodo = reader["Periodo"].ToString();
                        item2.Iniciocurso = reader["iniciocurso"].ToString();
                        item2.Pagoporcancelar = Int32.Parse(reader["pagoporcancelar"].ToString());
                        item2.Pagorealziado = Int32.Parse(reader["pagorealizado"].ToString());
                        item2.Totalpagoshacer = Int32.Parse(reader["totalpagoshacer"].ToString());
                        item2.Estadopago=reader["estadopago"].ToString();
                        lista.Add(item2);

                    }
                    return lista;
                }

            }

        }
    }
}
