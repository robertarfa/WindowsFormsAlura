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
    public partial class Form_MouseEventos : Form
    {
        public Form_MouseEventos()
        {
            InitializeComponent();
        }

        private void btn_MouseEventos_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEventos.Text = "Mouse Enter";
        }

        private void btn_MouseEventos_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseEventos.Text = "Mouse Leave";
        }

        private void btn_MouseEventos_MouseHover(object sender, EventArgs e)
        {
            btn_MouseEventos.Text = "Mouse Hover";
        }

        private void btn_MouseEventos_MouseDown(object sender, MouseEventArgs e)
        {
            btn_MouseEventos.Text = "Mouse Down";
        }

        private void btn_MouseEventos_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseEventos.Text = "Mouse Up";
        }
    }
}
