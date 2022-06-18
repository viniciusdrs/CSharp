
namespace ProjetoSelecao
{
    partial class FrmSelecao
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
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.picSemana = new System.Windows.Forms.PictureBox();
            this.BtnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(138, 42);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(74, 29);
            this.TxtDia.TabIndex = 0;
            this.TxtDia.TextChanged += new System.EventHandler(this.TxtDia_TextChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(23, 42);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(109, 24);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Dia: [1 a 7]";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(230, 45);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(17, 24);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "-";
            // 
            // picSemana
            // 
            this.picSemana.Location = new System.Drawing.Point(25, 96);
            this.picSemana.Name = "picSemana";
            this.picSemana.Size = new System.Drawing.Size(639, 418);
            this.picSemana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemana.TabIndex = 3;
            this.picSemana.TabStop = false;
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Location = new System.Drawing.Point(408, 30);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(130, 54);
            this.BtnSwitch.TabIndex = 4;
            this.BtnSwitch.Text = "Switch";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // FrmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.BtnSwitch);
            this.Controls.Add(this.picSemana);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.TxtDia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Exemplos de Switch";
            ((System.ComponentModel.ISupportInitialize)(this.picSemana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.PictureBox picSemana;
        private System.Windows.Forms.Button BtnSwitch;
    }
}

