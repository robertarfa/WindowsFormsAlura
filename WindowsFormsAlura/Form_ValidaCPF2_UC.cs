using CursoWindowsFormsBiblioteca;
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
    public partial class Form_ValidaCPF2_UC : UserControl
    {
        public Form_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (string.IsNullOrEmpty(vConteudo))
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vConteudo.Length < 11)
            {
                MessageBox.Show("CPF deve ter 11 dígitos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Form_Questao db = new Form_Questao();

                db.ShowDialog();

                //var question = MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                var question = db.DialogResult;


                if (question == DialogResult.Yes)
                {

                    var validaCPF = false;

                    validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);

                    if (validaCPF)
                    {
                        MessageBox.Show("CPF Válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
