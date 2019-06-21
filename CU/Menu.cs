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
        public Formulario formulario;
        public Cliente cliente;
        public int i;
        public string[] vectorCliente = new string[8];
        public Menu()
        {
            formulario = new Formulario();
            cliente = new Cliente();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
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
            formulario.bunifuCustomLabel1.Visible = false;
            formulario.ID.Visible = false;
            formulario.Crear.Visible = true;
            formulario.Actualizar.Visible = false;
            formulario.Show();
            Grilla.Visible = false;
            Buscar.Visible = false;
            label2.Visible = false;            
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

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            Buscar.Visible = true;
            Grilla.Visible = true;
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

            for (i = 0; i <= 7; i++)
            {
                vectorCliente[i] = row.Cells[i].Value.ToString();
            }
        }

        private void BunifuSwitch1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gian\Downloads\Cazzu.wav");

            if (bunifuSwitch1.Value == true)
            {         
                simpleSound.Play();
            }
            else if (bunifuSwitch1.Value == false)
                simpleSound.Stop();
        }

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dni = Convert.ToInt32(Grilla.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            Formulario formulario = new Formulario(dni);
            formulario.Show();
            /*formulario.ID.Text = vectorCliente[0].ToString();
            formulario.Documento.Text = vectorCliente[1].ToString();
            formulario.Nombre.Text = vectorCliente[2];

            if (vectorCliente[3] == "Masculino")
            {
                formulario.rbtnM.Checked = true;
            }
            else formulario.rbtnF.Checked = true;

            formulario.Fecha.Text = vectorCliente[4].ToString();
            formulario.Correo.Text = vectorCliente[5];
            formulario.Address.Text = vectorCliente[6];
            formulario.CBOCiudad.Text = vectorCliente[7].ToString();

            formulario.Actualizar.Visible = true;
            formulario.Crear.Visible = false;*/

            if (Grilla.CurrentRow == null)
                return;

            formulario.Show();
        }
    }
}
