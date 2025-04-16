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
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.lblECod = new System.Windows.Forms.Label();
            this.mrcModificar = new System.Windows.Forms.GroupBox();
            this.txtMDesc = new System.Windows.Forms.TextBox();
            this.lblMCod = new System.Windows.Forms.Label();
            this.txtMNom = new System.Windows.Forms.TextBox();
            this.lblMNom = new System.Windows.Forms.Label();
            this.lblMDesc = new System.Windows.Forms.Label();
            this.lblMCat = new System.Windows.Forms.Label();
            this.lblMPrecio = new System.Windows.Forms.Label();
            this.lblMStock = new System.Windows.Forms.Label();
            this.cmbECod = new System.Windows.Forms.ComboBox();
            this.numACod = new System.Windows.Forms.NumericUpDown();
            this.numAPrecio = new System.Windows.Forms.NumericUpDown();
            this.numAStock = new System.Windows.Forms.NumericUpDown();
            this.cmbACat = new System.Windows.Forms.ComboBox();
            this.numMCod = new System.Windows.Forms.NumericUpDown();
            this.numMPrecio = new System.Windows.Forms.NumericUpDown();
            this.numMStock = new System.Windows.Forms.NumericUpDown();
            this.cmbMCat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.mrcAgregar.SuspendLayout();
            this.mrcEliminar.SuspendLayout();
            this.mrcModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(129, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(144, 118);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(196, 208);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(651, 218);
            this.dgvInventario.TabIndex = 3;
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
            this.mrcAgregar.Controls.Add(this.numAStock);
            this.mrcAgregar.Controls.Add(this.numAPrecio);
            this.mrcAgregar.Controls.Add(this.numACod);
            this.mrcAgregar.Controls.Add(this.btnAgregar);
            this.mrcAgregar.Controls.Add(this.txtADesc);
            this.mrcAgregar.Controls.Add(this.lblACod);
            this.mrcAgregar.Controls.Add(this.txtANom);
            this.mrcAgregar.Controls.Add(this.lblANombre);
            this.mrcAgregar.Controls.Add(this.lblADescripcion);
            this.mrcAgregar.Controls.Add(this.lblACategorias);
            this.mrcAgregar.Controls.Add(this.lblAPrecio);
            this.mrcAgregar.Controls.Add(this.lblAStock);
            this.mrcAgregar.Location = new System.Drawing.Point(14, 36);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Size = new System.Drawing.Size(356, 156);
            this.mrcAgregar.TabIndex = 27;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Agregar producto";
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.Controls.Add(this.cmbECod);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.lblECod);
            this.mrcEliminar.Location = new System.Drawing.Point(425, 36);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Size = new System.Drawing.Size(161, 156);
            this.mrcEliminar.TabIndex = 0;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "Eliminar producto";
            // 
            // lblECod
            // 
            this.lblECod.AutoSize = true;
            this.lblECod.Location = new System.Drawing.Point(3, 21);
            this.lblECod.Name = "lblECod";
            this.lblECod.Size = new System.Drawing.Size(40, 13);
            this.lblECod.TabIndex = 29;
            this.lblECod.Text = "Código";
            // 
            // mrcModificar
            // 
            this.mrcModificar.Controls.Add(this.cmbMCat);
            this.mrcModificar.Controls.Add(this.numMPrecio);
            this.mrcModificar.Controls.Add(this.numMStock);
            this.mrcModificar.Controls.Add(this.numMCod);
            this.mrcModificar.Controls.Add(this.btnModificar);
            this.mrcModificar.Controls.Add(this.txtMDesc);
            this.mrcModificar.Controls.Add(this.lblMCod);
            this.mrcModificar.Controls.Add(this.txtMNom);
            this.mrcModificar.Controls.Add(this.lblMNom);
            this.mrcModificar.Controls.Add(this.lblMDesc);
            this.mrcModificar.Controls.Add(this.lblMCat);
            this.mrcModificar.Controls.Add(this.lblMPrecio);
            this.mrcModificar.Controls.Add(this.lblMStock);
            this.mrcModificar.Location = new System.Drawing.Point(628, 36);
            this.mrcModificar.Name = "mrcModificar";
            this.mrcModificar.Size = new System.Drawing.Size(350, 156);
            this.mrcModificar.TabIndex = 28;
            this.mrcModificar.TabStop = false;
            this.mrcModificar.Text = "Modificar producto";
            // 
            // txtMDesc
            // 
            this.txtMDesc.Location = new System.Drawing.Point(125, 37);
            this.txtMDesc.Name = "txtMDesc";
            this.txtMDesc.Size = new System.Drawing.Size(100, 20);
            this.txtMDesc.TabIndex = 15;
            // 
            // lblMCod
            // 
            this.lblMCod.AutoSize = true;
            this.lblMCod.Location = new System.Drawing.Point(16, 21);
            this.lblMCod.Name = "lblMCod";
            this.lblMCod.Size = new System.Drawing.Size(40, 13);
            this.lblMCod.TabIndex = 12;
            this.lblMCod.Text = "Código";
            // 
            // txtMNom
            // 
            this.txtMNom.Location = new System.Drawing.Point(19, 77);
            this.txtMNom.Name = "txtMNom";
            this.txtMNom.Size = new System.Drawing.Size(100, 20);
            this.txtMNom.TabIndex = 13;
            // 
            // lblMNom
            // 
            this.lblMNom.AutoSize = true;
            this.lblMNom.Location = new System.Drawing.Point(16, 61);
            this.lblMNom.Name = "lblMNom";
            this.lblMNom.Size = new System.Drawing.Size(44, 13);
            this.lblMNom.TabIndex = 14;
            this.lblMNom.Text = "Nombre";
            // 
            // lblMDesc
            // 
            this.lblMDesc.AutoSize = true;
            this.lblMDesc.Location = new System.Drawing.Point(122, 21);
            this.lblMDesc.Name = "lblMDesc";
            this.lblMDesc.Size = new System.Drawing.Size(63, 13);
            this.lblMDesc.TabIndex = 16;
            this.lblMDesc.Text = "Descripcion";
            // 
            // lblMCat
            // 
            this.lblMCat.AutoSize = true;
            this.lblMCat.Location = new System.Drawing.Point(231, 62);
            this.lblMCat.Name = "lblMCat";
            this.lblMCat.Size = new System.Drawing.Size(59, 13);
            this.lblMCat.TabIndex = 22;
            this.lblMCat.Text = "Categorías";
            // 
            // lblMPrecio
            // 
            this.lblMPrecio.AutoSize = true;
            this.lblMPrecio.Location = new System.Drawing.Point(122, 61);
            this.lblMPrecio.Name = "lblMPrecio";
            this.lblMPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblMPrecio.TabIndex = 18;
            this.lblMPrecio.Text = "Precio";
            // 
            // lblMStock
            // 
            this.lblMStock.AutoSize = true;
            this.lblMStock.Location = new System.Drawing.Point(231, 22);
            this.lblMStock.Name = "lblMStock";
            this.lblMStock.Size = new System.Drawing.Size(35, 13);
            this.lblMStock.TabIndex = 20;
            this.lblMStock.Text = "Stock";
            // 
            // cmbECod
            // 
            this.cmbECod.FormattingEnabled = true;
            this.cmbECod.Location = new System.Drawing.Point(6, 37);
            this.cmbECod.Name = "cmbECod";
            this.cmbECod.Size = new System.Drawing.Size(121, 21);
            this.cmbECod.TabIndex = 30;
            // 
            // numACod
            // 
            this.numACod.Location = new System.Drawing.Point(20, 38);
            this.numACod.Name = "numACod";
            this.numACod.Size = new System.Drawing.Size(100, 20);
            this.numACod.TabIndex = 23;
            this.numACod.ValueChanged += new System.EventHandler(this.numACod_ValueChanged);
            // 
            // numAPrecio
            // 
            this.numAPrecio.Location = new System.Drawing.Point(129, 80);
            this.numAPrecio.Name = "numAPrecio";
            this.numAPrecio.Size = new System.Drawing.Size(100, 20);
            this.numAPrecio.TabIndex = 24;
            this.numAPrecio.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numAStock
            // 
            this.numAStock.Location = new System.Drawing.Point(235, 37);
            this.numAStock.Name = "numAStock";
            this.numAStock.Size = new System.Drawing.Size(100, 20);
            this.numAStock.TabIndex = 25;
            this.numAStock.ValueChanged += new System.EventHandler(this.numAStock_ValueChanged);
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
            // numMCod
            // 
            this.numMCod.Location = new System.Drawing.Point(19, 37);
            this.numMCod.Name = "numMCod";
            this.numMCod.Size = new System.Drawing.Size(100, 20);
            this.numMCod.TabIndex = 27;
            // 
            // numMPrecio
            // 
            this.numMPrecio.Location = new System.Drawing.Point(125, 77);
            this.numMPrecio.Name = "numMPrecio";
            this.numMPrecio.Size = new System.Drawing.Size(100, 20);
            this.numMPrecio.TabIndex = 27;
            // 
            // numMStock
            // 
            this.numMStock.Location = new System.Drawing.Point(231, 37);
            this.numMStock.Name = "numMStock";
            this.numMStock.Size = new System.Drawing.Size(100, 20);
            this.numMStock.TabIndex = 28;
            // 
            // cmbMCat
            // 
            this.cmbMCat.FormattingEnabled = true;
            this.cmbMCat.Location = new System.Drawing.Point(231, 77);
            this.cmbMCat.Name = "cmbMCat";
            this.cmbMCat.Size = new System.Drawing.Size(100, 21);
            this.cmbMCat.TabIndex = 27;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.mrcModificar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.mrcAgregar);
            this.Controls.Add(this.mrcEliminar);
            this.Name = "frmInicio";
            this.Text = "Gestion de inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.mrcModificar.ResumeLayout(false);
            this.mrcModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numACod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMStock)).EndInit();
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
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.Label lblECod;
        private System.Windows.Forms.GroupBox mrcModificar;
        private System.Windows.Forms.TextBox txtMDesc;
        private System.Windows.Forms.Label lblMCod;
        private System.Windows.Forms.TextBox txtMNom;
        private System.Windows.Forms.Label lblMNom;
        private System.Windows.Forms.Label lblMDesc;
        private System.Windows.Forms.Label lblMCat;
        private System.Windows.Forms.Label lblMPrecio;
        private System.Windows.Forms.Label lblMStock;
        private System.Windows.Forms.ComboBox cmbECod;
        private System.Windows.Forms.NumericUpDown numAStock;
        private System.Windows.Forms.NumericUpDown numAPrecio;
        private System.Windows.Forms.NumericUpDown numACod;
        private System.Windows.Forms.ComboBox cmbACat;
        private System.Windows.Forms.ComboBox cmbMCat;
        private System.Windows.Forms.NumericUpDown numMPrecio;
        private System.Windows.Forms.NumericUpDown numMStock;
        private System.Windows.Forms.NumericUpDown numMCod;
    }
}

