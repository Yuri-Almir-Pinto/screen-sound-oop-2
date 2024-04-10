namespace ScreenSound.Models;

internal class Banda(string nome)
{
    public string Nome { get; } = nome;

    public List<Album> Albuns { get; } = [];
    public List<Avaliacao> Notas { get; } = [];

    public double Media => Notas.Average(n => n.Nota);

    public void Add(Album album) => Albuns.Add(album);
    public void Add(int nota) => Notas.Add(new(nota));
    public void Add(Avaliacao nota) => Notas.Add(nota);
    public void Add(List<int> notas) => notas.ForEach(Add);

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}