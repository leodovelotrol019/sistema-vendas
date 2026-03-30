namespace sistema_vendas
{
    partial class FormFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelListagemFuncionarios = new System.Windows.Forms.Label();
            this.botao_cadastrar_funcionario = new System.Windows.Forms.Button();
            this.painel_principal = new System.Windows.Forms.Panel();
            this.panel_cima = new System.Windows.Forms.Panel();
            this.panel_lista = new System.Windows.Forms.FlowLayoutPanel();
            this.painel_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListagemFuncionarios
            // 
            this.labelListagemFuncionarios.AutoSize = true;
            this.labelListagemFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListagemFuncionarios.Location = new System.Drawing.Point(28, 23);
            this.labelListagemFuncionarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListagemFuncionarios.Name = "labelListagemFuncionarios";
            this.labelListagemFuncionarios.Size = new System.Drawing.Size(221, 24);
            this.labelListagemFuncionarios.TabIndex = 0;
            this.labelListagemFuncionarios.Text = "Listagem Funcionários";
            // 
            // botao_cadastrar_funcionario
            // 
            this.botao_cadastrar_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_cadastrar_funcionario.BackColor = System.Drawing.Color.Maroon;
            this.botao_cadastrar_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao_cadastrar_funcionario.FlatAppearance.BorderSize = 2;
            this.botao_cadastrar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_cadastrar_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_cadastrar_funcionario.ForeColor = System.Drawing.Color.White;
            this.botao_cadastrar_funcionario.Location = new System.Drawing.Point(1291, 30);
            this.botao_cadastrar_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.botao_cadastrar_funcionario.Name = "botao_cadastrar_funcionario";
            this.botao_cadastrar_funcionario.Size = new System.Drawing.Size(114, 38);
            this.botao_cadastrar_funcionario.TabIndex = 1;
            this.botao_cadastrar_funcionario.Text = "Cadastrar";
            this.botao_cadastrar_funcionario.UseVisualStyleBackColor = false;
            this.botao_cadastrar_funcionario.Click += new System.EventHandler(this.botao_cadastrar_funcionario_Click);
            // 
            // painel_principal
            // 
            this.painel_principal.Controls.Add(this.panel_lista);
            this.painel_principal.Controls.Add(this.panel_cima);
            this.painel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_principal.Location = new System.Drawing.Point(0, 0);
            this.painel_principal.Name = "painel_principal";
            this.painel_principal.Size = new System.Drawing.Size(1426, 839);
            this.painel_principal.TabIndex = 2;
            this.painel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_principal_Paint);
            // 
            // panel_cima
            // 
            this.panel_cima.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cima.Location = new System.Drawing.Point(0, 0);
            this.panel_cima.Name = "panel_cima";
            this.panel_cima.Size = new System.Drawing.Size(1426, 100);
            this.panel_cima.TabIndex = 0;
            this.panel_cima.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cima_Paint);
            // 
            // panel_lista
            // 
            this.panel_lista.AutoScroll = true;
            this.panel_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_lista.Location = new System.Drawing.Point(0, 100);
            this.panel_lista.Name = "panel_lista";
            this.panel_lista.Size = new System.Drawing.Size(1426, 739);
            this.panel_lista.TabIndex = 1;
            this.panel_lista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_lista_Paint);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.botao_cadastrar_funcionario);
            this.Controls.Add(this.labelListagemFuncionarios);
            this.Controls.Add(this.painel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.painel_principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListagemFuncionarios;
        private System.Windows.Forms.Button botao_cadastrar_funcionario;
        private System.Windows.Forms.Panel painel_principal;
        private System.Windows.Forms.FlowLayoutPanel panel_lista;
        private System.Windows.Forms.Panel panel_cima;
    }
}