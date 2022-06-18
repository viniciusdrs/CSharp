using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOperadores
{
    public partial class FrmOperadores : Form
    {
        public FrmOperadores()
        {
            InitializeComponent();
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt16(txtX.Text);

            //y = x;
            //++x;

            y = ++x;

            MessageBox.Show("X: " + x + "\nY: " + y);
        }

        private void BtnPos_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt16(txtX.Text);

            //y = x;
            //x++;

            y = x++;

            MessageBox.Show("X: " + x + "\nY: " + y);
        }
    }
}
