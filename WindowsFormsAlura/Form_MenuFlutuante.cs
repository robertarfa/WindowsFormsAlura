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
    public partial class Form_MenuFlutuante : Form
    {
        public Form_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Form_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            //  string str1 = e.Button.ToString();

            if (e.Button == MouseButtons.Right)
            {

                var posicaoX = e.X;
                var posicaoY = e.Y;

                MessageBox.Show(e.Button.ToString() + " posicaoX: " + posicaoX + " posicaoY: " + posicaoY);
            }

        }
    }
}
