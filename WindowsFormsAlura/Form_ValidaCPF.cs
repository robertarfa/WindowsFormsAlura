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
    public partial class Form_ValidaCPF : Form
    {
        public Form_ValidaCPF()
        {
            InitializeComponent();
        }



        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = string.Empty;
            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var validaCPF = false;

            validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);

            if (validaCPF)
            {
                Lbl_Resultado.Text = "CPF Válido";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF Inválido";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
