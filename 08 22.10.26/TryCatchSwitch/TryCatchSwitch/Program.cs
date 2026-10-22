namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch Switch");


            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;
                }
            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");            
            }
            //kui number on suurem, kui int 32 bit-i
            catch (OverflowException)
            {
                Console.WriteLine("Number on liiga suur");
            }
        }
    }
}
