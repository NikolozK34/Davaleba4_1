using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[,] matrix = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rand.Next(-100, 101);
            }
        }
      
        Console.WriteLine("matrica:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }

        int min = int.MaxValue;
        int max = int.MinValue;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int currentNumber = matrix[i, j];
                min = Math.Min(min, currentNumber);
                max = Math.Max(max, currentNumber);
            }
        }

        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int currentNumber = matrix[i, j];

                if (currentNumber >= min && currentNumber <= max)
                {
                    sum += currentNumber;
                }
            }
        }

        Console.WriteLine($"jami aris: {sum}");
    }

}
