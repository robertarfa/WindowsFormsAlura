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

                var contextMenu = new ContextMenuStrip();

                var menu1 = DesenhaItemMenu("Item do Menu 1");
                var menu2 = DesenhaItemMenu("Item do Menu 2");

                var subMenu1 = DesenhaItemMenu("SubMenu 1");
                var subMenu2 = DesenhaItemMenu("SubMenu 2");

                contextMenu.Items.Add(menu1);
                contextMenu.Items.Add(menu2);

                menu1.DropDownItems.Add(subMenu1);
                menu2.DropDownItems.Add(subMenu2);


                contextMenu.Show(this, new Point(posicaoX, posicaoY));


                //MessageBox.Show(e.Button.ToString() + " posicaoX: " + posicaoX + " posicaoY: " + posicaoY);
            }

            ToolStripMenuItem DesenhaItemMenu(string text)
            {
                var vToolTip = new ToolStripMenuItem();

                vToolTip.Text = text;

                return vToolTip;
            }

        }


    }
}
