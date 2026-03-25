namespace sistema_vendas
{
    partial class FormCalculadora
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
            this.painel_principal = new System.Windows.Forms.Panel();
            this.painel_botoes_principais = new System.Windows.Forms.TableLayoutPanel();
            this.botao_soma = new System.Windows.Forms.Button();
            this.botao_igual = new System.Windows.Forms.Button();
            this.botao_0 = new System.Windows.Forms.Button();
            this.botao_virgula = new System.Windows.Forms.Button();
            this.botao_subtracao = new System.Windows.Forms.Button();
            this.botao_3 = new System.Windows.Forms.Button();
            this.botao_2 = new System.Windows.Forms.Button();
            this.botao_1 = new System.Windows.Forms.Button();
            this.botao_multiplicacao = new System.Windows.Forms.Button();
            this.botao_6 = new System.Windows.Forms.Button();
            this.botao_5 = new System.Windows.Forms.Button();
            this.botao_4 = new System.Windows.Forms.Button();
            this.botao_divisao = new System.Windows.Forms.Button();
            this.botao_9 = new System.Windows.Forms.Button();
            this.botao_8 = new System.Windows.Forms.Button();
            this.botao_7 = new System.Windows.Forms.Button();
            this.painel_botao_limpar = new System.Windows.Forms.Panel();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.painel_visor = new System.Windows.Forms.Panel();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.painel_principal.SuspendLayout();
            this.painel_botoes_principais.SuspendLayout();
            this.painel_botao_limpar.SuspendLayout();
            this.painel_visor.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_principal
            // 
            this.painel_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.painel_principal.Controls.Add(this.painel_botoes_principais);
            this.painel_principal.Controls.Add(this.painel_botao_limpar);
            this.painel_principal.Controls.Add(this.painel_visor);
            this.painel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_principal.Location = new System.Drawing.Point(0, 0);
            this.painel_principal.Name = "painel_principal";
            this.painel_principal.Size = new System.Drawing.Size(394, 454);
            this.painel_principal.TabIndex = 0;
            // 
            // painel_botoes_principais
            // 
            this.painel_botoes_principais.ColumnCount = 4;
            this.painel_botoes_principais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.Controls.Add(this.botao_soma, 3, 3);
            this.painel_botoes_principais.Controls.Add(this.botao_igual, 2, 3);
            this.painel_botoes_principais.Controls.Add(this.botao_0, 1, 3);
            this.painel_botoes_principais.Controls.Add(this.botao_virgula, 0, 3);
            this.painel_botoes_principais.Controls.Add(this.botao_subtracao, 3, 2);
            this.painel_botoes_principais.Controls.Add(this.botao_3, 2, 2);
            this.painel_botoes_principais.Controls.Add(this.botao_2, 1, 2);
            this.painel_botoes_principais.Controls.Add(this.botao_1, 0, 2);
            this.painel_botoes_principais.Controls.Add(this.botao_multiplicacao, 3, 1);
            this.painel_botoes_principais.Controls.Add(this.botao_6, 2, 1);
            this.painel_botoes_principais.Controls.Add(this.botao_5, 1, 1);
            this.painel_botoes_principais.Controls.Add(this.botao_4, 0, 1);
            this.painel_botoes_principais.Controls.Add(this.botao_divisao, 3, 0);
            this.painel_botoes_principais.Controls.Add(this.botao_9, 2, 0);
            this.painel_botoes_principais.Controls.Add(this.botao_8, 1, 0);
            this.painel_botoes_principais.Controls.Add(this.botao_7, 0, 0);
            this.painel_botoes_principais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_botoes_principais.Location = new System.Drawing.Point(0, 102);
            this.painel_botoes_principais.Name = "painel_botoes_principais";
            this.painel_botoes_principais.RowCount = 4;
            this.painel_botoes_principais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.painel_botoes_principais.Size = new System.Drawing.Size(394, 352);
            this.painel_botoes_principais.TabIndex = 2;
            // 
            // botao_soma
            // 
            this.botao_soma.BackColor = System.Drawing.Color.Silver;
            this.botao_soma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_soma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_soma.FlatAppearance.BorderSize = 0;
            this.botao_soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_soma.Location = new System.Drawing.Point(297, 267);
            this.botao_soma.Name = "botao_soma";
            this.botao_soma.Size = new System.Drawing.Size(94, 82);
            this.botao_soma.TabIndex = 15;
            this.botao_soma.Tag = "";
            this.botao_soma.Text = "+";
            this.botao_soma.UseVisualStyleBackColor = false;
            this.botao_soma.Click += new System.EventHandler(this.botao_soma_Click);
            // 
            // botao_igual
            // 
            this.botao_igual.BackColor = System.Drawing.Color.Silver;
            this.botao_igual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_igual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_igual.FlatAppearance.BorderSize = 0;
            this.botao_igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_igual.Location = new System.Drawing.Point(199, 267);
            this.botao_igual.Name = "botao_igual";
            this.botao_igual.Size = new System.Drawing.Size(92, 82);
            this.botao_igual.TabIndex = 14;
            this.botao_igual.Text = "=";
            this.botao_igual.UseVisualStyleBackColor = false;
            this.botao_igual.Click += new System.EventHandler(this.botao_igual_Click);
            // 
            // botao_0
            // 
            this.botao_0.BackColor = System.Drawing.Color.Silver;
            this.botao_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_0.FlatAppearance.BorderSize = 0;
            this.botao_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_0.Location = new System.Drawing.Point(101, 267);
            this.botao_0.Name = "botao_0";
            this.botao_0.Size = new System.Drawing.Size(92, 82);
            this.botao_0.TabIndex = 13;
            this.botao_0.Text = "0";
            this.botao_0.UseVisualStyleBackColor = false;
            this.botao_0.Click += new System.EventHandler(this.botao_0_Click);
            // 
            // botao_virgula
            // 
            this.botao_virgula.BackColor = System.Drawing.Color.Silver;
            this.botao_virgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_virgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_virgula.FlatAppearance.BorderSize = 0;
            this.botao_virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_virgula.Location = new System.Drawing.Point(3, 267);
            this.botao_virgula.Name = "botao_virgula";
            this.botao_virgula.Size = new System.Drawing.Size(92, 82);
            this.botao_virgula.TabIndex = 12;
            this.botao_virgula.Text = ",";
            this.botao_virgula.UseVisualStyleBackColor = false;
            this.botao_virgula.Click += new System.EventHandler(this.botao_virgula_Click);
            // 
            // botao_subtracao
            // 
            this.botao_subtracao.BackColor = System.Drawing.Color.Silver;
            this.botao_subtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_subtracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_subtracao.FlatAppearance.BorderSize = 0;
            this.botao_subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_subtracao.Location = new System.Drawing.Point(297, 179);
            this.botao_subtracao.Name = "botao_subtracao";
            this.botao_subtracao.Size = new System.Drawing.Size(94, 82);
            this.botao_subtracao.TabIndex = 11;
            this.botao_subtracao.Text = "-";
            this.botao_subtracao.UseVisualStyleBackColor = false;
            this.botao_subtracao.Click += new System.EventHandler(this.botao_subtracao_Click);
            // 
            // botao_3
            // 
            this.botao_3.BackColor = System.Drawing.Color.Silver;
            this.botao_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_3.FlatAppearance.BorderSize = 0;
            this.botao_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_3.Location = new System.Drawing.Point(199, 179);
            this.botao_3.Name = "botao_3";
            this.botao_3.Size = new System.Drawing.Size(92, 82);
            this.botao_3.TabIndex = 10;
            this.botao_3.Text = "3";
            this.botao_3.UseVisualStyleBackColor = false;
            this.botao_3.Click += new System.EventHandler(this.botao_3_Click);
            // 
            // botao_2
            // 
            this.botao_2.BackColor = System.Drawing.Color.Silver;
            this.botao_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_2.FlatAppearance.BorderSize = 0;
            this.botao_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_2.Location = new System.Drawing.Point(101, 179);
            this.botao_2.Name = "botao_2";
            this.botao_2.Size = new System.Drawing.Size(92, 82);
            this.botao_2.TabIndex = 9;
            this.botao_2.Text = "2";
            this.botao_2.UseVisualStyleBackColor = false;
            this.botao_2.Click += new System.EventHandler(this.botao_2_Click);
            // 
            // botao_1
            // 
            this.botao_1.BackColor = System.Drawing.Color.Silver;
            this.botao_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_1.FlatAppearance.BorderSize = 0;
            this.botao_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_1.Location = new System.Drawing.Point(3, 179);
            this.botao_1.Name = "botao_1";
            this.botao_1.Size = new System.Drawing.Size(92, 82);
            this.botao_1.TabIndex = 8;
            this.botao_1.Text = "1";
            this.botao_1.UseVisualStyleBackColor = false;
            this.botao_1.Click += new System.EventHandler(this.botao_1_Click);
            // 
            // botao_multiplicacao
            // 
            this.botao_multiplicacao.BackColor = System.Drawing.Color.Silver;
            this.botao_multiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_multiplicacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_multiplicacao.FlatAppearance.BorderSize = 0;
            this.botao_multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_multiplicacao.Location = new System.Drawing.Point(297, 91);
            this.botao_multiplicacao.Name = "botao_multiplicacao";
            this.botao_multiplicacao.Size = new System.Drawing.Size(94, 82);
            this.botao_multiplicacao.TabIndex = 7;
            this.botao_multiplicacao.Text = "X";
            this.botao_multiplicacao.UseVisualStyleBackColor = false;
            this.botao_multiplicacao.Click += new System.EventHandler(this.botao_multiplicacao_Click);
            // 
            // botao_6
            // 
            this.botao_6.BackColor = System.Drawing.Color.Silver;
            this.botao_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_6.FlatAppearance.BorderSize = 0;
            this.botao_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_6.Location = new System.Drawing.Point(199, 91);
            this.botao_6.Name = "botao_6";
            this.botao_6.Size = new System.Drawing.Size(92, 82);
            this.botao_6.TabIndex = 6;
            this.botao_6.Text = "6";
            this.botao_6.UseVisualStyleBackColor = false;
            this.botao_6.Click += new System.EventHandler(this.botao_6_Click);
            // 
            // botao_5
            // 
            this.botao_5.BackColor = System.Drawing.Color.Silver;
            this.botao_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_5.FlatAppearance.BorderSize = 0;
            this.botao_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_5.Location = new System.Drawing.Point(101, 91);
            this.botao_5.Name = "botao_5";
            this.botao_5.Size = new System.Drawing.Size(92, 82);
            this.botao_5.TabIndex = 5;
            this.botao_5.Text = "5";
            this.botao_5.UseVisualStyleBackColor = false;
            this.botao_5.Click += new System.EventHandler(this.botao_5_Click);
            // 
            // botao_4
            // 
            this.botao_4.BackColor = System.Drawing.Color.Silver;
            this.botao_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_4.FlatAppearance.BorderSize = 0;
            this.botao_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_4.Location = new System.Drawing.Point(3, 91);
            this.botao_4.Name = "botao_4";
            this.botao_4.Size = new System.Drawing.Size(92, 82);
            this.botao_4.TabIndex = 4;
            this.botao_4.Text = "4";
            this.botao_4.UseVisualStyleBackColor = false;
            this.botao_4.Click += new System.EventHandler(this.botao_4_Click);
            // 
            // botao_divisao
            // 
            this.botao_divisao.BackColor = System.Drawing.Color.Silver;
            this.botao_divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_divisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_divisao.FlatAppearance.BorderSize = 0;
            this.botao_divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_divisao.Location = new System.Drawing.Point(297, 3);
            this.botao_divisao.Name = "botao_divisao";
            this.botao_divisao.Size = new System.Drawing.Size(94, 82);
            this.botao_divisao.TabIndex = 3;
            this.botao_divisao.Text = "/";
            this.botao_divisao.UseVisualStyleBackColor = false;
            this.botao_divisao.Click += new System.EventHandler(this.botao_divisao_Click);
            // 
            // botao_9
            // 
            this.botao_9.BackColor = System.Drawing.Color.Silver;
            this.botao_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_9.FlatAppearance.BorderSize = 0;
            this.botao_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_9.Location = new System.Drawing.Point(199, 3);
            this.botao_9.Name = "botao_9";
            this.botao_9.Size = new System.Drawing.Size(92, 82);
            this.botao_9.TabIndex = 2;
            this.botao_9.Text = "9";
            this.botao_9.UseVisualStyleBackColor = false;
            this.botao_9.Click += new System.EventHandler(this.botao_9_Click);
            // 
            // botao_8
            // 
            this.botao_8.BackColor = System.Drawing.Color.Silver;
            this.botao_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_8.FlatAppearance.BorderSize = 0;
            this.botao_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_8.Location = new System.Drawing.Point(101, 3);
            this.botao_8.Name = "botao_8";
            this.botao_8.Size = new System.Drawing.Size(92, 82);
            this.botao_8.TabIndex = 1;
            this.botao_8.Text = "8";
            this.botao_8.UseVisualStyleBackColor = false;
            this.botao_8.Click += new System.EventHandler(this.botao_8_Click);
            // 
            // botao_7
            // 
            this.botao_7.BackColor = System.Drawing.Color.Silver;
            this.botao_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao_7.FlatAppearance.BorderSize = 0;
            this.botao_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_7.Location = new System.Drawing.Point(3, 3);
            this.botao_7.Name = "botao_7";
            this.botao_7.Size = new System.Drawing.Size(92, 82);
            this.botao_7.TabIndex = 0;
            this.botao_7.Text = "7";
            this.botao_7.UseVisualStyleBackColor = false;
            this.botao_7.Click += new System.EventHandler(this.botao_7_Click);
            // 
            // painel_botao_limpar
            // 
            this.painel_botao_limpar.Controls.Add(this.botao_limpar);
            this.painel_botao_limpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_botao_limpar.Location = new System.Drawing.Point(0, 49);
            this.painel_botao_limpar.Name = "painel_botao_limpar";
            this.painel_botao_limpar.Size = new System.Drawing.Size(394, 53);
            this.painel_botao_limpar.TabIndex = 1;
            // 
            // botao_limpar
            // 
            this.botao_limpar.BackColor = System.Drawing.Color.Silver;
            this.botao_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_limpar.Dock = System.Windows.Forms.DockStyle.Right;
            this.botao_limpar.FlatAppearance.BorderSize = 0;
            this.botao_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_limpar.Location = new System.Drawing.Point(297, 0);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(97, 53);
            this.botao_limpar.TabIndex = 0;
            this.botao_limpar.Text = "C";
            this.botao_limpar.UseVisualStyleBackColor = false;
            this.botao_limpar.Click += new System.EventHandler(this.botao_limpar_Click);
            // 
            // painel_visor
            // 
            this.painel_visor.Controls.Add(this.txtVisor);
            this.painel_visor.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_visor.Location = new System.Drawing.Point(0, 0);
            this.painel_visor.Name = "painel_visor";
            this.painel_visor.Size = new System.Drawing.Size(394, 49);
            this.painel_visor.TabIndex = 0;
            // 
            // txtVisor
            // 
            this.txtVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(0, 0);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(394, 49);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 454);
            this.Controls.Add(this.painel_principal);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.painel_principal.ResumeLayout(false);
            this.painel_botoes_principais.ResumeLayout(false);
            this.painel_botao_limpar.ResumeLayout(false);
            this.painel_visor.ResumeLayout(false);
            this.painel_visor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_principal;
        private System.Windows.Forms.Panel painel_visor;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Panel painel_botao_limpar;
        private System.Windows.Forms.Button botao_limpar;
        private System.Windows.Forms.TableLayoutPanel painel_botoes_principais;
        private System.Windows.Forms.Button botao_7;
        private System.Windows.Forms.Button botao_soma;
        private System.Windows.Forms.Button botao_igual;
        private System.Windows.Forms.Button botao_0;
        private System.Windows.Forms.Button botao_virgula;
        private System.Windows.Forms.Button botao_subtracao;
        private System.Windows.Forms.Button botao_3;
        private System.Windows.Forms.Button botao_2;
        private System.Windows.Forms.Button botao_1;
        private System.Windows.Forms.Button botao_multiplicacao;
        private System.Windows.Forms.Button botao_6;
        private System.Windows.Forms.Button botao_5;
        private System.Windows.Forms.Button botao_4;
        private System.Windows.Forms.Button botao_divisao;
        private System.Windows.Forms.Button botao_9;
        private System.Windows.Forms.Button botao_8;
    }
}