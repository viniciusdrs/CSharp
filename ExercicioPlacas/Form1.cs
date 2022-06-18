using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPlacas
{
    public partial class FrmPlaca : Form
    {
        public FrmPlaca()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            String placa;
            placa = TxtPlaca.Text;

            TxtTamanho.Text = placa.Length.ToString();
            TxtPosicao.Text = placa.Substring(0, TxtPlaca.TextLength);
            TxtAsterisco.Text = placa.LastIndexOf("*").ToString();
        }
    }
}