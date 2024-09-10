// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Net.Http.Json;
// Define o modelo do pedido
public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string Item { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorTotal { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7176/api/pedido";

        Console.WriteLine("Carlos Lanches");

        Console.WriteLine("Nome do Cliente");
        string nome = Console.ReadLine();

        Console.WriteLine("nome do item do pedido");
        string item = Console.ReadLine();

        Console.WriteLine("Quantidade");
        int Qtd = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Valor");
        int value = Convert.ToInt32(Console.ReadLine());

        // Cria um novo pedido
        Pedido novoPedido = new Pedido
        {
            Cliente = nome,
            Item = item,
            Quantidade = Qtd,
            ValorTotal = value
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoPedido);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Pedido enviado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao enviar o pedido.");
            }
        }

    }
}