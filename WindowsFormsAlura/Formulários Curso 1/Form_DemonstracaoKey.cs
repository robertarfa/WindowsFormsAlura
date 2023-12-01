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
    public partial class Form_DemonstracaoKey : Form
    {
        /// <summary>
        /// Vai aparecer como texto de explicação.
        /// </summary>
        /// 
        public Form_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            //"\r\n" no c# é uma quebra de linha
            //\t é um tab
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Código da tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();


        }



        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = string.Empty;
            Txt_Input.Text = string.Empty;
            Lbl_Upper.Text = string.Empty;
            Lbl_Lower.Text = string.Empty;
        }
    }
}
