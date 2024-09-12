// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Net.Http.Json;
public class Pedido
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public float Valor { get; set; }
    public int Quantidade { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7068/api/Produto";

        Console.WriteLine("Controlador de Pedidos");

        Console.WriteLine("Nome do Produto:");
        string nome = Console.ReadLine();

        Console.WriteLine("Quantidade:");
        int quantidade = int.Parse(Console.ReadLine());


        Console.WriteLine("Valor Total:");
        float valor = float.Parse(Console.ReadLine());

        while (valor <= 10)
        {
            Console.WriteLine("O valor Está abaixo de R$10");
            valor = float.Parse(Console.ReadLine());
        }

        // Cria um novo pedido
        Pedido novoPedido = new Pedido
        {
            Nome = nome,
            Quantidade = quantidade,
            Valor = valor
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoPedido);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Pedido enviado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao enviar o pedido. Código de status: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao enviar o pedido: " + ex.Message);
            }
        }
        Console.ReadKey();
    }
}

