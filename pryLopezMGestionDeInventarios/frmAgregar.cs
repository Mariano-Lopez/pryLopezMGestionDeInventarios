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

        
        //Instancias de clases.
        clsConexionBD objetoConexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            //Fuente global
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            //Para que empiece el prompt en el componente.
            numCodA.Focus();

            //Cargo la lista de productos.
            objetoConexion.cargarLista(lstProductos);

            //Luego la muestro en la DGV
            objetoConexion.ConectarBDDGV(dgvInventario);

            //Creo un vector para llenar los cmb.
            string[] dat = new string[] { "Electrònicos", "Bazar/Librerìa", "Perfumes", "Limpieza" };

            foreach (string d in dat)
            {
                cmbCatA.Items.Add(d);
            }
        }

        //Eventos
        //Botón que cierra el formulario y no abre el del incio.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento click
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verifico que el usuario no me deje espacios o saltos de línea.
            string nombre = txtNomA.Text.Replace("\r", "").Replace("\n", "").Trim();
            string descripcion = txtDescA.Text.Replace("\r", "").Replace("\n", "").Trim();

            //Vuelvo a llenar las mismas variables pero sin espacios.
            txtNomA.Text = nombre;
            txtDescA.Text = descripcion;

            //Verifico si el codigo esta repetido o no.
            if (codRep() == false)
            {
                //Si no lo está. Agrega el producto.

                //Primero a la clase.
                clsProducto aux = new clsProducto(Convert.ToInt32(numCodA.Value), txtNomA.Text, txtDescA.Text, numPrecioA.Value, Convert.ToInt32(numStockA.Value), cmbCatA.Text);

                //Luego a la lista.
                lstProductos.agregarProducto(aux);

                //A la BBDD.
                objetoConexion.agregarProducto(numCodA, txtNomA, txtDescA, numPrecioA, numStockA, cmbCatA);

                //Y vuelvo a mostrar la DGV actualizada.
                objetoConexion.ConectarBDDGV(dgvInventario);

                //Limpio los componentes.
                resetearDatos();
            }
        }

        //Verifico que si hay por lo menos un componente vacío, no se habilite el botón.
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

        //Cambio el formato del botón en caso de que pase o se aleje el mouse.
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


        //Procedimientos

        //Habilito el botón y cambio su formato.
        private void HabilitarBoton()
        {
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.BackColor = Color.Black;
            btnAgregar.ForeColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.BorderSize = 1;
        }

        //Procedimiento que controla que si hay almenos un componente vacío, el botón no se habilitará.
        public void cargaDeDatos(TextBox txt, NumericUpDown num, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            //Deshabilito el botón en caso de que borre un campo.
            if (
                numCodA.Value > 0 &&
                !string.IsNullOrWhiteSpace(txt.Text) &&
                num.Value != 0 &&
                !string.IsNullOrWhiteSpace(txt2.Text) &&
                num2.Value != 0 &&
                cmb.SelectedIndex != -1
                )
            {
                btnAgregar.Enabled = true;
                HabilitarBoton();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregar.FlatAppearance.BorderSize = 0;
                
            }

        }

        //Reinicio los componentes.
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

        //Hace un recorrido a la lista para ver si el código que intentar cargar ya existe.
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


    }
}
