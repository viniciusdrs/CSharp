using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDiaDaSemana
{
    public partial class FrmDiaDaSemana : Form
    {
        public FrmDiaDaSemana()
        {
            InitializeComponent();
        }

        private void FrmDiaDaSemana_Load(object sender, EventArgs e)
        {
            CboDiaDaSemana.Items.Add("Domingo");
            CboDiaDaSemana.Items.Add("Segunda-Feira");
            CboDiaDaSemana.Items.Add("Terça-Feira");
            CboDiaDaSemana.Items.Add("Quarta-Feira");
            CboDiaDaSemana.Items.Add("Quinta-Feira");
            CboDiaDaSemana.Items.Add("Sexta-Feira");
            CboDiaDaSemana.Items.Add("Sabádo");
        }

        private void CboDiaDaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDiaEscolhido.Text = CboDiaDaSemana.SelectedIndex + "- " + CboDiaDaSemana.Text;

            switch (CboDiaDaSemana.SelectedIndex)
            {
                case 0:
                    picDiaDaSemana.Load("Domingo.jpg");
                    break;
                case 1:
                    picDiaDaSemana.Load("Segunda.jpg");
                    break;
                case 2:
                    picDiaDaSemana.Load("Terca.jpg");
                    break;
                case 3:
                    picDiaDaSemana.Load("Quarta.jpg");
                    break;
                case 4:
                    picDiaDaSemana.Load("Quinta.jpg");
                    break;
                case 5:
                    picDiaDaSemana.Load("Sexta.jpg");
                    break;
                case 6:
                    picDiaDaSemana.Load("Sabado.jpg");
                    break;
            }
        }
    }
}
