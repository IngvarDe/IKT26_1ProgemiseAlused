namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else 
            //kirjuta automark
            //valikus on BMW, Audi, Porsche, Fiat ja Skoda
            //Kui valitakse Škoda, siis seal sees on uuesti küsimus, et 
            //mis mudelit soovid valida. Mudeli valikus Kodiaq ja Octavia

            Console.WriteLine("Sisesta autofirma");
            string car = Console.ReadLine();

            if (car == "BMW")
            {
                Console.WriteLine("Valisid BMW");
            }
            else if (car == "Audi")
            {
                Console.WriteLine("Valisid Audi");
            }
            else if (car == "Porsche")
            {
                Console.WriteLine("Valisid Porsche");
            }
            else if (car == "Fiat")
            {
                Console.WriteLine("Valisid Fiat");
            }
            else if (car == "Skoda")
            {
                Console.WriteLine("Valisid Skoda");
                Console.WriteLine("Sisesta automudel, kas Kodiaq v]i Octavia");
                string model = Console.ReadLine();
                if (model == "Kodiaq")
                {
                    Console.WriteLine("Valisid Kodiaqi");
                }
                else
                {
                    Console.WriteLine("valisid Octavia");
                }
            }
            else
            {
                Console.WriteLine("Ei valinud autot");
            }
        }
    }
}
