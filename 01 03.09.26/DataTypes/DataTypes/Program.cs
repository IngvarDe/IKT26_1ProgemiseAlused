namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string e tähemärkide jada, mis on defineeritud andmetüübiga string
            //andmetüüp toetab ainult true ja false väärtusi
            //myString on muutuja, mis on defineeritud andmetüübiga string
            //saab sisestada kõike, mis on klaviatuuril
            string myString = "Hello, World123!";
            //kirjutage cw ja vajutage tab, et genereerida Console.WriteLine
            Console.WriteLine(myString);
            string one = "1";
            string two = "2";
            Console.WriteLine(one + two);

            Console.WriteLine("----Täisarvud----");
            //int on täisarvuline andmetüüp, mis toetab ainult täisarve
            int myInt = 5;
            int secondInt = 10;
            Console.WriteLine(myInt);
            //kui kaks int tüüpi muutujat liita, siis liidetakse nende väärtused kokku
            Console.WriteLine(myInt + secondInt);

            Console.WriteLine("----Bool----");
            //see on andmetüüp, mis toetab ainult true ja false väärtusi
            bool myBool = true;
            Console.WriteLine(myBool);

            Console.WriteLine("----Ujukomaarvud----");
            //double on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve
            double myDouble = 5.5;
            double secondDouble = 10.5;
            Console.WriteLine(myDouble);
            //kui kaks double tüüpi muutujat liita, siis liidetakse nende väärtused kokku
            Console.WriteLine(myDouble + secondDouble);

            // float on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve
            Console.WriteLine("----Float----");
            float myFloat = 5.5f;
            float secondFloat = 10.5f;
            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat + secondFloat);

            Console.WriteLine("----Decimal----");
            //decimal on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve
            decimal myDecimal = 5.51m;
            decimal secondDecimal = 10.5m;
            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal + secondDecimal);

            Console.WriteLine("----Byte----");
            //byte on täisarvuline andmetüüp, mis toetab
            //ainult täisarve vahemikus 0 kuni 255
            //see on 8-bitine täisarvuline andmetüüp
            byte myByte = 5;
            Console.WriteLine(myByte);

            Console.WriteLine("----Long----");
            //long on täisarvuline andmetüüp, mis toetab ainult täisarve
            //selle maksimaalne väärtus on 9,223,372,036,854,775,807
            //see on 64-bitine täisarvuline andmetüüp
            long myLong = 5L;
            long secondLong = 10L;
            Console.WriteLine(myLong);
            Console.WriteLine(myLong + secondLong);

            Console.WriteLine("----Short----");
            //short on täisarvuline andmetüüp, mis toetab ainult täisarve
            //selle maksimaalne väärtus on 32,767
            //see on 16-bitine täisarvuline andmetüüp
            short myShort = 5;
            short secondShort = 10;
            Console.WriteLine(myShort);
            Console.WriteLine(myShort + secondShort);
        }
    }
}
