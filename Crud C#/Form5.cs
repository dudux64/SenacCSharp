using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ClienteLoarder.CarregarLoader(listViewClientes);
            ClienteCarregador.CarregarClientes(listViewClientes);  // Carrega os usuarioss na ListView
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

        private void button1_Click(object sender, EventArgs e)
        {

                string nome = textBox1.Text;
                string email = textBox2.Text;
                string strConexao = "server=localhost;uid=root;database=bancodedados1";
                MySqlConnection conexao = new MySqlConnection(strConexao);

                try
                {
                    conexao.Open();

                    // Query SQL para selecionar todos os registros da tabela 'usuarios'
                    string query = $"select UsuarioID,Nome,Idade,Email,DataCriacao,Status,salario \r\nfrom cliente \r\njoin usuarioperfil on cliente.UsuarioID = usuarioperfil.PerfilID where nome = '{nome}' and email = '{email}'";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Limpa os itens existentes no ListView antes de recarregar
                    listViewClientes.Items.Clear();

                    // Itera sobre os dados e os adiciona ao ListView
                    while (reader.Read())
                    {
                        // Adiciona os itens ao ListView
                        ListViewItem item = new ListViewItem(reader["UsuarioID"].ToString());
                        item.SubItems.Add(reader["nome"].ToString());
                        item.SubItems.Add(reader["idade"].ToString());
                        item.SubItems.Add(reader["email"].ToString());
                        item.SubItems.Add(reader["DataCriacao"].ToString());
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(reader["salario"].ToString());
                        listViewClientes.Items.Add(item);
                    }

                    reader.Close();
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar usuarios: {ex.Message}");
                }
            }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
