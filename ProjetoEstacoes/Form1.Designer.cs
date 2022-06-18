
namespace ProjetoEstacoes
{
    partial class FrmCombo
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
            this.grpEstacoes = new System.Windows.Forms.GroupBox();
            this.CboEstacoes = new System.Windows.Forms.ComboBox();
            this.lblEstacao = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblEscolhida = new System.Windows.Forms.Label();
            this.picEstacao = new System.Windows.Forms.PictureBox();
            this.grpEstacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstacao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEstacoes
            // 
            this.grpEstacoes.Controls.Add(this.picEstacao);
            this.grpEstacoes.Controls.Add(this.lblEscolhida);
            this.grpEstacoes.Controls.Add(this.lblMsg);
            this.grpEstacoes.Controls.Add(this.lblEstacao);
            this.grpEstacoes.Controls.Add(this.CboEstacoes);
            this.grpEstacoes.Location = new System.Drawing.Point(12, 12);
            this.grpEstacoes.Name = "grpEstacoes";
            this.grpEstacoes.Size = new System.Drawing.Size(660, 497);
            this.grpEstacoes.TabIndex = 0;
            this.grpEstacoes.TabStop = false;
            this.grpEstacoes.Text = "Estações";
            // 
            // CboEstacoes
            // 
            this.CboEstacoes.FormattingEnabled = true;
            this.CboEstacoes.Items.AddRange(new object[] {
            "Inverno",
            "Outono",
            "Primavera",
            "Verão"});
            this.CboEstacoes.Location = new System.Drawing.Point(6, 79);
            this.CboEstacoes.Name = "CboEstacoes";
            this.CboEstacoes.Size = new System.Drawing.Size(230, 30);
            this.CboEstacoes.Sorted = true;
            this.CboEstacoes.TabIndex = 1;
            this.CboEstacoes.Text = "Qual a estação do ano?";
            this.CboEstacoes.SelectedIndexChanged += new System.EventHandler(this.CboEstacoes_SelectedIndexChanged);
            // 
            // lblEstacao
            // 
            this.lblEstacao.AutoSize = true;
            this.lblEstacao.Location = new System.Drawing.Point(6, 54);
            this.lblEstacao.Name = "lblEstacao";
            this.lblEstacao.Size = new System.Drawing.Size(155, 22);
            this.lblEstacao.TabIndex = 2;
            this.lblEstacao.Text = "Estações do Ano";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(6, 139);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(172, 22);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Estação Escolhida:";
            // 
            // lblEscolhida
            // 
            this.lblEscolhida.AutoSize = true;
            this.lblEscolhida.Location = new System.Drawing.Point(184, 139);
            this.lblEscolhida.Name = "lblEscolhida";
            this.lblEscolhida.Size = new System.Drawing.Size(16, 22);
            this.lblEscolhida.TabIndex = 4;
            this.lblEscolhida.Text = "-";
            // 
            // picEstacao
            // 
            this.picEstacao.Location = new System.Drawing.Point(10, 164);
            this.picEstacao.Name = "picEstacao";
            this.picEstacao.Size = new System.Drawing.Size(644, 327);
            this.picEstacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstacao.TabIndex = 5;
            this.picEstacao.TabStop = false;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 508);
            this.Controls.Add(this.grpEstacoes);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprendendo ComboBox";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.grpEstacoes.ResumeLayout(false);
            this.grpEstacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEstacoes;
        private System.Windows.Forms.Label lblEstacao;
        private System.Windows.Forms.ComboBox CboEstacoes;
        private System.Windows.Forms.Label lblEscolhida;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picEstacao;
    }
}

