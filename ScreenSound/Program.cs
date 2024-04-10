using ScreenSound.Menus;
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

        var menu = new Navigator();
        menu.Add("1", new("Registar uma banda", () => Utils.ScreenPrint(RegistrarBanda)));
        menu.Add("2", new("Mostrar album da banda", () => Utils.ScreenPrint(RegistrarAlbum)));
        menu.Add("3", new("Mostrar todas as bandas", () => Utils.ScreenPrint(MostrarBandasRegistradas)));
        menu.Add("4", new("Avaliar uma banda", () => Utils.ScreenPrint(AvaliarUmaBanda)));
        menu.Add("5", new("Exibir detalhes de uma banda", () => Utils.ScreenPrint(ExibirDetalhes)));

        while (true)
        {
            Utils.ExibirLogo();
            menu.PrintOptions();

            Console.WriteLine("\nSelecione uma opção: ");

            var input = Utils.GetStringInput();
            menu.Choose(input);
        }
    }

    static void RegistrarAlbum()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        var banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (var banda in bandasRegistradas)
        {
            Console.WriteLine($"Banda: {banda.Nome}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

    static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    static void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        var banda = FindBanda(nomeDaBanda);
        if (banda is not null)
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            var nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.Add(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

    }

    static void ExibirDetalhes()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        var banda = FindBanda(nomeDaBanda);
        if (banda is not null)
        {
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    static Banda? FindBanda(string nome) => bandasRegistradas.Where(b => b.Nome.Equals(nome)).FirstOrDefault();
}