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
        
        //Instancias de clases.
        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            
            //Fuente global.
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            //Cargo los productos.
            objetoConexion.cargarLista(lstProductos);

            //Los muestro
            objetoConexion.ConectarBDDGV(dgvInventario);

            //Genero un vector para cargar los cmb.
            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatE.Items.Add(d);
            }

            //Dejo por defecto el mensaje de confirmación.
            chkConf.Checked = true;
            
        }

        //Eventos

        //Evento click
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Si esta clickeado el 
            if (chkConf.Checked)
            {
                //Pregunto si esta seguro de eliminar el producto.
                DialogResult rtdo = MessageBox.Show(
                    //Le muestro una descripción detallada del producto que esta por borrar.
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

                //Si llega a confirmar
                if (rtdo == DialogResult.Yes)
                {
                    //Controlo si quiere eliminar el código 0.
                    if (numCodE.Value == 0)
                    {
                        //Si es así, le dejo un mensaje.
                        MessageBox.Show("Por favor cargue un código o seleccione una fila.", "Error");
                    }
                    else
                    {
                        //Sino borramos el producto.

                        //Tomo el valor del código ya que es único.
                        decimal codigoBuscado = numCodE.Value;

                        //Lo busco.
                        clsProducto resultado = lstProductos.BuscarPorCodigo(codigoBuscado);

                        //Si se encuentra el prodcuto
                        if (resultado != null)
                        {
                            //Se elimina
                            objetoConexion.borrarProducto(numCodE);

                            //Se vuelve a mostrar la DGV actualizada.
                            objetoConexion.ConectarBDDGV(dgvInventario);
                        }
                        else
                        {
                            //Mensaje por si no se encuentra.
                            MessageBox.Show("Producto no encontrado.");

                        }

                        //Limpio la interfaz
                        resetearDatos();
                    }


                }
            }
            else
            {
                //En caso de que el mensaje de confirmación no esta activo, se borra el producto sin confirmar.
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

        //Evento click en la DGV
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                //Toma los datos de la fila seleccionada.
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

        //Evento click de buscar el producto.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Tomo el código
            decimal codigoBuscado = numCodE.Value;

            //Lo busco adentro de la lista.
            clsProducto resultado = lstProductos.BuscarPorCodigo(codigoBuscado);

            //Si consigue un dato
            if (resultado != null)
            {
                //Llena los componentes
                txtNomE.Text = resultado.Nombre;
                numStockE.Value = resultado.Stock;
                txtDescE.Text = resultado.Descripcion;
                numPrecioE.Value = resultado.Precio;
                cmbCatE.Text = resultado.Categoria;
            }
            else
            {
                //Sino informa que no se encontró el producto.
                MessageBox.Show("Producto no encontrado.");

            }
        }

        //Procedimientos

        //Procedimiento que habilita el botón con cierto formato.
        private void HabilitarBoton()
        {
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.ForeColor = Color.DarkGreen;
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnEliminar.FlatAppearance.BorderSize = 1;
        }

        //Cierra el formulario actual y nos lleva al incio.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Se reinician los componentes.
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

        //Cambia el formato de los botones cuando el mouse esta arriba o lejos.
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


















    }
}
