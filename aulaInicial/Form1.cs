using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaInicial
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! " + txtNome.Text, "Mensagem");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
