namespace sistema_vendas
{
    partial class Formdashboard
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
            this.panel_lefth = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.colunas_user = new System.Windows.Forms.TableLayoutPanel();
            this.coluna_principal = new System.Windows.Forms.TableLayoutPanel();
            this.label_dashboard = new System.Windows.Forms.Label();
            this.panel_lefth.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lefth
            // 
            this.panel_lefth.Controls.Add(this.colunas_user);
            this.panel_lefth.Controls.Add(this.panel_user);
            this.panel_lefth.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lefth.Location = new System.Drawing.Point(0, 0);
            this.panel_lefth.Name = "panel_lefth";
            this.panel_lefth.Size = new System.Drawing.Size(179, 561);
            this.panel_lefth.TabIndex = 1;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.panel_top.Controls.Add(this.label_dashboard);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(179, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1161, 126);
            this.panel_top.TabIndex = 3;
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(38)))));
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(179, 126);
            this.panel_user.TabIndex = 0;
            // 
            // colunas_user
            // 
            this.colunas_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(38)))));
            this.colunas_user.ColumnCount = 1;
            this.colunas_user.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colunas_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colunas_user.Location = new System.Drawing.Point(0, 126);
            this.colunas_user.Name = "colunas_user";
            this.colunas_user.RowCount = 6;
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.colunas_user.Size = new System.Drawing.Size(179, 435);
            this.colunas_user.TabIndex = 1;
            // 
            // coluna_principal
            // 
            this.coluna_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.coluna_principal.ColumnCount = 4;
            this.coluna_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.coluna_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.coluna_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.coluna_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.coluna_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.coluna_principal.Location = new System.Drawing.Point(179, 126);
            this.coluna_principal.Name = "coluna_principal";
            this.coluna_principal.RowCount = 1;
            this.coluna_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.coluna_principal.Size = new System.Drawing.Size(1161, 100);
            this.coluna_principal.TabIndex = 4;
            // 
            // label_dashboard
            // 
            this.label_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_dashboard.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_dashboard.Location = new System.Drawing.Point(0, 0);
            this.label_dashboard.Name = "label_dashboard";
            this.label_dashboard.Size = new System.Drawing.Size(1161, 126);
            this.label_dashboard.TabIndex = 0;
            this.label_dashboard.Text = "DASHBOARD";
            this.label_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Formdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1340, 561);
            this.Controls.Add(this.coluna_principal);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_lefth);
            this.Name = "Formdashboard";
            this.Text = "Formdashboard";
            this.Load += new System.EventHandler(this.Formdashboard_Load);
            this.panel_lefth.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lefth;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TableLayoutPanel colunas_user;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.TableLayoutPanel coluna_principal;
        private System.Windows.Forms.Label label_dashboard;
    }
}