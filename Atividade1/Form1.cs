using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class FrmSoma : Form
    {
        public FrmSoma()
        {
            InitializeComponent();
        }

        private void BtnInteiros_Click(object sender, EventArgs e)
        {
            int valor1, valor2, soma;

            valor1 = Int32.Parse(txtA.Text);
            valor2 = Int32.Parse(txtB.Text);

            soma = valor1 + valor2;

            txtResultado.Text = soma.ToString();
        }

        private void BtnReais_Click(object sender, EventArgs e)
        {
            double valor1, valor2, soma;

            valor1 = Double.Parse(txtA.Text);
            valor2 = Double.Parse(txtB.Text);

            soma = valor1 + valor2;

            txtResultado.Text = soma.ToString();
        }
    }
}
