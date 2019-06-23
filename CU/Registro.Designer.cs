namespace CU
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRegistroEmail = new System.Windows.Forms.TextBox();
            this.txtRegistroNick = new System.Windows.Forms.TextBox();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.txtRegistroContraseña = new System.Windows.Forms.TextBox();
            this.txtRegistroConfContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxPreguntas = new System.Windows.Forms.ComboBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegistroEmail
            // 
            this.txtRegistroEmail.Location = new System.Drawing.Point(150, 75);
            this.txtRegistroEmail.Name = "txtRegistroEmail";
            this.txtRegistroEmail.Size = new System.Drawing.Size(100, 20);
            this.txtRegistroEmail.TabIndex = 0;
            // 
            // txtRegistroNick
            // 
            this.txtRegistroNick.Location = new System.Drawing.Point(150, 114);
            this.txtRegistroNick.Name = "txtRegistroNick";
            this.txtRegistroNick.Size = new System.Drawing.Size(100, 20);
            this.txtRegistroNick.TabIndex = 1;
            this.txtRegistroNick.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(175, 329);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttnAceptar.TabIndex = 2;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.BttnAceptar_Click);
            // 
            // txtRegistroContraseña
            // 
            this.txtRegistroContraseña.Location = new System.Drawing.Point(150, 152);
            this.txtRegistroContraseña.Name = "txtRegistroContraseña";
            this.txtRegistroContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtRegistroContraseña.TabIndex = 3;
            // 
            // txtRegistroConfContraseña
            // 
            this.txtRegistroConfContraseña.Location = new System.Drawing.Point(150, 191);
            this.txtRegistroConfContraseña.Name = "txtRegistroConfContraseña";
            this.txtRegistroConfContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtRegistroConfContraseña.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "confirpsw";
            // 
            // cmbBoxPreguntas
            // 
            this.cmbBoxPreguntas.FormattingEnabled = true;
            this.cmbBoxPreguntas.Location = new System.Drawing.Point(150, 233);
            this.cmbBoxPreguntas.Name = "cmbBoxPreguntas";
            this.cmbBoxPreguntas.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxPreguntas.TabIndex = 9;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(150, 274);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "pregunta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "respuesta";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.cmbBoxPreguntas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistroConfContraseña);
            this.Controls.Add(this.txtRegistroContraseña);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.txtRegistroNick);
            this.Controls.Add(this.txtRegistroEmail);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistroEmail;
        private System.Windows.Forms.TextBox txtRegistroNick;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.TextBox txtRegistroContraseña;
        private System.Windows.Forms.TextBox txtRegistroConfContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxPreguntas;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}