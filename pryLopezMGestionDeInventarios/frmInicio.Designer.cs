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
            this.btnAgregar = new System.Windows.Forms.Button();
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
            this.cmbACat = new System.Windows.Forms.ComboBox();
            this.numAStock = new System.Windows.Forms.NumericUpDown();
            this.numAPrecio = new System.Windows.Forms.NumericUpDown();
            this.numACod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(260, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(179, 117);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(98, 116);
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
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(14, 220);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.ShowEditingIcon = false;
            this.dgvInventario.Size = new System.Drawing.Size(656, 218);
            this.dgvInventario.TabIndex = 3;
            this.dgvInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellDoubleClick);
            // 
            // lblACod
            // 
            this.lblACod.AutoSize = true;
            this.lblACod.Location = new System.Drawing.Point(17, 21);
            this.lblACod.Name = "lblACod";
            this.lblACod.Size = new System.Drawing.Size(40, 13);
            this.lblACod.TabIndex = 12;
            this.lblACod.Text = "Código";
            // 
            // lblANombre
            // 
            this.lblANombre.AutoSize = true;
            this.lblANombre.Location = new System.Drawing.Point(126, 21);
            this.lblANombre.Name = "lblANombre";
            this.lblANombre.Size = new System.Drawing.Size(44, 13);
            this.lblANombre.TabIndex = 14;
            this.lblANombre.Text = "Nombre";
            // 
            // txtANom
            // 
            this.txtANom.Location = new System.Drawing.Point(129, 37);
            this.txtANom.Name = "txtANom";
            this.txtANom.Size = new System.Drawing.Size(100, 20);
            this.txtANom.TabIndex = 13;
            this.txtANom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblADescripcion
            // 
            this.lblADescripcion.AutoSize = true;
            this.lblADescripcion.Location = new System.Drawing.Point(17, 63);
            this.lblADescripcion.Name = "lblADescripcion";
            this.lblADescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblADescripcion.TabIndex = 16;
            this.lblADescripcion.Text = "Descripcion";
            // 
            // txtADesc
            // 
            this.txtADesc.Location = new System.Drawing.Point(20, 79);
            this.txtADesc.Name = "txtADesc";
            this.txtADesc.Size = new System.Drawing.Size(100, 20);
            this.txtADesc.TabIndex = 15;
            this.txtADesc.TextChanged += new System.EventHandler(this.txtADesc_TextChanged);
            // 
            // lblAPrecio
            // 
            this.lblAPrecio.AutoSize = true;
            this.lblAPrecio.Location = new System.Drawing.Point(126, 64);
            this.lblAPrecio.Name = "lblAPrecio";
            this.lblAPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblAPrecio.TabIndex = 18;
            this.lblAPrecio.Text = "Precio";
            // 
            // lblAStock
            // 
            this.lblAStock.AutoSize = true;
            this.lblAStock.Location = new System.Drawing.Point(240, 22);
            this.lblAStock.Name = "lblAStock";
            this.lblAStock.Size = new System.Drawing.Size(35, 13);
            this.lblAStock.TabIndex = 20;
            this.lblAStock.Text = "Stock";
            // 
            // lblACategorias
            // 
            this.lblACategorias.AutoSize = true;
            this.lblACategorias.Location = new System.Drawing.Point(235, 64);
            this.lblACategorias.Name = "lblACategorias";
            this.lblACategorias.Size = new System.Drawing.Size(59, 13);
            this.lblACategorias.TabIndex = 22;
            this.lblACategorias.Text = "Categorías";
            // 
            // mrcAgregar
            // 
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
            this.mrcAgregar.Location = new System.Drawing.Point(158, 45);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Size = new System.Drawing.Size(356, 156);
            this.mrcAgregar.TabIndex = 27;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Agregar producto";
            // 
            // cmbACat
            // 
            this.cmbACat.FormattingEnabled = true;
            this.cmbACat.Location = new System.Drawing.Point(235, 80);
            this.cmbACat.Name = "cmbACat";
            this.cmbACat.Size = new System.Drawing.Size(100, 21);
            this.cmbACat.TabIndex = 26;
            this.cmbACat.SelectedIndexChanged += new System.EventHandler(this.cmbACat_SelectedIndexChanged);
            // 
            // numAStock
            // 
            this.numAStock.Location = new System.Drawing.Point(235, 37);
            this.numAStock.Name = "numAStock";
            this.numAStock.Size = new System.Drawing.Size(100, 20);
            this.numAStock.TabIndex = 25;
            this.numAStock.ValueChanged += new System.EventHandler(this.numAStock_ValueChanged);
            // 
            // numAPrecio
            // 
            this.numAPrecio.Location = new System.Drawing.Point(129, 80);
            this.numAPrecio.Name = "numAPrecio";
            this.numAPrecio.Size = new System.Drawing.Size(100, 20);
            this.numAPrecio.TabIndex = 24;
            this.numAPrecio.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numACod
            // 
            this.numACod.Location = new System.Drawing.Point(20, 38);
            this.numACod.Name = "numACod";
            this.numACod.Size = new System.Drawing.Size(100, 20);
            this.numACod.TabIndex = 23;
            this.numACod.ValueChanged += new System.EventHandler(this.numACod_ValueChanged);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 464);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.mrcAgregar);
            this.Name = "frmInicio";
            this.Text = "Gestion de inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
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
    }
}

