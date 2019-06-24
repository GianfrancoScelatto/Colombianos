using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using LC;

namespace CU
{
    public partial class Registro : Form
    {
        public Usuario usuario;
        public Registro()
        {
            usuario = new Usuario();
            InitializeComponent();
            Combo.Combo2campos(cmbBoxPreguntas, "Descripcion", "ID_Pregunta", "Pregunta");

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            usuario.Mail = txtMail.Text;
            usuario.Nick = txtNick.Text;
            usuario.IDPregunta = Convert.ToInt32(((DataRowView)cmbBoxPreguntas.SelectedItem)["ID_Pregunta"]);
            usuario.Contraseña = txtContraseña.Text;
            usuario.Respuesta = txtRespuesta.Text;
            usuario.UsuarioAccion(usuario, "ALTA");
            MessageBox.Show("¡Usuario registrado con éxito!");
        }
    }
}