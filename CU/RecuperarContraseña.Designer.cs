namespace CU
{
    partial class RecuperarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirContraseña = new System.Windows.Forms.TextBox();
            this.txtNickEmail = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtConfirContraseña
            // 
            this.txtConfirContraseña.Location = new System.Drawing.Point(116, 145);
            this.txtConfirContraseña.Name = "txtConfirContraseña";
            this.txtConfirContraseña.Size = new System.Drawing.Size(170, 20);
            this.txtConfirContraseña.TabIndex = 4;
            // 
            // txtNickEmail
            // 
            this.txtNickEmail.Location = new System.Drawing.Point(116, 9);
            this.txtNickEmail.Name = "txtNickEmail";
            this.txtNickEmail.Size = new System.Drawing.Size(170, 20);
            this.txtNickEmail.TabIndex = 5;
            this.txtNickEmail.TextChanged += new System.EventHandler(this.txtNickEmail_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(116, 112);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(170, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(116, 76);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(170, 20);
            this.txtRespuesta.TabIndex = 9;
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(211, 189);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttnAceptar.TabIndex = 10;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(49, 189);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttnCancelar.TabIndex = 11;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(116, 42);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(170, 20);
            this.txtPregunta.TabIndex = 12;
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 224);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNickEmail);
            this.Controls.Add(this.txtConfirContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecuperarContraseña";
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirContraseña;
        private System.Windows.Forms.TextBox txtNickEmail;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.TextBox txtPregunta;
    }
}