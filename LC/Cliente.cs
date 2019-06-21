using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

// gian cara de teta n
namespace LC
{
    public class Cliente
    {
        public int ID { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int CodigoCiudad { get; set; }

        public Ciudad ciudad;


        public Cliente()
        {
            ciudad = new Ciudad();
        }

        public List<Cliente> Listar(String cadena)
        {
            var conexion = new SqlConnection();
            var comando = new SqlCommand();
            var BaseDeDatos = new Connect();
            var Lista = new List<Cliente>();

            try
            {
                conexion = BaseDeDatos.Abrir();
                comando.Connection = conexion;
                comando.CommandText = "Select t1.*, t2.NombreCiudad " + " From BaseClientes as t1 " + " Inner Join BaseCiudades as t2 " + " On t1.CodigoCiudad = t2.CodigoCiudad " + "where NombreCliente like '%" + cadena + "%'" + " Order by t1.NombreCliente";
                var rdr = comando.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Cliente();
                    reg.ID = (int)rdr["ID"];
                    reg.Documento = (int)rdr["DocumentoCliente"];
                    reg.Nombre = (string)rdr["NombreCliente"];
                    reg.Sexo = (string)rdr["Sexo"];
                    reg.FechaNacimiento = (DateTime)rdr["FechaNac"];
                    reg.Correo = (string)rdr["CorreoCliente"];
                    reg.Direccion = (string)rdr["DireccionCliente"];
                    reg.CodigoCiudad = (int)rdr["CodigoCiudad"];
                    reg.ciudad.CodigoCiudad = (int)rdr["CodigoCiudad"];
                    reg.ciudad.NombreCiudad = (string)rdr["NombreCiudad"];

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

        public List<Cliente> ListDoc(int Dni)
        {
            var conexion = new SqlConnection();
            var comando = new SqlCommand();
            var BaseDeDatos = new Connect();
            var Lista = new List<Cliente>();

            try
            {
                conexion = BaseDeDatos.Abrir();
                comando.Connection = conexion;
                comando.CommandText = "Select t1.*, t2.NombreCiudad " + " From BaseClientes as t1 " + " Inner Join BaseCiudades as t2 " + " On t1.CodigoCiudad = t2.CodigoCiudad " + "where DocumentoCliente like '%" + Dni + "%'" + " Order by t1.NombreCliente";
                var rdr = comando.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Cliente();
                    reg.ID = (int)rdr["ID"];
                    reg.Documento = (int)rdr["DocumentoCliente"];
                    reg.Nombre = (string)rdr["NombreCliente"];
                    reg.Sexo = (string)rdr["Sexo"];
                    reg.FechaNacimiento = (DateTime)rdr["FechaNac"];
                    reg.Correo = (string)rdr["CorreoCliente"];
                    reg.Direccion = (string)rdr["DireccionCliente"];
                    reg.CodigoCiudad = (int)rdr["CodigoCiudad"];
                    reg.ciudad.CodigoCiudad = (int)rdr["CodigoCiudad"];
                    reg.ciudad.NombreCiudad = (string)rdr["NombreCiudad"];

                    Lista.Add(reg);
                } //Fin While
            }

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

        public bool Accion(Cliente _Cliente, string ejecutar)
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
                    comando.CommandText = "Insert into BaseClientes (DocumentoCliente, NombreCliente, Sexo, FechaNac, CorreoCliente, DireccionCliente, CodigoCiudad ) values (" + _Cliente.Documento + ",'" + _Cliente.Nombre + "','" + _Cliente.Sexo + "','" + _Cliente.FechaNacimiento + "','" + _Cliente.Correo + "','" + _Cliente.Direccion + "'," + _Cliente.CodigoCiudad + ")";
                }
                else if (ejecutar == "BAJA")
                {
                    comando.CommandText = "DELETE BaseClientes WHERE DocumentoCliente=" + _Cliente.Documento;

                }
                else
                {
                    comando.CommandText = "UPDATE BaseClientes SET DocumentoCliente=" + _Cliente.Documento + ", NombreCliente='" + _Cliente.Nombre + "', Sexo='" + _Cliente.Sexo + "', FechaNac='" + _Cliente.FechaNacimiento + "', CorreoCliente='" + _Cliente.Correo + "', DireccionCliente='" + _Cliente.Direccion + "', CodigoCiudad=" + _Cliente.CodigoCiudad + " WHERE ID=" + _Cliente.ID;
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