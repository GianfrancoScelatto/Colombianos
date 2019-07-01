using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using LC;

namespace CU
{
    public partial class Menu : Form
    {
        public FrmAbm formulario;
        public Cliente cliente;
        public int dni;
        public Login login;
        public Menu()
        {
            login = new Login();
            formulario = new FrmAbm(dni);
            cliente = new Cliente();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();           
        }

        public void CargarGrilla()
        {
            Grilla.Rows.Clear();           
            
            if (rbtnBuscNombre.Checked == true)
            {
                var cadena = Buscartxt.Text.ToString();
                var l = cliente.ListarNombre(cadena);
                foreach (var x in l)
                {
                    Grilla.Rows.Add(x.ID, x.Documento, x.Nombre, x.Sexo, x.FechaNacimiento.ToString("MM-dd-yyyy"),
                    x.Correo, x.Direccion, x.ciudad.NombreCiudad);
                }
            }
            else if (rbtnBuscDNI.Checked == true)
            {
                var cadena = Buscartxt.Text.ToString();
                var l = cliente.ListarNombre(cadena);
                
                if (Buscartxt.Text == "")
                {
                    l = cliente.ListarNombre(cadena);
                }
                else
                {
                    l = cliente.ListarDocumento(Convert.ToInt32(cadena));
                }
                foreach (var x in l)
                {
                    Grilla.Rows.Add(x.ID, x.Documento, x.Nombre, x.Sexo, x.FechaNacimiento.ToString("MM-dd-yyyy"),
                    x.Correo, x.Direccion, x.ciudad.NombreCiudad);
                }
            }
        }
        // Se verifica dentro de los condicionales que dependiendo del tipo de dato ingresado se actualice la grilla 
        
        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        //Boton de maximizar

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Se cierra la aplicacion definitivamente
       
        private void PbMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Minimizacion de la aplicacion

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();          
        }
        //Carga la grilla segun lo que reciva el buscador

        private void BunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (Grilla.CurrentRow == null)
                return;

            var row = (sender as DataGridView).CurrentRow;

            cliente.Documento = Convert.ToInt32(Grilla.CurrentRow.Cells["Documento"].Value);
        }
        //Selecciona el documento del cliente donde este posicionada la fila  

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dni = cliente.Documento;
            FrmAbm formulario = new FrmAbm(dni);
            formulario.bandera = true; // activamos la bandera del FrmAbm para indicarle que accion debe realizar con los datos del form
            formulario.ShowDialog();
          
        }
        //Se abre el formulario FrmAbm con los datos del cliente seleccionado en la grilla

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dni = 0;
            FrmAbm formulario = new FrmAbm(dni);
            formulario.bandera = false;
            formulario.ShowDialog();           
        }
        //Se abre un formulario sin datos dentro del mismo

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cliente.Documento = Convert.ToInt32(Grilla.CurrentRow.Cells["Documento"].Value);
            if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Borrar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.Accion(cliente, "BAJA");
            }
            if (Grilla.CurrentRow == null)
                return;

            Grilla.Rows.Remove(Grilla.CurrentRow);
        }
        //Se borra directamente el cliente seleccionado en la grilla

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dni = Convert.ToInt32(Grilla.Rows[e.RowIndex].Cells[1].Value.ToString());
            FrmAbm formulario = new FrmAbm(dni);
            formulario.bandera = true;
            formulario.ShowDialog();           
        }
        //Al hacer doble clic en un cliente se abre un formulario para poder actualizarlo

        private void Buscartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnBuscNombre.Checked == true)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (rbtnBuscDNI.Checked == true)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }
        //Se valida que no ingresen datos que no correspondan al Buscador dependiendo del radioButton seleccionado

        private void LkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            login.Show();
        }
        //Cierra el menu principal para que otro usuario pueda ingresar

        private void Menu_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        /* Lo utilizamos para cargar la grilla cuando esta este visible o activada recargando asi los datos ingresados 
         * object modificados de los clientes
         */
        private void RbtnBuscDNI_Click(object sender, EventArgs e)
        {
            Buscartxt.Clear();
        }
        /* Ref001 = Para evitar que los campos queden cargados a la hora de cargarlagrilla con datos que no corresponden al tipo 
         * que se esta buscando en el textBox del buscadr se vacian cuando el usuario le da click a los radiosButton
         */
        private void RbtnBuscNombre_Click(object sender, EventArgs e)
        {
            Buscartxt.Clear();
        }
        //Leer Ref001
    }
}
