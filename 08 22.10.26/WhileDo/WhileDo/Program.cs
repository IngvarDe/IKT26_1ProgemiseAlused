namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int nr = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(i);
                //++ liidab ühe numbri juurde eelnevale
                i++;
            } while (i <= nr);
        }
    }
}
