using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace LC
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nick { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public int IDPregunta { get; set; }
        public string Respuesta{ get; set; }

        public Pregunta pregunta;

        public bool UsuarioAccion(Usuario usuario, string ejecutar)
        {
            var conn = new SqlConnection();
            var comando = new SqlCommand();
            var baseDatos = new Connect();
            bool rta;
            try
            {
                conn = baseDatos.Abrir();
                comando.Connection = conn;

                if (ejecutar == "ALTA")
                {
                    comando.CommandText = "Insert into Cuenta (nickname, email, contraseña, FK_ID_Pregunta, Respuesta ) values ('" + usuario.Nick + "','" + usuario.Mail + "','" + usuario.Contraseña + "','" + usuario.IDPregunta + "','" + usuario.Respuesta  + "')";
                }
            
                else if (ejecutar == "EDITAR")
                {
                    comando.CommandText = "UPDATE Cuenta SET contraseña=" + usuario.Contraseña+ " WHERE nickname=" + usuario.Nick;
                }
                
                comando.ExecuteNonQuery();
                rta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return rta;

        }

    }
}
