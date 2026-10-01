namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Värvide valikuks on: red, blue, green ja white. " +
                "Sisesta värv");


            Console.WriteLine("Sisesta värv");
            string varv = Console.ReadLine();

            if (varv == "red")
            {
                Console.WriteLine("See on punane värv");
            }
            else if (varv == "blue")
            {
                Console.WriteLine("See on sinine");
            }
            else if (varv == "green")
            {
                Console.WriteLine("See on roheline");
            }
            else if (varv == "white")
            {
                Console.WriteLine("See on valge");
            }
            else
            {
                Console.WriteLine("Sisestasid suvalise värvi");
            }
        }
    }
}
