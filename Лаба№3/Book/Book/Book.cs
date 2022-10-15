namespace Program;

public class Book
{
    private List<BookDescription> descriptions = new List<BookDescription>();

    public void AddProperty(BookDescription description)
    {
        var index = descriptions.FindIndex(bookDescription => bookDescription.EqualName(description));

        if (index != -1)
        {
            descriptions.RemoveRange(index, 1);
        }

        descriptions.Add(description);
    }

    public void Show()
    {
        foreach (var property in descriptions)
        {
            property.Show();
        }
    }
}