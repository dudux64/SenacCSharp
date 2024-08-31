using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto_Shopping.Pages
{
    public class DetalhesModel : PageModel
    {
        public Filme Filme { get; set; } = new Filme();

        public void OnGet(int id)
        {
            // Simula��o de um banco de dados ou reposit�rio
            var filmes = new List<Filme>
            {
                new Filme
                {
                    Titulo = "DeadPool & Wolverine",
                    Genero = "A��o/Com�dia",
                    Duracao = 127,
                    Sessoes = "14:00, 18:00",
                    ImagemUrl = "/images/Deadpool-e-Wolverine.jpg",
                    Descricao = "Deadpool e Wolverine se unem em uma miss�o inusitada que mistura a��o e com�dia, trazendo muita adrenalina e humor negro. Eles precisam enfrentar uma amea�a que desafia suas habilidades enquanto lidam com suas pr�prias diferen�as."
                },
                new Filme
                {
                    Titulo = "Divertida Mente 2",
                    Genero = "Infantil/Com�dia",
                    Duracao = 96,
                    Sessoes = "16:00, 20:00",
                    ImagemUrl = "/images/DivertidaMente2.jpeg",
                    Descricao = "Riley est� crescendo, e com isso, novas emo��es surgem em sua mente. Alegria, Tristeza, Raiva, Medo e Nojinho voltam para novas aventuras enquanto tentam ajudar Riley a navegar pelas complexidades da adolesc�ncia."
                },
                new Filme
                {
                    Titulo = "Meu Malvado Favorito 4",
                    Genero = "Infantil/Com�dia",
                    Duracao = 94,
                    Sessoes = "15:00, 19:00",
                    ImagemUrl = "/images/MeuMalvadoFavorito4.jpg",
                    Descricao = "Gru e seus Minions est�o de volta para mais uma aventura hil�ria. Desta vez, Gru enfrenta um vil�o ainda mais perverso enquanto tenta equilibrar sua vida de supervil�o aposentado com sua fam�lia sempre em expans�o."
                },
                new Filme
                {
                    Titulo = "O Corvo",
                    Genero = "A��o/Fantasia",
                    Duracao = 102,
                    Sessoes = "17:00, 21:00",
                    ImagemUrl = "/images/ocorvo.jpg",
                    Descricao = "Um homem misterioso retorna do al�m-t�mulo para vingar sua pr�pria morte e a morte de sua noiva. Guiado por um corvo, ele ca�a os respons�veis e descobre que a vingan�a pode ser t�o dolorosa quanto redentora."
                },
                new Filme
                {
                    Titulo = "HellBoy e o Homem Torto",
                    Genero = "Terror/A��o",
                    Duracao = 115,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/HellBoyeoHomemTorto.png",
                    Descricao = "Hellboy enfrenta seu mais novo inimigo, o sinistro Homem Torto, em uma batalha que mistura horror e a��o. Enquanto luta para salvar a humanidade, Hellboy deve tamb�m enfrentar seus pr�prios dem�nios internos."
                },
                new Filme
                {
                    Titulo = "Luccas e Gi em Dinossauros",
                    Genero = "Infantil/Aventura",
                    Duracao = 91,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg",
                    Descricao = "Luccas e Gi embarcam em uma aventura pr�-hist�rica ao serem transportados para um mundo cheio de dinossauros. Com coragem e intelig�ncia, eles precisam encontrar uma maneira de voltar para casa antes que seja tarde demais."
                }
            };

            // Encontra o filme pelo ID (posi��o na lista, por exemplo)
            Filme = filmes.ElementAtOrDefault(id - 1);  // ID 1 ser� o primeiro filme, ID 2 ser� o segundo, etc.
        }
    }
}