﻿using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    string query = $"DELETE FROM cliente WHERE UsuarioID = {UsuarioID}";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se o registro foi excluído com sucesso
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cliente Alterado com sucesso!");
                        // Atualiza o ListView após a exclusão
                        ClienteCarregador.CarregarClientes(listViewClientes);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Alterar o usuario.");
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Alterar o usuario: {ex.Message}");
                }
            }
            else
            {
                // Exibe uma mensagem caso nenhum usuarios tenha sido selecionado
                MessageBox.Show("Por favor, selecione um usuarios para alterar.");
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ClienteLoarder.CarregarLoader(listViewClientes);
            ClienteCarregador.CarregarClientes(listViewClientes);
        }
    }
}
