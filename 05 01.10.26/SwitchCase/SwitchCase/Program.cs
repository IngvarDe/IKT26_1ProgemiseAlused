namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");
            string character = Console.ReadLine();

            switch (character)
            {
                case "a":
                    Console.WriteLine("Sisestasid tähe a");
                    break;
                case "b":
                    Console.WriteLine("Sisestasid tähe b");
                    break;
                default:
                    Console.WriteLine("Sisestasid mõnda muud tähte");
                    break;
            }
        }
    }
}
