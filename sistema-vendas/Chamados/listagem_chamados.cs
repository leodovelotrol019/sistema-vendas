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
    }
}
