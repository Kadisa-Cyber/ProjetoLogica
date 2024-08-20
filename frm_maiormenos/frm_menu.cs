using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_maiormenos
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        // Cada ação do botão abre a sua respectiva página, na qual será redirecionado a um novo forms

        private void btn1_Click(object sender, EventArgs e)
        {
            frm_maiormenor abrir1 = new frm_maiormenor();
            abrir1.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frm_peso abrir2 = new frm_peso();
            abrir2.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            frm_placar abrir3 = new frm_placar();
            abrir3.ShowDialog();
        }
    }
}
