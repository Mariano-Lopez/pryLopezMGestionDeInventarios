namespace pryLopezMGestionDeInventarios
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblTit = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mrcSesion = new System.Windows.Forms.GroupBox();
            this.chkContraseña = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblCIES = new System.Windows.Forms.Label();
            this.imgIES = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblGuiones = new System.Windows.Forms.Label();
            this.mrcSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTit
            // 
            this.lblTit.BackColor = System.Drawing.Color.Black;
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTit.Location = new System.Drawing.Point(107, 5);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(294, 26);
            this.lblTit.TabIndex = 0;
            this.lblTit.Text = "Gestión de inventario";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Black;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNom.Location = new System.Drawing.Point(107, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(139, 36);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Korax";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.BackColor = System.Drawing.Color.Black;
            this.lblInstruccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInstruccion.Location = new System.Drawing.Point(31, 105);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(443, 77);
            this.lblInstruccion.TabIndex = 3;
            this.lblInstruccion.Text = "Porfavor complete los campos para ingresar al sistema.\r\nRecuerde que solo cuenta " +
    "con 3 intentos sino su cuenta se bloqueará y deberá comunicarse con el departame" +
    "nto de sistemas.";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUsuario.Location = new System.Drawing.Point(6, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // mrcSesion
            // 
            this.mrcSesion.BackColor = System.Drawing.Color.Black;
            this.mrcSesion.Controls.Add(this.chkContraseña);
            this.mrcSesion.Controls.Add(this.btnIngresar);
            this.mrcSesion.Controls.Add(this.lblContraseña);
            this.mrcSesion.Controls.Add(this.txtContra);
            this.mrcSesion.Controls.Add(this.txtUsuario);
            this.mrcSesion.Controls.Add(this.lblUsuario);
            this.mrcSesion.Location = new System.Drawing.Point(135, 190);
            this.mrcSesion.Name = "mrcSesion";
            this.mrcSesion.Size = new System.Drawing.Size(189, 175);
            this.mrcSesion.TabIndex = 5;
            this.mrcSesion.TabStop = false;
            // 
            // chkContraseña
            // 
            this.chkContraseña.AutoSize = true;
            this.chkContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContraseña.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkContraseña.Location = new System.Drawing.Point(9, 114);
            this.chkContraseña.Name = "chkContraseña";
            this.chkContraseña.Size = new System.Drawing.Size(135, 17);
            this.chkContraseña.TabIndex = 9;
            this.chkContraseña.Text = "Mostrar contraseña";
            this.chkContraseña.UseVisualStyleBackColor = true;
            this.chkContraseña.CheckedChanged += new System.EventHandler(this.chkContraseña_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIngresar.Location = new System.Drawing.Point(52, 136);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 23);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblContraseña.Location = new System.Drawing.Point(6, 70);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(90, 16);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(9, 88);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(170, 20);
            this.txtContra.TabIndex = 6;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContra_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(170, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.BackColor = System.Drawing.Color.Black;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.Red;
            this.lblIntentos.Location = new System.Drawing.Point(121, 377);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(162, 20);
            this.lblIntentos.TabIndex = 9;
            this.lblIntentos.Text = "Intentos restantes:";
            this.lblIntentos.Visible = false;
            // 
            // lblCIES
            // 
            this.lblCIES.AutoSize = true;
            this.lblCIES.BackColor = System.Drawing.Color.Black;
            this.lblCIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIES.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCIES.Location = new System.Drawing.Point(12, 408);
            this.lblCIES.Name = "lblCIES";
            this.lblCIES.Size = new System.Drawing.Size(277, 16);
            this.lblCIES.TabIndex = 10;
            this.lblCIES.Text = "Coleigo Universitario IES Siglo 21 2025";
            // 
            // imgIES
            // 
            this.imgIES.Image = ((System.Drawing.Image)(resources.GetObject("imgIES.Image")));
            this.imgIES.Location = new System.Drawing.Point(432, 377);
            this.imgIES.Name = "imgIES";
            this.imgIES.Size = new System.Drawing.Size(53, 46);
            this.imgIES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIES.TabIndex = 11;
            this.imgIES.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Black;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 9);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(89, 83);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 12;
            this.imgLogo.TabStop = false;
            // 
            // lblGuiones
            // 
            this.lblGuiones.BackColor = System.Drawing.Color.Black;
            this.lblGuiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuiones.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGuiones.Location = new System.Drawing.Point(107, 67);
            this.lblGuiones.Name = "lblGuiones";
            this.lblGuiones.Size = new System.Drawing.Size(288, 25);
            this.lblGuiones.TabIndex = 13;
            this.lblGuiones.Text = "----------------------------------------------";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 432);
            this.Controls.Add(this.lblGuiones);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.imgIES);
            this.Controls.Add(this.lblCIES);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.mrcSesion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión - Gestión de inventario Korax";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.mrcSesion.ResumeLayout(false);
            this.mrcSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox mrcSesion;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblCIES;
        private System.Windows.Forms.PictureBox imgIES;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblGuiones;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.CheckBox chkContraseña;
    }
}