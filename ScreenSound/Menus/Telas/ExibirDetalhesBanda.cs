using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class ExibirDetalhesBanda(List<Banda> banda) : Menu(banda)
{
    public override void Execute()
    {
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Utils.GetStringInput();
        var banda = FindBanda(nomeDaBanda);
        if (banda is not null)
        {
            Console.WriteLine(banda.Summary);
        }
        else
        {
            Console.WriteLine("A banda não foi encontrada :<");
        }
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Detalhes banda");
    }
}
