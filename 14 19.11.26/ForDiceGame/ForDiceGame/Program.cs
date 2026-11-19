namespace ForDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;

            for (int round = 1; round <= 5; round++) 
            {
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);

                Console.WriteLine($"Sinu number: {playerRoll}");
                Console.WriteLine($"Arvuti number: {computerRoll}");

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("Sina võitsid vooru!");
                    playerScore++;
                }
                else if (computerRoll > playerRoll)
                {
                    Console.WriteLine("Arvuti võitis vooru!");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("Voor jäi viiki!");
                }
            }

            Console.WriteLine("Mäng läbi!");

            if (playerScore > computerScore)
            {
                Console.WriteLine("Sina võitsid kogu mängu");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("Arvuti võitis kogu mängu");
            }
            else
            {
                Console.WriteLine("Kogu mäng jäi viiki!");
            }
        }
    }
}
