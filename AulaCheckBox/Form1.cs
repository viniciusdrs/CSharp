using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCheckBox
{
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void ChkInteligente_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkInteligente.Checked)
            {
                lblQualidades.Text = "Inteligente";
            }
            else
            {
                lblQualidades.Text = "";
            } 
        }

        private void ChkAmavel_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAmavel.Checked)
            {
                lblQualidades.Text = "Amável";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void ChkSabio_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSabio.Checked)
            {
                lblQualidades.Text = "Sábio";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void ChkPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPaciente.Checked)
            {
                lblQualidades.Text = "Paciente";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void ChkTolerante_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTolerante.Checked)
            {
                lblQualidades.Text = "Intolerante";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void ChkModesto_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkModesto.Checked)
            {
                lblQualidades.Text = "Modesto";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void BtnQualidades_Click(object sender, EventArgs e)
        {

            lblTodas.Text = "Todas: ";

            if(ChkInteligente.Checked)
            {
                lblTodas.Text += "\n-Inteligente";
            }
            if(ChkAmavel.Checked)
            {
                lblTodas.Text += "\n-Amável";
            }
            if (ChkSabio.Checked)
            {
                lblTodas.Text += "\n-Sábio";
            }
            if (ChkPaciente.Checked)
            {
                lblTodas.Text += "\n-Paciente";
            }
            if (ChkTolerante.Checked)
            {
                lblTodas.Text += "\n-Tolerante";
            }
            if (ChkModesto.Checked)
            {
                lblTodas.Text += "\n-Modesto";
            }
        }

        private void RdbAzul_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Blue;
        }

        private void RdbVermelho_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Red;
        }

        private void RdbVerde_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Green;
        }

        private void FrmCheckBox_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Boa Noite", "Boas Vindas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
