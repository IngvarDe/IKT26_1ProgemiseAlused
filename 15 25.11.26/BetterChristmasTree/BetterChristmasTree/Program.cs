namespace BetterChristmasTree
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter tree height (at least 8): ");

            if (!int.TryParse(Console.ReadLine(), out int height) || height < 8)
            {
                Console.WriteLine("Please enter a number of at least 8.");
                return;
            }

            var random = new Random();
            var ornaments = new Dictionary<(int row, int col), ConsoleColor>();
            ConsoleColor[] colors =
            {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
            ConsoleColor.Magenta
        };

            int layerCount = 4;
            int rowsPerLayer = height / layerCount;
            int totalRows = rowsPerLayer * layerCount;

            // Place random ornaments on the tree.
            for (int row = 0; row < totalRows; row++)
            {
                int layer = row / rowsPerLayer;
                int rowInLayer = row % rowsPerLayer;
                int width = 2 * (rowInLayer + 1) + layer * 4 - 1;

                for (int col = 0; col < width; col++)
                {
                    if (random.Next(18) == 0)
                        ornaments[(row, col)] = colors[random.Next(colors.Length)];
                }
            }

            int widestWidth = 2 * rowsPerLayer + (layerCount - 1) * 4 - 1;
            int trunkWidth = 3;
            int treeLeft = height - widestWidth / 2;
            int trunkIndent = treeLeft + (widestWidth - trunkWidth) / 2;

            Console.CursorVisible = false;

            try
            {
                while (true)
                {
                    Console.SetCursorPosition(0, 0);

                    // Tree top
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', height) + "O");

                    // Stacked triangular branches
                    for (int row = 0; row < totalRows; row++)
                    {
                        int layer = row / rowsPerLayer;
                        int rowInLayer = row % rowsPerLayer;
                        int width = 2 * (rowInLayer + 1) + layer * 4 - 1;
                        int leftIndent = height - width / 2;

                        Console.Write(new string(' ', leftIndent));

                        for (int col = 0; col < width; col++)
                        {
                            if (ornaments.TryGetValue((row, col), out ConsoleColor color)
                                && random.Next(2) == 0)
                            {
                                Console.ForegroundColor = color;
                                Console.Write("O");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("*");
                            }
                        }

                        Console.WriteLine();
                    }

                    // Centered trunk
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    for (int row = 0; row < 3; row++)
                    {
                        Console.Write(new string(' ', trunkIndent));
                        Console.WriteLine(new string('#', trunkWidth));
                    }

                    Console.ResetColor();
                    Thread.Sleep(350);

                    if (Console.KeyAvailable &&
                        Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            finally
            {
                Console.ResetColor();
                Console.CursorVisible = true;
            }
        }
    }
}
