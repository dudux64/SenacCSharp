using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_C_
{
    public class ClienteCarregador
    {

        public static void CarregarClientes(ListView listViewClientes)

        {
            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para selecionar todos os registros da tabela 'usuarios'
                string query = "select UsuarioID,Nome,Idade,Email,DataCriacao,Status,salario from cliente join usuarioperfil on cliente.UsuarioID = usuarioperfil.PerfilID;";
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
                MessageBox.Show($"Erro ao carregar usuarioss: {ex.Message}");
            }
        }
    }
    public class ClienteLoarder
    {
        public static void CarregarLoader(ListView listViewClientes)
        {
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Idade", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Email", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("DataCriação", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Salario", 100, HorizontalAlignment.Left);
            listViewClientes.FullRowSelect = true; // Ativa a seleção da linha toda
            listViewClientes.GridLines = true; // Adiciona linhas de grade para melhor visualização
            ClienteCarregador.CarregarClientes(listViewClientes);                // Carrega os usuarioss na ListView
        }
    }
}
