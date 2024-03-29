﻿namespace CU
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
            this.lblErrorMsg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 45);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
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
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
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
            this.bunifuGradientPanel1.Controls.Add(this.lblErrorMsg);
            this.bunifuGradientPanel1.Controls.Add(this.txtAddress);
            this.bunifuGradientPanel1.Controls.Add(this.txtCorreo);
            this.bunifuGradientPanel1.Controls.Add(this.txtNombre);
            this.bunifuGradientPanel1.Controls.Add(this.txtDocumento);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnF);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnM);
            this.bunifuGradientPanel1.Controls.Add(this.dtpFecha);
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
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblErrorMsg.Location = new System.Drawing.Point(164, 79);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMsg.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(188, 387);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 27);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(188, 329);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(216, 27);
            this.txtCorreo.TabIndex = 39;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCorreo.Leave += new System.EventHandler(this.Correo_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(188, 118);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 27);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.White;
            this.txtDocumento.Location = new System.Drawing.Point(188, 49);
            this.txtDocumento.MaxLength = 9;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(216, 27);
            this.txtDocumento.TabIndex = 37;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocumento.Leave += new System.EventHandler(this.Documento_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(302, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(118, 39);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.BackColor = System.Drawing.Color.Transparent;
            this.rbtnF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnF.Location = new System.Drawing.Point(299, 184);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(105, 23);
            this.rbtnF.TabIndex = 3;
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
            this.rbtnM.TabIndex = 2;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Masculino";
            this.rbtnM.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(188, 268);
            this.dtpFecha.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(216, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(42, 268);
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
            this.btnAccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAccion.ButtonText = "    Aceptar";
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
            this.btnAccion.IconZoom = 50D;
            this.btnAccion.IsTab = false;
            this.btnAccion.Location = new System.Drawing.Point(82, 504);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAccion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccion.selected = false;
            this.btnAccion.Size = new System.Drawing.Size(118, 39);
            this.btnAccion.TabIndex = 8;
            this.btnAccion.Text = "    Aceptar";
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
            this.CBOCiudad.Location = new System.Drawing.Point(188, 447);
            this.CBOCiudad.Name = "CBOCiudad";
            this.CBOCiudad.Size = new System.Drawing.Size(216, 24);
            this.CBOCiudad.TabIndex = 7;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(42, 452);
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
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(42, 390);
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
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(42, 332);
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
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(42, 249);
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
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(42, 188);
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
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(42, 121);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.RadioButton rbtnF;
        public System.Windows.Forms.RadioButton rbtnM;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        public Bunifu.Framework.UI.BunifuCustomLabel lblErrorMsg;
    }
}