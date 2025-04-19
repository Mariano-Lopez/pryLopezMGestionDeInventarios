using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionInventario;
using pryLopezMGestionDeInventarios;

namespace pryGestionDeInventarios
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();
        private void frmInicio_Load(object sender, EventArgs e)
        {
            objetoConexion.cargarLista(lstProductos);

            objetoConexion.ConectarBD(dgvInventario);
            

            string[] dat = new string[] {"Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza"};

            foreach (string d in dat)
            {
                cmbACat.Items.Add(d);
               
            }

            


        }
        public void cargaDeDatos(TextBox txt, NumericUpDown num, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            if(numACod.Value != 0)
            {
                if (txt.Text != "" && num.Value != 0 && txt2.Text != "" && num2.Value != 0 && cmb.SelectedIndex != -1)
                {
                    btnAgregar.Enabled = true;
                }
                
            }

            
        }

        private void numACod_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }

        private void numAStock_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }

        private void txtADesc_TextChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }

        private void cmbACat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtANom, numAPrecio, txtADesc, numAStock, cmbACat);
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (codRep() == false)
            {
                clsProducto aux = new clsProducto(Convert.ToInt32(numACod.Value), txtANom.Text, txtADesc.Text, numAPrecio.Value, Convert.ToInt32(numAStock.Value), cmbACat.Text);

                lstProductos.agregarProducto(aux);

                objetoConexion.agregarProducto(numACod, txtANom, numAStock, txtADesc, numAPrecio, cmbACat);

                objetoConexion.ConectarBD(dgvInventario);


                resetearDatos();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoConexion.borrarProducto(numACod);

            objetoConexion.ConectarBD(dgvInventario);
            

            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            numACod.Enabled = true;

            resetearDatos();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            numACod.Enabled = false;
            

            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                numACod.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                txtANom.Text = fila.Cells["Nombre"].Value?.ToString();
                numAStock.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtADesc.Text = fila.Cells["Descripcion"].Value?.ToString();
                numAPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cmbACat.Text = fila.Cells["Categoria"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objetoConexion.modificarProducto(numACod, txtANom, numAStock, txtADesc, numAPrecio, cmbACat);

            objetoConexion.ConectarBD(dgvInventario);

            resetearDatos();

            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            numACod.Enabled = true;
        }

        public void resetearDatos()
        {
            numACod.Value = 0;
            txtANom.Text = "";
            numAStock.Value = 0;
            txtADesc.Text = "";
            numAPrecio.Value = 0;
            cmbACat.SelectedIndex = -1;
            cmbACat.Text = "Seleccione...";
            btnAgregar.Enabled = false;
        }

        public bool codRep()
        {
            bool bandera = false;

            lstProductos.lstProductos.ForEach(p =>
            {
                if (p.Codigo == Convert.ToInt32(numACod.Value))
                {

                    MessageBox.Show("Re", "Putito");
                    bandera = true;
                }

            });

            return bandera;
        }

        private void dgvInventario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAgregar.Enabled = false;
        }
    }
}
