using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Data;

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

    }
}
