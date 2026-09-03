namespace Intro  //See on projekti nimetus
{
    internal class Program // see on klassi nimetus
    {
        //meetotit ei saa panna namespace'i, kuna see on klassi sees
        static void Main(string[] args) //see on peamine meetod, mis käivitatakse programmi käivitamisel
        {
            Console.WriteLine("Hello, World!"); // see on konsooli väljund, mis prindib "Hello, World!" ekraanile
            //Kui tahad topelt rida teha, siis vajuta Ctrl + D
            //kui tahad kustutada rida, siis vajuta Ctrl + X
        }

        //Breakpointi saab panna koodirea vasakule poolele,
        //kus on hall ruut. Kui programm jõuab
        //selle koodirea juurde, siis peatub see ja võimaldab teil
        //uurida muutujate väärtusi ja programmi olekut.
    }
}
