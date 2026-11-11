namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("--------------------------------------");
            Console.Write("\n\n");

            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                //sum += j;
                sum = sum + j;
                Console.WriteLine("Summa on: " + sum);
            }
        }
    }
}
