namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double calculation1 = 3 + 8 / (4 - 2) * 4;
            double calculation2 = 3 + 8 / 4 - 2 * 4;
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            //kui tahad, et võtaks arvesse komakohta, siis pane nr lõppu .0
            double calculation4 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;


            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculation1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation4);
        }
    }
}
