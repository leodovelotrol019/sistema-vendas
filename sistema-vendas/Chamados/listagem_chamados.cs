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


            string sql = @"SELECT data, nome, status, prioridade FROM tb_chamados";
            MySqlCommand comando = new MySqlCommand(sql, conn);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Panel card = new Panel();
                card.Width = 200;
                card.Height = 200;
                
                switch ((reader["status"].ToString().ToLower()))
                {
                    case "aberto":
                        card.BackColor = Color.Red;
                        break;
                    case "em andamento":
                        card.BackColor = Color.Yellow;
                        break;

                    case "resolvido":
                        card.BackColor = Color.DarkGreen;
                        break;
                    default:
                        card.BackColor = Color.Blue;
                        break;
                }

                string prioridade = reader["prioridade"].ToString().ToLower();

                if(prioridade == "alta")
                {
                    Label alerta = new Label();
                    alerta.Text = "ALTA";
                    alerta.ForeColor = Color.Orange;
                    alerta.Dock = DockStyle.Top;
                    alerta.TextAlign = ContentAlignment.MiddleCenter;
                    card.Controls.Add( alerta );
                }


                Label data = new Label();
                data.ForeColor = Color.White;
                data.Font = new Font("Arial", 12);
                data.TextAlign = ContentAlignment.MiddleCenter;
                data.AutoSize = false;
                DateTime dataValor = Convert.ToDateTime(reader["data"]);
                data.Text = dataValor.ToString("dd/MM/yyyy");
                data.Dock = DockStyle.Top;
                card.Controls.Add(data);
               



                Label nome = new Label();
                nome.ForeColor = Color.White;
                nome.Font = new Font("Arial", 12);
                nome.TextAlign = ContentAlignment.MiddleCenter;
                nome.AutoSize = false;
                nome.Text = reader["nome"].ToString();
                nome.Dock = DockStyle.Top;
                card.Controls.Add(nome);

                Label status = new Label();
                status.ForeColor = Color.White;
                status.Font = new Font("Arial", 12);
                status.TextAlign = ContentAlignment.MiddleCenter;
                status.AutoSize = false;
                status.Text = reader["status"].ToString();
                status.Dock = DockStyle.Top;
            

               
                card.Controls.Add(status);

                panel_lista.Controls.Add(card);


            }
        }

        private void panel_lista_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
