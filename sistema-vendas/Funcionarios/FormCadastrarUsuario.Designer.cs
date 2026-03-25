namespace sistema_vendas
{
    partial class FormCadastrarUsuario
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
            this.painelTituloCadastrarFuncionario = new System.Windows.Forms.Panel();
            this.labelCadastrarFuncionario = new System.Windows.Forms.Label();
            this.painelLateralEsquerdo = new System.Windows.Forms.Panel();
            this.painelLateralDireito = new System.Windows.Forms.Panel();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.selec_depart = new System.Windows.Forms.ComboBox();
            this.label_depart = new System.Windows.Forms.Label();
            this.maskbox_tel = new System.Windows.Forms.MaskedTextBox();
            this.label_tel = new System.Windows.Forms.Label();
            this.maskbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label_cpf = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.painelFormularioCadastrarFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.painelTituloCadastrarFuncionario.SuspendLayout();
            this.painelFormularioCadastrarFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelTituloCadastrarFuncionario
            // 
            this.painelTituloCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.painelTituloCadastrarFuncionario.Controls.Add(this.labelCadastrarFuncionario);
            this.painelTituloCadastrarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTituloCadastrarFuncionario.Location = new System.Drawing.Point(96, 0);
            this.painelTituloCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.painelTituloCadastrarFuncionario.Name = "painelTituloCadastrarFuncionario";
            this.painelTituloCadastrarFuncionario.Size = new System.Drawing.Size(1234, 78);
            this.painelTituloCadastrarFuncionario.TabIndex = 3;
            // 
            // labelCadastrarFuncionario
            // 
            this.labelCadastrarFuncionario.AutoSize = true;
            this.labelCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.labelCadastrarFuncionario.Location = new System.Drawing.Point(9, 27);
            this.labelCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCadastrarFuncionario.Name = "labelCadastrarFuncionario";
            this.labelCadastrarFuncionario.Size = new System.Drawing.Size(216, 24);
            this.labelCadastrarFuncionario.TabIndex = 2;
            this.labelCadastrarFuncionario.Text = "Cadastrar Funcionário";
            // 
            // painelLateralEsquerdo
            // 
            this.painelLateralEsquerdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.painelLateralEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateralEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.painelLateralEsquerdo.Margin = new System.Windows.Forms.Padding(2);
            this.painelLateralEsquerdo.Name = "painelLateralEsquerdo";
            this.painelLateralEsquerdo.Size = new System.Drawing.Size(96, 839);
            this.painelLateralEsquerdo.TabIndex = 4;
            // 
            // painelLateralDireito
            // 
            this.painelLateralDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.painelLateralDireito.Location = new System.Drawing.Point(1330, 0);
            this.painelLateralDireito.Margin = new System.Windows.Forms.Padding(2);
            this.painelLateralDireito.Name = "painelLateralDireito";
            this.painelLateralDireito.Size = new System.Drawing.Size(96, 839);
            this.painelLateralDireito.TabIndex = 5;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enviar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_enviar.Location = new System.Drawing.Point(3, 762);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(1228, 74);
            this.btn_enviar.TabIndex = 13;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // selec_depart
            // 
            this.selec_depart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selec_depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selec_depart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selec_depart.FormattingEnabled = true;
            this.selec_depart.Items.AddRange(new object[] {
            "Adiministrador",
            "Vendas",
            "T.I"});
            this.selec_depart.Location = new System.Drawing.Point(3, 693);
            this.selec_depart.Name = "selec_depart";
            this.selec_depart.Size = new System.Drawing.Size(1228, 27);
            this.selec_depart.TabIndex = 12;
            this.selec_depart.SelectedIndexChanged += new System.EventHandler(this.selec_depart_SelectedIndexChanged);
            // 
            // label_depart
            // 
            this.label_depart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_depart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_depart.Location = new System.Drawing.Point(3, 621);
            this.label_depart.Name = "label_depart";
            this.label_depart.Size = new System.Drawing.Size(1228, 69);
            this.label_depart.TabIndex = 11;
            this.label_depart.Text = "Departamento";
            this.label_depart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maskbox_tel
            // 
            this.maskbox_tel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskbox_tel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskbox_tel.Location = new System.Drawing.Point(3, 555);
            this.maskbox_tel.Mask = "(00)00000-0000";
            this.maskbox_tel.Name = "maskbox_tel";
            this.maskbox_tel.Size = new System.Drawing.Size(1228, 27);
            this.maskbox_tel.TabIndex = 10;
            // 
            // label_tel
            // 
            this.label_tel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tel.Location = new System.Drawing.Point(3, 483);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(1228, 69);
            this.label_tel.TabIndex = 9;
            this.label_tel.Text = "Telefone";
            this.label_tel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maskbox_cpf
            // 
            this.maskbox_cpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskbox_cpf.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskbox_cpf.Location = new System.Drawing.Point(3, 417);
            this.maskbox_cpf.Mask = "000,000,000-00";
            this.maskbox_cpf.Name = "maskbox_cpf";
            this.maskbox_cpf.Size = new System.Drawing.Size(1228, 27);
            this.maskbox_cpf.TabIndex = 8;
            // 
            // label_cpf
            // 
            this.label_cpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cpf.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cpf.Location = new System.Drawing.Point(3, 345);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(1228, 69);
            this.label_cpf.TabIndex = 7;
            this.label_cpf.Text = "CPF";
            this.label_cpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_email
            // 
            this.txt_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(3, 279);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(1228, 27);
            this.txt_email.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(3, 207);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(1228, 69);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "E-mail";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(2, 69);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(1230, 69);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome Completo";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(2, 140);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(1230, 26);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // painelFormularioCadastrarFuncionario
            // 
            this.painelFormularioCadastrarFuncionario.ColumnCount = 1;
            this.painelFormularioCadastrarFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.txtNomeCompleto, 0, 2);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.labelNome, 0, 1);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.label_email, 0, 3);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.txt_email, 0, 4);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.label_cpf, 0, 5);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.maskbox_cpf, 0, 6);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.label_tel, 0, 7);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.maskbox_tel, 0, 8);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.label_depart, 0, 9);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.selec_depart, 0, 10);
            this.painelFormularioCadastrarFuncionario.Controls.Add(this.btn_enviar, 0, 11);
            this.painelFormularioCadastrarFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFormularioCadastrarFuncionario.Location = new System.Drawing.Point(96, 0);
            this.painelFormularioCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.painelFormularioCadastrarFuncionario.Name = "painelFormularioCadastrarFuncionario";
            this.painelFormularioCadastrarFuncionario.RowCount = 12;
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.painelFormularioCadastrarFuncionario.Size = new System.Drawing.Size(1234, 839);
            this.painelFormularioCadastrarFuncionario.TabIndex = 2;
            this.painelFormularioCadastrarFuncionario.Paint += new System.Windows.Forms.PaintEventHandler(this.painelFormularioCadastrarFuncionario_Paint);
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.painelTituloCadastrarFuncionario);
            this.Controls.Add(this.painelFormularioCadastrarFuncionario);
            this.Controls.Add(this.painelLateralEsquerdo);
            this.Controls.Add(this.painelLateralDireito);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastrarUsuario";
            this.Text = "Cadastrar Funcionário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.painelTituloCadastrarFuncionario.ResumeLayout(false);
            this.painelTituloCadastrarFuncionario.PerformLayout();
            this.painelFormularioCadastrarFuncionario.ResumeLayout(false);
            this.painelFormularioCadastrarFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painelTituloCadastrarFuncionario;
        private System.Windows.Forms.Label labelCadastrarFuncionario;
        private System.Windows.Forms.Panel painelLateralEsquerdo;
        private System.Windows.Forms.Panel painelLateralDireito;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.ComboBox selec_depart;
        private System.Windows.Forms.Label label_depart;
        private System.Windows.Forms.MaskedTextBox maskbox_tel;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.MaskedTextBox maskbox_cpf;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TableLayoutPanel painelFormularioCadastrarFuncionario;
    }
}