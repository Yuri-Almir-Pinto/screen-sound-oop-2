using ScreenSound.Models.Interfaces;
using ScreenSound.Extensions;

namespace ScreenSound.Models;

internal class Album(string nome) : ISummary, IAvaliavel
{
    public string Nome { get; } = nome;

    public List<Musica> Musicas { get; } = [];

    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public string AsList => $"- {Nome} ({DuracaoTotal} minutos) | Nota: {string.Format("{0:0.0}", Media)} ";
    public string Summary => 
$@"Album: {Nome}
Duração total: {DuracaoTotal} minutos
Musicas:
{Musicas.ConcatAsString(m => $"{m.AsList}\n")}";

    public List<Avaliacao> Notas { get; } = [];

    public double Media => Notas.Count > 0 ? Notas.Average(n => n.Nota) : 0;

    public void Add(Avaliacao nota) => Notas.Add(nota);

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