namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //numbri arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem
            while (guess != secretNumber)
            {
                Console.WriteLine("Arva number ära 1 kuni 100-ni: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Number on liiga väike");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Number on liiga suur");
                }
            }

            Console.WriteLine($"Õige! Arvatud kordade arv: {attempts}");
        }
    }
}
