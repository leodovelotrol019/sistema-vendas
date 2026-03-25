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

        private void botao_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario tela_usuario = new FormCadastrarUsuario();
            tela_usuario.ShowDialog();
        }
    }
}
