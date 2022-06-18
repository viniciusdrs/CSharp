
namespace ProjetoListBox
{
    partial class FrmListBox
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
            this.LstNumeros = new System.Windows.Forms.ListBox();
            this.BtnFor = new System.Windows.Forms.Button();
            this.BtnWhile = new System.Windows.Forms.Button();
            this.BtnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstNumeros
            // 
            this.LstNumeros.FormattingEnabled = true;
            this.LstNumeros.ItemHeight = 20;
            this.LstNumeros.Location = new System.Drawing.Point(25, 28);
            this.LstNumeros.Name = "LstNumeros";
            this.LstNumeros.Size = new System.Drawing.Size(225, 444);
            this.LstNumeros.TabIndex = 0;
            // 
            // BtnFor
            // 
            this.BtnFor.Location = new System.Drawing.Point(336, 82);
            this.BtnFor.Name = "BtnFor";
            this.BtnFor.Size = new System.Drawing.Size(110, 62);
            this.BtnFor.TabIndex = 1;
            this.BtnFor.Text = "For";
            this.BtnFor.UseVisualStyleBackColor = true;
            this.BtnFor.Click += new System.EventHandler(this.BtnFor_Click);
            // 
            // BtnWhile
            // 
            this.BtnWhile.Location = new System.Drawing.Point(336, 174);
            this.BtnWhile.Name = "BtnWhile";
            this.BtnWhile.Size = new System.Drawing.Size(110, 62);
            this.BtnWhile.TabIndex = 2;
            this.BtnWhile.Text = "While";
            this.BtnWhile.UseVisualStyleBackColor = true;
            this.BtnWhile.Click += new System.EventHandler(this.BtnWhile_Click);
            // 
            // BtnDoWhile
            // 
            this.BtnDoWhile.Location = new System.Drawing.Point(336, 259);
            this.BtnDoWhile.Name = "BtnDoWhile";
            this.BtnDoWhile.Size = new System.Drawing.Size(110, 62);
            this.BtnDoWhile.TabIndex = 3;
            this.BtnDoWhile.Text = "Do...While";
            this.BtnDoWhile.UseVisualStyleBackColor = true;
            this.BtnDoWhile.Click += new System.EventHandler(this.BtnDoWhile_Click);
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.BtnDoWhile);
            this.Controls.Add(this.BtnWhile);
            this.Controls.Add(this.BtnFor);
            this.Controls.Add(this.LstNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laços de Repetição com ListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstNumeros;
        private System.Windows.Forms.Button BtnFor;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Button BtnDoWhile;
    }
}

