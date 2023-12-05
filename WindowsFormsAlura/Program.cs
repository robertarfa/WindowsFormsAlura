using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlura
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_HelloWorld());
            // Application.Run(new Form_DemonstracaoKey());
            // Application.Run(new Form_ValidaSenha());
            //Application.Run(new Form_Mascara());
            //Application.Run(new Form_ValidaCPF());
            //Application.Run(new Form_ValidaCPF2());
            // Application.Run(new Form_Principal());
            // Application.Run(new Form_Principal_Menu());
            // Application.Run(new Form_Principal_Menu_MDI()); //Multiple documents interface
            Application.Run(new Form_Principal_Menu_UserControl()); //Multiple documents interface

        }
    }
}
