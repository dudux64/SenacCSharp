// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Net.Http.Json;
using System.Reflection.Metadata;
// Define o modelo do pedido
public class Tarefa
{
    public int Id { get; set; }
    public string Titulo{ get; set; }
    public bool Concluida { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7117/api/Tarefas";

        Console.WriteLine("Programa Api");
        Console.WriteLine("Qual o Titulo");
        string Titulo = Console.ReadLine();

        bool concluido = false;
        Console.Write("A tarefa está concluída? (Sim/Não): ");
        String resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        { 
            concluido=true;
        }

        // Cria um novo pedido
        Tarefa novaTarefa = new Tarefa
        {
            Titulo = Titulo,
            Concluida = concluido,
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novaTarefa);

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