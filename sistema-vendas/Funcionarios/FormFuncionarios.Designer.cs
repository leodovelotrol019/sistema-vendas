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
            this.botao_cadastrar_funcionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botao_cadastrar_funcionario.Name = "botao_cadastrar_funcionario";
            this.botao_cadastrar_funcionario.Size = new System.Drawing.Size(114, 38);
            this.botao_cadastrar_funcionario.TabIndex = 1;
            this.botao_cadastrar_funcionario.Text = "Cadastrar";
            this.botao_cadastrar_funcionario.UseVisualStyleBackColor = false;
            this.botao_cadastrar_funcionario.Click += new System.EventHandler(this.botao_cadastrar_funcionario_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.botao_cadastrar_funcionario);
            this.Controls.Add(this.labelListagemFuncionarios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListagemFuncionarios;
        private System.Windows.Forms.Button botao_cadastrar_funcionario;
    }
}