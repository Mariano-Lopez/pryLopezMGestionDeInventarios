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

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexionBD objetoConexion = new clsConexionBD();

            objetoConexion.ConectarBD(dgvInventario);

            int[] num = new int[] {1,2,3};

            foreach (int n in num)
            {
                cmbACat.Items.Add(n);
                cmbMCat.Items.Add(n);
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
    }
}
