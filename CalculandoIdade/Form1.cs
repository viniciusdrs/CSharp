using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoIdade
{
    public partial class FrmCalculandoIdade : Form
    {
        public FrmCalculandoIdade()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            short idade;
            int anoAtual, anoNascimento;

            anoAtual = Int16.Parse(txtAnoAtual.Text);
            anoNascimento = Int16.Parse(txtAnoNascimento.Text);

            idade = (short)(anoAtual - anoNascimento);

            txtIdade.Text = idade.ToString();

            if(idade < 18)
            {
                txtSituacao.Text = "Não pode dirigir!";
                txtSituacao.BackColor = Color.Red;
            } else
            {
                txtSituacao.Text = "Pode tirar habilitação!";
                txtSituacao.BackColor = Color.LightGreen;
            }

            txtAnoNascimento.Focus();


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCalculandoIdade_Load(object sender, EventArgs e)
        {
            txtAnoNascimento.Focus();
        }
    }
}
