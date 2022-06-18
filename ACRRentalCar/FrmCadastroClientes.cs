﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRRentalCar
{
    public partial class FrmCadastroClientes : Form
    {
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            habilitar();
        }

        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }

        private void desabilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }

        private void limparControles()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtCodigo.Clear();
            mskCPF.Clear();
            mskDtNasc.Clear();

            mskCPF.Focus();
        }

        private bool validaDados()
        {
            //verificar se mskCPF está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(mskCPF.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o mskCPF
                mskCPF.Clear();

                //coloca o cursor no mskCPF
                mskCPF.Focus();

                //retorna falso
                return false;
            }

            //verifica se o que foi digitado em data de nascimento é uma data válida 
            DateTime auxData; //variável auxiliar
                              //se não for uma data válida ou se não digitar nenhuma data
            if (!(DateTime.TryParse(mskDtNasc.Text, out auxData)))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o mskDtNasc
                mskDtNasc.Clear();

                //coloca o cursor no mskDtNasc
                mskDtNasc.Focus();

                //retorna falso
                return false;
            }

            //verifica se o txtNome está preenchido, Se for nulo ou vazio retorna falso
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o txtNome
                txtNome.Clear();

                //coloca o cursor no txtNome
                txtNome.Focus();

                //retorna falso
                return false;
            }

            //se todas as validações passaram no teste, retorna verdadeiro
            return true;
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                //se txtCodigo não estiver vazio, significa que já foi consultado um cliente.
                // a instrução a seguir captura se foi clicado o botão Yes (SIM) como resposta da pergunta.
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    limparControles();
                return;   //encerra a sub-rotina
            }

            // antes de incluir é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento para incluir no banco de dados

            if (validaDados() == false)
            {
                return;  //interrompe a sub-rotina
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";

            //Tratamento de exceções
            try
            {
                //abre a conexão com o banco de dados
                conCliente.Open();

                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));

                //executa o commando
                //ExecuteNonQuery envia instruções para o banco de dados que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                limparControles();
            }
            catch (Exception ex)  // se houve alguma exceção dentro do bloco try
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally  // independente se houve exceção ou não o bloco try é sempre executado
            {
                //se conexão não for nula, fecha conexão
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            
            Form frm = new FrmConsultaCliente(this);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //os campos para serem alterados são preenchidos por meio da consulta no grid do form Consulta de Cliente
            //verifica se tem o código do cliente no txtCodigo. Se o campo estiver vazio, interrompe a sub-rotina
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja alterar clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   //interrompe a sub-rotina
            }

            // antes de alterar o registro é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento
            if (validaDados() == false)
            {
                return;
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "UPDATE cliente set nome=@nome,data_nasc=@data_nasc,cpf=@cpf WHERE id_cliente=@id_cliente";

            //Tratamento de exceções 
            //códigos semelhantes ao botão inserir com diferença na instrução SQL
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                //executa o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                limparControles();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //veririfica se tem o código do cliente no txtCodigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //solicita confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //declaração da variável para guardar as instruções SQL
                string sqlQuery;

                //cria conexão chamando o método getConnection da classe Conexao
                SqlConnection conCliente = Conexao.getConnection();

                //cria a instrução sql, parametrizada
                sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                //Tratamento de exceções
                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    //define, adiciona os parametros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    //executa o commando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpa os campos para nova entrada de dados
                    limparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (conCliente != null)
                    {
                        conCliente.Close();
                    }
                }
            }
        }
    }
}
