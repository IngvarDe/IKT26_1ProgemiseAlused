namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else nestimine");

            int y = 10;

            if (y == 12)
            {
                Console.WriteLine("Y võrdub 12");
            }
            else if (y > 20)
            {
                if (y == 25)
                {
                    Console.WriteLine("Y võrdub 25");
                }
                else
                {
                    Console.WriteLine("Y on vahemikus 21 kuni 24 ja 26 kuni lõpmatus");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased numbrid jälle");
            }
        }
    }
}
