namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            //otsida Internetist While koodiga kolnurga
            //kujundeid e tegemise viise
            //kui kood on leitud, siis kirjutada see siia alla
            //teha vooskeem

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
