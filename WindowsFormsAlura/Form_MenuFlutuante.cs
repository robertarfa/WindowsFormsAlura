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

                var menu1 = DesenhaItemMenu("Item do Menu 1", "key");
                var menu2 = DesenhaItemMenu("Item do Menu 2", "key");

                var subMenu1 = DesenhaItemMenu("SubMenu 1", "key");
                var subMenu2 = DesenhaItemMenu("SubMenu 2", "key");

                contextMenu.Items.Add(menu1);
                contextMenu.Items.Add(menu2);

                menu1.DropDownItems.Add(subMenu1);
                menu2.DropDownItems.Add(subMenu2);


                contextMenu.Show(this, new Point(posicaoX, posicaoY));

                menu1.Click += new System.EventHandler(menu1_Click);
                menu2.Click += new System.EventHandler(menu2_Click);

                //MessageBox.Show(e.Button.ToString() + " posicaoX: " + posicaoX + " posicaoY: " + posicaoY);
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                Image MyImage = (Image)global::WindowsFormsAlura.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                ;
                var vToolTip = new ToolStripMenuItem
                {
                    Text = text,
                    Image = MyImage
                };



                return vToolTip;
            }

            void menu1_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Menu 1");
            }

            void menu2_Click(object sender2, EventArgs e1)
            {
                MessageBox.Show("Menu 2");
            }
        }


    }
}
