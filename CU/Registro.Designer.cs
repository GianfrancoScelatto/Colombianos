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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtCFPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbBoxPreguntas = new System.Windows.Forms.ComboBox();
            this.txtRespuesta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNick = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConfContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(400, 45);
            this.panel1.TabIndex = 10;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(358, 9);
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
            this.pbMinimizar.Location = new System.Drawing.Point(322, 9);
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
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO USUARIO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 455);
            this.panel2.TabIndex = 9;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtCFPass);
            this.bunifuGradientPanel1.Controls.Add(this.txtPass);
            this.bunifuGradientPanel1.Controls.Add(this.cmbBoxPreguntas);
            this.bunifuGradientPanel1.Controls.Add(this.txtRespuesta);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.Controls.Add(this.txtNick);
            this.bunifuGradientPanel1.Controls.Add(this.btnCrear);
            this.bunifuGradientPanel1.Controls.Add(this.txtMail);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtContraseña);
            this.bunifuGradientPanel1.Controls.Add(this.txtConfContraseña);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(400, 455);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // txtCFPass
            // 
            this.txtCFPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCFPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCFPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCFPass.ForeColor = System.Drawing.Color.White;
            this.txtCFPass.Location = new System.Drawing.Point(168, 217);
            this.txtCFPass.Name = "txtCFPass";
            this.txtCFPass.PasswordChar = '•';
            this.txtCFPass.Size = new System.Drawing.Size(210, 22);
            this.txtCFPass.TabIndex = 3;
            this.txtCFPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCFPass.Leave += new System.EventHandler(this.TxtCFPass_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(167, 154);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(210, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxPreguntas
            // 
            this.cmbBoxPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPreguntas.FormattingEnabled = true;
            this.cmbBoxPreguntas.Location = new System.Drawing.Point(167, 273);
            this.cmbBoxPreguntas.Name = "cmbBoxPreguntas";
            this.cmbBoxPreguntas.Size = new System.Drawing.Size(211, 21);
            this.cmbBoxPreguntas.TabIndex = 4;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtRespuesta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRespuesta.ForeColor = System.Drawing.Color.White;
            this.txtRespuesta.HintForeColor = System.Drawing.Color.Empty;
            this.txtRespuesta.HintText = "";
            this.txtRespuesta.isPassword = false;
            this.txtRespuesta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRespuesta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRespuesta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRespuesta.LineThickness = 3;
            this.txtRespuesta.Location = new System.Drawing.Point(167, 320);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(210, 33);
            this.txtRespuesta.TabIndex = 5;
            this.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(29, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(149, 48);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNick.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNick.ForeColor = System.Drawing.Color.White;
            this.txtNick.HintForeColor = System.Drawing.Color.Empty;
            this.txtNick.HintText = "";
            this.txtNick.isPassword = false;
            this.txtNick.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNick.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNick.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNick.LineThickness = 3;
            this.txtNick.Location = new System.Drawing.Point(167, 95);
            this.txtNick.Margin = new System.Windows.Forms.Padding(4);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(210, 33);
            this.txtNick.TabIndex = 1;
            this.txtNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNick_KeyPress);
            this.txtNick.Leave += new System.EventHandler(this.txtNick_Leave);
            // 
            // btnCrear
            // 
            this.btnCrear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrear.BorderRadius = 0;
            this.btnCrear.ButtonText = "Crear Usuario";
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.DisabledColor = System.Drawing.Color.Gray;
            this.btnCrear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCrear.Iconimage = null;
            this.btnCrear.Iconimage_right = null;
            this.btnCrear.Iconimage_right_Selected = null;
            this.btnCrear.Iconimage_Selected = null;
            this.btnCrear.IconMarginLeft = 0;
            this.btnCrear.IconMarginRight = 0;
            this.btnCrear.IconRightVisible = true;
            this.btnCrear.IconRightZoom = 0D;
            this.btnCrear.IconVisible = true;
            this.btnCrear.IconZoom = 90D;
            this.btnCrear.IsTab = false;
            this.btnCrear.Location = new System.Drawing.Point(223, 395);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCrear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCrear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCrear.selected = false;
            this.btnCrear.Size = new System.Drawing.Size(136, 48);
            this.btnCrear.TabIndex = 44;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrear.Textcolor = System.Drawing.Color.White;
            this.btnCrear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail.HintText = "";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMail.LineThickness = 3;
            this.txtMail.Location = new System.Drawing.Point(167, 25);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 33);
            this.txtMail.TabIndex = 0;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Respuesta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Pregunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Confirmar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.HintText = "";
            this.txtContraseña.isPassword = false;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContraseña.LineThickness = 3;
            this.txtContraseña.Location = new System.Drawing.Point(167, 154);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(210, 33);
            this.txtContraseña.TabIndex = 41;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtConfContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfContraseña.Enabled = false;
            this.txtConfContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfContraseña.ForeColor = System.Drawing.Color.White;
            this.txtConfContraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfContraseña.HintText = "";
            this.txtConfContraseña.isPassword = false;
            this.txtConfContraseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtConfContraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfContraseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtConfContraseña.LineThickness = 3;
            this.txtConfContraseña.Location = new System.Drawing.Point(167, 217);
            this.txtConfContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.Size = new System.Drawing.Size(210, 33);
            this.txtConfContraseña.TabIndex = 42;
            this.txtConfContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nick";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mail";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
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
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCrear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRespuesta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNick;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private System.Windows.Forms.ComboBox cmbBoxPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCFPass;
        private System.Windows.Forms.TextBox txtPass;
    }
}