
namespace ProjetoDiaDaSemana
{
    partial class FrmDiaDaSemana
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
            this.lblDiaDaSemana = new System.Windows.Forms.Label();
            this.CboDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.grpDiaDaSemana = new System.Windows.Forms.GroupBox();
            this.lblDiaEscolhido = new System.Windows.Forms.Label();
            this.picDiaDaSemana = new System.Windows.Forms.PictureBox();
            this.grpDiaDaSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaDaSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiaDaSemana
            // 
            this.lblDiaDaSemana.AutoSize = true;
            this.lblDiaDaSemana.Location = new System.Drawing.Point(9, 60);
            this.lblDiaDaSemana.Name = "lblDiaDaSemana";
            this.lblDiaDaSemana.Size = new System.Drawing.Size(266, 25);
            this.lblDiaDaSemana.TabIndex = 0;
            this.lblDiaDaSemana.Text = "Escolha o Dia da Semana:";
            // 
            // CboDiaDaSemana
            // 
            this.CboDiaDaSemana.FormattingEnabled = true;
            this.CboDiaDaSemana.Location = new System.Drawing.Point(9, 99);
            this.CboDiaDaSemana.Name = "CboDiaDaSemana";
            this.CboDiaDaSemana.Size = new System.Drawing.Size(266, 33);
            this.CboDiaDaSemana.TabIndex = 1;
            this.CboDiaDaSemana.Text = "Qual dia da Semana?";
            this.CboDiaDaSemana.SelectedIndexChanged += new System.EventHandler(this.CboDiaDaSemana_SelectedIndexChanged);
            // 
            // grpDiaDaSemana
            // 
            this.grpDiaDaSemana.Controls.Add(this.picDiaDaSemana);
            this.grpDiaDaSemana.Controls.Add(this.lblDiaEscolhido);
            this.grpDiaDaSemana.Controls.Add(this.CboDiaDaSemana);
            this.grpDiaDaSemana.Controls.Add(this.lblDiaDaSemana);
            this.grpDiaDaSemana.Location = new System.Drawing.Point(3, 0);
            this.grpDiaDaSemana.Name = "grpDiaDaSemana";
            this.grpDiaDaSemana.Size = new System.Drawing.Size(651, 631);
            this.grpDiaDaSemana.TabIndex = 2;
            this.grpDiaDaSemana.TabStop = false;
            this.grpDiaDaSemana.Text = "Dia da Semana";
            // 
            // lblDiaEscolhido
            // 
            this.lblDiaEscolhido.AutoSize = true;
            this.lblDiaEscolhido.Location = new System.Drawing.Point(93, 162);
            this.lblDiaEscolhido.Name = "lblDiaEscolhido";
            this.lblDiaEscolhido.Size = new System.Drawing.Size(19, 25);
            this.lblDiaEscolhido.TabIndex = 2;
            this.lblDiaEscolhido.Text = "-";
            // 
            // picDiaDaSemana
            // 
            this.picDiaDaSemana.Location = new System.Drawing.Point(9, 203);
            this.picDiaDaSemana.Name = "picDiaDaSemana";
            this.picDiaDaSemana.Size = new System.Drawing.Size(636, 422);
            this.picDiaDaSemana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiaDaSemana.TabIndex = 3;
            this.picDiaDaSemana.TabStop = false;
            // 
            // FrmDiaDaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 643);
            this.Controls.Add(this.grpDiaDaSemana);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmDiaDaSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dia da Semana";
            this.Load += new System.EventHandler(this.FrmDiaDaSemana_Load);
            this.grpDiaDaSemana.ResumeLayout(false);
            this.grpDiaDaSemana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaDaSemana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiaDaSemana;
        private System.Windows.Forms.ComboBox CboDiaDaSemana;
        private System.Windows.Forms.GroupBox grpDiaDaSemana;
        private System.Windows.Forms.Label lblDiaEscolhido;
        private System.Windows.Forms.PictureBox picDiaDaSemana;
    }
}

