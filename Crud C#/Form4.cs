using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_
{
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            string email = textBox1.Text;

            if (listViewClientes.SelectedItems.Count > 0)
            {
                // Pega o ID do usuarios selecionado (primeira coluna do ListView)
                string UsuarioID = listViewClientes.SelectedItems[0].SubItems[0].Text;

                string strConexao = "server=localhost;uid=root;database=bancodedados1";
                MySqlConnection conexao = new MySqlConnection(strConexao);

                try
                {
                    conexao.Open();

                    // Query SQL para deletar o usuarios baseado no UsuarioID
                    string query = $"UPDATE cliente SET nome = '{nome}', email = '{email}' WHERE UsuarioID = {UsuarioID}";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se o registro foi excluído com sucesso
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cliente alterado com sucesso!");
                        // Atualiza o ListView após a exclusão
                        ClienteCarregador.CarregarClientes(listViewClientes);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar o usuario.");
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar o usuario: {ex.Message}");
                }
            }
            else
            {
                // Exibe uma mensagem caso nenhum usuarios tenha sido selecionado
                MessageBox.Show("Por favor, selecione um usuarios para alterar.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ClienteLoarder.CarregarLoader(listViewClientes);
            ClienteCarregador.CarregarClientes(listViewClientes);
        }
    }
}
