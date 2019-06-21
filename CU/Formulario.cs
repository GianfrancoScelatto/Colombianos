using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LC;

namespace CU
{
    public partial class Formulario : Form
    {
        public Connect conn;
        public Cliente cliente;
        public Ciudad ciudad;
        public Menu menu;
        public int _dni;
        public Formulario(int dni)
        {
            _dni = dni;
            conn = new Connect();
            cliente = new Cliente();
            ciudad = new Ciudad();
            menu = new Menu();
            InitializeComponent();
            Combo.Combo2campos(CBOCiudad, "NombreCiudad", "CodigoCiudad", "BaseCiudades");

            if (_dni == null)
            {

            }
            else
            {
                var Registro = cliente.ListDoc(_dni);

                foreach (var x in Registro)
                {
                    ID.Text = Convert.ToInt32(x.ID.ToString()).ToString();
                    Documento.Text = Convert.ToInt32(x.Documento.ToString()).ToString();
                    Nombre.Text = x.Nombre;

                    if (x.Sexo == "Masculino")
                    {
                        rbtnM.Checked = true;
                    }
                    else rbtnF.Checked = true;

                    Fecha.Text = x.FechaNacimiento.ToString();
                    Correo.Text = x.Correo;
                    Address.Text = x.Direccion;
                    CBOCiudad.Text = x.ciudad.NombreCiudad.ToString();
                }
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
           
        }

        
        private void Crear_Click(object sender, EventArgs e)
        {
            conn.Abrir();
            cliente.Documento = Convert.ToInt32(Documento.Text);
            cliente.Nombre = Nombre.Text;

            if ((rbtnM.Checked) == true)
            {
                cliente.Sexo = "Masculino";
            }
            else cliente.Sexo = "Femenino";

            cliente.FechaNacimiento = Convert.ToDateTime(Fecha.Value.Date.ToString("MM-dd-yyyy"));
            cliente.Correo = Correo.Text;
            cliente.Direccion = Address.Text;
            cliente.CodigoCiudad = Convert.ToInt32(((DataRowView)CBOCiudad.SelectedItem)["CodigoCiudad"]);
            cliente.Accion(cliente, "ALTA");
            MessageBox.Show("¡Cliente nuevo ingresado con éxito!");
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Click_1(object sender, EventArgs e)
        {
            conn.Abrir();

            cliente.ID = Convert.ToInt32(ID.Text);
            cliente.Documento = Convert.ToInt32(Documento.Text);
            cliente.Nombre = Nombre.Text;

            if ((rbtnM.Checked) == true)
            {
                cliente.Sexo = "Masculino";
            }
            else cliente.Sexo = "Femenino";

            cliente.FechaNacimiento = Convert.ToDateTime(Fecha.Value.Date.ToString("MM-dd-yyyy"));
            cliente.Correo = Correo.Text;
            cliente.Direccion = Address.Text;
            cliente.CodigoCiudad = Convert.ToInt32(((DataRowView)CBOCiudad.SelectedItem)["CodigoCiudad"]);

            if (MessageBox.Show("¿Actualizar este cliente?", "Actualizar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.Accion(cliente, "UPDATE");
                MessageBox.Show("El cliente ha sido actualizado exitosamente");
            }
        }
    }
}
