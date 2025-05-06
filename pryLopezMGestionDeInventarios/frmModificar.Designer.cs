namespace pryLopezMGestionDeInventarios
{
    partial class frmModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mrcModificar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblModificar = new System.Windows.Forms.Label();
            this.imgModificar = new System.Windows.Forms.PictureBox();
            this.numCodM = new System.Windows.Forms.NumericUpDown();
            this.numPrecioM = new System.Windows.Forms.NumericUpDown();
            this.numStockM = new System.Windows.Forms.NumericUpDown();
            this.lblDesM = new System.Windows.Forms.Label();
            this.lblPreM = new System.Windows.Forms.Label();
            this.lblStockM = new System.Windows.Forms.Label();
            this.lblNomM = new System.Windows.Forms.Label();
            this.lblCatM = new System.Windows.Forms.Label();
            this.lblCodM = new System.Windows.Forms.Label();
            this.cmbCatM = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNomM = new System.Windows.Forms.TextBox();
            this.txtDescM = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mrcModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcModificar
            // 
            this.mrcModificar.BackColor = System.Drawing.Color.Black;
            this.mrcModificar.Controls.Add(this.btnBuscar);
            this.mrcModificar.Controls.Add(this.lblModificar);
            this.mrcModificar.Controls.Add(this.imgModificar);
            this.mrcModificar.Controls.Add(this.numCodM);
            this.mrcModificar.Controls.Add(this.numPrecioM);
            this.mrcModificar.Controls.Add(this.numStockM);
            this.mrcModificar.Controls.Add(this.lblDesM);
            this.mrcModificar.Controls.Add(this.lblPreM);
            this.mrcModificar.Controls.Add(this.lblStockM);
            this.mrcModificar.Controls.Add(this.lblNomM);
            this.mrcModificar.Controls.Add(this.lblCatM);
            this.mrcModificar.Controls.Add(this.lblCodM);
            this.mrcModificar.Controls.Add(this.cmbCatM);
            this.mrcModificar.Controls.Add(this.btnModificar);
            this.mrcModificar.Controls.Add(this.txtNomM);
            this.mrcModificar.Controls.Add(this.txtDescM);
            this.mrcModificar.Location = new System.Drawing.Point(34, 41);
            this.mrcModificar.Name = "mrcModificar";
            this.mrcModificar.Size = new System.Drawing.Size(705, 253);
            this.mrcModificar.TabIndex = 6;
            this.mrcModificar.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Location = new System.Drawing.Point(36, 215);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar producto";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblModificar.Location = new System.Drawing.Point(136, 19);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(552, 80);
            this.lblModificar.TabIndex = 21;
            this.lblModificar.Text = resources.GetString("lblModificar.Text");
            // 
            // imgModificar
            // 
            this.imgModificar.Image = ((System.Drawing.Image)(resources.GetObject("imgModificar.Image")));
            this.imgModificar.Location = new System.Drawing.Point(36, 19);
            this.imgModificar.Name = "imgModificar";
            this.imgModificar.Size = new System.Drawing.Size(94, 80);
            this.imgModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgModificar.TabIndex = 7;
            this.imgModificar.TabStop = false;
            // 
            // numCodM
            // 
            this.numCodM.Location = new System.Drawing.Point(36, 134);
            this.numCodM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCodM.Name = "numCodM";
            this.numCodM.Size = new System.Drawing.Size(77, 20);
            this.numCodM.TabIndex = 20;
            // 
            // numPrecioM
            // 
            this.numPrecioM.DecimalPlaces = 2;
            this.numPrecioM.Enabled = false;
            this.numPrecioM.Location = new System.Drawing.Point(123, 187);
            this.numPrecioM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioM.Name = "numPrecioM";
            this.numPrecioM.Size = new System.Drawing.Size(83, 20);
            this.numPrecioM.TabIndex = 18;
            // 
            // numStockM
            // 
            this.numStockM.Enabled = false;
            this.numStockM.Location = new System.Drawing.Point(36, 187);
            this.numStockM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStockM.Name = "numStockM";
            this.numStockM.Size = new System.Drawing.Size(77, 20);
            this.numStockM.TabIndex = 17;
            // 
            // lblDesM
            // 
            this.lblDesM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesM.AutoSize = true;
            this.lblDesM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDesM.Location = new System.Drawing.Point(342, 116);
            this.lblDesM.Name = "lblDesM";
            this.lblDesM.Size = new System.Drawing.Size(94, 16);
            this.lblDesM.TabIndex = 1;
            this.lblDesM.Text = "Descripción:";
            // 
            // lblPreM
            // 
            this.lblPreM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreM.AutoSize = true;
            this.lblPreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPreM.Location = new System.Drawing.Point(120, 169);
            this.lblPreM.Name = "lblPreM";
            this.lblPreM.Size = new System.Drawing.Size(56, 16);
            this.lblPreM.TabIndex = 3;
            this.lblPreM.Text = "Precio:";
            // 
            // lblStockM
            // 
            this.lblStockM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockM.AutoSize = true;
            this.lblStockM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockM.Location = new System.Drawing.Point(33, 169);
            this.lblStockM.Name = "lblStockM";
            this.lblStockM.Size = new System.Drawing.Size(50, 16);
            this.lblStockM.TabIndex = 4;
            this.lblStockM.Text = "Stock:";
            // 
            // lblNomM
            // 
            this.lblNomM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomM.AutoSize = true;
            this.lblNomM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomM.Location = new System.Drawing.Point(120, 115);
            this.lblNomM.Name = "lblNomM";
            this.lblNomM.Size = new System.Drawing.Size(66, 16);
            this.lblNomM.TabIndex = 2;
            this.lblNomM.Text = "Nombre:";
            // 
            // lblCatM
            // 
            this.lblCatM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCatM.AutoSize = true;
            this.lblCatM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCatM.Location = new System.Drawing.Point(209, 168);
            this.lblCatM.Name = "lblCatM";
            this.lblCatM.Size = new System.Drawing.Size(79, 16);
            this.lblCatM.TabIndex = 5;
            this.lblCatM.Text = "Categoría:";
            // 
            // lblCodM
            // 
            this.lblCodM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodM.AutoSize = true;
            this.lblCodM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodM.Location = new System.Drawing.Point(33, 116);
            this.lblCodM.Name = "lblCodM";
            this.lblCodM.Size = new System.Drawing.Size(61, 16);
            this.lblCodM.TabIndex = 0;
            this.lblCodM.Text = "Código:";
            // 
            // cmbCatM
            // 
            this.cmbCatM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCatM.Enabled = false;
            this.cmbCatM.FormattingEnabled = true;
            this.cmbCatM.Location = new System.Drawing.Point(212, 186);
            this.cmbCatM.Name = "cmbCatM";
            this.cmbCatM.Size = new System.Drawing.Size(124, 21);
            this.cmbCatM.TabIndex = 13;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.Location = new System.Drawing.Point(219, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(262, 24);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // txtNomM
            // 
            this.txtNomM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomM.Enabled = false;
            this.txtNomM.Location = new System.Drawing.Point(123, 134);
            this.txtNomM.Name = "txtNomM";
            this.txtNomM.Size = new System.Drawing.Size(213, 20);
            this.txtNomM.TabIndex = 8;
            // 
            // txtDescM
            // 
            this.txtDescM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescM.Enabled = false;
            this.txtDescM.Location = new System.Drawing.Point(345, 134);
            this.txtDescM.Multiline = true;
            this.txtDescM.Name = "txtDescM";
            this.txtDescM.Size = new System.Drawing.Size(326, 74);
            this.txtDescM.TabIndex = 9;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.Location = new System.Drawing.Point(55, 309);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(667, 287);
            this.dgvInventario.TabIndex = 5;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCerrar.Location = new System.Drawing.Point(34, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 656);
            this.Controls.Add(this.mrcModificar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificar";
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.mrcModificar.ResumeLayout(false);
            this.mrcModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcModificar;
        private System.Windows.Forms.NumericUpDown numCodM;
        private System.Windows.Forms.NumericUpDown numPrecioM;
        private System.Windows.Forms.NumericUpDown numStockM;
        private System.Windows.Forms.Label lblDesM;
        private System.Windows.Forms.Label lblPreM;
        private System.Windows.Forms.Label lblStockM;
        private System.Windows.Forms.Label lblNomM;
        private System.Windows.Forms.Label lblCatM;
        private System.Windows.Forms.Label lblCodM;
        private System.Windows.Forms.ComboBox cmbCatM;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNomM;
        private System.Windows.Forms.TextBox txtDescM;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox imgModificar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button btnBuscar;
    }
}