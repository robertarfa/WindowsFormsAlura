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
    public partial class Form_Principal_Menu_UserControl : Form
    {

        int ControlHelloWorld = 0;
        int ControlValidaCPF2 = 0;

        public Form_Principal_Menu_UserControl()
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

            ControlHelloWorld += 1;

            Form_HelloWorld_UC u = new Form_HelloWorld_UC();

            TabPage tb = new TabPage();

            //Nome do componente
            tb.Name = "Hello World " + ControlHelloWorld;

            //Nome que vai aparecer na tab
            tb.Text = "Hello World " + ControlHelloWorld;

            //Adiciona o ícone na aba
            tb.ImageIndex = 1;

            //Componentes que estarão dentro da tabPage
            tb.Controls.Add(u);

            //Adiciona o componente na página
            Tbc_Application.TabPages.Add(tb);
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

            //  Form_ValidaCPF2 f = new Form_ValidaCPF2();

            //f.ShowDialog();

            ControlValidaCPF2 += 1;

            Form_ValidaCPF2_UC f = new Form_ValidaCPF2_UC();

            TabPage tb = new TabPage();

            tb.Text = "Valida CPF2 " + ControlValidaCPF2;
            tb.Name = "Valida CPF2 " + ControlValidaCPF2;

            tb.ImageIndex = 4;

            tb.Controls.Add(f);

            Tbc_Application.TabPages.Add(tb);

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

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!(Tbc_Application.SelectedTab == null))
            {
                Tbc_Application.TabPages.Remove(Tbc_Application.SelectedTab);

            }
            else
            {
                MessageBox.Show("Não existe aba para apagar!", "Comando inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
