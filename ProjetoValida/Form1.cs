using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoValida
{
    public partial class FrmValida : Form
    {
        public FrmValida()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            int saidaIdade;
            double saidaSalario;

            if(string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe seu Nome", "Campo Nome está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if(int.TryParse(txtIdade.Text, out saidaIdade) == false)
            {
                MessageBox.Show("Informe sua Idade", "Campo Idade está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdade.Focus();
                return;
            }

            if(double.TryParse(txtSalario.Text, out saidaSalario) == false) 
            {
                MessageBox.Show("Informe seu Salário", "Campo Salário está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalario.Focus();
                return;
            }

            MessageBox.Show("Gravado com Sucesso...", "Salvando", MessageBoxButtons.OK);
        }
    }
}
