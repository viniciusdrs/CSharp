using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiposDados
{
    public partial class FrmTiposDados : Form
    {
        public FrmTiposDados()
        {
            InitializeComponent();
        }

        private void BtnCalcularSoma_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtValor1.Text);
            valor2 = Convert.ToInt16(txtValor2.Text);

            resultado = valor1 + valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void BtnSomarFloat_Click(object sender, EventArgs e)
        {
            float valor1, valor2;
            
            valor1 = Convert.ToSingle(txtValor1.Text);
            valor2 = Convert.ToSingle(txtValor2.Text);

            txtResultado.Text = (valor1 + valor2).ToString();
        }

        private void BtnConverte_Click(object sender, EventArgs e)
        {
            int i = 2000000;
            short s = 32767;

            //Conversão Implícita
            /*i = s;
            txtResultado.Text = i.ToString();*/

            //Conversão Explicita(Cast)
            s = (short)i;
            txtResultado.Text = s.ToString();
        }
    }
}
