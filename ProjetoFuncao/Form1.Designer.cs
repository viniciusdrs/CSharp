
namespace ProjetoFuncao
{
    partial class FrmFuncao
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblMaior = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.BtnVerifica = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblReajuste = new System.Windows.Forms.Label();
            this.lblNovoSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtReajuste = new System.Windows.Forms.TextBox();
            this.txtNovoSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.BtnCalculaImc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(40, 25);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 18);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(39, 84);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 18);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.Location = new System.Drawing.Point(7, 144);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(51, 18);
            this.lblMaior.TabIndex = 2;
            this.lblMaior.Text = "Maior";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(64, 25);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 24);
            this.txtValorA.TabIndex = 3;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(64, 78);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 24);
            this.txtValorB.TabIndex = 4;
            // 
            // txtMaior
            // 
            this.txtMaior.Location = new System.Drawing.Point(64, 138);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(100, 24);
            this.txtMaior.TabIndex = 5;
            // 
            // BtnVerifica
            // 
            this.BtnVerifica.Location = new System.Drawing.Point(185, 25);
            this.BtnVerifica.Name = "BtnVerifica";
            this.BtnVerifica.Size = new System.Drawing.Size(105, 41);
            this.BtnVerifica.TabIndex = 6;
            this.BtnVerifica.Text = "Verifica";
            this.BtnVerifica.UseVisualStyleBackColor = true;
            this.BtnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(185, 118);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(105, 44);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(61, 335);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 18);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Salário:";
            // 
            // lblReajuste
            // 
            this.lblReajuste.AutoSize = true;
            this.lblReajuste.Location = new System.Drawing.Point(9, 379);
            this.lblReajuste.Name = "lblReajuste";
            this.lblReajuste.Size = new System.Drawing.Size(118, 18);
            this.lblReajuste.TabIndex = 9;
            this.lblReajuste.Text = "ValorReajuste:";
            // 
            // lblNovoSalario
            // 
            this.lblNovoSalario.AutoSize = true;
            this.lblNovoSalario.Location = new System.Drawing.Point(16, 438);
            this.lblNovoSalario.Name = "lblNovoSalario";
            this.lblNovoSalario.Size = new System.Drawing.Size(111, 18);
            this.lblNovoSalario.TabIndex = 10;
            this.lblNovoSalario.Text = "Novo Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(133, 329);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 24);
            this.txtSalario.TabIndex = 11;
            // 
            // txtReajuste
            // 
            this.txtReajuste.Location = new System.Drawing.Point(133, 376);
            this.txtReajuste.Name = "txtReajuste";
            this.txtReajuste.Size = new System.Drawing.Size(100, 24);
            this.txtReajuste.TabIndex = 12;
            // 
            // txtNovoSalario
            // 
            this.txtNovoSalario.Location = new System.Drawing.Point(133, 432);
            this.txtNovoSalario.Name = "txtNovoSalario";
            this.txtNovoSalario.Size = new System.Drawing.Size(100, 24);
            this.txtNovoSalario.TabIndex = 13;
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Location = new System.Drawing.Point(277, 376);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(100, 43);
            this.BtnCalcula.TabIndex = 14;
            this.BtnCalcula.Text = "Calcular";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(576, 128);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(52, 18);
            this.lblPeso.TabIndex = 15;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(572, 187);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(56, 18);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura:";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(585, 248);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(43, 18);
            this.lblImc.TabIndex = 17;
            this.lblImc.Text = "IMC:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(549, 305);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(79, 18);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(634, 125);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 24);
            this.txtPeso.TabIndex = 19;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(634, 181);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 24);
            this.txtAltura.TabIndex = 20;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(634, 242);
            this.txtImc.Name = "txtImc";
            this.txtImc.Size = new System.Drawing.Size(100, 24);
            this.txtImc.TabIndex = 21;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(634, 302);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(343, 24);
            this.txtSituacao.TabIndex = 22;
            // 
            // BtnCalculaImc
            // 
            this.BtnCalculaImc.Location = new System.Drawing.Point(807, 163);
            this.BtnCalculaImc.Name = "BtnCalculaImc";
            this.BtnCalculaImc.Size = new System.Drawing.Size(120, 61);
            this.BtnCalculaImc.TabIndex = 23;
            this.BtnCalculaImc.Text = "Calcula IMC";
            this.BtnCalculaImc.UseVisualStyleBackColor = true;
            this.BtnCalculaImc.Click += new System.EventHandler(this.BtnCalculaImc_Click);
            // 
            // FrmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 637);
            this.Controls.Add(this.BtnCalculaImc);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.txtNovoSalario);
            this.Controls.Add(this.txtReajuste);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblNovoSalario);
            this.Controls.Add(this.lblReajuste);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVerifica);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo de Função";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Button BtnVerifica;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblReajuste;
        private System.Windows.Forms.Label lblNovoSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtReajuste;
        private System.Windows.Forms.TextBox txtNovoSalario;
        private System.Windows.Forms.Button BtnCalcula;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button BtnCalculaImc;
    }
}

