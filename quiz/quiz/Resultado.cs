using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Frm_resultado : Form
    {
        public Frm_resultado()
        {
            InitializeComponent();
        }

        private void Btn_v_quiz_Click(object sender, EventArgs e)
        {
            Frm_abertura abertura = new Frm_abertura();
            Hide();
            abertura.Show();  
        }

        private void Pic_Leoes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();      

        }
    }
}
