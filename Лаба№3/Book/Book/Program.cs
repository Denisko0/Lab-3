namespace Program
{
    class App
    {
        public static void Main()
        {
            var book = new Book();

            BookDescription[] props = { new Title("Way of the Samurai"), new Author("Yamamoto Cunetemo"), new Content("He was born ...") };

            foreach (var description in props)
            {
                book.AddProperty(description);
            }

            book.Show();
        }
    }
}