using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Digite o nome ou número do Pokémon: ");
        string pokemon = Console.ReadLine()?.ToLower();

        try
        {
            string respostaPokemon = await ObterDadosPokemon(pokemon);
            Console.WriteLine(respostaPokemon);
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter dados do Pokémon: {ex.Message}");
            Console.ReadKey();
        }
    }

    static async Task<string> ObterDadosPokemon(string pokemon)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string id = json["id"].ToString();
                string nome = json["name"].ToString();
                string altura = json["height"].ToString();
                string peso = json["weight"].ToString();
                string tipo = json["types"][0]["type"]["name"].ToString();
                string exp = json["base_experience"].ToString();
                string order = json["order"].ToString();
                string movimento = json["moves"][0]["move"]["name"].ToString();

                return $"Pokémon: {nome}\nId:{id}\nAltura: {altura} dm\nPeso: {peso} hg\nTipo: {tipo} \nExp:{exp} \nOrdem:{order} \nMove:{movimento}";
            }
            else
            {
                throw new Exception("Não foi possível obter os dados do Pokémon.");
            }
        }
    }


}


