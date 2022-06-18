
namespace TiposDados
{
    partial class FrmTiposDados
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.BtnCalcularSoma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.BtnSomarFloat = new System.Windows.Forms.Button();
            this.BtnConverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(99, 89);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(162, 22);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Primeiro Valor:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(99, 171);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(162, 22);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Segundo Valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(267, 81);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(128, 30);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.Text = "0";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(267, 163);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(128, 30);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.Text = "0";
            // 
            // BtnCalcularSoma
            // 
            this.BtnCalcularSoma.Location = new System.Drawing.Point(56, 245);
            this.BtnCalcularSoma.Name = "BtnCalcularSoma";
            this.BtnCalcularSoma.Size = new System.Drawing.Size(126, 42);
            this.BtnCalcularSoma.TabIndex = 4;
            this.BtnCalcularSoma.Text = "Somar";
            this.BtnCalcularSoma.UseVisualStyleBackColor = true;
            this.BtnCalcularSoma.Click += new System.EventHandler(this.BtnCalcularSoma_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(119, 368);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 22);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(252, 365);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(143, 30);
            this.txtResultado.TabIndex = 6;
            // 
            // BtnSomarFloat
            // 
            this.BtnSomarFloat.Location = new System.Drawing.Point(226, 245);
            this.BtnSomarFloat.Name = "BtnSomarFloat";
            this.BtnSomarFloat.Size = new System.Drawing.Size(126, 56);
            this.BtnSomarFloat.TabIndex = 7;
            this.BtnSomarFloat.Text = "Soma Float";
            this.BtnSomarFloat.UseVisualStyleBackColor = true;
            this.BtnSomarFloat.Click += new System.EventHandler(this.BtnSomarFloat_Click);
            // 
            // BtnConverte
            // 
            this.BtnConverte.Location = new System.Drawing.Point(397, 245);
            this.BtnConverte.Name = "BtnConverte";
            this.BtnConverte.Size = new System.Drawing.Size(126, 56);
            this.BtnConverte.TabIndex = 8;
            this.BtnConverte.Text = "Conversão";
            this.BtnConverte.UseVisualStyleBackColor = true;
            this.BtnConverte.Click += new System.EventHandler(this.BtnConverte_Click);
            // 
            // FrmTiposDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 441);
            this.Controls.Add(this.BtnConverte);
            this.Controls.Add(this.BtnSomarFloat);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnCalcularSoma);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmTiposDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de Tipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button BtnCalcularSoma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button BtnSomarFloat;
        private System.Windows.Forms.Button BtnConverte;
    }
}

