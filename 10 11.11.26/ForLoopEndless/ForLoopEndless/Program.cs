namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha for loopiga lõputu tsükkel,
            //mis prindib konsooli: i väärtus on: number

            //kui i väärtus on 10, siis tsükkel lõpeb
            //for loopi tingimus peab olema tühjaks jäetud, et see oleks lõputu
            short i = 1;

            for ( ; ; )
            {
                Console.WriteLine("i väärtus on: " + i);
                i++;

                if (i > 2)
                {
                    break;
                }
            }
        }
    }
}
