namespace IfElseFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta nimi");
            string name = Console.ReadLine();

            if (name == "Mati")
            {
                Console.WriteLine("Tere Mati");
            }
            else
            {
                Console.WriteLine("Sina ei ole Mati, vaid hoopis " + name);
            }
        }
    }
}
