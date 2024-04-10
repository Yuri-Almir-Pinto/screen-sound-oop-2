namespace ScreenSound.Models;
internal class Avaliacao(int nota)
{
    private int _nota = nota;
    public int Nota 
    { 
        get => _nota; 
        set 
        { 
            Alteracao = DateTime.Now;
            _nota = value;
        } 
    }
    public DateTime Momento { get; } = DateTime.Now;
    public DateTime Alteracao { get; private set; } = DateTime.Now;

    public static Avaliacao Parse(string texto)
    {
        var success = int.TryParse(texto, out var nota);
        if (success) return new(nota);
        else throw new FormatException("Erro ao tentar converter a nota em texto para inteiro na avaliação.");
    }
}
