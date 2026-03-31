using sistema_vendas.Chamados;
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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirNoPainel(Form form)
        {
            foreach (Control c in painel_principal.Controls)
            {
                if (c is Form f) f.Close();
            }
            painel_principal.Controls.Clear();

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            painel_principal.Controls.Add(form);
            form.Show();
        }
        private void menuCalculadora_Click(object sender, EventArgs e)

        {
            FormCalculadora tela_calculadora = new FormCalculadora();
            tela_calculadora.ShowDialog();

        }

        private void botao_funcionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios tela_funcionarios = new FormFuncionarios(this);
            painel_principal.Controls.Clear();
            tela_funcionarios.Dock = DockStyle.Fill;
            tela_funcionarios.TopLevel = false;

            painel_principal.Controls.Add(tela_funcionarios);
            tela_funcionarios.Show();

        }

        private void Chamados_Click(object sender, EventArgs e)
        {
           
                form_chamados_listar tela_chamados = new form_chamados_listar();
                painel_principal.Controls.Clear();
                tela_chamados.Dock = DockStyle.Fill;
                tela_chamados.TopLevel = false;
                painel_principal.Controls.Add(tela_chamados);
                tela_chamados.Show();
            }

        private void painel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botao_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
