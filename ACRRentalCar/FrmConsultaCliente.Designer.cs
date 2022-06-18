
namespace ACRRentalCar
{
    partial class FrmConsultaCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(0, 0);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(666, 400);
            this.dgvCliente.TabIndex = 0;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(189, 406);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(110, 51);
            this.BtnSelecionar.TabIndex = 1;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(377, 406);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 51);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.dgvCliente);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.FrmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.DataGridView dgvCliente;
    }
}