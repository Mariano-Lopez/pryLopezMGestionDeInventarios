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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        decimal num = 0;

        private void frmModificar_Load(object sender, EventArgs e)
        {
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            objetoConexion.cargarLista(lstProductos);

            objetoConexion.ConectarBDDGV(dgvInventario);


            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatM.Items.Add(d);
            }

            btnModificar.Enabled = false;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.BackColor = Color.Black;
            btnModificar.ForeColor = Color.DarkGreen;
            btnModificar.FlatAppearance.BorderSize = 0;
        }

        private void HabilitarBoton()
        {
            btnModificar.Enabled = true;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.BackColor = Color.Black;
            btnModificar.ForeColor = Color.DarkGreen;
            btnModificar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnModificar.FlatAppearance.BorderSize = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Limpiamos y verificamos los textos
            //Que no haya saltos de linea
            string nombre = txtNomM.Text.Replace("\r", "").Replace("\n", "").Trim();
            string descripcion = txtDescM.Text.Replace("\r", "").Replace("\n", "").Trim();
            

            if (numCodM.Value == 0 || string.IsNullOrWhiteSpace(nombre) || numStockM.Value == 0 || string.IsNullOrWhiteSpace(descripcion) || numPrecioM.Value == 0)
            {
                MessageBox.Show("No se pueden dejar campos vacíos o con solo espacios/saltos de línea.", "Error de carga");
                numCodM.Value = num;
            }
            else
            {
                // Actualizás los textos limpios en los TextBox por si querés corregir visualmente también
                txtNomM.Text = nombre;
                txtDescM.Text = descripcion;

                objetoConexion.modificarProducto(numCodM, txtNomM, numStockM, txtDescM, numPrecioM, cmbCatM);
                objetoConexion.ConectarBDDGV(dgvInventario);
                resetearDatos();
            }
        }

        public void resetearDatos()
        {
            numCodM.Value = 0;
            numCodM.Enabled = true;
            txtNomM.Text = "";
            numStockM.Value = 0;
            txtDescM.Text = "";
            numPrecioM.Value = 0;
            cmbCatM.SelectedIndex = -1;
            cmbCatM.Text = "Seleccione...";
            btnModificar.Enabled = false;
            btnModificar.FlatAppearance.BorderSize = 0;

            habilitarComponentes(false);

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                numCodM.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                txtNomM.Text = fila.Cells["Nombre"].Value?.ToString();
                numStockM.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtDescM.Text = fila.Cells["Descripcion"].Value?.ToString();
                numPrecioM.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cmbCatM.Text = fila.Cells["Categoria"].Value.ToString();

                numCodM.Enabled = false;

                HabilitarBoton();
                habilitarComponentes(true);
            }
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            if (btnModificar.Enabled)
            {
                // Invertir colores
                btnModificar.BackColor = Color.DarkGreen;
                btnModificar.ForeColor = Color.Black;
            }
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            if (btnModificar.Enabled)
            {
                // Volver al estilo original
                btnModificar.BackColor = Color.Black;
                btnModificar.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnModificar.ForeColor = Color.Black;
                btnModificar.BackColor = Color.Black;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            numCodM.Enabled = false;

            clsProducto resultado = lstProductos.BuscarPorCodigo(numCodM.Value);

            if (resultado != null)
            {
                txtNomM.Text = resultado.Nombre;
                numStockM.Value = resultado.Stock;
                txtDescM.Text = resultado.Descripcion;
                numPrecioM.Value = resultado.Precio;
                cmbCatM.Text = resultado.Categoria;

                habilitarComponentes(true);
                HabilitarBoton();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.","Error de búsqueda");
                numCodM.Enabled = true;
            }
        }

        public void habilitarComponentes(bool bnd)
        {
            txtNomM.Enabled = bnd;
            numStockM.Enabled = bnd;
            txtDescM.Enabled = bnd;
            numPrecioM.Enabled = bnd;
            cmbCatM.Enabled = bnd;
        }
    }
}
