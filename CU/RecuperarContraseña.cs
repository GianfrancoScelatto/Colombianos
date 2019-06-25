using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LC;

namespace CU
{
    public partial class RecuperarContraseña : Form
    {
        public Usuario _user;
        public Connect conn;
        public Pregunta pregunta;
        string resp;

        public RecuperarContraseña()
        {
            pregunta = new Pregunta();
            conn = new Connect();
            _user = new Usuario();
            InitializeComponent();
        }
        public void CargarUsuario()
        {
            var cadena = txtMailNick.Text;
            var l = _user.ListarUser(cadena);

            foreach (var x in l)
            {
                txtPreg.Text = x.pregunta.Descripcion ;
                resp = x.Respuesta;
                _user.Nick = x.Nick;
                _user.Mail = x.Mail;
                
                _user.IDPregunta = x.IDPregunta;
                _user.Respuesta = x.Respuesta;
            }
        }

        public void Limpieza()
        {
            txtMailNick.ResetText();
            txtPass.ResetText();
            txtCFPass.ResetText();
            txtResp.ResetText();
        }
        private void RecuperarContraseña_Load_1(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (txtResp.Text == resp)
            {
                _user.Contraseña = b.Text;
                _user.UsuarioAccion( _user, "EDITAR");
                MessageBox.Show("editado");
            }
        }

        private void txtNickEmail_TextChanged(object sender, EventArgs e)
        {
            CargarUsuario();

            if (txtMailNick.Text == "")
            {
                txtPreg.ResetText();
            }
        }

        private void TxtCFPass_Leave(object sender, EventArgs e)
        {
            if (b.Text != a.Text)
            {
                MessageBox.Show("No coinciden las contraseñas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                b.ResetText();
                a.ResetText();
                b.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpieza();
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpieza();
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
