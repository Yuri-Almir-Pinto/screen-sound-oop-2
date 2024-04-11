namespace ScreenSound.Menus;

internal class NavigatorOption
{
    public NavigatorOption(string text, Menu handler)
    {
        Text = text.Trim();
        Handler = handler;
        _method = Handler.Execute;
    }
    public NavigatorOption(string text, Action handler)
    {
        Text = text.Trim();
        _method = handler;
    }

    private readonly Action _method;

    public string Text { get; private set; }

    public Menu? Handler { get; private set; }
    

    public void Call() 
    {
        Console.Clear();
        Handler?.ExibirTitulo();
        _method();
        Console.WriteLine("\n\n\n");
        Utils.WaitActivity();
        Console.Clear();
    }
}