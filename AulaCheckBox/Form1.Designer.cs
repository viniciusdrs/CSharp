
namespace AulaCheckBox
{
    partial class FrmCheckBox
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
            this.grpQualidades = new System.Windows.Forms.GroupBox();
            this.ChkInteligente = new System.Windows.Forms.CheckBox();
            this.ChkAmavel = new System.Windows.Forms.CheckBox();
            this.ChkSabio = new System.Windows.Forms.CheckBox();
            this.ChkPaciente = new System.Windows.Forms.CheckBox();
            this.ChkTolerante = new System.Windows.Forms.CheckBox();
            this.ChkModesto = new System.Windows.Forms.CheckBox();
            this.lblQualidades = new System.Windows.Forms.Label();
            this.BtnQualidades = new System.Windows.Forms.Button();
            this.lblTodas = new System.Windows.Forms.Label();
            this.grpCor = new System.Windows.Forms.GroupBox();
            this.RdbAzul = new System.Windows.Forms.RadioButton();
            this.RdbVermelho = new System.Windows.Forms.RadioButton();
            this.RdbVerde = new System.Windows.Forms.RadioButton();
            this.grpQualidades.SuspendLayout();
            this.grpCor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQualidades
            // 
            this.grpQualidades.Controls.Add(this.ChkModesto);
            this.grpQualidades.Controls.Add(this.ChkTolerante);
            this.grpQualidades.Controls.Add(this.ChkPaciente);
            this.grpQualidades.Controls.Add(this.ChkSabio);
            this.grpQualidades.Controls.Add(this.ChkAmavel);
            this.grpQualidades.Controls.Add(this.ChkInteligente);
            this.grpQualidades.Location = new System.Drawing.Point(12, 12);
            this.grpQualidades.Name = "grpQualidades";
            this.grpQualidades.Size = new System.Drawing.Size(161, 298);
            this.grpQualidades.TabIndex = 0;
            this.grpQualidades.TabStop = false;
            this.grpQualidades.Text = "Qualidades";
            // 
            // ChkInteligente
            // 
            this.ChkInteligente.AutoSize = true;
            this.ChkInteligente.Location = new System.Drawing.Point(6, 44);
            this.ChkInteligente.Name = "ChkInteligente";
            this.ChkInteligente.Size = new System.Drawing.Size(115, 28);
            this.ChkInteligente.TabIndex = 0;
            this.ChkInteligente.Text = "Inteligente";
            this.ChkInteligente.UseVisualStyleBackColor = true;
            this.ChkInteligente.CheckedChanged += new System.EventHandler(this.ChkInteligente_CheckedChanged);
            // 
            // ChkAmavel
            // 
            this.ChkAmavel.AutoSize = true;
            this.ChkAmavel.Location = new System.Drawing.Point(6, 78);
            this.ChkAmavel.Name = "ChkAmavel";
            this.ChkAmavel.Size = new System.Drawing.Size(92, 28);
            this.ChkAmavel.TabIndex = 1;
            this.ChkAmavel.Text = "Amável";
            this.ChkAmavel.UseVisualStyleBackColor = true;
            this.ChkAmavel.CheckedChanged += new System.EventHandler(this.ChkAmavel_CheckedChanged);
            // 
            // ChkSabio
            // 
            this.ChkSabio.AutoSize = true;
            this.ChkSabio.Location = new System.Drawing.Point(6, 112);
            this.ChkSabio.Name = "ChkSabio";
            this.ChkSabio.Size = new System.Drawing.Size(77, 28);
            this.ChkSabio.TabIndex = 2;
            this.ChkSabio.Text = "Sábio";
            this.ChkSabio.UseVisualStyleBackColor = true;
            this.ChkSabio.CheckedChanged += new System.EventHandler(this.ChkSabio_CheckedChanged);
            // 
            // ChkPaciente
            // 
            this.ChkPaciente.AutoSize = true;
            this.ChkPaciente.Location = new System.Drawing.Point(6, 146);
            this.ChkPaciente.Name = "ChkPaciente";
            this.ChkPaciente.Size = new System.Drawing.Size(102, 28);
            this.ChkPaciente.TabIndex = 3;
            this.ChkPaciente.Text = "Paciente";
            this.ChkPaciente.UseVisualStyleBackColor = true;
            this.ChkPaciente.CheckedChanged += new System.EventHandler(this.ChkPaciente_CheckedChanged);
            // 
            // ChkTolerante
            // 
            this.ChkTolerante.AutoSize = true;
            this.ChkTolerante.Location = new System.Drawing.Point(6, 180);
            this.ChkTolerante.Name = "ChkTolerante";
            this.ChkTolerante.Size = new System.Drawing.Size(109, 28);
            this.ChkTolerante.TabIndex = 4;
            this.ChkTolerante.Text = "Tolerante";
            this.ChkTolerante.UseVisualStyleBackColor = true;
            this.ChkTolerante.CheckedChanged += new System.EventHandler(this.ChkTolerante_CheckedChanged);
            // 
            // ChkModesto
            // 
            this.ChkModesto.AutoSize = true;
            this.ChkModesto.Location = new System.Drawing.Point(6, 214);
            this.ChkModesto.Name = "ChkModesto";
            this.ChkModesto.Size = new System.Drawing.Size(102, 28);
            this.ChkModesto.TabIndex = 5;
            this.ChkModesto.Text = "Modesto";
            this.ChkModesto.UseVisualStyleBackColor = true;
            this.ChkModesto.CheckedChanged += new System.EventHandler(this.ChkModesto_CheckedChanged);
            // 
            // lblQualidades
            // 
            this.lblQualidades.AutoSize = true;
            this.lblQualidades.Location = new System.Drawing.Point(12, 313);
            this.lblQualidades.Name = "lblQualidades";
            this.lblQualidades.Size = new System.Drawing.Size(235, 24);
            this.lblQualidades.TabIndex = 1;
            this.lblQualidades.Text = "Nenhum Item Selecionado";
            // 
            // BtnQualidades
            // 
            this.BtnQualidades.Location = new System.Drawing.Point(250, 30);
            this.BtnQualidades.Name = "BtnQualidades";
            this.BtnQualidades.Size = new System.Drawing.Size(140, 59);
            this.BtnQualidades.TabIndex = 2;
            this.BtnQualidades.Text = "Todas Qualidades";
            this.BtnQualidades.UseVisualStyleBackColor = true;
            this.BtnQualidades.Click += new System.EventHandler(this.BtnQualidades_Click);
            // 
            // lblTodas
            // 
            this.lblTodas.AutoSize = true;
            this.lblTodas.Location = new System.Drawing.Point(262, 113);
            this.lblTodas.Name = "lblTodas";
            this.lblTodas.Size = new System.Drawing.Size(68, 24);
            this.lblTodas.TabIndex = 3;
            this.lblTodas.Text = "Todas:";
            // 
            // grpCor
            // 
            this.grpCor.BackColor = System.Drawing.Color.Gold;
            this.grpCor.Controls.Add(this.RdbVerde);
            this.grpCor.Controls.Add(this.RdbVermelho);
            this.grpCor.Controls.Add(this.RdbAzul);
            this.grpCor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpCor.Location = new System.Drawing.Point(432, 30);
            this.grpCor.Name = "grpCor";
            this.grpCor.Size = new System.Drawing.Size(209, 195);
            this.grpCor.TabIndex = 4;
            this.grpCor.TabStop = false;
            this.grpCor.Text = "Qual sua cor Favorita";
            // 
            // RdbAzul
            // 
            this.RdbAzul.AutoSize = true;
            this.RdbAzul.BackColor = System.Drawing.Color.Blue;
            this.RdbAzul.Location = new System.Drawing.Point(35, 51);
            this.RdbAzul.Name = "RdbAzul";
            this.RdbAzul.Size = new System.Drawing.Size(65, 28);
            this.RdbAzul.TabIndex = 0;
            this.RdbAzul.TabStop = true;
            this.RdbAzul.Text = "Azul";
            this.RdbAzul.UseVisualStyleBackColor = false;
            this.RdbAzul.CheckedChanged += new System.EventHandler(this.RdbAzul_CheckedChanged);
            // 
            // RdbVermelho
            // 
            this.RdbVermelho.AutoSize = true;
            this.RdbVermelho.BackColor = System.Drawing.Color.Red;
            this.RdbVermelho.Location = new System.Drawing.Point(35, 85);
            this.RdbVermelho.Name = "RdbVermelho";
            this.RdbVermelho.Size = new System.Drawing.Size(111, 28);
            this.RdbVermelho.TabIndex = 1;
            this.RdbVermelho.TabStop = true;
            this.RdbVermelho.Text = "Vermelho";
            this.RdbVermelho.UseVisualStyleBackColor = false;
            this.RdbVermelho.CheckedChanged += new System.EventHandler(this.RdbVermelho_CheckedChanged);
            // 
            // RdbVerde
            // 
            this.RdbVerde.AutoSize = true;
            this.RdbVerde.BackColor = System.Drawing.Color.Green;
            this.RdbVerde.Location = new System.Drawing.Point(35, 118);
            this.RdbVerde.Name = "RdbVerde";
            this.RdbVerde.Size = new System.Drawing.Size(80, 28);
            this.RdbVerde.TabIndex = 2;
            this.RdbVerde.TabStop = true;
            this.RdbVerde.Text = "Verde";
            this.RdbVerde.UseVisualStyleBackColor = false;
            this.RdbVerde.CheckedChanged += new System.EventHandler(this.RdbVerde_CheckedChanged);
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 690);
            this.Controls.Add(this.grpCor);
            this.Controls.Add(this.lblTodas);
            this.Controls.Add(this.BtnQualidades);
            this.Controls.Add(this.lblQualidades);
            this.Controls.Add(this.grpQualidades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.FrmCheckBox_Load);
            this.grpQualidades.ResumeLayout(false);
            this.grpQualidades.PerformLayout();
            this.grpCor.ResumeLayout(false);
            this.grpCor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQualidades;
        private System.Windows.Forms.CheckBox ChkModesto;
        private System.Windows.Forms.CheckBox ChkTolerante;
        private System.Windows.Forms.CheckBox ChkPaciente;
        private System.Windows.Forms.CheckBox ChkSabio;
        private System.Windows.Forms.CheckBox ChkAmavel;
        private System.Windows.Forms.CheckBox ChkInteligente;
        private System.Windows.Forms.Label lblQualidades;
        private System.Windows.Forms.Button BtnQualidades;
        private System.Windows.Forms.Label lblTodas;
        private System.Windows.Forms.GroupBox grpCor;
        private System.Windows.Forms.RadioButton RdbVerde;
        private System.Windows.Forms.RadioButton RdbVermelho;
        private System.Windows.Forms.RadioButton RdbAzul;
    }
}

