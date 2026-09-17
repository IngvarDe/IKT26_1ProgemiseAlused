namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else nestimine");
            //konsool küsib numbrit
            //if võrdub 12
            //else if ja siia sisse omakorda teha if ning else. Else if tingimus on, et
            //muutuja on suurem, kui 20
            //else ja seal väljastab konsool teksti: Mingid kahtlased väärtused

            //konsool loeb ainult string andmetüüpe
            string number = Console.ReadLine();
            //muudame stringi int andmetüübiks ja kasutame Parset
            int numberInt = int.Parse(number);

            if (numberInt == 12)
            {
                Console.WriteLine("Number on 12");
            }
            else if (numberInt > 20)
            {
                if (numberInt > 30 )
                {
                    Console.WriteLine("Sinu vanus on 31 või vanem");
                }
                else
                {
                    Console.WriteLine("Sinu vanus on 21 kuni 30");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased väärtused");
            }
        }
    }
}
