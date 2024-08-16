namespace Livraria
{
    public partial class Form1 : Form
    {
        public double acumulador;
        public double acumuladorqtd;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            if (int.TryParse(textBox1.Text, out int qtd) && qtd > 0 && double.TryParse(textBox3.Text, out double valor))
            {
                listBox1.Items.Add($"{nome} - Quantidade: {qtd}");

                acumulador += valor * qtd;
                acumuladorqtd += qtd;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();


            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (acumuladorqtd <= 30)
            {
                label6.Text = $"Valor dos Livros: R${acumulador}";
                MessageBox.Show("Pedido Enviado Com Sucesso!", "Pedido Enviado", MessageBoxButtons.OK);
                acumulador = 0;
                acumuladorqtd = 0;
            }
            else
            {
                MessageBox.Show("Numero de Livros Insuficientes", "Falha no envio", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}