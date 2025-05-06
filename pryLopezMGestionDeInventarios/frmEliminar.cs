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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            

            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            objetoConexion.cargarLista(lstProductos);

            objetoConexion.ConectarBDDGV(dgvInventario);


            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatE.Items.Add(d);
            }

            dgvInventario.DataBindingComplete += dgvInventario_DataBindingComplete;
        }

        private void HabilitarBoton()
        {
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.ForeColor = Color.DarkGreen;
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnEliminar.FlatAppearance.BorderSize = 1;
        }

        private void dgvInventario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventario.ClearSelection();
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (chkConf.Checked)
            {
                DialogResult rtdo = MessageBox.Show(
                    "¿Desea eliminar el siguiente producto?\n" +
                    $"Código: {numCodE.Value}\n" +
                    $"Nombre: {txtNomE.Text}\n" +
                    $"Descripción: {txtDescE.Text}\n" +
                    $"Stock: {numStockE.Value}\n" +
                    $"Precio: {numPrecioE.Value}\n" +
                    $"Categoría: {cmbCatE.Text}\n",
                    "COnfirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question

                );

                if (rtdo == DialogResult.Yes)
                {
                    if (numCodE.Value == 0)
                    {
                        MessageBox.Show("Por favor cargue un código o seleccione una fila.", "Error");
                    }

                    else
                    {
                        decimal codigoBuscado = numCodE.Value;
                        clsProducto resultado = lstProductos.BuscarPorCodigo(codigoBuscado);

                        if (resultado != null)
                        {
                            objetoConexion.borrarProducto(numCodE);

                            objetoConexion.ConectarBDDGV(dgvInventario);
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");

                        }

                        resetearDatos();
                    }


                }
            }
            else
            {
                if (numCodE.Value == 0)
                {
                    MessageBox.Show("Por favor cargue un código o seleccione una fila.", "Error");
                }

                else
                {
                    decimal codigoBuscado = numCodE.Value;
                    clsProducto resultado = lstProductos.BuscarPorCodigo(codigoBuscado);

                    if (resultado != null)
                    {
                        objetoConexion.borrarProducto(numCodE);

                        objetoConexion.ConectarBDDGV(dgvInventario);
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");

                    }

                    resetearDatos();
                }
            }
        }

        public void resetearDatos()
        {
            numCodE.Value = 0;
            txtNomE.Text = "";
            numStockE.Value = 0;
            txtDescE.Text = "";
            numPrecioE.Value = 0;
            cmbCatE.SelectedIndex = -1;
            cmbCatE.Text = "Seleccione...";
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
                btnEliminar.Enabled = true;
                numCodE.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                txtNomE.Text = fila.Cells["Nombre"].Value?.ToString();
                numStockE.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtDescE.Text = fila.Cells["Descripcion"].Value?.ToString();
                numPrecioE.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cmbCatE.Text = fila.Cells["Categoria"].Value.ToString();

                HabilitarBoton();
            }
        }

        private void btnEliminar_MouseEnter_1(object sender, EventArgs e)
        {
            if (btnEliminar.Enabled)
            {
                // Invertir colores
                btnEliminar.BackColor = Color.DarkGreen;
                btnEliminar.ForeColor = Color.Black;
            }
        }

        private void btnEliminar_MouseLeave_1(object sender, EventArgs e)
        {
            if (btnEliminar.Enabled)
            {
                // Volver al estilo original
                btnEliminar.BackColor = Color.Black;
                btnEliminar.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnEliminar.ForeColor = Color.Black;
                btnEliminar.BackColor = Color.Black;
            }
        }

        public void aparienciaHoverE(Button btn)
        {
            if (btn.Enabled)
            {
                // Invertir colores
                btn.BackColor = Color.DarkGreen;
                btn.ForeColor = Color.Black;
            }
        }

        public void aparienciaHoverL(Button btn)
        {
            if (btn.Enabled)
            {
                // Volver al estilo original
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.DarkGreen;
            }
            else
            {
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.Black;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            decimal codigoBuscado = numCodE.Value;
            clsProducto resultado = lstProductos.BuscarPorCodigo(codigoBuscado);

            if (resultado != null)
            {
                txtNomE.Text = resultado.Nombre;
                numStockE.Value = resultado.Stock;
                txtDescE.Text = resultado.Descripcion;
                numPrecioE.Value = resultado.Precio;
                cmbCatE.Text = resultado.Categoria;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");

            }
        }

        
            
        
    }
}
