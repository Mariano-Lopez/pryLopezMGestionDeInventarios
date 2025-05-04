using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezMGestionDeInventarios
{
    public class clsUsuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int estado { get; set; }
        public DateTime ultcon { get; set; }

        public clsUsuario(int id, string nombre, string contraseña, int estado, DateTime ultcon) 
        {
            this.id = id;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.estado = estado;
            this.ultcon = ultcon;    
        
        
        
        
        }


    }
}
