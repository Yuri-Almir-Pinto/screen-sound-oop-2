namespace ScreenSound.Models;

class Album(string nome)
{
    public string Nome { get; } = nome;

    public List<Musica> Musicas { get; } = [];

    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    

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
}