using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodizioPlaca
{
    public partial class FrmPlaca : Form
    {
        public FrmPlaca()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            byte placa;

            placa = Byte.Parse(txtPlaca.Text);

            switch(placa)
            {
                case 1:
                case 2:
                    lblSemana.Text = "Proibido Segunda-Feira";
                    break;
                case 3:
                case 4:
                    lblSemana.Text = "Proibido Terça-Feira";
                    break;
                case 5:
                case 6:
                    lblSemana.Text = "Proibido Quarta-Feira";
                    break;
                case 7:
                case 8:
                    lblSemana.Text = "Proibido Quinta-Feira";
                    break;
                case 9:
                case 0:
                    lblSemana.Text = "Proibido Sexta-Feira";
                    break;
                default:
                    lblSemana.Text = "Número Inválido";
                    break;
            }
        }

        private void BtnLicenca_Click(object sender, EventArgs e)
        {
            byte placa;

            placa = Byte.Parse(txtPlaca.Text);

            switch (placa)
            {
                case 1:
                    lblLicenca.Text = "Licenciar até Abril";
                    break;
                case 2:
                    lblLicenca.Text = "Licenciar até Maio";
                    break;
                case 3:
                    lblLicenca.Text = "Licenciar até Junho";
                    break;
                case 4:
                    lblLicenca.Text = "Licenciar até Julho";
                    break;
                case 5:
                case 6:
                    lblLicenca.Text = "Licenciar até Agosto";
                    break;
                case 7:
                    lblLicenca.Text = "Licenciar até Setembro";
                    break;
                case 8:
                    lblLicenca.Text = "Licenciar até Outubro";
                    break;
                case 9:
                    lblLicenca.Text = "Licenciar até Novemvbro";
                    break;
                case 0:
                    lblLicenca.Text = "Licenciar até Dezembro";
                    break;
                default:
                    lblLicenca.Text = "Número Inválido";
                    break;
            }
        }
    }
}
