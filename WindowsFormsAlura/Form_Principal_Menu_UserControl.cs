﻿using CursoWindowsFormsBiblioteca;
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
        int ControleArquivoImagem = 0;

        public Form_Principal_Menu_UserControl()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
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

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para abrir um arquivo
            OpenFileDialog db = new OpenFileDialog();
            db.InitialDirectory = "C:\\Users\\rober\\OneDrive\\CURSOS\\IOT\\POC\\WindowsFormsAlura\\WindowsFormsAlura\\Imagens";
            db.Filter = "PNG|*.PNG";
            db.Title = "Escolha a Imagem";

            if (db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = db.FileName;

                ControleArquivoImagem += 1;

                Form_ArquivoImage_UC u = new Form_ArquivoImage_UC(nomeArquivoImagem);

                TabPage tb = new TabPage();

                //Nome do componente
                tb.Name = "Arquivo Imagem " + ControleArquivoImagem;

                //Nome que vai aparecer na tab
                tb.Text = "Arquivo Imagem " + ControleArquivoImagem;

                //Adiciona o ícone na aba
                tb.ImageIndex = 6;

                //Componentes que estarão dentro da tabPage
                tb.Controls.Add(u);

                //Adiciona o componente na página
                Tbc_Application.TabPages.Add(tb);
            }


        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();

            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string senha = f.senha;
                string login = f.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.ValidaSenhaLogin(senha) == true)
                {

                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Questao db = new Form_Questao("Question1", "Deseja desconectar?");

            db.ShowDialog();

            var question = db.DialogResult;


            if (question == DialogResult.Yes)
            {

                //Tbc_Application.TabPages.Remove(Tbc_Application.SelectedTab);

                //Sempre que for Collection, precisa fechar de trás pra frente
                for (int i = Tbc_Application.TabPages.Count - 1; i >= 0; i += -1)
                {
                    Tbc_Application.TabPages.Remove(Tbc_Application.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }


        }
    }
}
