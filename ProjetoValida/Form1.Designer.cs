
namespace ProjetoValida
{
    partial class FrmValida
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.BtnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(27, 138);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(60, 20);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(17, 190);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(70, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(88, 138);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(38, 26);
            this.txtIdade.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(88, 190);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(132, 26);
            this.txtSalario.TabIndex = 5;
            // 
            // BtnVerifica
            // 
            this.BtnVerifica.Location = new System.Drawing.Point(159, 263);
            this.BtnVerifica.Name = "BtnVerifica";
            this.BtnVerifica.Size = new System.Drawing.Size(118, 41);
            this.BtnVerifica.TabIndex = 6;
            this.BtnVerifica.Text = "Verificar";
            this.BtnVerifica.UseVisualStyleBackColor = true;
            this.BtnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // FrmValida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BtnVerifica);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmValida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button BtnVerifica;
    }
}

