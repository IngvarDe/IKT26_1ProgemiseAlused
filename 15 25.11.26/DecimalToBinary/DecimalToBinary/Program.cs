namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sisesta number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = "";

            while (num > 0)
            {
                int reminder = num % 2;
                binaryNumber = reminder + binaryNumber;
                num /= 2;
            }
            Console.WriteLine("Binnar: " + binaryNumber);
        }
    }
}
