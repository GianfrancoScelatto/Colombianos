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
        public string Nick { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public int IDPregunta { get; set; }
        public string Respuesta { get; set; }

        public Pregunta pregunta;

        public Usuario()
        {
            pregunta = new Pregunta();
        }

        public List<Usuario> ListarUser(String cadena)
        {
            var conexion = new SqlConnection();
            var comando = new SqlCommand();
            var BaseDeDatos = new Connect();
            var Lista = new List<Usuario>();

            try
            {
                conexion = BaseDeDatos.Abrir();
                comando.Connection = conexion;
                comando.CommandText = "Select t1.*, t2.Descripcion " + " From Cuenta as t1 " + " Inner Join Pregunta as t2 " + " On t1.FK_ID_Pregunta = t2.ID_Pregunta " + "where nickname='" + cadena + "' or email=' " + cadena + "' Order by t1.nickname";
                var rdr = comando.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Usuario();
                    reg.Nick = (string)rdr["nickname"];
                    reg.Mail = (string)rdr["email"];
                    reg.Contraseña = (string)rdr["contraseña"];
                    reg.IDPregunta = (int)rdr["FK_ID_Pregunta"];
                    reg.Respuesta = (string)rdr["Respuesta"];
                    reg.pregunta.Descripcion = (string)rdr["Descripcion"];

                    Lista.Add(reg);
                } //Fin While

            }//Fin Try

            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");

            }//Fin Catch

            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }//Fin Finally

            return Lista;

        }

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
                    comando.CommandText = "Insert into Cuenta (nickname, email, contraseña, FK_ID_Pregunta, Respuesta ) values ('" + usuario.Nick + "','" + usuario.Mail + "','" + usuario.Contraseña + "','" + usuario.IDPregunta + "','" + usuario.Respuesta + "')";
                }

                else if (ejecutar == "EDITAR")
                {
                    comando.CommandText = "UPDATE Cuenta SET contraseña='" + usuario.Contraseña + "' WHERE nickname='" + usuario.Nick + "'";
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
