namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid
            string input = Console.ReadLine();

            //kontrollime, kas sisestatud väärtus on number
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Sisestatud number on: {number}");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus ei ole number.");
            }
        }
    }
}
