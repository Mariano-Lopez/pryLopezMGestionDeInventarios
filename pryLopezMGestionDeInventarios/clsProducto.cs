using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezMGestionDeInventarios
{
    public class clsProducto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }

        public string Categoria { get; set; }

        public clsProducto(int Codigo, string Nombre, string Descripcion, decimal Precio, int Stock, string Categoria) 
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Categoria = Categoria;
            this.Stock = Stock;
            this.Precio = Precio;       
        
        }


    }
}
