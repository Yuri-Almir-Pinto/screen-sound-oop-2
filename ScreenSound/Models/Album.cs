using ScreenSound.Models.Interfaces;
using ScreenSound.Extensions;

namespace ScreenSound.Models;

internal class Album(string nome) : ISummary
{
    public string Nome { get; } = nome;

    public List<Musica> Musicas { get; } = [];

    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public string AsList => $"- {Nome} | {DuracaoTotal} minutos.";
    public string Summary => 
$@"Album: {Nome}
Duração total: {DuracaoTotal} minutos
Musicas:
{Musicas.ConcatAsString(m => $"{m.AsList}\n")}";
    

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public void List()
    {
        throw new NotImplementedException();
    }

    public void Summarize()
    {
        throw new NotImplementedException();
    }
}