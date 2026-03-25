namespace sistema_vendas
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.painelMenuSuperior = new System.Windows.Forms.Panel();
            this.botao_funcionarios = new System.Windows.Forms.Button();
            this.menuCalculadora = new System.Windows.Forms.Button();
            this.botao_shop = new System.Windows.Forms.Button();
            this.botao_produtos = new System.Windows.Forms.Button();
            this.botao_adicionar_itens = new System.Windows.Forms.Button();
            this.botao_fatura = new System.Windows.Forms.Button();
            this.botao_registrar = new System.Windows.Forms.Button();
            this.img_fundo = new System.Windows.Forms.PictureBox();
            this.Chamados = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.painelMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(963, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuUsuarios});
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // submenuUsuarios
            // 
            this.submenuUsuarios.Name = "submenuUsuarios";
            this.submenuUsuarios.Size = new System.Drawing.Size(119, 22);
            this.submenuUsuarios.Text = "Usuários";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            // 
            // painelMenuSuperior
            // 
            this.painelMenuSuperior.BackColor = System.Drawing.Color.Brown;
            this.painelMenuSuperior.Controls.Add(this.Chamados);
            this.painelMenuSuperior.Controls.Add(this.botao_funcionarios);
            this.painelMenuSuperior.Controls.Add(this.menuCalculadora);
            this.painelMenuSuperior.Controls.Add(this.botao_shop);
            this.painelMenuSuperior.Controls.Add(this.botao_produtos);
            this.painelMenuSuperior.Controls.Add(this.botao_adicionar_itens);
            this.painelMenuSuperior.Controls.Add(this.botao_fatura);
            this.painelMenuSuperior.Controls.Add(this.botao_registrar);
            this.painelMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenuSuperior.Location = new System.Drawing.Point(0, 24);
            this.painelMenuSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.painelMenuSuperior.Name = "painelMenuSuperior";
            this.painelMenuSuperior.Size = new System.Drawing.Size(963, 59);
            this.painelMenuSuperior.TabIndex = 1;
            // 
            // botao_funcionarios
            // 
            this.botao_funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_funcionarios.ForeColor = System.Drawing.Color.White;
            this.botao_funcionarios.Location = new System.Drawing.Point(592, 11);
            this.botao_funcionarios.Margin = new System.Windows.Forms.Padding(2);
            this.botao_funcionarios.Name = "botao_funcionarios";
            this.botao_funcionarios.Size = new System.Drawing.Size(114, 37);
            this.botao_funcionarios.TabIndex = 1;
            this.botao_funcionarios.Text = "Funcionários";
            this.botao_funcionarios.UseVisualStyleBackColor = true;
            this.botao_funcionarios.Click += new System.EventHandler(this.botao_funcionarios_Click);
            // 
            // menuCalculadora
            // 
            this.menuCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCalculadora.ForeColor = System.Drawing.Color.White;
            this.menuCalculadora.Location = new System.Drawing.Point(474, 11);
            this.menuCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.menuCalculadora.Name = "menuCalculadora";
            this.menuCalculadora.Size = new System.Drawing.Size(114, 37);
            this.menuCalculadora.TabIndex = 1;
            this.menuCalculadora.Text = "Calculadora";
            this.menuCalculadora.UseVisualStyleBackColor = true;
            this.menuCalculadora.Click += new System.EventHandler(this.menuCalculadora_Click);
            // 
            // botao_shop
            // 
            this.botao_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_shop.ForeColor = System.Drawing.Color.White;
            this.botao_shop.Location = new System.Drawing.Point(382, 11);
            this.botao_shop.Margin = new System.Windows.Forms.Padding(2);
            this.botao_shop.Name = "botao_shop";
            this.botao_shop.Size = new System.Drawing.Size(87, 37);
            this.botao_shop.TabIndex = 0;
            this.botao_shop.Text = "Shop";
            this.botao_shop.UseVisualStyleBackColor = true;
            // 
            // botao_produtos
            // 
            this.botao_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_produtos.ForeColor = System.Drawing.Color.White;
            this.botao_produtos.Location = new System.Drawing.Point(291, 11);
            this.botao_produtos.Margin = new System.Windows.Forms.Padding(2);
            this.botao_produtos.Name = "botao_produtos";
            this.botao_produtos.Size = new System.Drawing.Size(87, 37);
            this.botao_produtos.TabIndex = 0;
            this.botao_produtos.Text = "Produto";
            this.botao_produtos.UseVisualStyleBackColor = true;
            // 
            // botao_adicionar_itens
            // 
            this.botao_adicionar_itens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_adicionar_itens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_adicionar_itens.ForeColor = System.Drawing.Color.White;
            this.botao_adicionar_itens.Location = new System.Drawing.Point(200, 11);
            this.botao_adicionar_itens.Margin = new System.Windows.Forms.Padding(2);
            this.botao_adicionar_itens.Name = "botao_adicionar_itens";
            this.botao_adicionar_itens.Size = new System.Drawing.Size(87, 37);
            this.botao_adicionar_itens.TabIndex = 0;
            this.botao_adicionar_itens.Text = "Add Itens";
            this.botao_adicionar_itens.UseVisualStyleBackColor = true;
            // 
            // botao_fatura
            // 
            this.botao_fatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_fatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_fatura.ForeColor = System.Drawing.Color.White;
            this.botao_fatura.Location = new System.Drawing.Point(108, 11);
            this.botao_fatura.Margin = new System.Windows.Forms.Padding(2);
            this.botao_fatura.Name = "botao_fatura";
            this.botao_fatura.Size = new System.Drawing.Size(87, 37);
            this.botao_fatura.TabIndex = 0;
            this.botao_fatura.Text = "Fatura";
            this.botao_fatura.UseVisualStyleBackColor = true;
            // 
            // botao_registrar
            // 
            this.botao_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_registrar.ForeColor = System.Drawing.Color.White;
            this.botao_registrar.Location = new System.Drawing.Point(16, 11);
            this.botao_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.botao_registrar.Name = "botao_registrar";
            this.botao_registrar.Size = new System.Drawing.Size(87, 37);
            this.botao_registrar.TabIndex = 0;
            this.botao_registrar.Text = "Registrar";
            this.botao_registrar.UseVisualStyleBackColor = true;
            // 
            // img_fundo
            // 
            this.img_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_fundo.Image = ((System.Drawing.Image)(resources.GetObject("img_fundo.Image")));
            this.img_fundo.Location = new System.Drawing.Point(0, 83);
            this.img_fundo.Margin = new System.Windows.Forms.Padding(2);
            this.img_fundo.Name = "img_fundo";
            this.img_fundo.Size = new System.Drawing.Size(963, 487);
            this.img_fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_fundo.TabIndex = 3;
            this.img_fundo.TabStop = false;
            // 
            // Chamados
            // 
            this.Chamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chamados.ForeColor = System.Drawing.Color.White;
            this.Chamados.Location = new System.Drawing.Point(710, 11);
            this.Chamados.Margin = new System.Windows.Forms.Padding(2);
            this.Chamados.Name = "Chamados";
            this.Chamados.Size = new System.Drawing.Size(114, 37);
            this.Chamados.TabIndex = 2;
            this.Chamados.Text = "Chamados";
            this.Chamados.UseVisualStyleBackColor = true;
            this.Chamados.Click += new System.EventHandler(this.Chamados_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.img_fundo);
            this.Controls.Add(this.painelMenuSuperior);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.painelMenuSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem submenuUsuarios;
        private System.Windows.Forms.Panel painelMenuSuperior;
        private System.Windows.Forms.Button botao_registrar;
        private System.Windows.Forms.Button botao_fatura;
        private System.Windows.Forms.Button botao_shop;
        private System.Windows.Forms.Button botao_produtos;
        private System.Windows.Forms.Button botao_adicionar_itens;
        private System.Windows.Forms.PictureBox img_fundo;
        private System.Windows.Forms.Button menuCalculadora;
        private System.Windows.Forms.Button botao_funcionarios;
        private System.Windows.Forms.Button Chamados;
    }
}

