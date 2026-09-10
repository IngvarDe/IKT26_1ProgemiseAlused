namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If and else nesting");
            //Nesting tähendab, et if-else struktuuride
            //sees võib olla teisi if-else struktuure.
            //See võimaldab teha keerukamaid otsuseid ja
            //kontrollida erinevaid tingimusi.

            int number = 21;
            if (number > 9)
            {
                //kui sisestan 9, siis see if-else struktuur käivitub
                if (number == 11)
                {
                    //kui sisestan 11, siis see if-else struktuur käivitub
                    Console.WriteLine("Number on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            else if (number == 21)
            {
                Console.WriteLine("Vastus oli 21");
            }
            else if (number == 30)
            {
                Console.WriteLine("Vastus oli 30");
            }
            else
            {
                Console.WriteLine("Mingi kahtlane number");
            }
        }
    }
}
