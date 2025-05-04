namespace pryGestionDeInventarios
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ptbCierre = new System.Windows.Forms.PictureBox();
            this.lblUltcon = new System.Windows.Forms.Label();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbModificar = new System.Windows.Forms.PictureBox();
            this.ptbAgregar = new System.Windows.Forms.PictureBox();
            this.btnCerarSesion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTit = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.ptbCierre);
            this.panelMenu.Controls.Add(this.lblUltcon);
            this.panelMenu.Controls.Add(this.ptbInicio);
            this.panelMenu.Controls.Add(this.ptbEliminar);
            this.panelMenu.Controls.Add(this.ptbModificar);
            this.panelMenu.Controls.Add(this.ptbAgregar);
            this.panelMenu.Controls.Add(this.btnCerarSesion);
            this.panelMenu.Controls.Add(this.btnEliminar);
            this.panelMenu.Controls.Add(this.btnModificar);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.pnlLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 617);
            this.panelMenu.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("BankGothic Md BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUsuario.Location = new System.Drawing.Point(2, 517);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(242, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "nombre de usurio actual";
            // 
            // ptbCierre
            // 
            this.ptbCierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbCierre.Image = ((System.Drawing.Image)(resources.GetObject("ptbCierre.Image")));
            this.ptbCierre.Location = new System.Drawing.Point(0, 572);
            this.ptbCierre.Name = "ptbCierre";
            this.ptbCierre.Size = new System.Drawing.Size(51, 45);
            this.ptbCierre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCierre.TabIndex = 0;
            this.ptbCierre.TabStop = false;
            // 
            // lblUltcon
            // 
            this.lblUltcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUltcon.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltcon.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltcon.Location = new System.Drawing.Point(3, 533);
            this.lblUltcon.Name = "lblUltcon";
            this.lblUltcon.Size = new System.Drawing.Size(241, 36);
            this.lblUltcon.TabIndex = 0;
            this.lblUltcon.Text = "fecha y hora de ultima conexion de usuario actual";
            // 
            // ptbInicio
            // 
            this.ptbInicio.Image = ((System.Drawing.Image)(resources.GetObject("ptbInicio.Image")));
            this.ptbInicio.Location = new System.Drawing.Point(0, 100);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(51, 45);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInicio.TabIndex = 10;
            this.ptbInicio.TabStop = false;
            // 
            // ptbEliminar
            // 
            this.ptbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("ptbEliminar.Image")));
            this.ptbEliminar.Location = new System.Drawing.Point(0, 235);
            this.ptbEliminar.Name = "ptbEliminar";
            this.ptbEliminar.Size = new System.Drawing.Size(51, 45);
            this.ptbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEliminar.TabIndex = 8;
            this.ptbEliminar.TabStop = false;
            // 
            // ptbModificar
            // 
            this.ptbModificar.Image = ((System.Drawing.Image)(resources.GetObject("ptbModificar.Image")));
            this.ptbModificar.Location = new System.Drawing.Point(0, 190);
            this.ptbModificar.Name = "ptbModificar";
            this.ptbModificar.Size = new System.Drawing.Size(51, 45);
            this.ptbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbModificar.TabIndex = 7;
            this.ptbModificar.TabStop = false;
            // 
            // ptbAgregar
            // 
            this.ptbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAgregar.Image")));
            this.ptbAgregar.Location = new System.Drawing.Point(0, 145);
            this.ptbAgregar.Name = "ptbAgregar";
            this.ptbAgregar.Size = new System.Drawing.Size(51, 45);
            this.ptbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgregar.TabIndex = 6;
            this.ptbAgregar.TabStop = false;
            // 
            // btnCerarSesion
            // 
            this.btnCerarSesion.BackColor = System.Drawing.Color.Black;
            this.btnCerarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCerarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCerarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerarSesion.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerarSesion.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCerarSesion.Location = new System.Drawing.Point(0, 572);
            this.btnCerarSesion.Name = "btnCerarSesion";
            this.btnCerarSesion.Size = new System.Drawing.Size(250, 45);
            this.btnCerarSesion.TabIndex = 4;
            this.btnCerarSesion.Text = "Cerrar sesión";
            this.btnCerarSesion.UseVisualStyleBackColor = false;
            this.btnCerarSesion.Click += new System.EventHandler(this.btnCerarSesion_Click);
            this.btnCerarSesion.MouseEnter += new System.EventHandler(this.btnCerarSesion_MouseEnter);
            this.btnCerarSesion.MouseLeave += new System.EventHandler(this.btnCerarSesion_MouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.Location = new System.Drawing.Point(0, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(250, 45);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("BankGothic Md BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.Location = new System.Drawing.Point(0, 190);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(250, 45);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(250, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblNom);
            this.pnlLogo.Controls.Add(this.lblTit);
            this.pnlLogo.Controls.Add(this.ptbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.Color.DarkGreen;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Black;
            this.lblNom.Font = new System.Drawing.Font("BankGothic Md BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNom.Location = new System.Drawing.Point(117, 48);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(122, 36);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Korax";
            // 
            // lblTit
            // 
            this.lblTit.BackColor = System.Drawing.Color.Black;
            this.lblTit.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTit.Location = new System.Drawing.Point(123, 9);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(121, 52);
            this.lblTit.TabIndex = 3;
            this.lblTit.Text = "Gestión de inventario";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(117, 100);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlFormHijo
            // 
            this.pnlFormHijo.BackColor = System.Drawing.Color.Black;
            this.pnlFormHijo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormHijo.BackgroundImage")));
            this.pnlFormHijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHijo.Location = new System.Drawing.Point(250, 0);
            this.pnlFormHijo.Name = "pnlFormHijo";
            this.pnlFormHijo.Size = new System.Drawing.Size(777, 617);
            this.pnlFormHijo.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 617);
            this.Controls.Add(this.pnlFormHijo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de inventario Korax";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnCerarSesion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.PictureBox ptbAgregar;
        private System.Windows.Forms.PictureBox ptbInicio;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbModificar;
        private System.Windows.Forms.PictureBox ptbCierre;
        private System.Windows.Forms.Label lblUltcon;
        private System.Windows.Forms.Label lblUsuario;
    }
}

