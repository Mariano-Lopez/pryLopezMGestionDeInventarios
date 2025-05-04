using pryGestionInventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezMGestionDeInventarios
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            
            btnAgregar.Enabled = false;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.BackColor = Color.Black;
            btnAgregar.ForeColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;


            numCodA.Focus();

            objetoConexion.cargarLista(lstProductos);

            objetoConexion.ConectarBDDGV(dgvInventario);


            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatA.Items.Add(d);
            }
        }

        // Luego, en algún punto de tu código habilitás el botón
        private void HabilitarBoton()
        {
            btnAgregar.Enabled = true;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.BackColor = Color.Black;
            btnAgregar.ForeColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.BorderSize = 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiamos y verificamos los textos
            //Que no haya saltos de linea
            string nombre = txtNomA.Text.Replace("\r", "").Replace("\n", "").Trim();
            string descripcion = txtDescA.Text.Replace("\r", "").Replace("\n", "").Trim();

            txtNomA.Text = nombre;
            txtDescA.Text = descripcion;


            if (codRep() == false)
            {
                clsProducto aux = new clsProducto(Convert.ToInt32(numCodA.Value), txtNomA.Text, txtDescA.Text , numPrecioA.Value, Convert.ToInt32(numStockA.Value), cmbCatA.Text);

                lstProductos.agregarProducto(aux);

                objetoConexion.agregarProducto(numCodA, txtNomA, numStockA, txtDescA, numPrecioA, cmbCatA);

                objetoConexion.ConectarBDDGV(dgvInventario);

                resetearDatos();

                
            }
        }

        public void cargaDeDatos(TextBox txt, NumericUpDown num, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            if (numCodA.Value != 0)
            {
                if (txt.Text != "" && num.Value != 0 && txt2.Text != "" && num2.Value != 0 && cmb.SelectedIndex != -1)
                {
                    
                    HabilitarBoton();
                    
                }
                else
                {
                    btnAgregar.Enabled = false;
                    btnAgregar.FlatAppearance.BorderSize = 0;
                }
            }
        }

        public void resetearDatos()
        {
            numCodA.Value = 0;
            numCodA.Enabled = true;
            txtNomA.Text = "";
            numStockA.Value = 0;
            txtDescA.Text = "";
            numPrecioA.Value = 0;
            cmbCatA.SelectedIndex = -1;
            cmbCatA.Text = "Seleccione...";
            btnAgregar.Enabled = false;
            btnAgregar.FlatAppearance.BorderSize = 0;
            numCodA.Focus();
        }

        public bool codRep()
        {
            bool bandera = false;

            lstProductos.lstProductos.ForEach(p =>
            {
                if (p.Codigo == Convert.ToInt32(numCodA.Value))
                {

                    MessageBox.Show("El código que intentar cargar ya existe", "Error de carga");
                    bandera = true;
                }

            });

            return bandera;
        }

        private void numCodA_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void txtNomA_TextChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void txtDescA_TextChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void numStockA_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void numPrecioA_ValueChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void cmbCatA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaDeDatos(txtNomA, numPrecioA, txtDescA, numStockA, cmbCatA);
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAgregar.Enabled)
            {
                // Invertir colores
                btnAgregar.BackColor = Color.DarkGreen;
                btnAgregar.ForeColor = Color.Black;
            }

        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAgregar.Enabled)
            {
                // Volver al estilo original
                btnAgregar.BackColor = Color.Black;
                btnAgregar.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnAgregar.ForeColor = Color.Black;
                btnAgregar.BackColor = Color.Black;
            }

        }
    }
}
