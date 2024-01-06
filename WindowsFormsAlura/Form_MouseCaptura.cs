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
    public partial class Form_MouseCaptura : Form
    {
        public Form_MouseCaptura()
        {
            InitializeComponent();
        }

        private void Btn_MouseCaptura_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();

            MessageBox.Show("Foi pressionado o botão" + str1);
        }
    }
}
