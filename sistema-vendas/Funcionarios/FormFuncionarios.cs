using MySql.Data.MySqlClient;
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
    public partial class FormFuncionarios : Form
    {
        public formPrincipal principal;
        public FormFuncionarios(formPrincipal form)
        {

            InitializeComponent();
            principal = form;
        }
        private void Abrirtela(Form tela)

        {

            painel_principal.Controls.Clear();


            tela.Dock = DockStyle.Fill;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.TopLevel = false;


            painel_principal.Controls.Add(tela);
            painel_principal.Tag = tela;
            tela.Show();
        }

        private void botao_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario cadastrarUsuario = new FormCadastrarUsuario();
            cadastrarUsuario.Dock = DockStyle.Fill;
            cadastrarUsuario.FormBorderStyle = FormBorderStyle.None;
            cadastrarUsuario.TopLevel = false;

            principal.painel_principal.Controls.Clear();
            principal.painel_principal.Controls.Add(cadastrarUsuario);
            cadastrarUsuario.Show();
        }

        private void painel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_lista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_cima_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

            string conexao = "server=localhost;database=db_sistema_chamados;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);

            conn.Open();


            string sql = @"SELECT nome, departamento, ativo FROM tb_Funcionarios";
            MySqlCommand comando = new MySqlCommand(sql, conn);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Panel card = new Panel();
                card.Width = 200;
                card.Height = 200;
                if (Convert.ToInt16(reader["ativo"]) == 1)
                {
                    card.BackColor = Color.Green;
                }
                else
                {
                    card.BackColor = Color.Red;
                }
                   


                Label departamento = new Label();
                departamento.ForeColor = Color.White;
                departamento.BackColor = Color.DarkGreen;
                departamento.Font = new Font("Arial", 12);
                departamento.TextAlign = ContentAlignment.MiddleCenter;
                departamento.AutoSize = false;
                departamento.Text = reader["departamento"].ToString();
                departamento.Dock = DockStyle.Top;
                card.Controls.Add(departamento);
                panel_lista.Controls.Add(card);

                Label nome = new Label();
                nome.ForeColor = Color.White;
                nome.Font = new Font("Arial", 12);
                nome.TextAlign = ContentAlignment.MiddleCenter;
                nome.AutoSize = false;
                nome.Text = reader["nome"].ToString();
                nome.Dock = DockStyle.Top;
                card.Controls.Add(nome);


                
            }
        }
    }
}