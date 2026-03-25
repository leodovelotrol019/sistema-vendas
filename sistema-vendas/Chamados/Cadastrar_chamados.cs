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

namespace sistema_vendas.Chamados
{
    public partial class Cadastrar_chamados : Form
    {
        public Cadastrar_chamados()
        {
            InitializeComponent();
        }

        private void pai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Nome Completo é obrigatorio!!!");
                return;
            }
            if (txt_contato.Text.Trim() == "")
            {
                MessageBox.Show("Canal de Contato é obrigatorio!!!");
                return;
            }

            if (txt_assunto.Text.Trim() == "")
            {
                MessageBox.Show("Assunto é obrigatorio!!!");
                return;
            }
            if (selec_prioridade.Text.Trim() == "")
            {
                MessageBox.Show("Prioridade é obrigatorio!!!");
                return;
            }
            if (txt_cidade.Text.Trim() == "")
            {
                MessageBox.Show("Cidade é obrigatorio!!!");
                return;

            }
            

            //CONECTAR E GUARDAR INFORMAÇÕES NA TABELA DE HISTORICO NO BANCO DE DADOS

            string conexao = "server=localhost;database=db_sistema_chamados;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);

            conn.Open();


            string sql = @"INSERT INTO tb_chamados(Nome, Contato, Assunto, Prioridade, Cidade, Observacao) 
                                  VALUES (@nome, @contato, @assunto, @prioridade ,@cidade, @obs  )";


            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@contato", txt_contato.Text);
            comando.Parameters.AddWithValue("@assunto", txt_assunto.Text);
            comando.Parameters.AddWithValue("@prioridade", selec_prioridade.Text);
            comando.Parameters.AddWithValue("@cidade", txt_cidade.Text);
            comando.Parameters.AddWithValue("@obs", txt_obs.Text);

            if (comando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro inserido com sucesso");
            }

            conn.Close();

            txt_nome.Clear();
            txt_contato.Clear();
            txt_assunto.Clear();
            selec_prioridade.SelectedIndex = -1;
            txt_cidade.Clear();
            txt_obs.Clear();
        }

        private void txt_assunto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
