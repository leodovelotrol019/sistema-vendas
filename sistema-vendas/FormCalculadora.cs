using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace sistema_vendas
{
    public partial class FormCalculadora : Form
    {
        


        private decimal Resultado { get; set; }

        private decimal Valor1 { get; set; }

        private decimal Valor2 { get; set; }

        private enum Operacao
        {
            soma,
            subtracao,
            multiplicacao,
            divisao
        }

        private Operacao operacaoSelecionada { get; set; }



        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void botao_1_Click(object sender, EventArgs e)
        {
            txtVisor.Text +=  "1";
        }

        private void botao_2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void botao_0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void botao_3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void botao_4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void botao_5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void botao_6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void botao_7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void botao_8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void botao_9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
        }

        private void botao_virgula_Click(object sender, EventArgs e)
        {

            if (!txtVisor.Text.Contains(","))
            {
                txtVisor.Text += ",";
            }
            
        }

        private void botao_soma_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDecimal(txtVisor.Text);
            operacaoSelecionada = Operacao.soma;
            txtVisor.Clear();
        }

        private void botao_igual_Click(object sender, EventArgs e)
        {

            Valor2 = Convert.ToDecimal(txtVisor.Text);

            switch (operacaoSelecionada)
            {
                case Operacao.soma:
                    Resultado = Valor1 + Valor2;
                    break;
                
                case Operacao.subtracao:
                    Resultado = Valor1 - Valor2;
                    break;

                case Operacao.multiplicacao:    
                    Resultado = Valor1 * Valor2;
                    break;

                case Operacao.divisao:
                    Resultado = Valor1 / Valor2;
                    break;

            }

            txtVisor.Text = Convert.ToString(Resultado);


            //CONECTAR E GUARDAR INFORMAÇÕES NA TABELA DE HISTORICO NO BANCO DE DADOS

            string conexao = "server=localhost;database=db_calculadora;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);
            
            conn.Open();


            string sql = @"INSERT INTO tb_historico (valor1, operacao, valor2, resultado) 
                                             VALUES (@valor1, @operacao, @valor2, @resultado)";      
            
            
            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@valor1", Valor1);
            comando.Parameters.AddWithValue("@operacao", operacaoSelecionada.ToString());
            comando.Parameters.AddWithValue("@valor2", Valor2);
            comando.Parameters.AddWithValue("@resultado", Resultado);

            if(comando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro inserido com sucesso");
            }

            conn.Close();

        }

        private void botao_subtracao_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDecimal(txtVisor.Text);
            operacaoSelecionada = Operacao.subtracao;
            txtVisor.Clear();

        }

        private void botao_multiplicacao_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDecimal(txtVisor.Text);
            operacaoSelecionada = Operacao.multiplicacao;
            txtVisor.Clear();
        }

        private void botao_divisao_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDecimal(txtVisor.Text);
            operacaoSelecionada = Operacao.divisao;
            txtVisor.Clear();
        }
    }
}
