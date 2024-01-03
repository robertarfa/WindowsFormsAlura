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
    public partial class Form_Questao : Form
    {
        public Form_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image MyImage = (Image)global::WindowsFormsAlura.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_imagem.Image = MyImage;

            Label_Questao.Text = mensagem;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Yes;

            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
