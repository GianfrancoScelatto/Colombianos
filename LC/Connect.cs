using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LC
{
    public class Connect
    {
        public string _servidor;
        public string _database;
        public string _usuario;//si posee usuario y contrasena el sql server
        public string _password;//si posee usuario y contrasena el sql server
        public static string Cadena;
        public Connect()
        {
            try
            {
                _servidor = "DESKTOP-0OTOOTM\\SQL";
                _database = "Colombia";
                _usuario = "DESKTOP-0OTOOTM\\leo";
                _password = "";

            } //try
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");
            }//catch




        }//Conectar
        public SqlConnection Abrir()
        {
            Cadena = "Server=" + _servidor + ";Database=" + _database + ";Trusted_Connection=Yes";
            var conn = new SqlConnection(Cadena);//cadena
            conn.Open();
            return conn;

        }//abrir

    }


}