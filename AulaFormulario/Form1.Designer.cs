
namespace AulaFormulario
{
    partial class FrmPrincipal
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
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.BtnMensagem = new System.Windows.Forms.Button();
            this.txtCopiaNome = new System.Windows.Forms.TextBox();
            this.txtCopiaCidade = new System.Windows.Forms.TextBox();
            this.txtCopiaEndereco = new System.Windows.Forms.TextBox();
            this.txtCopiaIdade = new System.Windows.Forms.TextBox();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkGray;
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(12, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Seu Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.DarkGray;
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEndereco.Location = new System.Drawing.Point(17, 101);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(79, 16);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.DarkGray;
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCidade.Location = new System.Drawing.Point(34, 145);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(62, 16);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblIdade.Location = new System.Drawing.Point(44, 190);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(52, 16);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNome.ForeColor = System.Drawing.Color.Red;
            this.txtNome.Location = new System.Drawing.Point(102, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Chartreuse;
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEndereco.Location = new System.Drawing.Point(103, 98);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(287, 22);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Red;
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(103, 142);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(287, 22);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.Text = "São Paulo";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtIdade.ForeColor = System.Drawing.Color.Chocolate;
            this.txtIdade.Location = new System.Drawing.Point(102, 187);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 22);
            this.txtIdade.TabIndex = 7;
            // 
            // BtnMensagem
            // 
            this.BtnMensagem.Location = new System.Drawing.Point(432, 62);
            this.BtnMensagem.Name = "BtnMensagem";
            this.BtnMensagem.Size = new System.Drawing.Size(129, 52);
            this.BtnMensagem.TabIndex = 8;
            this.BtnMensagem.Text = "Mensagem";
            this.BtnMensagem.UseVisualStyleBackColor = true;
            this.BtnMensagem.Click += new System.EventHandler(this.BtnMensagem_Click);
            // 
            // txtCopiaNome
            // 
            this.txtCopiaNome.Location = new System.Drawing.Point(20, 299);
            this.txtCopiaNome.Name = "txtCopiaNome";
            this.txtCopiaNome.Size = new System.Drawing.Size(288, 22);
            this.txtCopiaNome.TabIndex = 9;
            // 
            // txtCopiaCidade
            // 
            this.txtCopiaCidade.Location = new System.Drawing.Point(20, 381);
            this.txtCopiaCidade.Name = "txtCopiaCidade";
            this.txtCopiaCidade.Size = new System.Drawing.Size(288, 22);
            this.txtCopiaCidade.TabIndex = 10;
            // 
            // txtCopiaEndereco
            // 
            this.txtCopiaEndereco.Location = new System.Drawing.Point(20, 340);
            this.txtCopiaEndereco.Name = "txtCopiaEndereco";
            this.txtCopiaEndereco.Size = new System.Drawing.Size(287, 22);
            this.txtCopiaEndereco.TabIndex = 11;
            // 
            // txtCopiaIdade
            // 
            this.txtCopiaIdade.Location = new System.Drawing.Point(20, 425);
            this.txtCopiaIdade.Name = "txtCopiaIdade";
            this.txtCopiaIdade.Size = new System.Drawing.Size(100, 22);
            this.txtCopiaIdade.TabIndex = 12;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.Location = new System.Drawing.Point(432, 142);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(129, 52);
            this.BtnCopiar.TabIndex = 13;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(432, 220);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(129, 52);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnCor
            // 
            this.BtnCor.BackColor = System.Drawing.Color.White;
            this.BtnCor.Location = new System.Drawing.Point(432, 299);
            this.BtnCor.Name = "BtnCor";
            this.BtnCor.Size = new System.Drawing.Size(129, 52);
            this.BtnCor.TabIndex = 15;
            this.BtnCor.Text = "Cor";
            this.BtnCor.UseVisualStyleBackColor = false;
            this.BtnCor.Click += new System.EventHandler(this.BtnCor_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 527);
            this.Controls.Add(this.BtnCor);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.txtCopiaIdade);
            this.Controls.Add(this.txtCopiaEndereco);
            this.Controls.Add(this.txtCopiaCidade);
            this.Controls.Add(this.txtCopiaNome);
            this.Controls.Add(this.BtnMensagem);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula de Formulario";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button BtnMensagem;
        private System.Windows.Forms.TextBox txtCopiaNome;
        private System.Windows.Forms.TextBox txtCopiaCidade;
        private System.Windows.Forms.TextBox txtCopiaEndereco;
        private System.Windows.Forms.TextBox txtCopiaIdade;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCor;
    }
}

