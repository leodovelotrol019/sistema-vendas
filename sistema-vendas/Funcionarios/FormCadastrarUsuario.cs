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
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void painelFormularioCadastrarFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void selec_depart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text.Trim() == "")
            {
                MessageBox.Show("Nome Completo é obrigatorio!!!");
                return;
            }
            if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("E-mail é obrigatorio!!!");
                return;
            }
  
            if (maskbox_cpf.MaskCompleted == false)
            {
                MessageBox.Show("CPF é obrigatorio!!!");
                return;
            }
            if (maskbox_tel.MaskCompleted == false )
            {
                MessageBox.Show("telefone é obrigatorio!!!");
                return;
            }
            if (selec_depart.Text.Trim() == "")
            {
                MessageBox.Show("Departamento é obrigatorio!!!");
                return;

            }

            //CONECTAR E GUARDAR INFORMAÇÕES NA TABELA DE HISTORICO NO BANCO DE DADOS

            string conexao = "server=localhost;database=db_sistema_chamados;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);

            conn.Open();


            string sql = @"INSERT INTO tb_funcionarios (nome, email, telefone, cpf, departamento) 
                                  VALUES (@nome, @email, @telefone, @cpf,@departamento  )";


            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
            comando.Parameters.AddWithValue("@email", txt_email.Text);
            comando.Parameters.AddWithValue("@telefone", maskbox_tel.Text);
            comando.Parameters.AddWithValue("@cpf", maskbox_cpf.Text);
            comando.Parameters.AddWithValue("@departamento", selec_depart.Text);

            if (comando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro inserido com sucesso");
            }

            conn.Close();

            txtNomeCompleto.Clear();
            txt_email.Clear();
            maskbox_cpf.Clear();
            maskbox_tel.Clear();
            selec_depart.SelectedIndex = -1;
        }
    }
}
