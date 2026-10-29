namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            //raadius * 2
            int diameter = roundRadius * 2;
            //ruudu pindala on a*a
            double squareArea = Math.Pow(diameter, 2);
            //double squareArea = diameter * diameter;

            //ümbermõõt 4 * a
            double squarePerimeter = 4 * diameter;

            Console.WriteLine("Ruudu pindala: " + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvuta ringi pindala ja ümbermõõt
            double roundArea = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi pindala: " + roundArea);
            Console.WriteLine("Ringi ümbermõõt: " + roundPerimeter);
        }
    }
}
