using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_vendas
{
    public partial class FormDois : Form
    {
        public FormDois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            if(painel_menu_lateral.Visible == true)
            {
                painel_menu_lateral.Visible = false;
            }
            else
            {
                painel_menu_lateral.Visible = true;
            }
        }

        private void botao_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void botao_stats_Click(object sender, EventArgs e)
        {

        }

        private void timer_data_hora_atual_Tick(object sender, EventArgs e)
        {
            label_data_hora_atual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void label_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // --> Encerra o aplicativo
            //this.Close();        --> Fecha a tela
        }
    }
}
