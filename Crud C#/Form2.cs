using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string dataCriacao = DateTime.Now.ToString("yyyy-MM-dd");
            string status = "Ativo";
            string salario = textBox3.Text;

            string strConexao = "server=localhost;uid=root;database=bancodedados1";

            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                string query = $"INSERT INTO cliente (nome, email, DataCriacao, Status) VALUES ('{nome}', '{email}', '{dataCriacao}', '{status}')";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int linhasAfetadas = cmd.ExecuteNonQuery();


                if (linhasAfetadas > 0)
                {

                    long usuarioID = cmd.LastInsertedId;


                    string querySalario = $"INSERT INTO usuarioperfil (PerfilID, salario) VALUES ('{usuarioID}', '{salario}')";
                    MySqlCommand cmdSalario = new MySqlCommand(querySalario, conexao);
                    cmdSalario.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso!");

                    ClienteCarregador.CarregarClientes(listViewClientes);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir dados.");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            ClienteLoarder.CarregarLoader(listViewClientes);
            ClienteCarregador.CarregarClientes(listViewClientes);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
