using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSelecao
{
    public partial class FrmSelecao : Form
    {
        public FrmSelecao()
        {
            InitializeComponent();
        }

        private void TxtDia_TextChanged(object sender, EventArgs e)
        {
            /*
            byte dia;

            if (TxtDia.Text != "")
            {
                dia = Byte.Parse(TxtDia.Text);


                if (dia == 1)
                {
                    lblDiaSemana.Text = "Domingo";
                    picSemana.Load("Domingo.jpg");
                } else if (dia == 2)
                {
                    lblDiaSemana.Text = "Segunda-Feira";
                    picSemana.Load("Segunda.jpg");
                } else if (dia == 3)
                {
                    lblDiaSemana.Text = "Terça-Feira";
                    picSemana.Load("Terca.jpg");
                } else if (dia == 4)
                {
                    lblDiaSemana.Text = "Quarta-Feira";
                    picSemana.Load("Quarta.jpg");
                } else if (dia == 5)
                {
                    lblDiaSemana.Text = "Quinta-Feira";
                    picSemana.Load("Quinta.jpg");
                } else if (dia == 6)
                {
                    lblDiaSemana.Text = "Sexta-Feira";
                    picSemana.Load("Sexta.jpg");
                } else if (dia == 7)
                {
                    lblDiaSemana.Text = "Sábado";
                    picSemana.Load("Sabado.jpg");
                } else
                {
                    lblDiaSemana.Text = "Número Inválido";
                    picSemana.Load("Erro.png");
                }
            }
         */

        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            byte dia;

            if (TxtDia.Text != "")
            {
                dia = Byte.Parse(TxtDia.Text);

                switch (dia)
                {
                    case 1:
                        lblDiaSemana.Text = "Domingo";
                        picSemana.Load("Domingo.jpg");
                        break;
                    case 2:
                        lblDiaSemana.Text = "Segunda-Feira";
                        picSemana.Load("Segunda.jpg");
                        break;
                    case 3:
                        lblDiaSemana.Text = "Terça-Feira";
                        picSemana.Load("Terca.jpg");
                        break;
                    case 4:
                        lblDiaSemana.Text = "Quarta-Feira";
                        picSemana.Load("Quarta.jpg");
                        break;
                    case 5:
                        lblDiaSemana.Text = "Quinta-Feira";
                        picSemana.Load("Quinta.jpg");
                        break;
                    case 6:
                        lblDiaSemana.Text = "Sexta-Feira";
                        picSemana.Load("Sexta.jpg");
                        break;
                    case 7:
                        lblDiaSemana.Text = "Sábado";
                        picSemana.Load("Sabado.jpg");
                        break;
                    default:
                        lblDiaSemana.Text = "Número Inválido";
                        picSemana.Load("Erro.png");
                        break;
                }
            }
        }
    }
}
