namespace pryLopezMGestionDeInventarios
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.chkConf = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.imgEliminar = new System.Windows.Forms.PictureBox();
            this.numCodE = new System.Windows.Forms.NumericUpDown();
            this.numPrecioE = new System.Windows.Forms.NumericUpDown();
            this.numStockE = new System.Windows.Forms.NumericUpDown();
            this.lblDesE = new System.Windows.Forms.Label();
            this.lblPreE = new System.Windows.Forms.Label();
            this.lblStockE = new System.Windows.Forms.Label();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblCatE = new System.Windows.Forms.Label();
            this.lblCodE = new System.Windows.Forms.Label();
            this.cmbCatE = new System.Windows.Forms.ComboBox();
            this.txtNomE = new System.Windows.Forms.TextBox();
            this.txtDescE = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mrcEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.BackColor = System.Drawing.Color.Black;
            this.mrcEliminar.Controls.Add(this.chkConf);
            this.mrcEliminar.Controls.Add(this.btnBuscar);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.lblEliminar);
            this.mrcEliminar.Controls.Add(this.imgEliminar);
            this.mrcEliminar.Controls.Add(this.numCodE);
            this.mrcEliminar.Controls.Add(this.numPrecioE);
            this.mrcEliminar.Controls.Add(this.numStockE);
            this.mrcEliminar.Controls.Add(this.lblDesE);
            this.mrcEliminar.Controls.Add(this.lblPreE);
            this.mrcEliminar.Controls.Add(this.lblStockE);
            this.mrcEliminar.Controls.Add(this.lblNomE);
            this.mrcEliminar.Controls.Add(this.lblCatE);
            this.mrcEliminar.Controls.Add(this.lblCodE);
            this.mrcEliminar.Controls.Add(this.cmbCatE);
            this.mrcEliminar.Controls.Add(this.txtNomE);
            this.mrcEliminar.Controls.Add(this.txtDescE);
            this.mrcEliminar.Location = new System.Drawing.Point(34, 41);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Size = new System.Drawing.Size(705, 253);
            this.mrcEliminar.TabIndex = 6;
            this.mrcEliminar.TabStop = false;
            // 
            // chkConf
            // 
            this.chkConf.AutoSize = true;
            this.chkConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConf.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkConf.Location = new System.Drawing.Point(503, 218);
            this.chkConf.Name = "chkConf";
            this.chkConf.Size = new System.Drawing.Size(160, 17);
            this.chkConf.TabIndex = 25;
            this.chkConf.Text = "Mesaje de confirmación";
            this.chkConf.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Location = new System.Drawing.Point(36, 213);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar producto";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.Location = new System.Drawing.Point(256, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(241, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter_1);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave_1);
            // 
            // lblEliminar
            // 
            this.lblEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEliminar.Location = new System.Drawing.Point(140, 19);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(531, 80);
            this.lblEliminar.TabIndex = 22;
            this.lblEliminar.Text = "Para elminar un producto, haga click sobre la fila que desea borrar, también lo p" +
    "uede buscar  por el código del mismo.";
            // 
            // imgEliminar
            // 
            this.imgEliminar.Image = ((System.Drawing.Image)(resources.GetObject("imgEliminar.Image")));
            this.imgEliminar.Location = new System.Drawing.Point(36, 19);
            this.imgEliminar.Name = "imgEliminar";
            this.imgEliminar.Size = new System.Drawing.Size(94, 80);
            this.imgEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEliminar.TabIndex = 21;
            this.imgEliminar.TabStop = false;
            // 
            // numCodE
            // 
            this.numCodE.Location = new System.Drawing.Point(36, 134);
            this.numCodE.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCodE.Name = "numCodE";
            this.numCodE.Size = new System.Drawing.Size(77, 20);
            this.numCodE.TabIndex = 20;
            // 
            // numPrecioE
            // 
            this.numPrecioE.DecimalPlaces = 2;
            this.numPrecioE.Enabled = false;
            this.numPrecioE.Location = new System.Drawing.Point(123, 187);
            this.numPrecioE.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioE.Name = "numPrecioE";
            this.numPrecioE.Size = new System.Drawing.Size(83, 20);
            this.numPrecioE.TabIndex = 18;
            // 
            // numStockE
            // 
            this.numStockE.Enabled = false;
            this.numStockE.Location = new System.Drawing.Point(36, 187);
            this.numStockE.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStockE.Name = "numStockE";
            this.numStockE.Size = new System.Drawing.Size(77, 20);
            this.numStockE.TabIndex = 17;
            // 
            // lblDesE
            // 
            this.lblDesE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesE.AutoSize = true;
            this.lblDesE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDesE.Location = new System.Drawing.Point(342, 115);
            this.lblDesE.Name = "lblDesE";
            this.lblDesE.Size = new System.Drawing.Size(94, 16);
            this.lblDesE.TabIndex = 1;
            this.lblDesE.Text = "Descripción:";
            // 
            // lblPreE
            // 
            this.lblPreE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreE.AutoSize = true;
            this.lblPreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPreE.Location = new System.Drawing.Point(120, 169);
            this.lblPreE.Name = "lblPreE";
            this.lblPreE.Size = new System.Drawing.Size(56, 16);
            this.lblPreE.TabIndex = 3;
            this.lblPreE.Text = "Precio:";
            // 
            // lblStockE
            // 
            this.lblStockE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockE.AutoSize = true;
            this.lblStockE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockE.Location = new System.Drawing.Point(33, 169);
            this.lblStockE.Name = "lblStockE";
            this.lblStockE.Size = new System.Drawing.Size(50, 16);
            this.lblStockE.TabIndex = 4;
            this.lblStockE.Text = "Stock:";
            // 
            // lblNomE
            // 
            this.lblNomE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomE.Location = new System.Drawing.Point(120, 115);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(66, 16);
            this.lblNomE.TabIndex = 2;
            this.lblNomE.Text = "Nombre:";
            // 
            // lblCatE
            // 
            this.lblCatE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCatE.AutoSize = true;
            this.lblCatE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCatE.Location = new System.Drawing.Point(209, 168);
            this.lblCatE.Name = "lblCatE";
            this.lblCatE.Size = new System.Drawing.Size(79, 16);
            this.lblCatE.TabIndex = 5;
            this.lblCatE.Text = "Categoría:";
            // 
            // lblCodE
            // 
            this.lblCodE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodE.AutoSize = true;
            this.lblCodE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodE.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodE.Location = new System.Drawing.Point(33, 115);
            this.lblCodE.Name = "lblCodE";
            this.lblCodE.Size = new System.Drawing.Size(61, 16);
            this.lblCodE.TabIndex = 0;
            this.lblCodE.Text = "Código:";
            // 
            // cmbCatE
            // 
            this.cmbCatE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCatE.Enabled = false;
            this.cmbCatE.FormattingEnabled = true;
            this.cmbCatE.Location = new System.Drawing.Point(212, 186);
            this.cmbCatE.Name = "cmbCatE";
            this.cmbCatE.Size = new System.Drawing.Size(124, 21);
            this.cmbCatE.TabIndex = 13;
            // 
            // txtNomE
            // 
            this.txtNomE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomE.Enabled = false;
            this.txtNomE.Location = new System.Drawing.Point(123, 134);
            this.txtNomE.Name = "txtNomE";
            this.txtNomE.Size = new System.Drawing.Size(213, 20);
            this.txtNomE.TabIndex = 8;
            // 
            // txtDescE
            // 
            this.txtDescE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescE.Enabled = false;
            this.txtDescE.Location = new System.Drawing.Point(345, 134);
            this.txtDescE.Multiline = true;
            this.txtDescE.Name = "txtDescE";
            this.txtDescE.Size = new System.Drawing.Size(326, 74);
            this.txtDescE.TabIndex = 9;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.Black;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.Location = new System.Drawing.Point(51, 300);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(667, 287);
            this.dgvInventario.TabIndex = 5;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCerrar.Location = new System.Drawing.Point(34, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 617);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminar";
            this.Text = "Eliminar producto";
            this.Load += new System.EventHandler(this.frmEliminar_Load);
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.NumericUpDown numCodE;
        private System.Windows.Forms.NumericUpDown numPrecioE;
        private System.Windows.Forms.NumericUpDown numStockE;
        private System.Windows.Forms.Label lblDesE;
        private System.Windows.Forms.Label lblPreE;
        private System.Windows.Forms.Label lblStockE;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblCatE;
        private System.Windows.Forms.Label lblCodE;
        private System.Windows.Forms.ComboBox cmbCatE;
        private System.Windows.Forms.TextBox txtNomE;
        private System.Windows.Forms.TextBox txtDescE;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox imgEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkConf;
    }
}