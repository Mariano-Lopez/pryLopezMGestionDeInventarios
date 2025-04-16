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

namespace pryGestionDeInventarios
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsConexionBD objetoConexion = new clsConexionBD();
        private void frmInicio_Load(object sender, EventArgs e)
        {
            

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

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Visible = true;
            btnModificar.Visible = true;

            

            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objetoConexion.agregarProducto(numACod, txtANom, numAStock, txtADesc, numAPrecio, cmbACat);

            objetoConexion.ConectarBD(dgvInventario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoConexion.borrarProducto(numACod);

            objetoConexion.ConectarBD(dgvInventario);
        }
    }
}
