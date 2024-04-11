using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class AvaliarAlbum(List<Banda> data) : Menu(data)
{
    public override void Execute()
    {
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Utils.GetStringInput();
        var banda = FindBanda(nomeDaBanda);
        if (banda is null)
        {
            Console.WriteLine("A banda não foi encontrada :<");
            return;
        }

        Console.Write("Digite o nome do album da banda: ");
        string nomeAlbum = Utils.GetStringInput();
        var album = FindAlbum(banda, nomeAlbum);
        if (album is null)
        {
            Console.WriteLine("O album não foi encontrado :<");
            return;
        }

        Console.Write($"Qual a nota que o album {nomeAlbum} merece: ");
        Avaliacao nota = new(Utils.GetIntInput());
        album.Add(nota);
        Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album '{nomeAlbum}'");
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Avaliar album");
    }
}
