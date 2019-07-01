using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using LC;

namespace CU
{
    public partial class FrmAbm : Form
    {
        public Cliente cliente;
        public Ciudad ciudad;
        public bool bandera;
        public DialogResult result;
        private int _dni, id, documento;
        private string correo;
        public FrmAbm(int dni)
        {
            _dni = dni;
            cliente = new Cliente();
            ciudad = new Ciudad();
            InitializeComponent();
            Combo.Combo2campos(CBOCiudad, "NombreCiudad", "CodigoCiudad", "BaseCiudades");

            if (_dni == 0)
            {                

            }
            else
            {
                var Registro = cliente.ListarDocumento(_dni);
                foreach (var x in Registro)
                {
                    txtDocumento.Text = Convert.ToInt32(x.Documento.ToString()).ToString();
                    txtNombre.Text = x.Nombre;
                    if ((x.Sexo) == "Femenino")
                    {
                        rbtnF.Checked = true;
                    }
                    else
                    {
                        rbtnM.Checked = true;
                    }
                    dtpFecha.Text = x.FechaNacimiento.ToString("MM-dd-yyyy");
                    txtCorreo.Text = x.Correo;
                    txtAddress.Text = x.Direccion;
                    CBOCiudad.Text = x.ciudad.NombreCiudad;
                    id = x.ID;
                }
            }
        }
        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        #region Métodos
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        public bool Validar(string correo)
        {
            return Regex.IsMatch(correo, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        public void CheckCorreo()
        {
            var cadena = txtCorreo.Text;
            var l = cliente.ListarNombre(cadena);

            foreach (var x in l)
            {
                correo = x.Correo;
            }
        }
        public void CheckDNI()
        {
            var cadena = txtDocumento.Text;
            var l = cliente.ListarDocumento(Convert.ToInt32(cadena));

            foreach (var x in l)
            {
                documento = x.Documento;
            }
        }
        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void Limpieza()
        {
            txtDocumento.ResetText();
            txtNombre.ResetText();
            rbtnM.Checked = true;
            dtpFecha.Value = new DateTime(2001, 12, 31);
            txtCorreo.ResetText();
            txtAddress.ResetText();
            CBOCiudad.SelectedIndex = 0;
            _dni = 0;
            Hide();
        }

        private void BtnAccion_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumento.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Debe completar todos los datos", "Datos incompletos", MessageBoxButtons.OK);
                return;
            }

            cliente.Documento = Convert.ToInt32(txtDocumento.Text);
            cliente.Nombre = txtNombre.Text;

            if (rbtnM.Checked == true)
            {
                cliente.Sexo = "Masculino";
            }
            else
            {
                cliente.Sexo = "Femenino";
            }

            cliente.FechaNacimiento = Convert.ToDateTime(dtpFecha.Value.Date.ToString("MM-dd-yyyy"));
            cliente.Correo = txtCorreo.Text;
            cliente.Direccion = txtAddress.Text;
            cliente.CodigoCiudad = Convert.ToInt32(((DataRowView)CBOCiudad.SelectedItem)["CodigoCiudad"]);
            cliente.ID = id;

            if (bandera == true)
            {
                cliente.Accion(cliente, "UPDATE");
                Limpieza();
            }
            else if (bandera == false)
            {
                cliente.Accion(cliente, "ALTA");
                result = MessageBox.Show("¿Desea agregar otro cliente?", "Clientes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {           
                    Limpieza();
                    Show();
                }
                else if (result == DialogResult.No)
                {
                    _dni = 0;
                    Hide();
                }
                bandera = false;
            }
        }
        private void Correo_Leave(object sender, EventArgs e)
        {
            CheckCorreo();

            if (txtCorreo.Text == correo)
            {
                MessageBox.Show("El correo ya está en uso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Este campo es obligatorio.");
            }

            if (Validar(txtCorreo.Text) == false)
            {
                MessageBox.Show("Este correo no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
            }
        }
        private void Documento_Leave(object sender, EventArgs e)
        {
            CheckDNI();

            if (txtDocumento.TextLength < 9)
            {
                lblErrorMsg.Text = "El documento ingresado no es válido.";
            }
            else
            {
                lblErrorMsg.Text = "";
            }

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Este campo es obligatorio.");
            }
            if (Convert.ToInt32(txtDocumento.Text) == documento)
            {
                MessageBox.Show("El cliente ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumento.Focus();
            }
        }

        private void Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }
        }

        private void Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

       

    }
}
