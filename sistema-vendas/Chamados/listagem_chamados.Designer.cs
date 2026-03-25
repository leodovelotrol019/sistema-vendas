namespace sistema_vendas.Chamados
{
    partial class form_chamados_listar
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
            this.painel_da_esquerda = new System.Windows.Forms.Panel();
            this.painel_da_direita = new System.Windows.Forms.Panel();
            this.painel_de_cima = new System.Windows.Forms.Panel();
            this.painel_principal = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.botao_chamados = new System.Windows.Forms.Button();
            this.painel_de_cima.SuspendLayout();
            this.painel_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_da_esquerda
            // 
            this.painel_da_esquerda.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.painel_da_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_da_esquerda.Location = new System.Drawing.Point(0, 0);
            this.painel_da_esquerda.Name = "painel_da_esquerda";
            this.painel_da_esquerda.Size = new System.Drawing.Size(112, 450);
            this.painel_da_esquerda.TabIndex = 0;
            // 
            // painel_da_direita
            // 
            this.painel_da_direita.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.painel_da_direita.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel_da_direita.Location = new System.Drawing.Point(688, 0);
            this.painel_da_direita.Name = "painel_da_direita";
            this.painel_da_direita.Size = new System.Drawing.Size(112, 450);
            this.painel_da_direita.TabIndex = 1;
            // 
            // painel_de_cima
            // 
            this.painel_de_cima.BackColor = System.Drawing.Color.LightBlue;
            this.painel_de_cima.Controls.Add(this.titulo);
            this.painel_de_cima.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_de_cima.Location = new System.Drawing.Point(112, 0);
            this.painel_de_cima.Name = "painel_de_cima";
            this.painel_de_cima.Size = new System.Drawing.Size(576, 68);
            this.painel_de_cima.TabIndex = 2;
            // 
            // painel_principal
            // 
            this.painel_principal.BackColor = System.Drawing.Color.LightCyan;
            this.painel_principal.Controls.Add(this.botao_chamados);
            this.painel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_principal.Location = new System.Drawing.Point(112, 68);
            this.painel_principal.Name = "painel_principal";
            this.painel_principal.Size = new System.Drawing.Size(576, 382);
            this.painel_principal.TabIndex = 3;
            // 
            // titulo
            // 
            this.titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titulo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(576, 68);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Chamados";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botao_chamados
            // 
            this.botao_chamados.Dock = System.Windows.Forms.DockStyle.Top;
            this.botao_chamados.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_chamados.Location = new System.Drawing.Point(0, 0);
            this.botao_chamados.Name = "botao_chamados";
            this.botao_chamados.Size = new System.Drawing.Size(576, 74);
            this.botao_chamados.TabIndex = 0;
            this.botao_chamados.Text = "Chamados Cadastrar";
            this.botao_chamados.UseVisualStyleBackColor = true;
            this.botao_chamados.Click += new System.EventHandler(this.botao_chamados_Click);
            // 
            // form_chamados_listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painel_principal);
            this.Controls.Add(this.painel_de_cima);
            this.Controls.Add(this.painel_da_direita);
            this.Controls.Add(this.painel_da_esquerda);
            this.Name = "form_chamados_listar";
            this.Text = "v";
            this.painel_de_cima.ResumeLayout(false);
            this.painel_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_da_esquerda;
        private System.Windows.Forms.Panel painel_da_direita;
        private System.Windows.Forms.Panel painel_de_cima;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel painel_principal;
        private System.Windows.Forms.Button botao_chamados;
    }
}