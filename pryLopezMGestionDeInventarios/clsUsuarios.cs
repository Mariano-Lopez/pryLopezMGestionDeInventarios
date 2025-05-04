using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezMGestionDeInventarios
{
    public class clsUsuarios
    {
        public List<clsUsuario> lstUsuarios;

        public clsUsuarios()
        {
            lstUsuarios = new List<clsUsuario>();
        }

        public void agregarUsuario(clsUsuario nuevo)
        {
            lstUsuarios.Add(nuevo);
        }

    }
}
