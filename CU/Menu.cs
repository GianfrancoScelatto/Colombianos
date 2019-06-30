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
        public Menu()
        {
            FrmAbm formulario = new FrmAbm(dni);
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
            var cadena = Buscartxt.Text.ToString();
            var l = cliente.ListarNombre(cadena);
            foreach (var x in l)
            {
                Grilla.Rows.Add(x.ID, x.Documento, x.Nombre, x.Sexo, x.FechaNacimiento.ToString("MM-dd-yyyy"), 
                x.Correo,x.Direccion, x.ciudad.NombreCiudad);
            }
            
        }

        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbMaximizar.Visible = true;
            pbRestaurar.Visible = false;
        }

        private void PbMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();          
        }

        private void BunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (Grilla.CurrentRow == null)
                return;

            var row = (sender as DataGridView).CurrentRow;

            cliente.Documento = Convert.ToInt32(Grilla.CurrentRow.Cells["Documento"].Value);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dni = cliente.Documento;
            FrmAbm formulario = new FrmAbm(dni);
            formulario.ShowDialog();
            formulario.bandera = true; // activamos la bandera del FrmAbm para indicarle que accion debe realizar con los datos del form
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dni = 0;
            FrmAbm formulario = new FrmAbm(dni);
            formulario.ShowDialog();
        }

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

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dni = Convert.ToInt32(Grilla.Rows[e.RowIndex].Cells[1].Value.ToString());
            FrmAbm formulario = new FrmAbm(dni);
            formulario.ShowDialog();
            formulario.bandera = true;
        }
    }
}
