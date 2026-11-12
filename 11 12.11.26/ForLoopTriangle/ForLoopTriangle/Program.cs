namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("------------------------------------");
            // \n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            //for tuleb panna for loopi sisse
            int i, j, rows;

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
