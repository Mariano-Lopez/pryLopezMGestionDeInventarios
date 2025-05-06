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
using System.Globalization;

namespace pryGestionInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion.
        string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        //conector.
        SqlConnection conexionBaseDatos;
        
        //comando.
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        //Procedimiento para conectarse a la BBDD y mostrar los datos en una DGV.
        public void ConectarBDDGV(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();
                
                
                //Query.
                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();


                dataAdapter.Fill(dataTable);

                dgv.DataSource = dataTable;

                dgv.ClearSelection();

                //Cambio de formato para poder mostrar los precios con ",".
                dgv.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgv.Columns["Precio"].DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");

                //Que la DGV no la pueda controlar el usuario u ordenarla.
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

        //Cargo todos los usuarios en una lista para poder manipular los datos.
        public void cargarUsuario(clsUsuarios lst)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable.
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    clsUsuario aux = new clsUsuario(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3]), Convert.ToDateTime(fila[4]), Convert.ToInt32(fila[5])); 

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

        public void ActualizarIntentos(clsUsuario usuario)
        {
            string query = "UPDATE Usuarios SET intentos = @intentos WHERE id = @id";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignamos los parámetros
                    cmd.Parameters.AddWithValue("@intentos", usuario.intentos);
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

        public void agregarProducto(NumericUpDown num, TextBox txt, TextBox txt2, NumericUpDown num1,  NumericUpDown num2, ComboBox cmb)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                string query = @"INSERT INTO Productos 
                         (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) 
                         VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock, @Categoria)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                command.Parameters.AddWithValue("@Codigo", Convert.ToInt32(num.Value));
                command.Parameters.AddWithValue("@Nombre", txt.Text);
                command.Parameters.AddWithValue("@Descripcion", txt2.Text);
                command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(num1.Value));
                command.Parameters.AddWithValue("@Stock", Convert.ToInt32(num2.Value));
                command.Parameters.AddWithValue("@Categoria", cmb.Text);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar producto");
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










