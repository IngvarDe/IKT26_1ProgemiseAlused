namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //sisestad algarvu
            //Algarv on naturaalarv, mis jagub ainult 1 ja iseendaga.
            //Näiteks 2, 3, 5, 7 ja 11 on algarvud.
            //Arv 1 ei ole algarv. 2 on ainus paarisarvuline algarv.

            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = number > 1;



            //kontrollib, kas muutuja number v''rtus on algarv

            //i* i <= number — tsükkel jätkub seni, kuni i ruut on
            //arvust number väiksem või sellega võrdne. Piisab jagajate
            //kontrollimisest kuni ruutjuureni.
            for (int i = 2; i * i <= number; i++)
            {
                //avab ts[kli sisu. Sulgude vahel olev kood kordub
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} on algarv");
            }
            else
            {
                Console.WriteLine($"{number} ei ole algarv");
            }
        }
    }
}
