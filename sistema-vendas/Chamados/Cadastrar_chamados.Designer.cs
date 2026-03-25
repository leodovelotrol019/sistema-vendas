namespace sistema_vendas.Chamados
{
    partial class Cadastrar_chamados
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
            this.painel_direita = new System.Windows.Forms.Panel();
            this.painel_esquerda = new System.Windows.Forms.Panel();
            this.painel_titulo = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.painel_infos = new System.Windows.Forms.TableLayoutPanel();
            this.label_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label_contato = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.label_assunto = new System.Windows.Forms.Label();
            this.label_prioridade = new System.Windows.Forms.Label();
            this.selec_prioridade = new System.Windows.Forms.ComboBox();
            this.label_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label_obs = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.painel_titulo.SuspendLayout();
            this.painel_infos.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_direita
            // 
            this.painel_direita.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.painel_direita.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_direita.Location = new System.Drawing.Point(0, 0);
            this.painel_direita.Name = "painel_direita";
            this.painel_direita.Size = new System.Drawing.Size(119, 1041);
            this.painel_direita.TabIndex = 0;
            this.painel_direita.Paint += new System.Windows.Forms.PaintEventHandler(this.pai_Paint);
            // 
            // painel_esquerda
            // 
            this.painel_esquerda.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel_esquerda.Location = new System.Drawing.Point(1260, 0);
            this.painel_esquerda.Name = "painel_esquerda";
            this.painel_esquerda.Size = new System.Drawing.Size(124, 1041);
            this.painel_esquerda.TabIndex = 1;
            // 
            // painel_titulo
            // 
            this.painel_titulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.painel_titulo.Controls.Add(this.titulo);
            this.painel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_titulo.Location = new System.Drawing.Point(119, 0);
            this.painel_titulo.Name = "painel_titulo";
            this.painel_titulo.Size = new System.Drawing.Size(1141, 100);
            this.painel_titulo.TabIndex = 2;
            // 
            // titulo
            // 
            this.titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titulo.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1141, 100);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Chamados";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painel_infos
            // 
            this.painel_infos.BackColor = System.Drawing.Color.LightGray;
            this.painel_infos.ColumnCount = 1;
            this.painel_infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.painel_infos.Controls.Add(this.label_nome, 0, 0);
            this.painel_infos.Controls.Add(this.txt_nome, 0, 1);
            this.painel_infos.Controls.Add(this.label_contato, 0, 2);
            this.painel_infos.Controls.Add(this.txt_contato, 0, 3);
            this.painel_infos.Controls.Add(this.txt_assunto, 0, 5);
            this.painel_infos.Controls.Add(this.label_assunto, 0, 4);
            this.painel_infos.Controls.Add(this.label_prioridade, 0, 6);
            this.painel_infos.Controls.Add(this.selec_prioridade, 0, 7);
            this.painel_infos.Controls.Add(this.label_cidade, 0, 8);
            this.painel_infos.Controls.Add(this.txt_cidade, 0, 9);
            this.painel_infos.Controls.Add(this.txt_obs, 0, 11);
            this.painel_infos.Controls.Add(this.label_obs, 0, 10);
            this.painel_infos.Controls.Add(this.btn_enviar, 0, 12);
            this.painel_infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_infos.Location = new System.Drawing.Point(119, 100);
            this.painel_infos.Name = "painel_infos";
            this.painel_infos.RowCount = 13;
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.painel_infos.Size = new System.Drawing.Size(1141, 941);
            this.painel_infos.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.BackColor = System.Drawing.Color.Silver;
            this.label_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_nome.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(3, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(1135, 72);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "CHAMADOS";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_nome
            // 
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 32.75F, System.Drawing.FontStyle.Bold);
            this.txt_nome.Location = new System.Drawing.Point(3, 75);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(1135, 60);
            this.txt_nome.TabIndex = 1;
            // 
            // label_contato
            // 
            this.label_contato.BackColor = System.Drawing.Color.Silver;
            this.label_contato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_contato.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contato.Location = new System.Drawing.Point(3, 144);
            this.label_contato.Name = "label_contato";
            this.label_contato.Size = new System.Drawing.Size(1135, 72);
            this.label_contato.TabIndex = 2;
            this.label_contato.Text = "CANAL DE CONTATO";
            this.label_contato.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_contato
            // 
            this.txt_contato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_contato.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold);
            this.txt_contato.Location = new System.Drawing.Point(3, 219);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(1135, 59);
            this.txt_contato.TabIndex = 3;
            // 
            // txt_assunto
            // 
            this.txt_assunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_assunto.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assunto.Location = new System.Drawing.Point(3, 363);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(1135, 59);
            this.txt_assunto.TabIndex = 4;
            this.txt_assunto.TextChanged += new System.EventHandler(this.txt_assunto_TextChanged);
            // 
            // label_assunto
            // 
            this.label_assunto.BackColor = System.Drawing.Color.Silver;
            this.label_assunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_assunto.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_assunto.Location = new System.Drawing.Point(3, 288);
            this.label_assunto.Name = "label_assunto";
            this.label_assunto.Size = new System.Drawing.Size(1135, 72);
            this.label_assunto.TabIndex = 5;
            this.label_assunto.Text = "ASSUNTO";
            this.label_assunto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_prioridade
            // 
            this.label_prioridade.BackColor = System.Drawing.Color.Silver;
            this.label_prioridade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_prioridade.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prioridade.Location = new System.Drawing.Point(3, 432);
            this.label_prioridade.Name = "label_prioridade";
            this.label_prioridade.Size = new System.Drawing.Size(1135, 72);
            this.label_prioridade.TabIndex = 6;
            this.label_prioridade.Text = "PRIORIDADE";
            this.label_prioridade.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // selec_prioridade
            // 
            this.selec_prioridade.AllowDrop = true;
            this.selec_prioridade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selec_prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selec_prioridade.Font = new System.Drawing.Font("Roboto", 32F);
            this.selec_prioridade.FormattingEnabled = true;
            this.selec_prioridade.Items.AddRange(new object[] {
            "BAIXA",
            "MÉDIA",
            "ALTA"});
            this.selec_prioridade.Location = new System.Drawing.Point(3, 507);
            this.selec_prioridade.Name = "selec_prioridade";
            this.selec_prioridade.Size = new System.Drawing.Size(1135, 60);
            this.selec_prioridade.TabIndex = 7;
            // 
            // label_cidade
            // 
            this.label_cidade.BackColor = System.Drawing.Color.Silver;
            this.label_cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cidade.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cidade.Location = new System.Drawing.Point(3, 576);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(1135, 72);
            this.label_cidade.TabIndex = 8;
            this.label_cidade.Text = "Cidade";
            this.label_cidade.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cidade.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold);
            this.txt_cidade.Location = new System.Drawing.Point(3, 651);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(1135, 59);
            this.txt_cidade.TabIndex = 9;
            // 
            // txt_obs
            // 
            this.txt_obs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_obs.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.Location = new System.Drawing.Point(3, 795);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(1135, 59);
            this.txt_obs.TabIndex = 10;
            // 
            // label_obs
            // 
            this.label_obs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_obs.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_obs.Location = new System.Drawing.Point(3, 720);
            this.label_obs.Name = "label_obs";
            this.label_obs.Size = new System.Drawing.Size(1135, 72);
            this.label_obs.TabIndex = 11;
            this.label_obs.Text = "OBSERVAÇÃO";
            this.label_obs.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enviar.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_enviar.Location = new System.Drawing.Point(3, 867);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(1135, 71);
            this.btn_enviar.TabIndex = 12;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Cadastrar_chamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 1041);
            this.Controls.Add(this.painel_infos);
            this.Controls.Add(this.painel_titulo);
            this.Controls.Add(this.painel_esquerda);
            this.Controls.Add(this.painel_direita);
            this.Name = "Cadastrar_chamados";
            this.Text = "Cadastrar_chamados";
            this.painel_titulo.ResumeLayout(false);
            this.painel_infos.ResumeLayout(false);
            this.painel_infos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_direita;
        private System.Windows.Forms.Panel painel_esquerda;
        private System.Windows.Forms.Panel painel_titulo;
        private System.Windows.Forms.TableLayoutPanel painel_infos;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label_contato;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.Label label_assunto;
        private System.Windows.Forms.Label label_prioridade;
        private System.Windows.Forms.ComboBox selec_prioridade;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label_obs;
        private System.Windows.Forms.Button btn_enviar;
    }
}