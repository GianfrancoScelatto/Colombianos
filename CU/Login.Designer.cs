namespace CU
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LkLblPass = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.LkLblRegistro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(392, 45);
            this.panel1.TabIndex = 9;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(350, 9);
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
            this.pbMinimizar.Location = new System.Drawing.Point(314, 9);
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
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 374);
            this.panel2.TabIndex = 9;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtuser);
            this.bunifuGradientPanel1.Controls.Add(this.txtPass);
            this.bunifuGradientPanel1.Controls.Add(this.passCheck);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.LkLblRegistro);
            this.bunifuGradientPanel1.Controls.Add(this.btnLog);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.LkLblPass);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(392, 374);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLog.BorderRadius = 0;
            this.btnLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLog.ButtonText = "Ingresar";
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLog.Iconimage = null;
            this.btnLog.Iconimage_right = null;
            this.btnLog.Iconimage_right_Selected = null;
            this.btnLog.Iconimage_Selected = null;
            this.btnLog.IconMarginLeft = 0;
            this.btnLog.IconMarginRight = 0;
            this.btnLog.IconRightVisible = true;
            this.btnLog.IconRightZoom = 0D;
            this.btnLog.IconVisible = true;
            this.btnLog.IconZoom = 90D;
            this.btnLog.IsTab = false;
            this.btnLog.Location = new System.Drawing.Point(148, 254);
            this.btnLog.Name = "btnLog";
            this.btnLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLog.selected = false;
            this.btnLog.Size = new System.Drawing.Size(97, 48);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Ingresar";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLog.Textcolor = System.Drawing.Color.White;
            this.btnLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuario o Mail";
            // 
            // LkLblPass
            // 
            this.LkLblPass.AutoSize = true;
            this.LkLblPass.BackColor = System.Drawing.Color.Transparent;
            this.LkLblPass.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.LkLblPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblPass.LinkColor = System.Drawing.Color.White;
            this.LkLblPass.Location = new System.Drawing.Point(244, 350);
            this.LkLblPass.Name = "LkLblPass";
            this.LkLblPass.Size = new System.Drawing.Size(136, 15);
            this.LkLblPass.TabIndex = 3;
            this.LkLblPass.TabStop = true;
            this.LkLblPass.Text = "¿Olvidó su contraseña?";
            this.LkLblPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblPass_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contraseña";
            // 
            // LkLblRegistro
            // 
            this.LkLblRegistro.AutoSize = true;
            this.LkLblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.LkLblRegistro.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.LkLblRegistro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LkLblRegistro.LinkColor = System.Drawing.Color.White;
            this.LkLblRegistro.Location = new System.Drawing.Point(294, 103);
            this.LkLblRegistro.Name = "LkLblRegistro";
            this.LkLblRegistro.Size = new System.Drawing.Size(70, 15);
            this.LkLblRegistro.TabIndex = 4;
            this.LkLblRegistro.TabStop = true;
            this.LkLblRegistro.Text = "Registrarse";
            this.LkLblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblRegistro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mostrar contraseña";
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.BackColor = System.Drawing.Color.Transparent;
            this.passCheck.Location = new System.Drawing.Point(350, 193);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(15, 14);
            this.passCheck.TabIndex = 32;
            this.passCheck.UseVisualStyleBackColor = false;
            this.passCheck.CheckedChanged += new System.EventHandler(this.PassCheck_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(148, 149);
            this.txtPass.MaxLength = 16;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(216, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(149, 62);
            this.txtuser.MaxLength = 30;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(216, 27);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LkLblPass;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnLog;
        private System.Windows.Forms.LinkLabel LkLblRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtuser;
    }
}