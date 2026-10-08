namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            //Random genereerib iga kord suvalise nr 1-st kuni 6-ni
            int cube = new Random().Next(1, 7);

            //kasuta switchi ja iga juhtum tuleb ära printida, mis number tuli
            switch (cube)
            {
                case 1:
                    Console.WriteLine("Täring näitas 1");
                    break;
                case 2:
                    Console.WriteLine("Täring näitas 2");
                    break;
                case 3:
                    Console.WriteLine("Täring näitas 3");
                    break;
                case 4:
                    Console.WriteLine("Täring näitas 4");
                    break;
                case 5:
                    Console.WriteLine("Täring näitas 5");
                    break;
                case 6:
                    Console.WriteLine("Täring näitas 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
