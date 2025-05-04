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
using static System.Collections.Specialized.BitVector32;

namespace pryLopezMGestionDeInventarios
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        clsConexionBD objetoConexion = new clsConexionBD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        

        int intentos = 3;

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            objetoConexion.cargarUsuario(lstUsuarios);
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            if (btnIngresar.Enabled)
            {
                // Invertir colores
                btnIngresar.BackColor = Color.DarkGreen;
                btnIngresar.ForeColor = Color.Black;
            }

        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            if (btnIngresar.Enabled)
            {
                // Volver al estilo original
                btnIngresar.BackColor = Color.Black;
                btnIngresar.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnIngresar.ForeColor = Color.Black;
                btnIngresar.BackColor = Color.Black;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContra.Text != "" && txtUsuario.Text != "")
            {
                

                // Busca el usuario en la lista por el nombre de usuario ingresado
                var usuario = lstUsuarios.lstUsuarios.FirstOrDefault(u => u.nombre == txtUsuario.Text);

                if (usuario != null)
                {
                    if (usuario.estado != 0)
                    {

                    // Si el usuario existe, verifica la contraseña
                    if (usuario.contraseña == txtContra.Text)
                    {
                        // Si la contraseña es correcta, resetea los intentos fallidos
                        /*usuario.intentosFallidos = 0;*/
                        MessageBox.Show($"Bienvenido { usuario.nombre}.", "Login exitoso");

                        clsSesion.nomUs = usuario.nombre;

                        clsSesion.ultConUs = usuario.ultcon;

                        objetoConexion.validacionDeDatos(txtUsuario, txtContra);

                        usuario.ultcon = System.DateTime.Now;

                        objetoConexion.ActualizarInicio(usuario);

                        txtContra.Text = "";
                        txtUsuario.Text = "";

                        

                    }
                    else
                    {
                        // Si la contraseña es incorrecta, aumenta los intentos fallidos
                        lblIntentos.Visible = true;
                        intentos--;
                        lblIntentos.Text = $"Intentos restantes: {intentos}";
                        if (intentos == 0)
                        {
                            // Si llega a 3 intentos fallidos, deshabilita al usuario
                            usuario.estado = 0;
                            MessageBox.Show("Has alcanzado el límite de intentos fallidos. Tu cuenta ha sido deshabilitada.");
                            txtUsuario.Text = "";
                            lblIntentos.Visible= false;
                            intentos = 3;

                        }
                        /*else
                        {
                            // Si no se alcanzan 3 intentos fallidos, muestra el mensaje
                            MessageBox.Show("Contraseña incorrecta. Intentos fallidos: " + intentos);
                        }*/
                    }

                    // Aquí puedes hacer la actualización de la base de datos con el estado actualizado
                    objetoConexion.ActualizarUsuario(usuario);

                    }
                    else
                    {
                        MessageBox.Show("Ha agotado todos los intentos de inicio de sesión", "Cuenta suspendida");
                    }

                }
                else
                {
                    //Si el usuario no existe en la lista
                    MessageBox.Show("Usuario no encontrado.");
                }
                
            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacios, porfavor cargue los datos faltantes", "Error de carga");
            }
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !chkContraseña.Checked;
        }

    }
}
