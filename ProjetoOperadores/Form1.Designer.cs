
namespace ProjetoOperadores
{
    partial class FrmOperadores
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
            this.BtnPre = new System.Windows.Forms.Button();
            this.BtnPos = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPre
            // 
            this.BtnPre.Location = new System.Drawing.Point(107, 232);
            this.BtnPre.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(103, 46);
            this.BtnPre.TabIndex = 0;
            this.BtnPre.Text = "Pré";
            this.BtnPre.UseVisualStyleBackColor = true;
            this.BtnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // BtnPos
            // 
            this.BtnPos.Location = new System.Drawing.Point(235, 232);
            this.BtnPos.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.BtnPos.Name = "BtnPos";
            this.BtnPos.Size = new System.Drawing.Size(117, 46);
            this.BtnPos.TabIndex = 1;
            this.BtnPos.Text = "Pós";
            this.BtnPos.UseVisualStyleBackColor = true;
            this.BtnPos.Click += new System.EventHandler(this.BtnPos_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(235, 171);
            this.txtX.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(87, 33);
            this.txtX.TabIndex = 2;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(183, 171);
            this.lblX.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 26);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // FrmOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 499);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.BtnPos);
            this.Controls.Add(this.BtnPre);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmOperadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo de Operadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPre;
        private System.Windows.Forms.Button BtnPos;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
    }
}

