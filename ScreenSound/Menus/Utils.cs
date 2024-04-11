namespace ScreenSound.Menus;
internal static class Utils
{

    public static string GetStringInput(string aviso = "Por favor, insira algo.") 
    { 
        while (true)
        {
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(aviso);
                continue;
            }

            return input;
        }
    }

    public static int GetIntInput(string aviso = "Por favor, insira um número inteiro.")
    {
        while (true)
        {
            var input = GetStringInput(aviso);

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine(aviso);
                continue;
            }

            return result;
        }
    }

    public static void WaitActivity(string waitText = "(Pressione qualquer tecla para voltar)")
    {
        Console.WriteLine(waitText);
        Console.ReadKey();
    }

    public static void AsBanner(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}
