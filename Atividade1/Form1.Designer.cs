
namespace Atividade1
{
    partial class FrmSoma
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.BtnInteiros = new System.Windows.Forms.Button();
            this.BtnReais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(53, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(53, 46);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 85);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(73, 78);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 43);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 11);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 5;
            // 
            // BtnInteiros
            // 
            this.BtnInteiros.Location = new System.Drawing.Point(194, 11);
            this.BtnInteiros.Name = "BtnInteiros";
            this.BtnInteiros.Size = new System.Drawing.Size(75, 23);
            this.BtnInteiros.TabIndex = 6;
            this.BtnInteiros.Text = "Inteiros";
            this.BtnInteiros.UseVisualStyleBackColor = true;
            this.BtnInteiros.Click += new System.EventHandler(this.BtnInteiros_Click);
            // 
            // BtnReais
            // 
            this.BtnReais.Location = new System.Drawing.Point(194, 40);
            this.BtnReais.Name = "BtnReais";
            this.BtnReais.Size = new System.Drawing.Size(75, 23);
            this.BtnReais.TabIndex = 7;
            this.BtnReais.Text = "Reais";
            this.BtnReais.UseVisualStyleBackColor = true;
            this.BtnReais.Click += new System.EventHandler(this.BtnReais_Click);
            // 
            // FrmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 139);
            this.Controls.Add(this.BtnReais);
            this.Controls.Add(this.BtnInteiros);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "FrmSoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button BtnInteiros;
        private System.Windows.Forms.Button BtnReais;
    }
}

