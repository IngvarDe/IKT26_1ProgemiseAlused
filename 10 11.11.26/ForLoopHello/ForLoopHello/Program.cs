namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //teha konsoolirakendus, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast ja lõpus on reanumber
            //kasutaja ei tohi sisestada midagi
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("tere tulemast " + i );
            }
        }
    }
}
