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
    public partial class Form_HelloWorld : Form
    {
        public Form_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            //Altera o resultado da msg quando clica no botão
            //  DialogResult = DialogResult.Abort;

            this.Close();
        }

        private void Btn_ModificaTexto_Click(object sender, EventArgs e)
        {
            label_Titulo.Text = txt_ConteudoLabel.Text;
        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
