namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja prindib vastavalt ridade arvule tärne
            //kasutada for loopi
            //teha vooskeem
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
