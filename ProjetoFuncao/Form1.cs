using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFuncao
{
    public partial class FrmFuncao : Form
    {
        //int valorA, valorB;

        public FrmFuncao()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        void limparControles()
        {
            txtValorA.Clear();
            txtValorB.Clear();
            txtMaior.Clear();

            txtValorA.Focus();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            int valorA = Int16.Parse(txtValorA.Text);
            int valorB = Int16.Parse(txtValorB.Text);

            txtMaior.Text = verificaMaior(valorA, valorB).ToString();
        }

        int verificaMaior(int valorA, int valorB)
        {
            if(valorA > valorB)
            {
                return valorA;
            } else
            {
                return valorB;
            }
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            double salario = double.Parse(txtSalario.Text);
            double reajuste = 0, novoSalario = 0;

            calculaSalario(salario, ref reajuste, ref novoSalario);

            txtReajuste.Text = reajuste.ToString();
            txtNovoSalario.Text = novoSalario.ToString();
        }

        void calculaSalario(double salario, ref double reajuste, ref double novoSalario)
        {
            reajuste = salario * 0.10;
            novoSalario = salario + reajuste;
        }

        private void BtnCalculaImc_Click(object sender, EventArgs e)
        {

            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            txtImc.Text = calculaIMC(peso, altura).ToString("F2");
            mostraSituacao(double.Parse(txtImc.Text));

        }

        double calculaIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        void mostraSituacao(double imc)
        {
            if(imc < 17)
            {
                txtSituacao.Text = "Muito Abaixo do Peso";
            } else if(imc <= 18.49) 
            {
                txtSituacao.Text = "Abaixo do Peso";
            } else if (imc <= 24.99)
            {
                txtSituacao.Text = "Peso Normal";
            } else if (imc <= 29.99)
            {
                txtSituacao.Text = "Acima do Peso";
            } else if (imc <= 34.99)
            {
                txtSituacao.Text = "Obesidade 1";
            } else if (imc <= 39.99)
            {
                txtSituacao.Text = "Obesidade 2";
            } else
            {
                txtSituacao.Text = "Obesidade 3";
            }
        }
    }
}
