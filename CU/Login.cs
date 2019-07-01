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
using System.Runtime.InteropServices;


namespace CU
{

    public partial class Login : Form

    {
        public Usuario user;
        public Menu MenuL;
        int intentos;
        public Registro registro;
        public RecuperarContraseña RContrasena;

        public Login()
        {
            user = new Usuario();
            InitializeComponent();
        }

        private void IntentarLogear()
        {
            intentos += 0;

            var conexion = new SqlConnection();
            var comando = new SqlCommand();
            var BaseDeDatos = new Connect();
            conexion = BaseDeDatos.Abrir();
            comando.Connection = conexion;
            comando.CommandText = "SELECT nickname, email, contraseña FROM Cuenta WHERE nickname='" + txtuser.Text + "' or email='" + txtuser.Text + "' and contraseña='" + user.Contraseña + "'";
            var rdr = comando.ExecuteReader();
            var reg = new Usuario();

            while (rdr != null && rdr.Read())
            {
                reg.Nick = (string)rdr["nickname"];
                reg.Mail = (string)rdr["email"];
                reg.Contraseña = (string)rdr["contraseña"];
            }

            if (reg.Mail == txtuser.Text || reg.Nick == txtuser.Text && reg.Contraseña == txtPass.Text)
            {
                txtuser.Clear();
                txtPass.Clear();
                Hide();
                MenuL = new Menu();
                MenuL.Show();
                MenuL.lblUser.Text = "¡Bienvenido " + reg.Nick + "!";
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Si se ha olvidado la contraseña, intente restaurarla.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticación, verifique usuario y/o contraseña.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region Dll Import para mover formularios 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LkLblPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña RContrasena = new RecuperarContraseña();
            RContrasena.ShowDialog();
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Focus();
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
            }
        }

        private void LkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }
        private void PassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnLog_Click_1(object sender, EventArgs e)
        {
            IntentarLogear();
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IntentarLogear();
            }
        }
    }
}

