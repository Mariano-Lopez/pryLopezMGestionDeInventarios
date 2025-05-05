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
            this.imgCierre = new System.Windows.Forms.PictureBox();
            this.lblUltcon = new System.Windows.Forms.Label();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            this.imgEliminar = new System.Windows.Forms.PictureBox();
            this.imgModificar = new System.Windows.Forms.PictureBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.btnCerarSesion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTit = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.imgCierre);
            this.panelMenu.Controls.Add(this.lblUltcon);
            this.panelMenu.Controls.Add(this.imgInicio);
            this.panelMenu.Controls.Add(this.imgEliminar);
            this.panelMenu.Controls.Add(this.imgModificar);
            this.panelMenu.Controls.Add(this.imgAgregar);
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
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUsuario.Location = new System.Drawing.Point(2, 517);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(202, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre de usuario actual";
            // 
            // imgCierre
            // 
            this.imgCierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgCierre.Image = ((System.Drawing.Image)(resources.GetObject("imgCierre.Image")));
            this.imgCierre.Location = new System.Drawing.Point(0, 572);
            this.imgCierre.Name = "imgCierre";
            this.imgCierre.Size = new System.Drawing.Size(51, 45);
            this.imgCierre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCierre.TabIndex = 0;
            this.imgCierre.TabStop = false;
            // 
            // lblUltcon
            // 
            this.lblUltcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUltcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltcon.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltcon.Location = new System.Drawing.Point(3, 533);
            this.lblUltcon.Name = "lblUltcon";
            this.lblUltcon.Size = new System.Drawing.Size(241, 36);
            this.lblUltcon.TabIndex = 0;
            this.lblUltcon.Text = "Ffecha y hora de última conexión de usuario actual";
            // 
            // imgInicio
            // 
            this.imgInicio.Image = ((System.Drawing.Image)(resources.GetObject("imgInicio.Image")));
            this.imgInicio.Location = new System.Drawing.Point(0, 100);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(51, 45);
            this.imgInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInicio.TabIndex = 10;
            this.imgInicio.TabStop = false;
            // 
            // imgEliminar
            // 
            this.imgEliminar.Image = ((System.Drawing.Image)(resources.GetObject("imgEliminar.Image")));
            this.imgEliminar.Location = new System.Drawing.Point(0, 235);
            this.imgEliminar.Name = "imgEliminar";
            this.imgEliminar.Size = new System.Drawing.Size(51, 45);
            this.imgEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEliminar.TabIndex = 8;
            this.imgEliminar.TabStop = false;
            // 
            // imgModificar
            // 
            this.imgModificar.Image = ((System.Drawing.Image)(resources.GetObject("imgModificar.Image")));
            this.imgModificar.Location = new System.Drawing.Point(0, 190);
            this.imgModificar.Name = "imgModificar";
            this.imgModificar.Size = new System.Drawing.Size(51, 45);
            this.imgModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgModificar.TabIndex = 7;
            this.imgModificar.TabStop = false;
            // 
            // imgAgregar
            // 
            this.imgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("imgAgregar.Image")));
            this.imgAgregar.Location = new System.Drawing.Point(0, 145);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(51, 45);
            this.imgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAgregar.TabIndex = 6;
            this.imgAgregar.TabStop = false;
            // 
            // btnCerarSesion
            // 
            this.btnCerarSesion.BackColor = System.Drawing.Color.Black;
            this.btnCerarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCerarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCerarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlLogo.Controls.Add(this.imgLogo);
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
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTit.Location = new System.Drawing.Point(123, 9);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(121, 52);
            this.lblTit.TabIndex = 3;
            this.lblTit.Text = "Gestión de inventario";
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(117, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.imgCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.PictureBox imgAgregar;
        private System.Windows.Forms.PictureBox imgInicio;
        private System.Windows.Forms.PictureBox imgEliminar;
        private System.Windows.Forms.PictureBox imgModificar;
        private System.Windows.Forms.PictureBox imgCierre;
        private System.Windows.Forms.Label lblUltcon;
        private System.Windows.Forms.Label lblUsuario;
    }
}

