using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace Models.Repositories
{
    public class PagoProfesoresRepository
    {
        public List<PagoProfesoresEntity> Detalle(PagoProfesoresEntity item)
        {
            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sis_PagoProfesores_Detalle";
                cmd.Parameters.AddWithValue("@mes", item.Mespago);
                cmd.Parameters.AddWithValue("@idcurso", item.Idcurso);
                cmd.Parameters.AddWithValue("@idperiodo", item.Idperiodo);

                using (var reader = cmd.ExecuteReader())
                {
                    List<PagoProfesoresEntity> lista = new List<PagoProfesoresEntity>();

                    while (reader.Read())
                    {
                        PagoProfesoresEntity item2 = new PagoProfesoresEntity();
                        item2.Id = Int32.Parse(reader["Id"].ToString());
                        item2.Curso = reader["curso"].ToString();
                        item2.Idempleado = Int32.Parse(reader["idempleado"].ToString());
                        item2.Nombre = reader["empleado"].ToString();
                        item2.Pagarxmatricula = reader["pagar_x_matricula"].ToString();
                        item2.Ingresxmatricula = reader["ingreso_x_matricula"].ToString();
                        item2.Pagarxmensualidad = reader["pagar_x_mensualidad"].ToString();
                        item2.Ingresoxmensualidad = reader["ingreso_x_mensualidad"].ToString();
                        item2.Totalingreso = reader["Total_ingreso"].ToString();

                        item2.Montopagar = reader["Total_Pagar"].ToString();
                        lista.Add(item2);

                    }
                    return lista;
                }

            }

        }
    }
}
