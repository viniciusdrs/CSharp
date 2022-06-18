
namespace aulaInicial
{
    partial class FrmInicial
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
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.BackColor = System.Drawing.Color.Red;
            this.lblAnoNascimento.Location = new System.Drawing.Point(80, 132);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(223, 25);
            this.lblAnoNascimento.TabIndex = 0;
            this.lblAnoNascimento.Text = "Ano de Nascimento:";
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.BackColor = System.Drawing.Color.OrangeRed;
            this.lblAnoAtual.Location = new System.Drawing.Point(182, 190);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(121, 25);
            this.lblAnoAtual.TabIndex = 1;
            this.lblAnoAtual.Text = "Ano Atual:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(48, 473);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(309, 132);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 31);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(309, 187);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 31);
            this.txtAnoAtual.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 473);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 31);
            this.txtNome.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(309, 240);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 37);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(162, 510);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(141, 36);
            this.btnMensagem.TabIndex = 7;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1369, 1061);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAnoAtual);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmInicial";
            this.Text = "Aula de Introdução";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

