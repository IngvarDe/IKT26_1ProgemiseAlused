namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: *, /, +, -");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number!");
            float secondNr = float.Parse(Console.ReadLine());

            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel

            switch (input)
            {
                case "+":
                    //Console.Clear();
                    Console.WriteLine($"Liitmise tulemus: {firstNr} + {secondNr} = {firstNr + secondNr}");
                    break;

                case "-":
                    //Console.Clear();
                    Console.WriteLine($"Lahutamise tulemus: {firstNr} - {secondNr} = {firstNr - secondNr}");
                    break;

                case "*":
                    //Console.Clear();
                    Console.WriteLine($"Korrutamise tulemus: {firstNr} * {secondNr} = {firstNr * secondNr}");
                    break;

                case "/":
                    if (secondNr == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        //Console.Clear();
                        Console.WriteLine($"Jagamise tulemus: {firstNr} / {secondNr} = {firstNr / secondNr}");
                    }                  
                    break;

                default:
                    Console.WriteLine("Valisid vale tingmärgi");
                    break;
            }
        }
    }
}
