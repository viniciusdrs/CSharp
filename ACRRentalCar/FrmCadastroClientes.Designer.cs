
namespace ACRRentalCar
{
    partial class FrmCadastroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(501, 20);
            this.txtNome.TabIndex = 3;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(15, 154);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 30);
            this.BtnIncluir.TabIndex = 4;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(107, 154);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 30);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(197, 154);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 30);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(290, 154);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 30);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(441, 154);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 30);
            this.BtnFechar.TabIndex = 8;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(221, 9);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(413, 9);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(89, 13);
            this.lblDtNasc.TabIndex = 10;
            this.lblDtNasc.Text = "Data Nascimento";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(224, 25);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 11;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskDtNasc
            // 
            this.mskDtNasc.Location = new System.Drawing.Point(416, 25);
            this.mskDtNasc.Mask = "00/00/0000";
            this.mskDtNasc.Name = "mskDtNasc";
            this.mskDtNasc.Size = new System.Drawing.Size(100, 20);
            this.mskDtNasc.TabIndex = 12;
            // 
            // FrmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.Controls.Add(this.mskDtNasc);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDtNasc;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.MaskedTextBox mskDtNasc;
    }
}