namespace ScreenSound.Models;
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        _nota = _insertNota(nota);
    }
    private int _nota;
    public int Nota 
    {
        get => _nota;
        set
        {
            _nota = _insertNota(value);
        }
    }
    public DateTime Momento { get; } = DateTime.Now;
    public DateTime Alteracao { get; private set; } = DateTime.Now;

    private int _insertNota(int nota)
    {
        Validate(ref nota);

        Alteracao = DateTime.Now;
        
        return nota;

        static void Validate(ref int nota)
        {
            if (nota < 0) nota = 0;
            if (nota > 10) nota = 10;
        }
    }

    public static Avaliacao Parse(string texto)
    {
        var success = int.TryParse(texto, out var nota);
        if (success) return new(nota);
        else throw new FormatException("Erro ao tentar converter a nota em texto para inteiro na avaliação.");
    }

    public override string ToString()
    {
        return Convert.ToString(Nota);
    }
}
