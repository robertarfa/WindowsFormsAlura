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


    public partial class Form_Login : Form
    {
        public string senha;
        public string login;

        public Form_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Btn_Cancel.Text = "Cancel";
            Btn_Ok.Text = "OK";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            senha = Txt_Password.Text;
            login = Txt_Login.Text;


            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
