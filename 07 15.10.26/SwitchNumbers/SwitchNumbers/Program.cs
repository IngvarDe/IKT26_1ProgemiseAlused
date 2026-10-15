namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisest number!");
            //tuleb teha switch, kus esimene case on 10, teine on 20 ja kolmas on 30

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 10:
                    Console.WriteLine("Sisestasid 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid 30");
                    break;

                default:
                    Console.WriteLine("Mingi muu number: " + input);
                    break;
            }
        }
    }
}
