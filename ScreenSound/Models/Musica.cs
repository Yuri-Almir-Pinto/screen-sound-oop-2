using ScreenSound.Models.Interfaces;

namespace ScreenSound.Models;

internal class Musica(Banda artista, string nome, int duracao, bool disponivel) : ISummary
{
    public string Nome { get; } = nome;
    public int Duracao { get; set; } = duracao;
    public bool Disponivel { get; set; } = disponivel;

    public Banda Artista { get; } = artista;

    public string AsList => $"- {Nome} | {Duracao} minutos (Feito por {Artista.Nome} - {(Disponivel ? "Disponível" : "Plus+")})";
    public string Summary =>
                            $@"Nome: {Nome}
                            Artista: {Artista.Nome}
                            Duração: {Duracao}
                            {(Disponivel ? "Disponível no plano." : "Adquira o plano Plus+")}";
}