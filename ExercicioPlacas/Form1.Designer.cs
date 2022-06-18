
namespace ExercicioPlacas
{
    partial class FrmPlaca
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblAsterisco = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtTamanho = new System.Windows.Forms.TextBox();
            this.TxtPosicao = new System.Windows.Forms.TextBox();
            this.TxtAsterisco = new System.Windows.Forms.TextBox();
            this.BtnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(30, 60);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(8, 173);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(83, 20);
            this.lblTamanho.TabIndex = 1;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(19, 225);
            this.lblPosicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(72, 20);
            this.lblPosicao.TabIndex = 2;
            this.lblPosicao.Text = "Posição";
            // 
            // lblAsterisco
            // 
            this.lblAsterisco.AutoSize = true;
            this.lblAsterisco.Location = new System.Drawing.Point(75, 277);
            this.lblAsterisco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsterisco.Name = "lblAsterisco";
            this.lblAsterisco.Size = new System.Drawing.Size(16, 20);
            this.lblAsterisco.TabIndex = 3;
            this.lblAsterisco.Text = "*";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(99, 58);
            this.TxtPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(164, 26);
            this.TxtPlaca.TabIndex = 4;
            // 
            // TxtTamanho
            // 
            this.TxtTamanho.Location = new System.Drawing.Point(98, 173);
            this.TxtTamanho.Name = "TxtTamanho";
            this.TxtTamanho.Size = new System.Drawing.Size(111, 26);
            this.TxtTamanho.TabIndex = 5;
            // 
            // TxtPosicao
            // 
            this.TxtPosicao.Location = new System.Drawing.Point(98, 222);
            this.TxtPosicao.Name = "TxtPosicao";
            this.TxtPosicao.Size = new System.Drawing.Size(111, 26);
            this.TxtPosicao.TabIndex = 6;
            // 
            // TxtAsterisco
            // 
            this.TxtAsterisco.Location = new System.Drawing.Point(98, 274);
            this.TxtAsterisco.Name = "TxtAsterisco";
            this.TxtAsterisco.Size = new System.Drawing.Size(111, 26);
            this.TxtAsterisco.TabIndex = 7;
            // 
            // BtnVerifica
            // 
            this.BtnVerifica.Location = new System.Drawing.Point(283, 204);
            this.BtnVerifica.Name = "BtnVerifica";
            this.BtnVerifica.Size = new System.Drawing.Size(96, 62);
            this.BtnVerifica.TabIndex = 8;
            this.BtnVerifica.Text = "Verifica";
            this.BtnVerifica.UseVisualStyleBackColor = true;
            this.BtnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // FrmPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.BtnVerifica);
            this.Controls.Add(this.TxtAsterisco);
            this.Controls.Add(this.TxtPosicao);
            this.Controls.Add(this.TxtTamanho);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.lblAsterisco);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblPlaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio Placas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblAsterisco;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtTamanho;
        private System.Windows.Forms.TextBox TxtPosicao;
        private System.Windows.Forms.TextBox TxtAsterisco;
        private System.Windows.Forms.Button BtnVerifica;
    }
}

