using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezMGestionDeInventarios
{
    public static class clsFuente
    {
        private static PrivateFontCollection privateFonts = new PrivateFontCollection();
        private static Font fuentePersonalizada;

        public static void AplicarFuentePersonalizada(Control formulario, string rutaRelativaTTF, float tamaño = 10f)
        {
            try
            {
                if (fuentePersonalizada == null)
                {
                    // Obtén la ruta de ejecución (bin\Debug o bin\Release)
                    string rutaBin = Application.StartupPath;  // Ruta de ejecución del proyecto (bin\Debug o bin\Release)

                    // Subir dos carpetas desde bin\Debug o bin\Release para llegar a la raíz del proyecto
                    string rutaRaizProyecto = Directory.GetParent(rutaBin).Parent.FullName;

                    // Ahora combinamos la ruta raíz con las carpetas que contienen la fuente
                    string rutaFuente = Path.Combine(rutaRaizProyecto, "Recursos", "Fuentes", rutaRelativaTTF);

                    // Verificar si el archivo de la fuente existe en la ruta generada
                    if (!File.Exists(rutaFuente))
                    {
                        MessageBox.Show("No se encontró la fuente personalizada en: " + rutaFuente);
                        return;
                    }

                    // Cargar la fuente desde el archivo
                    privateFonts.AddFontFile(rutaFuente);

                    // Usar la primera familia de la fuente cargada
                    fuentePersonalizada = new Font(privateFonts.Families[0], tamaño, FontStyle.Regular);
                }

                // Aplicar la fuente a todos los controles del formulario
                AplicarFuenteAControles(formulario.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error aplicando fuente:\n" + ex.Message);
            }
        }

        private static void AplicarFuenteAControles(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                // Cambiar la fuente si es "Microsoft Sans Serif"
                if (ctrl.Font.Name == "Microsoft Sans Serif")
                {
                    ctrl.Font = new Font(fuentePersonalizada.FontFamily, ctrl.Font.Size, ctrl.Font.Style);
                }

                // Aplicar recursivamente a los controles hijos si existen
                if (ctrl.HasChildren)
                {
                    AplicarFuenteAControles(ctrl.Controls);
                }
            }
        }

    }
}
