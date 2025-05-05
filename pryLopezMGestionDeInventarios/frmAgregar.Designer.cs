namespace pryLopezMGestionDeInventarios
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.mrcAgregar = new System.Windows.Forms.GroupBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.numCodA = new System.Windows.Forms.NumericUpDown();
            this.numPrecioA = new System.Windows.Forms.NumericUpDown();
            this.numStockA = new System.Windows.Forms.NumericUpDown();
            this.lblDesA = new System.Windows.Forms.Label();
            this.lblPreA = new System.Windows.Forms.Label();
            this.lblStockA = new System.Windows.Forms.Label();
            this.lblNomA = new System.Windows.Forms.Label();
            this.lblCatA = new System.Windows.Forms.Label();
            this.lblCodA = new System.Windows.Forms.Label();
            this.cmbCatA = new System.Windows.Forms.ComboBox();
            this.txtNomA = new System.Windows.Forms.TextBox();
            this.txtDescA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCerrar.Location = new System.Drawing.Point(34, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(219, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(262, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
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
            this.dgvInventario.Location = new System.Drawing.Point(51, 300);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(667, 287);
            this.dgvInventario.TabIndex = 2;
            // 
            // mrcAgregar
            // 
            this.mrcAgregar.BackColor = System.Drawing.Color.Black;
            this.mrcAgregar.Controls.Add(this.imgAgregar);
            this.mrcAgregar.Controls.Add(this.lblAgregar);
            this.mrcAgregar.Controls.Add(this.numCodA);
            this.mrcAgregar.Controls.Add(this.numPrecioA);
            this.mrcAgregar.Controls.Add(this.numStockA);
            this.mrcAgregar.Controls.Add(this.lblDesA);
            this.mrcAgregar.Controls.Add(this.lblPreA);
            this.mrcAgregar.Controls.Add(this.lblStockA);
            this.mrcAgregar.Controls.Add(this.lblNomA);
            this.mrcAgregar.Controls.Add(this.lblCatA);
            this.mrcAgregar.Controls.Add(this.lblCodA);
            this.mrcAgregar.Controls.Add(this.cmbCatA);
            this.mrcAgregar.Controls.Add(this.btnAgregar);
            this.mrcAgregar.Controls.Add(this.txtNomA);
            this.mrcAgregar.Controls.Add(this.txtDescA);
            this.mrcAgregar.Location = new System.Drawing.Point(34, 41);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Size = new System.Drawing.Size(705, 253);
            this.mrcAgregar.TabIndex = 3;
            this.mrcAgregar.TabStop = false;
            // 
            // imgAgregar
            // 
            this.imgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("imgAgregar.Image")));
            this.imgAgregar.Location = new System.Drawing.Point(36, 20);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(94, 80);
            this.imgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAgregar.TabIndex = 4;
            this.imgAgregar.TabStop = false;
            // 
            // lblAgregar
            // 
            this.lblAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAgregar.Location = new System.Drawing.Point(136, 20);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(535, 86);
            this.lblAgregar.TabIndex = 21;
            this.lblAgregar.Text = "Para agregar un producto, llene todos los campos que se ven a continuación. En ca" +
    "so de que un campo quede vacío, el boton no se habilitará.";
            // 
            // numCodA
            // 
            this.numCodA.Location = new System.Drawing.Point(36, 134);
            this.numCodA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCodA.Name = "numCodA";
            this.numCodA.Size = new System.Drawing.Size(77, 20);
            this.numCodA.TabIndex = 0;
            this.numCodA.ValueChanged += new System.EventHandler(this.numCodA_ValueChanged);
            // 
            // numPrecioA
            // 
            this.numPrecioA.Location = new System.Drawing.Point(123, 187);
            this.numPrecioA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioA.Name = "numPrecioA";
            this.numPrecioA.Size = new System.Drawing.Size(83, 20);
            this.numPrecioA.TabIndex = 4;
            this.numPrecioA.ValueChanged += new System.EventHandler(this.numPrecioA_ValueChanged);
            // 
            // numStockA
            // 
            this.numStockA.Location = new System.Drawing.Point(36, 187);
            this.numStockA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStockA.Name = "numStockA";
            this.numStockA.Size = new System.Drawing.Size(77, 20);
            this.numStockA.TabIndex = 3;
            this.numStockA.ValueChanged += new System.EventHandler(this.numStockA_ValueChanged);
            // 
            // lblDesA
            // 
            this.lblDesA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesA.AutoSize = true;
            this.lblDesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDesA.Location = new System.Drawing.Point(342, 116);
            this.lblDesA.Name = "lblDesA";
            this.lblDesA.Size = new System.Drawing.Size(94, 16);
            this.lblDesA.TabIndex = 1;
            this.lblDesA.Text = "Descripción:";
            // 
            // lblPreA
            // 
            this.lblPreA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreA.AutoSize = true;
            this.lblPreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPreA.Location = new System.Drawing.Point(120, 168);
            this.lblPreA.Name = "lblPreA";
            this.lblPreA.Size = new System.Drawing.Size(56, 16);
            this.lblPreA.TabIndex = 3;
            this.lblPreA.Text = "Precio:";
            // 
            // lblStockA
            // 
            this.lblStockA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockA.AutoSize = true;
            this.lblStockA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockA.Location = new System.Drawing.Point(33, 168);
            this.lblStockA.Name = "lblStockA";
            this.lblStockA.Size = new System.Drawing.Size(50, 16);
            this.lblStockA.TabIndex = 4;
            this.lblStockA.Text = "Stock:";
            // 
            // lblNomA
            // 
            this.lblNomA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomA.AutoSize = true;
            this.lblNomA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomA.Location = new System.Drawing.Point(120, 116);
            this.lblNomA.Name = "lblNomA";
            this.lblNomA.Size = new System.Drawing.Size(66, 16);
            this.lblNomA.TabIndex = 2;
            this.lblNomA.Text = "Nombre:";
            // 
            // lblCatA
            // 
            this.lblCatA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCatA.AutoSize = true;
            this.lblCatA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCatA.Location = new System.Drawing.Point(209, 167);
            this.lblCatA.Name = "lblCatA";
            this.lblCatA.Size = new System.Drawing.Size(79, 16);
            this.lblCatA.TabIndex = 5;
            this.lblCatA.Text = "Categoría:";
            // 
            // lblCodA
            // 
            this.lblCodA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodA.AutoSize = true;
            this.lblCodA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodA.Location = new System.Drawing.Point(33, 116);
            this.lblCodA.Name = "lblCodA";
            this.lblCodA.Size = new System.Drawing.Size(61, 16);
            this.lblCodA.TabIndex = 0;
            this.lblCodA.Text = "Código:";
            // 
            // cmbCatA
            // 
            this.cmbCatA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCatA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatA.FormattingEnabled = true;
            this.cmbCatA.Location = new System.Drawing.Point(212, 186);
            this.cmbCatA.Name = "cmbCatA";
            this.cmbCatA.Size = new System.Drawing.Size(124, 21);
            this.cmbCatA.TabIndex = 5;
            this.cmbCatA.SelectedIndexChanged += new System.EventHandler(this.cmbCatA_SelectedIndexChanged);
            // 
            // txtNomA
            // 
            this.txtNomA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomA.Location = new System.Drawing.Point(123, 134);
            this.txtNomA.Name = "txtNomA";
            this.txtNomA.Size = new System.Drawing.Size(213, 20);
            this.txtNomA.TabIndex = 1;
            this.txtNomA.TextChanged += new System.EventHandler(this.txtNomA_TextChanged);
            // 
            // txtDescA
            // 
            this.txtDescA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescA.Location = new System.Drawing.Point(345, 134);
            this.txtDescA.Multiline = true;
            this.txtDescA.Name = "txtDescA";
            this.txtDescA.Size = new System.Drawing.Size(326, 74);
            this.txtDescA.TabIndex = 2;
            this.txtDescA.TextChanged += new System.EventHandler(this.txtDescA_TextChanged);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 617);
            this.Controls.Add(this.mrcAgregar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.Text = "Agregar producto";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox mrcAgregar;
        private System.Windows.Forms.Label lblCatA;
        private System.Windows.Forms.Label lblStockA;
        private System.Windows.Forms.Label lblPreA;
        private System.Windows.Forms.Label lblNomA;
        private System.Windows.Forms.Label lblDesA;
        private System.Windows.Forms.Label lblCodA;
        private System.Windows.Forms.ComboBox cmbCatA;
        private System.Windows.Forms.TextBox txtDescA;
        private System.Windows.Forms.TextBox txtNomA;
        private System.Windows.Forms.NumericUpDown numCodA;
        private System.Windows.Forms.NumericUpDown numPrecioA;
        private System.Windows.Forms.NumericUpDown numStockA;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.PictureBox imgAgregar;
    }
}