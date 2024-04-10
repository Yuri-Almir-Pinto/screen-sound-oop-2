using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class RegistrarBanda(List<Banda> banda) : Menu(banda)
{
    public override void Execute()
    {
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Utils.GetStringInput();
        var banda = new Banda(nomeDaBanda);
        Data.Add(banda);
        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Registro de banda");
    }
}
