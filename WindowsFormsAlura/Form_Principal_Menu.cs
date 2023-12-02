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
    public partial class Form_Principal_Menu : Form
    {
        public Form_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DemonstracaoKey f = new Form_DemonstracaoKey();

            f.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HelloWorld f = new Form_HelloWorld();

            f.ShowDialog();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Mascara f = new Form_Mascara();

            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidaCPF f = new Form_ValidaCPF();

            f.ShowDialog();
        }

        private void válidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_ValidaCPF2 f = new Form_ValidaCPF2();

            f.ShowDialog();

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidaSenha f = new Form_ValidaSenha();

            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
