using ScreenSound.Extensions;
using ScreenSound.Models.Interfaces;
using System.Text;

namespace ScreenSound.Models;

internal class Banda(string nome) : ISummary
{
    public string Nome { get; } = nome;

    public List<Album> Albuns { get; } = [];
    public List<Avaliacao> Notas { get; } = [];

    public double Media => Notas.Count > 0 ? Notas.Average(n => n.Nota) : 0;
    public string Summary => _summary();
    public string AsList => $"- {Nome} | Média: {string.Format("{0:0.0}", Media)}";

    public string _summary()
    {
        var str = new StringBuilder();
        
        str.AppendLine($"Nome: {Nome}");
        if (Albuns.Count > 0 )
        {
            str.AppendLine($"Albuns:");
            foreach (var Albuns in Albuns )
            {
                str.AppendLine($"{Albuns.AsList}");
            }
        }
        if (Notas.Count > 0)
            str.AppendLine($"Notas: {string.Join(", ", Notas)}.");

        return str.ToString();
    }

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