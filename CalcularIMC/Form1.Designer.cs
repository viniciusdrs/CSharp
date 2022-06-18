
namespace CalcularIMC
{
    partial class FrmImc
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(43, 34);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(43, 117);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(57, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(112, 29);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(164, 26);
            this.txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(112, 112);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(164, 26);
            this.txtAltura.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(362, 57);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 62);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.lblImc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(600, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(399, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Índice de Massa Corporal";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(186, 66);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(80, 20);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(17, 55);
            this.lblImc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(103, 37);
            this.lblImc.TabIndex = 0;
            this.lblImc.Text = "00,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaximo);
            this.groupBox2.Controls.Add(this.lblMinimo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(592, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(294, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seu Peso Ideal";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(166, 113);
            this.lblMaximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(54, 20);
            this.lblMaximo.TabIndex = 3;
            this.lblMaximo.Text = "00.00";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(166, 58);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(54, 20);
            this.lblMinimo.TabIndex = 2;
            this.lblMinimo.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Máximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mínimo";
            // 
            // FrmImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmImc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo do IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

