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
        public FormFuncionarios()
        {
            InitializeComponent();
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
            Abrirtela(new FormCadastrarUsuario());
        }
    }
}
