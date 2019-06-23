using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using LC;

namespace CU
{
    public partial class Menu : Form
    {
        public FrmAbm formulario;
        public Cliente cliente;
        public int i;
        public string[] vectorCliente = new string[8];
        public int dni;
        public Menu()
        {
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
            var cadena = Buscar.Text.ToString();
            var l = cliente.Listar(cadena);

            foreach (var x in l)
            {
                Grilla.Rows.Add(x.ID, x.Documento, x.Nombre, x.Sexo, x.FechaNacimiento.ToString("MM-dd-yyyy"), x.Correo,
                                x.Direccion, x.ciudad.NombreCiudad);
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

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        { 
            formulario.Show();          
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            cliente.Documento = Convert.ToInt32(Grilla.CurrentRow.Cells["Documento"].Value);
            if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Borrar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.Accion(cliente, "BAJA");
                MessageBox.Show("El cliente ha sido borrado exitosamente");
            }

            if (Grilla.CurrentRow == null)
                return;

            Grilla.Rows.Remove(Grilla.CurrentRow);
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

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dni = Convert.ToInt32(Grilla.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            formulario = new FrmAbm(dni);
            formulario.Show();

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
