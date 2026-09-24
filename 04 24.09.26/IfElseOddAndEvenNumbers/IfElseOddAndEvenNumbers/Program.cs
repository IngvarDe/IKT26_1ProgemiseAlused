namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu nr

            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            //% jagab muutujat number 2-ga kuni võrdub 0
            if (number %2 == 0)
            {
                Console.WriteLine("See on paarisarv " + number);
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paarisarv
                EvenNumberMethod();
            }
            else
            {
                Console.WriteLine("See on paaritu number " + number);
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paarituarv
                OddNumberMethod();
            }
        }

        static void EvenNumberMethod()
        {
            Console.WriteLine("See on paarisarv");
        }

        static void OddNumberMethod()
        {
            Console.WriteLine("See on paarituarv");
        }
    }
}
