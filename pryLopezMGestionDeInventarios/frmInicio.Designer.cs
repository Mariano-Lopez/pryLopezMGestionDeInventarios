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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblACod = new System.Windows.Forms.Label();
            this.lblANombre = new System.Windows.Forms.Label();
            this.txtANom = new System.Windows.Forms.TextBox();
            this.lblADescripcion = new System.Windows.Forms.Label();
            this.txtADesc = new System.Windows.Forms.TextBox();
            this.lblAPrecio = new System.Windows.Forms.Label();
            this.lblAStock = new System.Windows.Forms.Label();
            this.lblACategorias = new System.Windows.Forms.Label();
            this.mrcAgregar = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cmbACat = new System.Windows.Forms.ComboBox();
            this.numAStock = new System.Windows.Forms.NumericUpDown();
            this.numAPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numACod = new System.Windows.Forms.NumericUpDown();
            this.mrcInstrucciones = new System.Windows.Forms.GroupBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).BeginInit();
            this.mrcInstrucciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificar.Location = new System.Drawing.Point(104, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminar.Location = new System.Drawing.Point(23, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.Location = new System.Drawing.Point(10, 216);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.ShowEditingIcon = false;
            this.dgvInventario.Size = new System.Drawing.Size(654, 218);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventario_CellMouseClick);
            // 
            // lblACod
            // 
            this.lblACod.AutoSize = true;
            this.lblACod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblACod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblACod.Location = new System.Drawing.Point(20, 21);
            this.lblACod.Name = "lblACod";
            this.lblACod.Size = new System.Drawing.Size(40, 13);
            this.lblACod.TabIndex = 3;
            this.lblACod.Text = "Código";
            // 
            // lblANombre
            // 
            this.lblANombre.AutoSize = true;
            this.lblANombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblANombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblANombre.Location = new System.Drawing.Point(133, 21);
            this.lblANombre.Name = "lblANombre";
            this.lblANombre.Size = new System.Drawing.Size(44, 13);
            this.lblANombre.TabIndex = 14;
            this.lblANombre.Text = "Nombre";
            // 
            // txtANom
            // 
            this.txtANom.Location = new System.Drawing.Point(132, 37);
            this.txtANom.Name = "txtANom";
            this.txtANom.Size = new System.Drawing.Size(100, 20);
            this.txtANom.TabIndex = 1;
            this.txtANom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblADescripcion
            // 
            this.lblADescripcion.AutoSize = true;
            this.lblADescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblADescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblADescripcion.Location = new System.Drawing.Point(21, 63);
            this.lblADescripcion.Name = "lblADescripcion";
            this.lblADescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblADescripcion.TabIndex = 16;
            this.lblADescripcion.Text = "Descripcion";
            // 
            // txtADesc
            // 
            this.txtADesc.Location = new System.Drawing.Point(20, 79);
            this.txtADesc.Multiline = true;
            this.txtADesc.Name = "txtADesc";
            this.txtADesc.Size = new System.Drawing.Size(212, 60);
            this.txtADesc.TabIndex = 3;
            this.txtADesc.TextChanged += new System.EventHandler(this.txtADesc_TextChanged);
            // 
            // lblAPrecio
            // 
            this.lblAPrecio.AutoSize = true;
            this.lblAPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAPrecio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAPrecio.Location = new System.Drawing.Point(240, 63);
            this.lblAPrecio.Name = "lblAPrecio";
            this.lblAPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblAPrecio.TabIndex = 18;
            this.lblAPrecio.Text = "Precio";
            // 
            // lblAStock
            // 
            this.lblAStock.AutoSize = true;
            this.lblAStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAStock.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAStock.Location = new System.Drawing.Point(240, 20);
            this.lblAStock.Name = "lblAStock";
            this.lblAStock.Size = new System.Drawing.Size(35, 13);
            this.lblAStock.TabIndex = 20;
            this.lblAStock.Text = "Stock";
            // 
            // lblACategorias
            // 
            this.lblACategorias.AutoSize = true;
            this.lblACategorias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblACategorias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblACategorias.Location = new System.Drawing.Point(240, 102);
            this.lblACategorias.Name = "lblACategorias";
            this.lblACategorias.Size = new System.Drawing.Size(59, 13);
            this.lblACategorias.TabIndex = 22;
            this.lblACategorias.Text = "Categorías";
            // 
            // mrcAgregar
            // 
            this.mrcAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.mrcAgregar.Controls.Add(this.btnReiniciar);
            this.mrcAgregar.Controls.Add(this.cmbACat);
            this.mrcAgregar.Controls.Add(this.btnEliminar);
            this.mrcAgregar.Controls.Add(this.numAStock);
            this.mrcAgregar.Controls.Add(this.numAPrecio);
            this.mrcAgregar.Controls.Add(this.btnAgregar);
            this.mrcAgregar.Controls.Add(this.btnModificar);
            this.mrcAgregar.Controls.Add(this.numACod);
            this.mrcAgregar.Controls.Add(this.txtADesc);
            this.mrcAgregar.Controls.Add(this.lblACod);
            this.mrcAgregar.Controls.Add(this.txtANom);
            this.mrcAgregar.Controls.Add(this.lblANombre);
            this.mrcAgregar.Controls.Add(this.lblADescripcion);
            this.mrcAgregar.Controls.Add(this.lblACategorias);
            this.mrcAgregar.Controls.Add(this.lblAPrecio);
            this.mrcAgregar.Controls.Add(this.lblAStock);
            this.mrcAgregar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mrcAgregar.Location = new System.Drawing.Point(12, 12);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Size = new System.Drawing.Size(365, 198);
            this.mrcAgregar.TabIndex = 0;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Agregar producto";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(266, 156);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cmbACat
            // 
            this.cmbACat.FormattingEnabled = true;
            this.cmbACat.Location = new System.Drawing.Point(240, 118);
            this.cmbACat.Name = "cmbACat";
            this.cmbACat.Size = new System.Drawing.Size(100, 21);
            this.cmbACat.TabIndex = 5;
            this.cmbACat.Text = "Seleccione...";
            this.cmbACat.SelectedIndexChanged += new System.EventHandler(this.cmbACat_SelectedIndexChanged);
            // 
            // numAStock
            // 
            this.numAStock.Location = new System.Drawing.Point(241, 36);
            this.numAStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAStock.Name = "numAStock";
            this.numAStock.Size = new System.Drawing.Size(100, 20);
            this.numAStock.TabIndex = 2;
            this.numAStock.ValueChanged += new System.EventHandler(this.numAStock_ValueChanged);
            // 
            // numAPrecio
            // 
            this.numAPrecio.Location = new System.Drawing.Point(241, 79);
            this.numAPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAPrecio.Name = "numAPrecio";
            this.numAPrecio.Size = new System.Drawing.Size(100, 20);
            this.numAPrecio.TabIndex = 4;
            this.numAPrecio.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(185, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numACod
            // 
            this.numACod.Location = new System.Drawing.Point(20, 38);
            this.numACod.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numACod.Name = "numACod";
            this.numACod.Size = new System.Drawing.Size(100, 20);
            this.numACod.TabIndex = 0;
            this.numACod.ValueChanged += new System.EventHandler(this.numACod_ValueChanged);
            // 
            // mrcInstrucciones
            // 
            this.mrcInstrucciones.BackColor = System.Drawing.Color.SlateGray;
            this.mrcInstrucciones.Controls.Add(this.lblInstrucciones);
            this.mrcInstrucciones.Location = new System.Drawing.Point(394, 12);
            this.mrcInstrucciones.Name = "mrcInstrucciones";
            this.mrcInstrucciones.Size = new System.Drawing.Size(270, 198);
            this.mrcInstrucciones.TabIndex = 2;
            this.mrcInstrucciones.TabStop = false;
            this.mrcInstrucciones.Text = "Instrucciones de uso";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Location = new System.Drawing.Point(6, 21);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(258, 174);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text");
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.mrcInstrucciones);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.mrcAgregar);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).EndInit();
            this.mrcInstrucciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblACod;
        private System.Windows.Forms.Label lblANombre;
        private System.Windows.Forms.TextBox txtANom;
        private System.Windows.Forms.Label lblADescripcion;
        private System.Windows.Forms.TextBox txtADesc;
        private System.Windows.Forms.Label lblAPrecio;
        private System.Windows.Forms.Label lblAStock;
        private System.Windows.Forms.Label lblACategorias;
        private System.Windows.Forms.GroupBox mrcAgregar;
        private System.Windows.Forms.NumericUpDown numAStock;
        private System.Windows.Forms.NumericUpDown numAPrecio;
        private System.Windows.Forms.NumericUpDown numACod;
        private System.Windows.Forms.ComboBox cmbACat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox mrcInstrucciones;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}

