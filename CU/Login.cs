using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LC;
using System.Data.SqlClient;

namespace CU
{

    public partial class Login : Form

    {
        public Usuario user;
        public Menu MenuL;
        int intentos;
        public Registro registro;
        public Connect conn;
        public RecuperarContraseña RContrasena;



        public Login()
        {
            user = new Usuario();
            conn = new Connect();
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void BtnLog_Click_1(object sender, EventArgs e)
        {
            conn.Abrir();
            intentos += 0;

            var conexion = new SqlConnection();
            var comando = new SqlCommand();
            var comando1 = new SqlCommand();
            var comando2 = new SqlCommand();
            var BaseDeDatos = new Connect();
            conexion = BaseDeDatos.Abrir();
            comando.Connection = conexion;
            comando1.Connection = conexion;
            comando2.Connection = conexion;
            comando.CommandText = "Select nickname FROM Cuenta";
            comando1.CommandText = "Select email FROM Cuenta";
            comando2.CommandText = "Select contraseña FROM Cuenta";
            user.Nick = comando.ExecuteScalar().ToString();
            user.Mail = comando1.ExecuteScalar().ToString();
            user.Contraseña = comando2.ExecuteScalar().ToString();

            if (user.Mail == txtuser.Text || user.Nick == txtuser.Text && user.Contraseña == txtcontra.Text)
            {

                this.Hide();
                MenuL = new Menu();
                MenuL.Show();
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Ha alcanzado el nivel maximo de intentos, Porfavor vuelva a intentarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcontra.Text = "";

            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            registro = new Registro();
            registro.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RContrasena = new RecuperarContraseña();
            RContrasena.Show();
        }
    }
}

