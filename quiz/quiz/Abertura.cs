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
    public partial class Frm_abertura : Form
    {
        public Frm_abertura()
        {
            InitializeComponent();
        }

        private void Rad_perf1_CheckedChanged(object sender, EventArgs e)
        {
            Pic_perfil_visit.Image = Properties.Resources.aquaman;
        }

        private void Rad_perfil2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_perfil_visit.Image = Properties.Resources.filme_dr_estra;
        }

        private void Rad_perf3_CheckedChanged(object sender, EventArgs e)
        {
            Pic_perfil_visit.Image = Properties.Resources.pantera_negra;
        }

        private void Rad_sem_perfil_CheckedChanged(object sender, EventArgs e)
        {
            Pic_perfil_visit.Image = Properties.Resources.p_rostos;
        }

        private void Rad_arco_iris_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.arco_iris;
            Lbl_resulta1.Text = Rad_arco_iris.Text;
        }

        private void Rad_cachoeira_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.cachoeira;
            Lbl_resulta1.Text = Rad_cachoeira.Text;     
        }

        private void Rad_cat1_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.cataratas_1;
            Lbl_resulta1.Text = Rad_cat1.Text; 
        }

        private void Rad_cat2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.cataratas_2;
            Lbl_resulta1.Text = Rad_cat2.Text;  
        }

        private void Rad_coq_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.coqueiros;
            Lbl_resulta1.Text = Rad_coq.Text;  
        }

        private void Rad_praia_CheckedChanged(object sender, EventArgs e)
        {
            Pic_paisag.Image = Properties.Resources.praia;
            Lbl_resulta1.Text = Rad_praia.Text;  
        }

        private void Rad_ti_br_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigre_branco;
            Lbl_resulta2.Text = Rad_ti_br.Text;   
        }

        private void Rad_ti_agua_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigre_na_agua;
            Lbl_resulta2.Text = Rad_ti_agua.Text;    
        }

        private void Rad_ti_pard_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigre_Pardo;
            Lbl_resulta2.Text = Rad_ti_pard.Text;  
        }


        private void Rad_ti_polar_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigre_polar;
            Lbl_resulta2.Text = Rad_ti_polar.Text;  
        }

        private void Rad_tig_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigre;
            Lbl_resulta2.Text = Rad_tig.Text;  
        }

        private void Rad_ti_bw_CheckedChanged(object sender, EventArgs e)
        {
            Pic_tigres.Image = Properties.Resources.tigres_b_w;
            Lbl_resulta2.Text = Rad_ti_bw.Text;  
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rad_DINh_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_din;
            Lbl_resulta3.Text = Rad_DINh.Text;  
        }

        private void Rad_m_dor_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_dor;
            Lbl_resulta3.Text = Rad_m_dor.Text;  
        }

        private void Rad_m_coisas_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_coisas;
            Lbl_resulta3.Text = Rad_m_coisas.Text;  
        }

        private void Rad_m_prova_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_prova;
            Lbl_resulta3.Text = Rad_m_prova.Text;   
        }

        private void Rad_m_chur_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_chu;
            Lbl_resulta3.Text = Rad_m_chur.Text;  
        }

        private void Rad_m_Titanic_CheckedChanged(object sender, EventArgs e)
        {
            Pic_meme.Image = Properties.Resources.meme_titanic;
            Lbl_resulta3.Text = Rad_m_Titanic.Text;  
        }

        private void Rad_le_br_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.leao_branco;
            Lbl_resulta4.Text = Rad_le_br.Text;  
        }

        private void Rad_casal_le_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.casal_leoes;
            Lbl_resulta4.Text = Rad_casal_le.Text;  
        }

        private void Rad_casal_le_b_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.casal_leoes_B;
            Lbl_resulta4.Text = Rad_casal_le_b.Text;  
        }

        private void Rad_rost_le_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.rosto_leao;
            Lbl_resulta4.Text = Rad_rost_le.Text;  

        }

        private void Rad_le_cast_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.leao_castanho;
            Lbl_resulta4.Text = Rad_le_cast.Text;  
        }

        private void Rad_rost_le2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_leoes.Image = Properties.Resources.rosto_leao_2;
            Lbl_resulta4.Text = Rad_rost_le2.Text;  
        }

        private void Frm_abertura_Load(object sender, EventArgs e)
        {

        }

        private void Btn_resultado_Click(object sender, EventArgs e)
        {
            Frm_resultado resultado = new Frm_resultado();  // Instanciar(criar objeto) = nome resultado.

            resultado.Lbl_nome.Text = Txt_nome.Text; // Levando o nome do perfil para tela de resultado.
            resultado.Pic_no_perf.Image = Pic_perfil_visit.Image; // Levando a imagem do perfil do visitante para a tela resultado.
            resultado.Pic_paisag.Image = Pic_paisag.Image; // Levando a imagem do pic paisagem para a tela do resultado.
            resultado.Pic_Tig.Image = Pic_tigres.Image; // Levando a imagem do pic tigre para a atela do resultado.
            resultado.Pic_memes.Image = Pic_meme.Image; // Levando a imagem do pic meme para a tela do resultado.
            resultado.Pic_Leoes.Image = Pic_leoes.Image; // Levando a imagem do pic leoes para a tela do resultado.
            resultado.Lbl_result1.Text = Lbl_resulta1.Text; // Levando o texto do resultado da tela abertura para o resultado da tela resultado.
            resultado.Lbl_result2.Text = Lbl_resulta2.Text;  // Levando o texto do resultado da tela abertura para o resultado da tela resultado.
            resultado.Lbl_result3.Text = Lbl_resulta3.Text;  // Levando o texto do resultado da tela abertura para o resultado da tela resultado.
            resultado.Lbl_result4.Text = Lbl_resulta4.Text; //  Levando o texto do resultado da tela abertura para o resultado da tela resultado.

            Hide();
            resultado.Show();  
        }

        private void Lbl_resulta1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_resulta4_Click(object sender, EventArgs e)
        {

        }

        private void Lb_selec_Click(object sender, EventArgs e)
        {

        }

        private void Lb_quiz_Click(object sender, EventArgs e)
        {

        }

        private void Pic_paisag_Click(object sender, EventArgs e)
        {

        }
    }
}
