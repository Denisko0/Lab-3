namespace Program;

public abstract class BookDescription
{
    public readonly string Name;
    protected string value;
    protected ConsoleColor color;

    public BookDescription(string value, string name, ConsoleColor color)
    {
        this.color = color;
        this.value = value;
        this.Name = name;
    }

    public void Show()
    {
        var prevColor = Console.BackgroundColor;
        Console.BackgroundColor = this.color;

        Console.WriteLine($"{Name} is {value}");

        Console.BackgroundColor = prevColor;
    }

    public bool EqualName(BookDescription description)
    {
        return Name == description.Name;
    }
}
