
namespace RodizioPlaca
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
            this.grpPlaca = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.BtnVerifica = new System.Windows.Forms.Button();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.BtnLicenca = new System.Windows.Forms.Button();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.grpPlaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlaca
            // 
            this.grpPlaca.Controls.Add(this.lblLicenca);
            this.grpPlaca.Controls.Add(this.BtnLicenca);
            this.grpPlaca.Controls.Add(this.lblHorario);
            this.grpPlaca.Controls.Add(this.lblSemana);
            this.grpPlaca.Controls.Add(this.BtnVerifica);
            this.grpPlaca.Controls.Add(this.txtPlaca);
            this.grpPlaca.Controls.Add(this.lblPlaca);
            this.grpPlaca.Location = new System.Drawing.Point(12, 12);
            this.grpPlaca.Name = "grpPlaca";
            this.grpPlaca.Size = new System.Drawing.Size(634, 294);
            this.grpPlaca.TabIndex = 0;
            this.grpPlaca.TabStop = false;
            this.grpPlaca.Text = "Dados do Veículo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(38, 119);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(77, 23);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(28, 146);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 30);
            this.txtPlaca.TabIndex = 1;
            // 
            // BtnVerifica
            // 
            this.BtnVerifica.Location = new System.Drawing.Point(134, 130);
            this.BtnVerifica.Name = "BtnVerifica";
            this.BtnVerifica.Size = new System.Drawing.Size(133, 30);
            this.BtnVerifica.TabIndex = 2;
            this.BtnVerifica.Text = "Rodizio";
            this.BtnVerifica.UseVisualStyleBackColor = true;
            this.BtnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(305, 35);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(17, 23);
            this.lblSemana.TabIndex = 3;
            this.lblSemana.Text = "-";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(305, 134);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(235, 46);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário: 7h ate 10h\r\n               17h ate 20h";
            // 
            // BtnLicenca
            // 
            this.BtnLicenca.Location = new System.Drawing.Point(134, 162);
            this.BtnLicenca.Name = "BtnLicenca";
            this.BtnLicenca.Size = new System.Drawing.Size(133, 30);
            this.BtnLicenca.TabIndex = 5;
            this.BtnLicenca.Text = "Licenciar";
            this.BtnLicenca.UseVisualStyleBackColor = true;
            this.BtnLicenca.Click += new System.EventHandler(this.BtnLicenca_Click);
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(305, 241);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(17, 23);
            this.lblLicenca.TabIndex = 6;
            this.lblLicenca.Text = "-";
            // 
            // FrmPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 316);
            this.Controls.Add(this.grpPlaca);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodizio de Placa";
            this.grpPlaca.ResumeLayout(false);
            this.grpPlaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlaca;
        private System.Windows.Forms.Button BtnVerifica;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Button BtnLicenca;
        private System.Windows.Forms.Label lblLicenca;
    }
}

