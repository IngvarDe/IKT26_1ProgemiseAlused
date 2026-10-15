namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("Basic");
                    break;

                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Itermediate");
                    break;

                case "Asynchronous Programming" or "LINQ" or "Delegates":
                    Console.WriteLine("Advanced");
                    break;

                default:
                    Console.WriteLine("Unknown course");
                    break;
            }
        }
    }
}
