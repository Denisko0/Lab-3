namespace Program
{
    class App
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first side");
            var first_side = Console.ReadLine();

            Console.WriteLine("Enter the second side");
            var second_side = Console.ReadLine();

            var rectangle = new Rectangle(double.Parse(first_side), double.Parse(second_side));

            Console.WriteLine(rectangle.ToString());
        }
    }
}