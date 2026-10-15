namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni 100,
            //Teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasutada switchi

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Number vahemikus 0-100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Number vahemikus 0-100");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Number vahemikus 0-100");
                    break;

                default:
                    Console.WriteLine("Number ei ole vahemikus 0 kuni 300");
                    break;
            }
        }
    }
}
