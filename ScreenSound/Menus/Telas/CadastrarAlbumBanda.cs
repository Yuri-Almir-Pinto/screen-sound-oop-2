
using ScreenSound.Models;

namespace ScreenSound.Menus.Telas;
internal class CadastrarAlbumBanda(List<Banda> banda) : Menu(banda)
{
    public override void Execute()
    {
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeBanda = Utils.GetStringInput();

        var banda = FindBanda(nomeBanda);
        if (banda is null)
        {
            Console.WriteLine("Banda não foi encontrada :<");
            return;
        }

        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Utils.GetStringInput();

        var album = new Album(tituloAlbum);
        banda.Albuns.Add(album);

        Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
    }

    public override void ExibirTitulo()
    {
        Utils.AsBanner("Cadastrar album banda");
    }
}
