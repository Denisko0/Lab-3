namespace Program
{
    class App
    {
        public static void Main()
        {
            var invoice = new Invoice(117, "Donald", "Osama Sushi");
            invoice.Article = "Futomaki set";
            invoice.SetQuantity(10);

            invoice.Print();
        }
    }
}
