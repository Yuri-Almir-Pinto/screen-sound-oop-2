namespace ScreenSound.Menus;

using OptionsDict = Dictionary<string, NavigatorOption>;

internal class Navigator
{
    private OptionsDict _options = [];

    public void Add(string selector, NavigatorOption option) => _options.Add(selector, option);
    public void Remove(string selector) => _options.Remove(selector);
    public bool Choose(string selector)
    {
        if (_options.TryGetValue(selector, out NavigatorOption? option))
        {
            option?.Call();
            return true;
        }

        return false;
    }
    public void PrintOptions()
    {
        foreach (var option in _options)
            Console.WriteLine($"{option.Key} - {option.Value.Text}");
    }
}
