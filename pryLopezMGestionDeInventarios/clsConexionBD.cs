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


        public void ConectarBD(DataGridView dgv)
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
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
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
