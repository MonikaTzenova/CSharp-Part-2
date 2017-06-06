using System;

class MaxAreaSumMatrix
{
    static int[,] GetMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            var values = (Console.ReadLine().Split(' '));
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(values[col]);
            }
        }
        return matrix;
    }
    static void GetMaxSumMatrix(int[,] matrix, int rows, int cols)
    {
        int maxSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currentSum = 0;
                for (int i = row; i <= row + 2; i++)
                {
                    for (int j = col; j <= col + 2; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startRow = row;
                    startCol = col;
                }
            }
        }
        Console.WriteLine(maxSum);
    }

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] matrix = GetMatrix(n, m);
        GetMaxSumMatrix(matrix, n, m);
    }
}
