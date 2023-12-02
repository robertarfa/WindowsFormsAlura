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
    public partial class Form_Principal_Menu_MDI : Form
    {
        public Form_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DemonstracaoKey f = new Form_DemonstracaoKey();

            //Com essa função fica dentro do formulário principal.. sem essa função fica a caixa solta na tela
            f.MdiParent = this; //parent =pai/nivel mais alto o formulário this Form_Principal_Menu_MDI

            // f.ShowDialog();
            f.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HelloWorld f = new Form_HelloWorld();

            f.MdiParent = this;
            // f.ShowDialog();
            f.Show();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            f.MdiParent = this;
            // f.ShowDialog();
            f.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidaCPF f = new Form_ValidaCPF();


            f.MdiParent = this;
            // f.ShowDialog();
            f.Show();
        }

        private void válidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_ValidaCPF2 f = new Form_ValidaCPF2();

            f.MdiParent = this;
            // f.ShowDialog();
            f.Show();

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidaSenha f = new Form_ValidaSenha();


            f.MdiParent = this;
            // f.ShowDialog();
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
