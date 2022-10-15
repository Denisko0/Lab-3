namespace Program
{
    class App
    {
        public static void Main()
        {
            var figure = new Figure(new Point(1.3, 1.3), new Point(3.2, 3.4), new Point(4.6, 5.3));

            Console.WriteLine(figure.Name);
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}