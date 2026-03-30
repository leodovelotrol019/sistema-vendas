using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_vendas.Chamados
{
    public partial class form_chamados_listar : Form
    {
        public form_chamados_listar()
        {
            InitializeComponent();
        }

        private void botao_chamados_Click(object sender, EventArgs e)
        {

            Cadastrar_chamados tela_chamados = new Cadastrar_chamados();
            tela_chamados.ShowDialog();
        }

        private void form_chamados_listar_Load(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=db_sistema_chamados;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);

            conn.Open();


            string sql = @"SELECT Data, Nome, prioridade FROM tb_chamados";
            MySqlCommand comando = new MySqlCommand(sql, conn);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Panel card = new Panel();
                card.Width = 200;
                card.Height = 200;
               
                switch ((reader["prioridade"]))
                {
                    case (alta) :
                        prioridade.BackColor = Color.DarkGreen;
                        break;
                        case    
                }


                Label data = new Label();
                data.ForeColor = Color.White;
                data.BackColor = Color.DarkGreen;
                data.Font = new Font("Arial", 12);
                data.TextAlign = ContentAlignment.MiddleCenter;
                data.AutoSize = false;
                data.Text = reader["data"].ToString();
                data.Dock = DockStyle.Top;
                card.Controls.Add(data);
                panel_lista.Controls.Add(card);

                Label nome = new Label();
                nome.ForeColor = Color.White;
                nome.Font = new Font("Arial", 12);
                nome.TextAlign = ContentAlignment.MiddleCenter;
                nome.AutoSize = false;
                nome.Text = reader["nome"].ToString();
                nome.Dock = DockStyle.Top;
                card.Controls.Add(nome);

                Label prioridade = new Label();
                prioridade.ForeColor = Color.White;
                prioridade.Font = new Font("Arial", 12);
                prioridade.TextAlign = ContentAlignment.MiddleCenter;
                prioridade.AutoSize = false;
                prioridade.Text = reader["prioridade"].ToString();
                prioridade.Dock = DockStyle.Top;
                prioridade.Controls.Add(data);
                panel_lista.Controls.Add(card);




            }
        }
}
