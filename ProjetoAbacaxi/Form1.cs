using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAbacaxi
{
    public partial class FrmAbacaxi : Form
    {
        public FrmAbacaxi()
        {
            InitializeComponent();
        }

        private void FrmAbacaxi_Load(object sender, EventArgs e)
        {
            CmbFrutas.Items.Add("Abacaxi");
            CmbFrutas.Items.Add("Limão");
            CmbFrutas.Items.Add("Amora");

            CmbPreco.Items.Add("3,56");
            CmbPreco.Items.Add("5,46");
            CmbPreco.Items.Add("7,99");
        }

        double resultado;
        private void CmbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbPreco.SelectedIndex = CmbFrutas.SelectedIndex;
            LstSelecionados.Items.Add(TxtQuantidade.Text + " " + CmbFrutas.Text + " - " + CmbPreco.Text);
            
            int quantidade;
            double preco;

            quantidade = Int32.Parse(TxtQuantidade.Text);
            preco = Double.Parse(CmbPreco.Text);
            double novoResultado = quantidade * preco;
            resultado += novoResultado;

            lblMensagem.Text = resultado.ToString();
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {


            if (int.TryParse(TxtQuantidade.Text, out int id) == false)
            {
                MessageBox.Show("Digite a Quantidade", "Campo Quantidade");
                TxtQuantidade.Focus();
                return;
            }

            if (Convert.ToInt32(TxtQuantidade.Text) <= 0)
            {
                MessageBox.Show("A Quantidade deve ser maior que 0", "Campo Quantidade");
                TxtQuantidade.Focus();
                return;
            }
        }

        private void LstSelecionados_MouseClick(object sender, MouseEventArgs e)
        {
            int tamanhoString, pos1, pos2;
            double quantidade, valor;
            String ItemSelecionado = LstSelecionados.Text;

            LstSelecionados.Items.RemoveAt(LstSelecionados.SelectedIndex);

            //LstSelecionados.Refresh();

            tamanhoString = ItemSelecionado.Length;
            pos1 = ItemSelecionado.IndexOf("-");
            pos2 = ItemSelecionado.LastIndexOf("-");

            quantidade = int.Parse(ItemSelecionado.Substring(0, pos1));
            valor = double.Parse(ItemSelecionado.Substring(pos2 + 1, tamanhoString - pos2 - 1));

            lblMensagem.Text = (double.Parse(lblMensagem.Text) - (quantidade * valor)).ToString();

        }
    }
}
