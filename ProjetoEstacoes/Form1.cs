using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacoes
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
            CboEstacoes.Items.Add("Verão 1");
            CboEstacoes.Items.Add("Inverno 1");
            CboEstacoes.Items.Add("Primavera 1");
            CboEstacoes.Items.Add("Outono 1");
        }

        private void CboEstacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEscolhida.Text = CboEstacoes.SelectedIndex + "-" + CboEstacoes.Text;

            switch (CboEstacoes.SelectedIndex)
            {
                case 0:
                case 1:
                    picEstacao.Load("Inverno.jpg");
                    break;
                case 2:
                case 3:
                    picEstacao.Load("Outono.jpg");
                    break;
                case 4:
                case 5:
                    picEstacao.Load("Primavera.jpg");
                    break;
                case 6:
                case 7:
                    picEstacao.Load("Verao.jpg");
                    break;

            }
        }
    }
}
