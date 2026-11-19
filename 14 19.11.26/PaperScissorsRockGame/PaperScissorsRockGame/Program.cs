namespace PaperScissorsRockGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string playerChoice = "";
            int playerPoints = 0;
            int computerPoints = 0;

            while (playerChoice != "lopeta")
            {
                Console.WriteLine("Vali: kivi, paber või käärid.");
                Console.WriteLine("Mängu lõpetamiseks kirjuta: lopeta");
                //ToLower muudab sinu kirjutatud teksti väikesteks tähtedeks
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "lõpeta")
                {
                    break;
                }    

                if (playerChoice != "kivi" &&
                    playerChoice != "paber" &&
                    playerChoice != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, Proovi uuesti.");
                    continue;
                }

                int computerNumber = random.Next(1, 4);
                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "kivi";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "paber";
                }
                else
                {
                    computerChoice = "käärid";
                }

                Console.WriteLine($"Arvuti valis: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Viik!");
                }
                else if ((playerChoice == "kivi" && computerChoice == "käärid") || //ctrl alt gr z
                        (playerChoice == "paber" && computerChoice == "kivi") ||
                        (playerChoice == "käärid" && computerChoice == "paber"))
                {
                    Console.WriteLine("Sina võitisd!");
                    playerPoints++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis!");
                    computerPoints++;
                }

                Console.WriteLine($"Punktid: sina {playerPoints} -- arvuti {computerPoints}");
                Console.WriteLine();
            }

            Console.WriteLine("Mäng on läbi");
            Console.WriteLine($"Lõpptulemus: sina {playerPoints} -- arvuti {computerPoints}");
        }
    }
}
