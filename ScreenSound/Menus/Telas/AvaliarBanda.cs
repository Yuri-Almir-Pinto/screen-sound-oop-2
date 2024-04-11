using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class AvaliarBanda(List<Banda> banda) : Menu(banda)
{
    public override void Execute()
    {
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Utils.GetStringInput();
        var banda = FindBanda(nomeDaBanda);
        if (banda is not null)
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = new(Utils.GetIntInput());
            banda.Add(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        }
        else
        {
            Console.WriteLine("A banda não foi encontrada :<");
        }
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Avaliação banda");
    }
}
