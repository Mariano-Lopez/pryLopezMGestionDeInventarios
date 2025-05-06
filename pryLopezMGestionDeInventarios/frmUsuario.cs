using pryGestionDeInventarios;
using pryGestionInventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //Instancias de cls
        clsConexionBD objetoConexion = new clsConexionBD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //Me resultó mucho mas fácil manejar los datos de los usuarios mediante las listas, ya que son mas fáciles de acceder y manipular.
            objetoConexion.cargarUsuario(lstUsuarios);

            //Aplico una fuente global, ya que tuve problemas al clonarlas en las facultad.
            //En la interfaz antes de ejecutar el programa se ve de una forma, pero cuando se ejecuta se aplica la fuente.
            clsFuente.AplicarFuentePersonalizada(this, "BankGothic Md BT.ttf");

        }

        // Eventos //

        //Evento click del botón ingresar.
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Verifico que el usuario ingrese algún dato.
            if (txtContra.Text != "" && txtUsuario.Text != "")
            {
                // Busca el usuario en la lista por el nombre de usuario ingresado.
                var usuario = lstUsuarios.lstUsuarios.FirstOrDefault(u => u.nombre == txtUsuario.Text);

                //Si encontró un usuario ingresa al if.
                if (usuario != null)
                {
                    //Verifica que el usuario esta habilitado.
                    if (usuario.estado != 0)
                    {

                        // Si el usuario existe, verifica la contraseña.
                        if (usuario.contraseña == txtContra.Text)
                        {
                            //Mensaje de bienvenida.
                            MessageBox.Show($"Bienvenido {usuario.nombre}.", "Login exitoso");

                            //Variables globales que después voy a utilizar en el frmInicio para mostrar nombre de usuario y última conexión.
                            clsSesion.nomUs = usuario.nombre;

                            //Primero igualo la variable a la ultima conexión que tuvo.
                            clsSesion.ultConUs = usuario.ultcon;

                            //Luego la igualo a la hora del sistema, Ya que sería la última.
                            usuario.ultcon = System.DateTime.Now;

                            //Actualizo los datos en la BBDD.
                            objetoConexion.ActualizarInicio(usuario);

                            //Limpio los componentes
                            txtContra.Text = "";
                            txtUsuario.Text = "";

                            //Abro el formulario de inicio, ya que los datos que ingreso son correctos.
                            frmInicio v = new frmInicio();
                            v.ShowDialog();

                        }
                        else
                        {
                            //El lbl de los intentos esta oculto, ya que si ingresa sin equivocarse es redundante mostrarle los intentos.
                            lblIntentos.Visible = true;

                            // Si la contraseña es incorrecta, disminuye los intentos fallidos.
                            usuario.intentos--;

                            //Los intentos esta contados en la BBDD, si el usuario se equivoca le disminuyo los intentos en la BBDD lo cual se refleja en el programa.
                            objetoConexion.ActualizarIntentos(usuario);

                            //lbl con datos actualizados.
                            lblIntentos.Text = $"Intentos restantes: {usuario.intentos}";

                            //Si se queda sin intentos.
                            if (usuario.intentos == 0)
                            {
                                // Si llega a 3 intentos fallidos, deshabilita al usuario.
                                usuario.estado = 0;

                                //Deshabilito el usuario en la bbdd.
                                objetoConexion.ActualizarUsuario(usuario);

                                //Se le informa al usuario.
                                MessageBox.Show("Has alcanzado el límite de intentos fallidos. Tu cuenta ha sido deshabilitada.");

                                //Limpio los componentes.
                                txtUsuario.Text = "";
                                txtContra.Text = "";

                                //Reinicio la interfaz, escondiendo el lbl y actualizandole los intentos al usuario (lo cual es indistinto porque esta deshabilitado).
                                lblIntentos.Visible = false;
                                usuario.intentos = 3;
                                objetoConexion.ActualizarIntentos(usuario);
                            }

                        }

                    }
                    else
                    {
                        //Mensaje de que se va a inhabilitar al usuario.
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
                //Aviso al usuario de que tiene que llenar campos.
                MessageBox.Show("No se pueden dejar campos vacios, porfavor cargue los datos faltantes", "Error de carga");
            }
        }


        //Evento cuando se pasa el mouse por arriba o si lo saca.
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {

            //Cambio el formato del botón.
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
                //Lo oculto
                btnIngresar.ForeColor = Color.Black;
                btnIngresar.BackColor = Color.Black;
            }
        }

        //Si se quiere ver la contraseña que se escribe o no.
        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !chkContraseña.Checked;
        }

        //Una suma a las funcionalidades, por inercia si le da enter al txtbox de la contraseña, simula un click al botón.
        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificamos si la tecla presionada es Enter.
            if (e.KeyCode == Keys.Enter)
            {
                // Llamamos al evento Click del botón como si se hubiera hecho click.
                btnIngresar.PerformClick();
            }
        }







































    }
}
