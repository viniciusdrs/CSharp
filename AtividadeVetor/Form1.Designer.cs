
namespace AtividadeVetor
{
    partial class FrmCalculaImc
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.BtnVerVetor = new System.Windows.Forms.Button();
            this.LstVetores = new System.Windows.Forms.ListBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(52, 71);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(44, 131);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(57, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(63, 191);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(38, 20);
            this.lblImc.TabIndex = 2;
            this.lblImc.Text = "Imc";
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Location = new System.Drawing.Point(48, 292);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(163, 46);
            this.BtnCalcula.TabIndex = 3;
            this.BtnCalcula.Text = "Calcula Imc";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // BtnVerVetor
            // 
            this.BtnVerVetor.Location = new System.Drawing.Point(375, 402);
            this.BtnVerVetor.Name = "BtnVerVetor";
            this.BtnVerVetor.Size = new System.Drawing.Size(163, 46);
            this.BtnVerVetor.TabIndex = 4;
            this.BtnVerVetor.Text = "Ver Vetores";
            this.BtnVerVetor.UseVisualStyleBackColor = true;
            this.BtnVerVetor.Click += new System.EventHandler(this.BtnVerVetor_Click);
            // 
            // LstVetores
            // 
            this.LstVetores.FormattingEnabled = true;
            this.LstVetores.ItemHeight = 20;
            this.LstVetores.Location = new System.Drawing.Point(291, 12);
            this.LstVetores.Name = "LstVetores";
            this.LstVetores.Size = new System.Drawing.Size(344, 384);
            this.LstVetores.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(107, 71);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 6;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(107, 131);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 7;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(107, 191);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(100, 26);
            this.txtImc.TabIndex = 8;
            // 
            // FrmCalculaImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 611);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.LstVetores);
            this.Controls.Add(this.BtnVerVetor);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCalculaImc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade Vetor IMC";
            this.Load += new System.EventHandler(this.FrmCalculaImc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Button BtnCalcula;
        private System.Windows.Forms.Button BtnVerVetor;
        private System.Windows.Forms.ListBox LstVetores;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtImc;
    }
}

