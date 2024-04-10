namespace ScreenSound.Models;

internal class Musica(Banda artista, string nome, int duracao)
{
    public string Nome { get; } = nome;
    public int Duracao { get; set; } = duracao;
    public bool? Disponivel { get; set; }

    public Banda Artista { get; } = artista;

    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        if (Disponivel is null)
        {
            Console.WriteLine("Propriedade disponível está nula.");
            return;
        }

        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel.Value)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}