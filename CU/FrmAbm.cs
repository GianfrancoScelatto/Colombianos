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
    public partial class FrmAbm : Form
    {
        public Cliente cliente;
        public Ciudad ciudad;
        public bool bandera=false;
        int _dni = 0;
        public FrmAbm(int dni)
        {
            _dni = dni;
            cliente = new Cliente();
            ciudad = new Ciudad();
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
                    Documento.Text = Convert.ToInt32(x.Documento.ToString()).ToString();
                    Nombre.Text = x.Nombre;

                    if ((rbtnM.Checked) == true)
                    {
                        cliente.Sexo = "Masculino";
                    }
                    else cliente.Sexo = "Femenino";
                    
                    Fecha.Text = x.FechaNacimiento.ToString("MM-dd-yyyy");
                    Correo.Text = x.Correo;
                    Address.Text = x.Direccion;
                    CBOCiudad.Text = x.ciudad.NombreCiudad;
                }
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
           
        }
        
        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (Nombre.Text=="" || Correo.Text=="" || Direccion.Text=="" || Documento.Text == "")
            {
                MessageBox.Show("Completa todo amigo");
                return;
            }

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

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       /* private void Actualizar_Click_1(object sender, EventArgs e)
        {
            //  conn.Abrir();
            if (Nombre.Text == "" || Correo.Text == "" || Direccion.text == "" || Documento.Text == "")
            {
                MessageBox.Show("Completa todo amigo");
                return;
            }

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

            bandera = true;
            this.Hide();
        }*/
    }
}
