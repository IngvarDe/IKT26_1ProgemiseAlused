namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            //Tee kolm meetodit, mis teevad järgmist:
            //esimene ütleb: auh
            //teine ütleb: tahan magada
            //kolmas ütleb: tahan õppida
            //Need tuleb esile kutsuda numbri valikuga
            //Tuleb kasutada switchi
            //Tuleb teha menüü, kus kasutaja saab valida, millist meetodit ta tahab esile kutsuda
            Console.WriteLine("Vali meetod (1-3):");
            Console.WriteLine("1. auh");
            Console.WriteLine("2. tahan magada");
            Console.WriteLine("3. tahan õppida");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Auh();
                    break;
                case 2:
                    Sleep();
                    break;
                case 3:
                    Study();
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        static void Auh()
        {
            Console.WriteLine("auh");
        }
        static void Sleep()
        {
            Console.WriteLine("tahan magada");
        }
        static void Study()
        {
            Console.WriteLine("tahan õppida");
        }
    }
}
