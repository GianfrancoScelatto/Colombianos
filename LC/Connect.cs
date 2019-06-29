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
        public string _usuario;
        public string _password;
        public static string Cadena;
        public Connect()
        {
            try
            {
                _servidor = "LAPTOP-8F009B90\\SQLEXPRESS";
                _database = "colombia";
                _usuario = "LAPTOP-8F009B90\\Gian";
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