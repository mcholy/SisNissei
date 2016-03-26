using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using Microsoft.Office.Tools;
namespace Buro_CRM.Models
{

    public class ConfiguracionSolicitudModels : DbContext
    {
        string id_usr;
        public ConfiguracionSolicitudModels(string id_usuario)
            : base("BURO_CRM")
        {
            id_usr = id_usuario;
        }

        public ResultModels Get_list_Camp(string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SOL_CALLCENTER_listar_Campanias";
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                ResultModels obj = null;
                List<SOL_CAMPANIA> ress_usr = new List<SOL_CAMPANIA>();
                using (var reader = cmd.ExecuteReader())
                {

                    SOL_CAMPANIA usr = null;
                    while (reader.Read())
                    {
                        usr = new SOL_CAMPANIA(reader["ID"].ToString(), reader["Campania"].ToString(), reader["IsAddVenta"].ToString(), reader["Estado"].ToString());
                        ress_usr.Add(usr);
                    }

                }
                obj = new ResultModels
                {
                    Message = "",
                    Result = "1",
                    data = ress_usr
                };
                return obj;
            }
        }
        public ResultModels Get_list_Form(string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Conf_Form_listar_Formulario";
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                ResultModels obj = null;
                List<SOL_FORMULARIO> ress_usr = new List<SOL_FORMULARIO>();
                using (var reader = cmd.ExecuteReader())
                {

                    SOL_FORMULARIO usr = null;
                    while (reader.Read())
                    {
                        usr = new SOL_FORMULARIO(reader["ID_form"].ToString(), reader["Nombre_form"].ToString(), reader["codigo_form"].ToString(), reader["Estado"].ToString());
                        ress_usr.Add(usr);
                    }

                }
                obj = new ResultModels
                {
                    Message = "",
                    Result = "1",
                    data = ress_usr
                };
                return obj;
            }
        }

        public ResultModels Set_Form(string id_form, string form, string idbc, string id_form_old)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Conf_Form_set_Form";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_form", id_form);
                cmd.Parameters.AddWithValue("@id_form_old", id_form_old);
                cmd.Parameters.AddWithValue("@form", form);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                //cmd.Parameters.AddWithValue("@isAddVenta", isAddVenta);

                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Form"].ToString()
                    };
                }

                return obj;
            }
        }

        public ResultModels Set_Camp(string id_camp, string camp, string idbc, string id_camp_old, string isAddVenta)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SOL_CALLCENTER_set_Campania";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_camp", id_camp);
                cmd.Parameters.AddWithValue("@id_camp_old", id_camp_old);
                cmd.Parameters.AddWithValue("@camp", camp);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                cmd.Parameters.AddWithValue("@isAddVenta", isAddVenta);

                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Camp"].ToString()
                    };
                }

                return obj;
            }
        }
        public ResultModels Del_Camp(string id_camp, string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SOL_CALLCENTER_del_Campania";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_camp", id_camp);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Camp"].ToString()
                    };
                }

                return obj;
            }
        }

        public ResultModels Del_Form(string id_form, string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Conf_Form_del_Formulario";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_form", id_form);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Form"].ToString()
                    };
                }

                return obj;
            }
        }

        public ResultModels update_Camp(string id_camp, string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SOL_CALLCENTER_UPDATE_Campania";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_camp", id_camp);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Camp"].ToString()
                    };
                }

                return obj;
            }
        }

        public ResultModels update_Form(string id_form, string idbc)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString))
            using (var conn = new SqlConnection(Buro_CRM.variables_globales.VarConfig.getCadenaConexion()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Conf_Form_UPDATE_Formulario";
                cmd.Parameters.AddWithValue("@id_user", id_usr);
                cmd.Parameters.AddWithValue("@id_form", id_form);
                cmd.Parameters.AddWithValue("@id_uunn", idbc);
                var reader = cmd.ExecuteReader();
                ResultModels obj = null;
                while (reader.Read())
                {
                    obj = new ResultModels
                    {
                        Message = reader["msj"].ToString(),
                        Result = reader["Indica"].ToString(),
                        data = reader["ID_Form"].ToString()
                    };
                }

                return obj;
            }
        }

    }
    public class SOL_CAMPANIA
    {
        public SOL_CAMPANIA()
        {


        }
        public SOL_CAMPANIA(string ID, string Campania, string IsAddVenta, string Estado)
        {
            this.ID = ID;
            this.Campania = Campania;
            this.IsAddVenta = IsAddVenta;
            this.Estado = Estado;
        }

        public string IsAddVenta { get; set; }
        public string Estado { get; set; }
        public string ID { get; set; }
        public string Campania { get; set; }


    }

    public class SOL_FORMULARIO
    {
        public SOL_FORMULARIO()
        {


        }
        public SOL_FORMULARIO(string ID_form, string Nombre_form, string codigo_form, string Estado)
        {
            this.ID_form = ID_form;
            this.Nombre_form = Nombre_form;
            this.codigo_form = codigo_form;
            this.Estado = Estado;
        }

        public string codigo_form { get; set; }
        public string Estado { get; set; }
        public string ID_form { get; set; }
        public string Nombre_form { get; set; }


    }


}
