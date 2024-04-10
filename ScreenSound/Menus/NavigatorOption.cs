namespace ScreenSound.Menus;

internal class NavigatorOption(string text, Menu handler)
{
    public string Text { get; private set; } = text.Trim();

    public Menu Handler { get; private set; } = handler;

    public void Call() 
    {
        Console.Clear();
        Handler.Execute();
        Thread.Sleep(1500);
        Console.Clear();
    }
}