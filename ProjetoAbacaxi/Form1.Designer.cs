
namespace ProjetoAbacaxi
{
    partial class FrmAbacaxi
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
            this.CmbFrutas = new System.Windows.Forms.ComboBox();
            this.CmbPreco = new System.Windows.Forms.ComboBox();
            this.LstSelecionados = new System.Windows.Forms.ListBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbFrutas
            // 
            this.CmbFrutas.FormattingEnabled = true;
            this.CmbFrutas.Location = new System.Drawing.Point(120, 110);
            this.CmbFrutas.Name = "CmbFrutas";
            this.CmbFrutas.Size = new System.Drawing.Size(149, 28);
            this.CmbFrutas.TabIndex = 0;
            this.CmbFrutas.SelectedIndexChanged += new System.EventHandler(this.CmbFrutas_SelectedIndexChanged);
            // 
            // CmbPreco
            // 
            this.CmbPreco.FormattingEnabled = true;
            this.CmbPreco.Location = new System.Drawing.Point(120, 223);
            this.CmbPreco.Name = "CmbPreco";
            this.CmbPreco.Size = new System.Drawing.Size(149, 28);
            this.CmbPreco.TabIndex = 1;
            // 
            // LstSelecionados
            // 
            this.LstSelecionados.FormattingEnabled = true;
            this.LstSelecionados.ItemHeight = 20;
            this.LstSelecionados.Location = new System.Drawing.Point(311, 26);
            this.LstSelecionados.Name = "LstSelecionados";
            this.LstSelecionados.Size = new System.Drawing.Size(207, 444);
            this.LstSelecionados.TabIndex = 2;
            this.LstSelecionados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstSelecionados_MouseClick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(91, 387);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(19, 20);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "0";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(33, 110);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(86, 20);
            this.lblProdutos.TabIndex = 4;
            this.lblProdutos.Text = "Produtos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(59, 223);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(60, 20);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 38);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(107, 20);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(120, 38);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(108, 26);
            this.TxtQuantidade.TabIndex = 7;
            this.TxtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total R$:";
            // 
            // FrmAbacaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.LstSelecionados);
            this.Controls.Add(this.CmbPreco);
            this.Controls.Add(this.CmbFrutas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAbacaxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmAbacaxi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFrutas;
        private System.Windows.Forms.ComboBox CmbPreco;
        private System.Windows.Forms.ListBox LstSelecionados;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label1;
    }
}

