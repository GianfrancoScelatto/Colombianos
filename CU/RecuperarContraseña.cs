using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using LC;

namespace CU
{
    public partial class RecuperarContraseña : Form
    {
        public Usuario _user;
        public Connect conn;
        public Pregunta pregunta;
        string resp, nick, mail;


        public RecuperarContraseña()
        {
            pregunta = new Pregunta();
            conn = new Connect();
            _user = new Usuario();
            InitializeComponent();
        }
        public void CheckNickMail()
        {
            var cadena = txtMailNick.Text;
            var l = _user.ListarUsuario(cadena);

            foreach (var x in l)
            {
                nick = x.Nick;
                mail = x.Mail;
            }
        }

        public void CargarUsuario()
        {
            var cadena = txtMailNick.Text;
            var l = _user.ListarUsuario(cadena);

            foreach (var x in l)
            {
                txtPreg.Text = x.pregunta.Descripcion;
                resp = x.Respuesta;
                _user.Nick = x.Nick;
                _user.Mail = x.Mail;
                
                _user.IDPregunta = x.IDPregunta;
                _user.Respuesta = x.Respuesta;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Limpieza()
        {
            Hide();
            txtMailNick.ResetText();
            txtPass.ResetText();
            txtCFPass.ResetText();
            txtResp.ResetText();
        }
        private void RecuperarContraseña_Load_1(object sender, EventArgs e)
        {

        }

        private void TxtCFPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtCFPass.Text)
            {
                MessageBox.Show("No coinciden las contraseñas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void TxtMailNick_OnValueChanged(object sender, EventArgs e)
        {
            CargarUsuario();

            if (txtMailNick.Text == "")
            {
                txtPreg.ResetText();
            }
        }

        private void BtnAccion_Click(object sender, EventArgs e)
        {
            if (txtMailNick.Text == "" || txtResp.Text == "" || txtPass.Text == "" || txtCFPass.Text == "")
            {
                MessageBox.Show("Hay campos sin completar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtResp.Text == resp)
            {
                _user.Contraseña = txtCFPass.Text;
                _user.UsuarioAccion(_user, "EDITAR");
                Limpieza();
            }
            else if (txtResp.Text != resp)
            {
                MessageBox.Show("La respuesta es incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Limpieza();
            }
            else
                return;
        }

        private void Label6_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.TextLength < 8)
            {
                MessageBox.Show("La contraseña debe tener 8 caracteres como mínimo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtMailNick_Leave(object sender, EventArgs e)
        {
            CheckNickMail();
            if (!(txtMailNick.Text == mail || txtMailNick.Text == nick))
            {
                MessageBox.Show("El usuario ingresado no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMailNick.Focus();
            }
        }
    }
}
