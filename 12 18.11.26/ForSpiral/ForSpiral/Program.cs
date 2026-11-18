namespace ForSpiral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int size = 7;
            int[,] matrix = new int[size, size];

            int top = 0, bottom = size - 1;
            int left = 0, right = size - 1;
            int value = 1;

            while (top <= bottom && left <= right)
            {
                for (int col = left; col <= right; col++)
                {
                    matrix[top, col] = value++;
                }
                top++;

                for (int row = top; row <= bottom; row++)
                {
                    matrix[row, right] = value++;
                }
                right--;

                if (top <= bottom)
                {
                    for (int col = right; col >= left; col--)
                    {
                        matrix[bottom, col] = value++;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int row = bottom; row >= top; row--)
                    {
                        matrix[row, left] = value++;
                    }
                    left++;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row, col],3}");
                }

                Console.WriteLine();
            }
        }
    }
}
