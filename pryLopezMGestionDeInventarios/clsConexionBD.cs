using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Data;
using System.Collections;
using pryLopezMGestionDeInventarios;
using pryGestionDeInventarios;

namespace pryGestionInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        public void ConectarBDDGV(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();
                
                

                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();


                dataAdapter.Fill(dataTable);

                dgv.DataSource = dataTable;

                dgv.ClearSelection();

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "No se pudo conectar a la BBDD");
            }
            finally
            {
                conexionBaseDatos.Close();
            }

        }

        public void ConectarBD()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();



                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "No se pudo conectar a la BBDD");
            }
            finally
            {
                conexionBaseDatos.Close();
            }

        }

        public void validacionDeDatos(TextBox txt, TextBox txt2)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @usuario AND contraseña = @contraseña";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", txt.Text);
                cmd.Parameters.AddWithValue("@contraseña", txt2.Text);

                conexion.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    frmInicio v= new frmInicio();
                    v.ShowDialog();
                }
            }



        }

        public void cargarUsuario(clsUsuarios lst)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    clsUsuario aux = new clsUsuario(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3]), Convert.ToDateTime(fila[4])); 

                    lst.lstUsuarios.Add(aux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }


        public void ActualizarUsuario(clsUsuario usuario)
        {
            string query = "UPDATE Usuarios SET estado = @estado WHERE id = @id";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignamos los parámetros
                    cmd.Parameters.AddWithValue("@estado", usuario.estado);
                    cmd.Parameters.AddWithValue("@id", usuario.id);

                    // Abrimos la conexión y ejecutamos el comando
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarInicio(clsUsuario usuario)
        {
            string query = "UPDATE Usuarios SET ultcon = @ultcon WHERE id = @id";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignamos los parámetros
                    cmd.Parameters.AddWithValue("@ultcon", usuario.ultcon);
                    cmd.Parameters.AddWithValue("@id", usuario.id);

                    // Abrimos la conexión y ejecutamos el comando
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void cargarLista(clsProductos lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Productos";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    clsProducto prod = new clsProducto(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(),
                        Convert.ToDecimal(fila[3]), Convert.ToInt32(fila[4]), fila[5].ToString()); ;

                    lista.lstProductos.Add(prod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








        public void agregarProducto(NumericUpDown num, TextBox txt, NumericUpDown num1, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            try 
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = $"INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES ('{num.Value}', '{txt.Text}','{txt2.Text}' , '{num1.Value}', '{num2.Value}', '{cmb.Text}')";
                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"Errorax");
            }
            finally 
            {
                conexionBaseDatos.Close();
            }
            


        }

        public void borrarProducto(NumericUpDown num)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = $"DELETE FROM Productos WHERE Codigo = '{num.Value}'";
                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Errorax");
            }
            finally
            {
                conexionBaseDatos.Close();
            }



        }

        public void modificarProducto(NumericUpDown num, TextBox txt, NumericUpDown num1, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Categoria = @Categoria, Stock = @Stock, Precio = @Precio WHERE Codigo = @Codigo";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);



                // Asignar los parámetros
                command.Parameters.AddWithValue("@Nombre", txt.Text);
                command.Parameters.AddWithValue("@Descripcion", txt2.Text);
                command.Parameters.AddWithValue("@Categoria", cmb.Text);
                command.Parameters.AddWithValue("@Stock", num1.Value);
                command.Parameters.AddWithValue("@Precio", num2.Value);
                command.Parameters.AddWithValue("@Codigo", num.Value);

                command.ExecuteNonQuery();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errorax");
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        




    }
}
