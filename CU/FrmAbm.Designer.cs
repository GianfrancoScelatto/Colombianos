namespace CU
{
    partial class FrmAbm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Correo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Documento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAccion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Direccion = new Bunifu.Framework.UI.BunifuTextbox();
            this.CBOCiudad = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 45);
            this.panel1.TabIndex = 8;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(438, 9);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(30, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 8;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(402, 9);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 6;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.PbMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 555);
            this.panel2.TabIndex = 8;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.rbtnF);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnM);
            this.bunifuGradientPanel1.Controls.Add(this.Fecha);
            this.bunifuGradientPanel1.Controls.Add(this.Address);
            this.bunifuGradientPanel1.Controls.Add(this.Correo);
            this.bunifuGradientPanel1.Controls.Add(this.Nombre);
            this.bunifuGradientPanel1.Controls.Add(this.Documento);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuGradientPanel1.Controls.Add(this.btnAccion);
            this.bunifuGradientPanel1.Controls.Add(this.Direccion);
            this.bunifuGradientPanel1.Controls.Add(this.CBOCiudad);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(480, 555);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.BackColor = System.Drawing.Color.Transparent;
            this.rbtnF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnF.Location = new System.Drawing.Point(315, 184);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(105, 23);
            this.rbtnF.TabIndex = 35;
            this.rbtnF.Text = "Femenino";
            this.rbtnF.UseVisualStyleBackColor = false;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.BackColor = System.Drawing.Color.Transparent;
            this.rbtnM.Checked = true;
            this.rbtnM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnM.Location = new System.Drawing.Point(188, 184);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(106, 23);
            this.rbtnM.TabIndex = 34;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Masculino";
            this.rbtnM.UseVisualStyleBackColor = false;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(165, 243);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(278, 20);
            this.Fecha.TabIndex = 32;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Address.ForeColor = System.Drawing.Color.Transparent;
            this.Address.HintForeColor = System.Drawing.Color.Empty;
            this.Address.HintText = "";
            this.Address.isPassword = false;
            this.Address.LineFocusedColor = System.Drawing.Color.Blue;
            this.Address.LineIdleColor = System.Drawing.Color.Transparent;
            this.Address.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Address.LineThickness = 3;
            this.Address.Location = new System.Drawing.Point(165, 363);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(278, 37);
            this.Address.TabIndex = 31;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Correo.ForeColor = System.Drawing.Color.Transparent;
            this.Correo.HintForeColor = System.Drawing.Color.Empty;
            this.Correo.HintText = "";
            this.Correo.isPassword = false;
            this.Correo.LineFocusedColor = System.Drawing.Color.Blue;
            this.Correo.LineIdleColor = System.Drawing.Color.Transparent;
            this.Correo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Correo.LineThickness = 3;
            this.Correo.Location = new System.Drawing.Point(165, 296);
            this.Correo.Margin = new System.Windows.Forms.Padding(4);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(278, 37);
            this.Correo.TabIndex = 30;
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correo.Leave += new System.EventHandler(this.Correo_Leave);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nombre.ForeColor = System.Drawing.Color.Transparent;
            this.Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.Nombre.HintText = "";
            this.Nombre.isPassword = false;
            this.Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.Nombre.LineIdleColor = System.Drawing.Color.Transparent;
            this.Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Nombre.LineThickness = 3;
            this.Nombre.Location = new System.Drawing.Point(165, 103);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(278, 37);
            this.Nombre.TabIndex = 29;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            this.Nombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // Documento
            // 
            this.Documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Documento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Documento.ForeColor = System.Drawing.Color.Transparent;
            this.Documento.HintForeColor = System.Drawing.Color.Empty;
            this.Documento.HintText = "";
            this.Documento.isPassword = false;
            this.Documento.LineFocusedColor = System.Drawing.Color.Blue;
            this.Documento.LineIdleColor = System.Drawing.Color.Transparent;
            this.Documento.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Documento.LineThickness = 3;
            this.Documento.Location = new System.Drawing.Point(165, 43);
            this.Documento.Margin = new System.Windows.Forms.Padding(4);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(278, 37);
            this.Documento.TabIndex = 28;
            this.Documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Documento_KeyPress);
            this.Documento.Leave += new System.EventHandler(this.Documento_Leave);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(42, 253);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(98, 19);
            this.bunifuCustomLabel9.TabIndex = 26;
            this.bunifuCustomLabel9.Text = "nacimiento";
            // 
            // btnAccion
            // 
            this.btnAccion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccion.BorderRadius = 0;
            this.btnAccion.ButtonText = "Aceptar";
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccion.Iconimage")));
            this.btnAccion.Iconimage_right = null;
            this.btnAccion.Iconimage_right_Selected = null;
            this.btnAccion.Iconimage_Selected = null;
            this.btnAccion.IconMarginLeft = 0;
            this.btnAccion.IconMarginRight = 0;
            this.btnAccion.IconRightVisible = true;
            this.btnAccion.IconRightZoom = 0D;
            this.btnAccion.IconVisible = true;
            this.btnAccion.IconZoom = 90D;
            this.btnAccion.IsTab = false;
            this.btnAccion.Location = new System.Drawing.Point(337, 504);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAccion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccion.selected = false;
            this.btnAccion.Size = new System.Drawing.Size(117, 29);
            this.btnAccion.TabIndex = 21;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccion.Textcolor = System.Drawing.Color.White;
            this.btnAccion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.Click += new System.EventHandler(this.BtnAccion_Click_1);
            // 
            // Direccion
            // 
            this.Direccion.BackColor = System.Drawing.Color.Silver;
            this.Direccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Direccion.BackgroundImage")));
            this.Direccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Direccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.Direccion.Icon = ((System.Drawing.Image)(resources.GetObject("Direccion.Icon")));
            this.Direccion.Location = new System.Drawing.Point(343, 633);
            this.Direccion.Margin = new System.Windows.Forms.Padding(5);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(417, 68);
            this.Direccion.TabIndex = 15;
            this.Direccion.text = "";
            // 
            // CBOCiudad
            // 
            this.CBOCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.CBOCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOCiudad.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.CBOCiudad.ForeColor = System.Drawing.Color.White;
            this.CBOCiudad.FormattingEnabled = true;
            this.CBOCiudad.Location = new System.Drawing.Point(165, 426);
            this.CBOCiudad.Name = "CBOCiudad";
            this.CBOCiudad.Size = new System.Drawing.Size(278, 24);
            this.CBOCiudad.TabIndex = 13;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(57, 428);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(68, 19);
            this.bunifuCustomLabel8.TabIndex = 7;
            this.bunifuCustomLabel8.Text = "Ciudad";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 372);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(83, 19);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Dirección";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(59, 305);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 19);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Correo";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(49, 234);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(83, 19);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Fecha de";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(64, 175);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(46, 19);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Sexo";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(52, 112);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(73, 19);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Nombre";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 52);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Documento";
            // 
            // FrmAbm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbm";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox Direccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.ComboBox CBOCiudad;
        public Bunifu.Framework.UI.BunifuFlatButton btnAccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Address;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Correo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Nombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Documento;
        public System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.RadioButton rbtnF;
        public System.Windows.Forms.RadioButton rbtnM;
    }
}