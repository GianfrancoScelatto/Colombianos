using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LC;

namespace CU
{
    public partial class FrmAbm : Form
    {
        public Cliente cliente;
        public Ciudad ciudad;
        public bool bandera;
        public DateTime fechalimpia = DateTime.Parse("31-12-2001");
        int _dni;
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
                    Documento.Text = Convert.ToInt32(x.Documento.ToString()).ToString();
                    Nombre.Text = x.Nombre;

                    if ((rbtnM.Checked) == true)
                    {
                        cliente.Sexo = "Masculino";
                    }
                    else cliente.Sexo = "Femenino";

                    Fecha.Text = x.FechaNacimiento.ToString("dd-MM-yyyy");
                    Correo.Text = x.Correo;
                    Address.Text = x.Direccion;
                    CBOCiudad.Text = x.ciudad.NombreCiudad;
                }
            }
        }

        public bool validar(string correo)
        {
            return Regex.IsMatch(correo, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

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
            this.Hide();
            Documento.ResetText();
            Nombre.ResetText();
            rbtnM.Checked = true;
            Fecha.Value = fechalimpia;
            Correo.ResetText();
            Address.ResetText();
        }

        private void BtnAccion_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Documento.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(Correo.Text))
            {
                MessageBox.Show("Debe completar todos los datos", "Datos incompletos", MessageBoxButtons.OK);
                return;
            }

            cliente.Documento = Convert.ToInt32(Documento.Text);
            cliente.Nombre = Nombre.Text;

            if ((rbtnM.Checked) == true)
            {
                cliente.Sexo = "Masculino";
            }
            else cliente.Sexo = "Femenino";

            cliente.FechaNacimiento = Convert.ToDateTime(Fecha.Value.Date.ToString("dd-MM-yyyy"));
            cliente.Correo = Correo.Text;
            cliente.Direccion = Address.Text;
            cliente.CodigoCiudad = Convert.ToInt32(((DataRowView)CBOCiudad.SelectedItem)["CodigoCiudad"]);

            if (bandera == true)
            {
                cliente.Accion(cliente, "UPDATE");
                MessageBox.Show("¡Cliente actualizado con éxito!", "Actualizar cliente", MessageBoxButtons.OK);
                bandera = false;
            }
            else
            {
                cliente.Accion(cliente, "ALTA");
                MessageBox.Show("¡Cliente nuevo ingresado con éxito!", "Crear cliente", MessageBoxButtons.OK);
            }
        }
        private void Correo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Correo.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }

            if (validar(Correo.Text) == false)
            {
                MessageBox.Show("No válido");
                Correo.Focus();
            }
        }
        private void Documento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Documento.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }
        }

        private void Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Este campo es obligatorio");
            }
        }

        private void Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("No se permiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        
    }
}
