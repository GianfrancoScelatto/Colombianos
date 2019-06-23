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
  
    public partial class Login : Form
        
    {
        public Usuario claseL;
        public Menu MenuL;
        int intentos;
        string datos;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            intentos+= 1;
            

            if (txtuser.Text == claseL.Mail && textBox2.Text == claseL.Contraseña)
            {
                
                this.Hide();
                MenuL = new Menu();
                MenuL.Show();
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Ha alcanzado el nivel maximo de intentos, Porfavor vuelva a intentarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";

            }

        }
 
    }
    
    
}
