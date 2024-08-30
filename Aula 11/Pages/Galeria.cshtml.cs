using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class GaleriaModel : PageModel
{
    public List<Imagem> Imagens { get; set; }

    public void OnGet()
    {
        // Simula��o de uma galeria de imagens
        Imagens = new List<Imagem>
        {
            new Imagem { Url = "/images/imagem2.jpg", Descricao = "Imagem 1" },
            new Imagem { Url = "/images/imagem3.jpg", Descricao = "Imagem 2" },
            new Imagem { Url = "/images/imagem4.jpg", Descricao = "Imagem 3" },
            new Imagem { Url = "/images/imagem1.png", Descricao = "Imagem 4" }
        };
    }
}

public class Imagem
{
    public string Url { get; set; }
    public string Descricao { get; set; }
}