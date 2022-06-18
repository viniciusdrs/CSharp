using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
{
    public partial class FrmImc : Form
    {
        public FrmImc()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, min, max, imc;

            peso = Double.Parse(txtPeso.Text);
            altura = Double.Parse(txtAltura.Text);

            imc = peso / (altura * altura);
            lblImc.Text = imc.ToString("F2");

            min = 18.5 * (altura * altura);
            lblMinimo.Text = min.ToString("F2") + " Kg";

            max = 24.99 * (altura * altura);
            lblMaximo.Text = max.ToString("F2") + " Kg";

            if (imc < 17)
            {
                lblSituacao.Text = "Muito abaixo do peso";
            } else if(imc <= 18.49) {
                lblSituacao.Text = "Abaixo do peso";
            } else if(imc <= 24.99)
            {
                lblSituacao.Text = "Peso normal";
            } else if(imc <= 29.99)
            {
                lblSituacao.Text = "Acima do peso";
            } else if(imc <= 34.99)
            {
                lblSituacao.Text = "Obesidade 1";
            } else if(imc <= 39.99)
            {
                lblSituacao.Text = "Obesidade 2";
            } else
            {
                lblSituacao.Text = "Obesidade 3";
            }
            
        }
    }
}
