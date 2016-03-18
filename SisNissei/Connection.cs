using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Pecas.ConfigurationManager.Cryptography;
namespace SisNissei.Global_Variables
{
    public static class Connection
    {
        public static string getCadenaConexion()
        {
            string strTipoConexionDB = ConfigurationManager.AppSettings["typeConnectionDataBase"].ToString();
            string strCon = "";
            switch (strTipoConexionDB.Trim().ToLower())
            {
                case "pro":
                    strCon = ConfigurationManager.ConnectionStrings["BURO_CRM"].ConnectionString;
                    break;
                case "pru":
                    strCon = ConfigurationManager.ConnectionStrings["TEST_BURO_CRM"].ConnectionString;
                    break;
            }
            Crypto decrypt = new Crypto();
            decrypt.Pasword = "0B1U2R3O4M5V6C7";
            String strconx = decrypt.Decrypt(strCon);
            //strconx = "Server=192.168.1.4; Uid=sa;Pwd=123456; Database=SisNisei";
            //String strconx_tmp = decrypt.Encrypt(strconx);
            //strconx_tmp = "";

            //Crypto encriptado = new Crypto();
            //encriptado.Pasword = "0P1A2S3S4W5O6R7D8";
            //String PasswordDes = encriptado.Decrypt("¾š¯›Ç”¿Å™°h");

            //String PasswordEnc = decrypt.Encrypt("Data Source=.\SQLEXPRESS;Initial Catalog=SisNisei;Integrated Security=true");
            //string strconx = "Data Source=.\SQLEXPRESS;Initial Catalog=SisNisei;User ID=sa;Password=123456;";
            if (strconx == String.Empty)
                return string.Empty;
            else
                return strconx;
        }

        public static string getPasswordUserEncrypt(string strPws)
        {
            Crypto encriptado = new Crypto();
            encriptado.Pasword = "0P1A2S3S4W5O6R7D8";
            String PasswordEnc = encriptado.Encrypt(strPws);
            return PasswordEnc;
        }

        public static string getPasswordUserDecrypt(string strPws)
        {
            Crypto encriptado = new Crypto();
            encriptado.Pasword = "0P1A2S3S4W5O6R7D8";
            String PasswordDes = encriptado.Decrypt(strPws);
            //String PasswordDesw = encriptado.Decrypt("‚d¸¤ˆi");//23wr56
            return PasswordDes;
        }
    }
}
