﻿using System;
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
    public partial class Form_ValidaCPF2 : Form
    {
        public Form_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Form_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {

            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {

            var question = MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
