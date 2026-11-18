namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            //while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes
            while (word != "yes")
            {
                Console.WriteLine("Kirjuta sõna yes või midagi muud");
                word = Console.ReadLine();
            }

            Console.WriteLine("Tubli töö");
        }
    }
}
