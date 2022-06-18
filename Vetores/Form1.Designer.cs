
namespace Vetores
{
    partial class FrmVetor
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
            this.LstInteiros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstInteiros
            // 
            this.LstInteiros.FormattingEnabled = true;
            this.LstInteiros.ItemHeight = 20;
            this.LstInteiros.Location = new System.Drawing.Point(166, 24);
            this.LstInteiros.Name = "LstInteiros";
            this.LstInteiros.Size = new System.Drawing.Size(198, 484);
            this.LstInteiros.TabIndex = 0;
            // 
            // FrmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 548);
            this.Controls.Add(this.LstInteiros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmVetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetor";
            this.Load += new System.EventHandler(this.FrmVetor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstInteiros;
    }
}

