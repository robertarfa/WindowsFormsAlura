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
    public partial class Form_ArquivoImage_UC : UserControl
    {
        public Form_ArquivoImage_UC(string nomeArquivoImagem)
        {
            InitializeComponent();

            Label_ArquivoImagem.Text = nomeArquivoImagem;

            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog cdb = new ColorDialog();

            if (cdb.ShowDialog() == DialogResult.OK)
            {
                Label_ArquivoImagem.ForeColor = cdb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog fdb = new FontDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                Label_ArquivoImagem.Font = fdb.Font;
            }
        }
    }
}
