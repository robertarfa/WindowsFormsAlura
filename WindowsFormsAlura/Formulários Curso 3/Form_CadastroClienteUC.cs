using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classes;
using Microsoft.VisualBasic;

namespace WindowsFormsAlura
{
    public partial class Form_CadastroClienteUC : UserControl
    {
        public Form_CadastroClienteUC()
        {
            InitializeComponent();

            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";

            Lbl_Logradouro.Text = "Logradouro";
            Lbl_Cidade.Text = "Cidade";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Grp_codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_endereco.Text = "Endereço";
            Grp_outros.Text = "Outros";
            Chk_TemPai.Text = "Pai desconhecido";
            Grp_Genero.Text = "Gênero";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Indefinido.Text = "Indefinido";

            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Recuperar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Atualizar um cliente existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa os dados da tela";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                C_Cliente.Single C = new C_Cliente.Single();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();
                MessageBox.Show("Classe foi inicializadas sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ValidationException Ex)
            {

                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                //Pra exibir o que está no throw Exception como popup
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void apagaToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void limpaToolStripButton_Click(object sender, EventArgs e)
        {

        }

        C_Cliente.Single LeituraFormulario()
        {
            C_Cliente.Single C = new C_Cliente.Single();

            C.Id = Txt_codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeDaMae = Txt_NomeMae.Text;
            C.NomeDoPai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            else
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }
            C.Cpf = Txt_CPF.Text;

            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;

            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);

                if (vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }


            return C;
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {

            string vCep = Txt_CEP.Text;

            if (vCep != "" && vCep.Length == 8 && Information.IsNumeric(vCep))
            {
                var vJson = Cls_Uteis.GeraJSONCEP(vCep);

                C_CEP.Single CEP = new C_CEP.Single();

                CEP = C_CEP.DesserializeSingle(vJson);

                Txt_Logradouro.Text = CEP.Logradouro;
                Txt_Bairro.Text = CEP.Bairro;
                Txt_Cidade.Text = CEP.Localidade;

                Cmb_Estados.SelectedIndex = -1;

                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.Uf + ")");

                    if (vPos > 0)
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }




        }
    }
}
