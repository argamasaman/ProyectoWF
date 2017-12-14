using System;
using System.Windows.Forms;

namespace ProyectoWF
{

    internal static class Program
    {

        public static Boolean esLogin;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            do
            {
                esLogin = false;
                Application.Run(new Login());
            } while (esLogin);
            Conexion.cerrarConexion();



        }
        

    }
}