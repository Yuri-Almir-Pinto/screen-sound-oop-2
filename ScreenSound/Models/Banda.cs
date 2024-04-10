namespace ScreenSound.Models;

class Banda(string nome)
{
    public string Nome { get; } = nome;

    public List<Album> Albuns { get; } = [];
    public List<int> Notas { get; } = [];

    public double Media => Notas.Average();

    public void Add(Album album) => Albuns.Add(album);
    public void Add(int nota) => Notas.Add(nota);
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