namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline),
            //teine jalanumbri 34 - 38 (siin on tagataust valge),
            //kolmas jalanumbri 39 - 44 (siin on tekst sinine ja tagataust kollane),
            //neljas jalanumbri 45 - 48 (siin teeb aruvti häält beep)
            //Kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit.

            Console.WriteLine("Sisesta jalanumber");
            string footNumber = Console.ReadLine();
            int foot = int.Parse(footNumber);

            if (foot >= 30 && foot <= 33)
            {
                Console.WriteLine("Jalanumber on 30 kuni 33");
            }
            else if (foot >= 34 && foot <= 38)
            {
                Console.WriteLine("Jalanumber on 34 kuni 38");
            }
            else if (foot >= 39 && foot <= 44)
            {
                Console.WriteLine("Jalanumber on 39 kuni 44");
            }
            else if (foot >= 45 && foot <= 48)
            {
                Console.WriteLine("Jalanumber on 45 kuni 48");
            }
            else
            {
                Console.WriteLine("Sinu jalanumber on väga suur või väike");
            }
        }
    }
}
