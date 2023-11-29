using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace WindowsFormsAlura
{
    public partial class Form_ValidaSenha : Form
    {

        bool VerSenhaTxt = false;

        public Form_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = string.Empty;
            Txt_Senha.Text = string.Empty;
            Btn_VerSenha.Text = "Ver Senha";
        }


        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;

            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == ChecaForcaSenha.ForcaDaSenha.Inaceitavel.ToString() || Lbl_Resultado.Text == ChecaForcaSenha.ForcaDaSenha.Fraca.ToString())
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }

            if (Lbl_Resultado.Text == ChecaForcaSenha.ForcaDaSenha.Aceitavel.ToString())
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }

            if (Lbl_Resultado.Text == ChecaForcaSenha.ForcaDaSenha.Forte.ToString() || Lbl_Resultado.Text == ChecaForcaSenha.ForcaDaSenha.Segura.ToString())
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {

            //'\0' representa um caracter vazio

            if (String.IsNullOrEmpty(Txt_Senha.Text))
                return;

            if (!VerSenhaTxt)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";

            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";

            }


        }
    }


}
