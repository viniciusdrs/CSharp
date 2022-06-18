using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeVetor
{
    public partial class FrmCalculaImc : Form
    {
        double[] vPeso = new double[10];
        double[] vAltura = new double[10];
        double[] vImc = new double[10];
        int tamanhoVet = 10;
        int indice = 0;



        public FrmCalculaImc()
        {
            InitializeComponent();
        }

        private void FrmCalculaImc_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            if(indice < 10)
            {
                vAltura[indice] = double.Parse(txtAltura.Text);
                vPeso[indice] = double.Parse(txtPeso.Text);
                vImc[indice] = vPeso[indice] / (vAltura[indice] * vAltura[indice]);

                txtImc.Text = vImc[indice].ToString("F2");
                indice++;
            } else
            {
                BtnCalcula.Enabled = false;
                MessageBox.Show("Limite Máximo Atingido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void BtnVerVetor_Click(object sender, EventArgs e)
        {
            LstVetores.Items.Clear();

            for (int i = 0; i < indice; i++)
            {
                 LstVetores.Items.Add(i + 1 + " - Peso: " + vPeso[i] + "  Altura: " + vAltura[i] + "  Imc: " + vImc[i].ToString("F2"));
            }
        }
    }
}
