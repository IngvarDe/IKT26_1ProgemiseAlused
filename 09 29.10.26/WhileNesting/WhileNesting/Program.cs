namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while while sisse panna
            //while nesting
            //while kordab ennast 5 korda
            //teha vooskeem
            int a = 1;
            while (a <= 5)
            {
                //uus while
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }

                Console.WriteLine();
                a++;
            }
        }
    }
}
