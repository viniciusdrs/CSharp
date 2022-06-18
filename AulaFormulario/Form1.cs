using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaFormulario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá " + txtNome.Text + 
                "\n que mora em " + txtCidade.Text, "Mensagem");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Vinicius dos Reis Soares";
            txtEndereco.Text = "Rua Linkin Park, 12545";
            txtIdade.Text = "20";
            txtNome.ReadOnly = true;
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            txtCopiaNome.Text = txtNome.Text;
            txtCopiaEndereco.Text = txtEndereco.Text;
            txtCopiaCidade.Text = txtCidade.Text;
            txtCopiaIdade.Text = txtIdade.Text;

            txtCopiaNome.ReadOnly = true;
            txtCopiaEndereco.ReadOnly = true;
            txtCopiaCidade.ReadOnly = true;
            txtCopiaIdade.ReadOnly = true;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCopiaNome.Clear();
            txtCopiaEndereco.Clear();
            txtCopiaCidade.Clear();
            txtCopiaIdade.Clear();

            txtCopiaNome.ReadOnly = false;
            txtCopiaEndereco.ReadOnly = false;
            txtCopiaCidade.ReadOnly = false;
            txtCopiaIdade.ReadOnly = false;
        }

        private void BtnCor_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            txtNome.ForeColor = Color.Black;
            lblNome.BackColor = Color.White;
            lblNome.ForeColor = Color.Black;

            txtEndereco.BackColor = Color.Aquamarine;
            txtEndereco.ForeColor = Color.Magenta;
            lblEndereco.BackColor = Color.Aquamarine;
            lblEndereco.ForeColor = Color.Magenta;

            txtCidade.BackColor = Color.Tan;
            txtCidade.ForeColor = Color.MediumOrchid;
            lblCidade.BackColor = Color.Tan;
            lblCidade.ForeColor = Color.MediumOrchid;

            txtIdade.BackColor = Color.DarkRed;
            txtIdade.ForeColor = Color.DarkSlateBlue;
            lblIdade.BackColor = Color.DarkRed;
            lblIdade.ForeColor = Color.DarkSlateBlue;
        }
    }
}
