using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionInventario;

namespace pryLopezMGestionDeInventarios
{
    public class clsProductos
    {
        public List<clsProducto> lstProductos;

        clsConexionBD conn = new clsConexionBD();

        public clsProductos()
        {
            lstProductos = new List<clsProducto>();
        }

        public void agregarProducto(clsProducto nuevo)
        {
            lstProductos.Add(nuevo);
        }


        public clsProducto BuscarPorCodigo(decimal codigo)
        {
            return lstProductos.Find(e => e.Codigo == codigo);
        }



    }


}
