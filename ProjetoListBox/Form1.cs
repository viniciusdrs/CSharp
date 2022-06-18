using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoListBox
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                LstNumeros.Items.Add(i);
            }

            for (int i = 10; i > 0; i--)
            {
                LstNumeros.Items.Add(i);
            }

            for(char j = 'a'; j< 'z'; j++)
            {
                LstNumeros.Items.Add(j);
            }
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            while(i < 5)
            {
                LstNumeros.Items.Add(i);
                i++;
            }
        }

        private void BtnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            do
            {
                LstNumeros.Items.Add(i);
                i++;
            } while(i < 5);
        }
    }
}
