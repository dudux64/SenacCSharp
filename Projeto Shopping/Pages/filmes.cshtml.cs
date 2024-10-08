using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto_Shopping.Pages
{
    public class filmesModel : PageModel
    {
        public List<Filme> Filmes { get; set; } = new List<Filme>();

        public void OnGet()
        {
            Filmes = new List<Filme>
    {
        new Filme
        {
                Titulo = "DeadPool & Wolverine",
                Genero = "A��o/Com�dia",
                Duracao = 127,
                Sessoes = "14:00, 18:00",
                ImagemUrl = "/images/Deadpool-e-Wolverine.jpg"
            },
            new Filme
            {
                Titulo = "Divertida Mente 2",
                Genero = "Infantil/Com�dia",
                Duracao = 96,
                Sessoes = "16:00, 20:00",
                ImagemUrl = "/images/DivertidaMente2.jpeg"
            },
            new Filme
            {
                Titulo = "Meu Malvado Favorito 4",
                Genero = "Infantil/Com�dia",
                Duracao = 94,
                Sessoes = "15:00, 19:00",
                ImagemUrl = "/images/MeuMalvadoFavorito4.jpg"
            },
            new Filme
            {
                Titulo = "O Corvo",
                Genero = "A��o/Fantasia",
                Duracao = 102,
                Sessoes = "17:00, 21:00",
                ImagemUrl = "/images/ocorvo.jpg"
            },
            new Filme
            {
                Titulo = "HellBoy e o Homem Torto",
                Genero = "Terror/A��o",
                Duracao = 115,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/images/HellBoyeoHomemTorto.png"
            },
            new Filme
            {
                Titulo = "Luccas e Gi em Dinossauros",
                Genero = "Infantil/Aventura",
                Duracao = 91,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
            },
            new Filme
            {
                Titulo = "O �ltimo Guardi�o",
                Genero = "Aventura/Fantasia",
                Duracao = 142,
                Sessoes = "13:30, 17:45, 21:00",
                ImagemUrl = "/images/ultimo_guardiao.jpg",
                Descricao = "Em um mundo onde a magia est� quase extinta, um jovem escolhido deve se tornar o �ltimo guardi�o de um antigo poder. Com a ajuda de aliados improv�veis e enfrentando criaturas m�sticas, ele deve proteger o reino de uma amea�a que pode destruir tudo o que ele conhece. Uma jornada �pica cheia de a��o, magia e descobertas surpreendentes."
            }



            };

        }
    }
}
