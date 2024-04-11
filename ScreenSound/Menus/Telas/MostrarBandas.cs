using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class MostrarBandas(List<Banda> banda) : Menu(banda)
{
    public override void Execute()
    {
        foreach (var banda in Data)
        {
            Console.WriteLine(banda.AsList);
        }
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Mostrar Bandas");
    }
}
