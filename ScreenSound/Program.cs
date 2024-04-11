using ScreenSound.Menus;
using ScreenSound.Menus.Telas;
using ScreenSound.Models;

namespace ScreenSound;

class Program
{
    public static List<Banda> bandasRegistradas = [];
    static void Main()
    {
        var linkinPark = new Banda("Linkin Park");
        linkinPark.Add([10, 8, 7]);
        var theBeatles = new Banda("The Beatles");
        theBeatles.Add([10, 8, 7]);

        bandasRegistradas.Add(linkinPark);
        bandasRegistradas.Add(theBeatles);

        bool run = true;

        var menu = new Navigator();
        menu.Add("1", new("Registar uma banda", new RegistrarBanda(bandasRegistradas)));
        menu.Add("2", new("Registrar album da banda", new CadastrarAlbumBanda(bandasRegistradas)));
        menu.Add("3", new("Mostrar todas as bandas", new MostrarBandas(bandasRegistradas)));
        menu.Add("4", new("Avaliar uma banda", new AvaliarBanda(bandasRegistradas)));
        menu.Add("5", new("Avaliar um album", new AvaliarAlbum(bandasRegistradas)));
        menu.Add("6", new("Exibir detalhes de uma banda", new ExibirDetalhesBanda(bandasRegistradas)));
        menu.Add("0", new("Sair", () => { run = false; }));

        while (run)
        {
            Menu.Logo();

            menu.PrintOptions();

            Console.WriteLine("\nSelecione uma opção: ");

            var input = Utils.GetStringInput();

            var isValid = menu.Choose(input);

            if (!isValid)
            {
                Console.WriteLine("Opção inválida.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }


    
}