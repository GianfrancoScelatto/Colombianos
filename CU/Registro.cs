using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using LC;

namespace CU
{
    public partial class Registro : Form
    {
        public Usuario usuario;
        public string nick;
        public string mail;
        public Registro()
        {
            usuario = new Usuario();
            InitializeComponent();
            Combo.Combo2campos(cmbBoxPreguntas, "Descripcion", "ID_Pregunta", "Pregunta");
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "" || txtNick.Text == "" || txtPass.Text == "" || txtCFPass.Text == "" || txtRespuesta.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            usuario.Mail = txtMail.Text;
            usuario.Nick = txtNick.Text;
            usuario.IDPregunta = Convert.ToInt32(((DataRowView)cmbBoxPreguntas.SelectedItem)["ID_Pregunta"]);
            usuario.Contraseña = txtCFPass.Text;
            usuario.Respuesta = txtRespuesta.Text;
            usuario.UsuarioAccion(usuario, "ALTA");
            MessageBox.Show("¡Usuario registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpieza();
        }
        public bool validar(string correo)
        {
            return Regex.IsMatch(correo, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        public void Limpieza()
        {
            this.Hide();
            txtNick.ResetText();
            txtMail.ResetText();
            txtContraseña.ResetText();
            txtConfContraseña.ResetText();
            txtRespuesta.ResetText();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void TxtNick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("No se permiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void TxtCFPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtCFPass.Text)
            {
                MessageBox.Show("No coinciden las contraseñas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass.ResetText();
                txtCFPass.ResetText();
                txtPass.Focus();
            }
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void CheckNick()
        {
            var cadena = txtNick.Text;
            var l = usuario.ListarUsuario(cadena);

            foreach (var x in l)
            {
                nick = x.Nick;       
            }
        }

        public void CheckMail()
        {
            var cadena = txtMail.Text;
            var l = usuario.ListarUsuario(cadena);

            foreach (var x in l)
            {
                mail = x.Mail;
            }
        }

        private void txtNick_Leave(object sender, EventArgs e)
        {
            CheckNick();

            if (txtNick.Text == nick)
            {
                MessageBox.Show("El usuario ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNick.Focus();
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            CheckMail();

            if (txtMail.Text == mail)
            {
                MessageBox.Show("El usuario ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMail.Focus();
            }

            if (validar(txtMail.Text) == false)
            {
                MessageBox.Show("Correo no válido");
                txtMail.Focus();
            }
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}