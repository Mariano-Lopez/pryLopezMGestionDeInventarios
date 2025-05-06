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

        //Instancias de clases.
        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmModificar_Load(object sender, EventArgs e)
        {

            //Fuente global.
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            //Cargo la lista de productos.
            objetoConexion.cargarLista(lstProductos);

            //Muestro los productos.
            objetoConexion.ConectarBDDGV(dgvInventario);

            //Vector que llena los cmb.
            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatM.Items.Add(d);
            }

            
        }

        //Eventos

        //Evento click de búsqueda.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Deshabilito el num ya que no se puede modificar el código del producto.
            numCodM.Enabled = false;

            //Obtengo el producto y los cargo en una clase.
            clsProducto resultado = lstProductos.BuscarPorCodigo(numCodM.Value);

            //Recorro la lista en caso de que no este vacía y lleno los componentes.
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
                //Mensaje de que no se encontró el producto.
                MessageBox.Show("Producto no encontrado.", "Error de búsqueda");
                numCodM.Enabled = true;
            }
        }

        //Eventos cuando se aleja o se acerca el mouse.
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

        //Evento click de la DGV
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si no selecciona la columna.
            if (e.RowIndex >= 0)
            {
                //Toma los datos de la fila y llena los componentes.
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                numCodM.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                txtNomM.Text = fila.Cells["Nombre"].Value?.ToString();
                numStockM.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtDescM.Text = fila.Cells["Descripcion"].Value?.ToString();
                numPrecioM.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cmbCatM.Text = fila.Cells["Categoria"].Value.ToString();

                numCodM.Enabled = false;

                //Habilito el botón y deshabilito los componentes.
                HabilitarBoton();
                habilitarComponentes(true);
            }
        }

        //Evento click
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Mismo control que en el frmAgregar para que no puedan cargar productos con saltos de linea.
            string nombre = txtNomM.Text.Replace("\r", "").Replace("\n", "").Trim();
            string descripcion = txtDescM.Text.Replace("\r", "").Replace("\n", "").Trim();

            //Mensaje por si al modificar deja algún campo vacío.
            if (numCodM.Value == 0 || string.IsNullOrWhiteSpace(nombre) || numStockM.Value == 0 || string.IsNullOrWhiteSpace(descripcion) || numPrecioM.Value == 0)
            {
                MessageBox.Show("No se pueden dejar campos vacíos o con solo espacios/saltos de línea.", "Error de carga");

            }
            else
            {
                //Actualizo los componentes
                txtNomM.Text = nombre;
                txtDescM.Text = descripcion;

                //Mando la modificación a la BBDD.
                objetoConexion.modificarProducto(numCodM, txtNomM, numStockM, txtDescM, numPrecioM, cmbCatM);

                //Muestro los productos con el cambio realizado.
                objetoConexion.ConectarBDDGV(dgvInventario);

                //Reinicio los componentes.
                resetearDatos();
            }
        }

        //Procedimientos

        //Habilitación de componentes.
        public void habilitarComponentes(bool bnd)
        {
            txtNomM.Enabled = bnd;
            numStockM.Enabled = bnd;
            txtDescM.Enabled = bnd;
            numPrecioM.Enabled = bnd;
            cmbCatM.Enabled = bnd;
        }


        //Limpieza de interfaz.
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

        //Procedmiento que habilita el botón con distinto formato.
        private void HabilitarBoton()
        {
            btnModificar.Enabled = true;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.BackColor = Color.Black;
            btnModificar.ForeColor = Color.DarkGreen;
            btnModificar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnModificar.FlatAppearance.BorderSize = 1;
        }

        //Cierra el formulario actual y nos deja en el inicio.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
