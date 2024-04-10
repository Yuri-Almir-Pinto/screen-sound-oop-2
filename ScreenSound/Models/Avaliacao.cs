namespace ScreenSound.Models;
internal class Avaliacao(int nota)
{
    private int _nota = nota;
    public int Nota 
    {
        get => _nota;
        set
        {
            Validate(ref value);

            Alteracao = DateTime.Now;
            _nota = value;

            static void Validate(ref int nota)
            {
                if (nota < 0) nota = 0;
                if (nota > 10) nota = 10;
            }
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
