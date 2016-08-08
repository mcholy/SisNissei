using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities;
using System.Data.Entity;


namespace Models.Repositories
{
    public class BaseDetalleRepository<TEntity> : DbContext where TEntity : BaseDetalleEntity, new()
    {
        protected virtual List<TEntity> Listar(string Procedimiento)
        {

            using (var conn = new SqlConnection(Models.Global_Variables.Connection.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Procedimiento;

                using (var reader = cmd.ExecuteReader())
                {
                    List<TEntity> lista = new List<TEntity>();
                    lista.Add(new TEntity() { Id = 0});

                    while (reader.Read())
                    {
                        TEntity itemdetalle = new TEntity();
                        itemdetalle .Id = Int32.Parse(reader["Id"].ToString());
                        lista.Add(itemdetalle);
                    }
                    return lista;
                }
            }
        }
    }
}
