using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionInventario;
using pryLopezMGestionDeInventarios;
using static System.Net.Mime.MediaTypeNames;

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
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

            lblUsuario.Text = $"Sesión de {clsSesion.nomUs}";
            lblUltcon.Text = $"Fecha y hora de última conexión: {clsSesion.ultConUs.ToString()}";
        }
        
        private Form activeForm = null;

        private void abrirFormularioHijo(Form frm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(frm);
            pnlFormHijo.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }
        private void Home(Form frm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = frm;
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmAgregar());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmModificar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmEliminar());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Home(new frmInicio());
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            aparienciaHoverE(btnInicio);
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            aparienciaHoverL(btnInicio);
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            aparienciaHoverE(btnAgregar);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            aparienciaHoverL(btnAgregar);
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            aparienciaHoverE(btnModificar);
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            aparienciaHoverL(btnModificar);
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            aparienciaHoverE(btnEliminar);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            aparienciaHoverL(btnEliminar);
        }

        private void btnCerarSesion_MouseEnter(object sender, EventArgs e)
        {
            aparienciaHoverE(btnCerarSesion);
        }

        private void btnCerarSesion_MouseLeave(object sender, EventArgs e)
        {
            aparienciaHoverL(btnCerarSesion);
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

        private void btnCerarSesion_Click(object sender, EventArgs e)
        {
            DialogResult rtdo = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (rtdo == DialogResult.Yes)
            {
                this.Close();
            }

            

            

     



        }

        
    }

    




}
