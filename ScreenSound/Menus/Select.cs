namespace ScreenSound.Menus;

using OptionsDict = Dictionary<string, SelectOption>;

internal class Select
{
    private OptionsDict _options = [];

    public void Add(string selector, SelectOption option) => _options.Add(selector, option);
    public void Remove(string selector) => _options.Remove(selector);
    public void Choose(string selector)
    {
        if (_options.TryGetValue(selector, out SelectOption? option))
            option?.Call();
    }
    public void PrintOptions()
    {
        foreach (var option in _options)
            Console.WriteLine($"{option.Key} - {option.Value.Text}");
    }
}
