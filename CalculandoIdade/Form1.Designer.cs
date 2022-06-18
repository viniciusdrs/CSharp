
namespace CalculandoIdade
{
    partial class FrmCalculandoIdade
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(47, 132);
            this.lblAnoNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(175, 26);
            this.lblAnoNascimento.TabIndex = 0;
            this.lblAnoNascimento.Text = "Ano Nascimento:";
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Location = new System.Drawing.Point(110, 196);
            this.lblAnoAtual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(112, 26);
            this.lblAnoAtual.TabIndex = 1;
            this.lblAnoAtual.Text = "Ano Atual:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(151, 260);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(71, 26);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(124, 324);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(98, 26);
            this.lblSituacao.TabIndex = 3;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(231, 132);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(75, 32);
            this.txtAnoNascimento.TabIndex = 4;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(231, 193);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(75, 32);
            this.txtAnoAtual.TabIndex = 5;
            this.txtAnoAtual.Text = "2021";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(231, 257);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(98, 32);
            this.txtIdade.TabIndex = 6;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(231, 321);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(267, 32);
            this.txtSituacao.TabIndex = 7;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(129, 413);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(125, 60);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(313, 423);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(107, 40);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmCalculandoIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 523);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblAnoAtual);
            this.Controls.Add(this.lblAnoNascimento);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCalculandoIdade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculando Idade";
            this.Load += new System.EventHandler(this.FrmCalculandoIdade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
    }
}

