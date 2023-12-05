using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlura
{
    public partial class Form_HelloWorld_UC : UserControl
    {
        public Form_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void btn_ModificaTexto_Click(object sender, EventArgs e)
        {
            label_Titulo.Text = txt_ConteudoLabel.Text;

        }
    }
}
