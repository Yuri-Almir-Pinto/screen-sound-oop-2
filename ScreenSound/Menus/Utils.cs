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

    public static void WaitActivity()
    {
        Console.ReadKey();
    }
}
