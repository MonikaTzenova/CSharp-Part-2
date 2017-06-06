using System;

namespace FillMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string letter = Console.ReadLine();
            int count = 1;


            switch (letter)
            {
                case "a":
                    for (int col = 0; col < n; col++)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[row, col] = count;
                            count++;
                        }
                    }
                    PrintingMatrix(n, matrix);

                    break;
                case "b":

                    for (int col = 0; col < n; col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < n; row++)
                            {
                                matrix[row, col] = count;
                                count++;
                            }
                        }
                        else
                        {
                            for (int row = n - 1; row >= 0; row--)
                            {
                                matrix[row, col] = count;
                                count++;
                            }
                        }
                    }

                    PrintingMatrix(n, matrix);
                    break;
                case "c":
                    int r = n - 1;
                    int c = 0;
                    for (int i = 0; i < n * n; i++)
                    {
                        matrix[r, c] = count;
                        r++;
                        c++;
                        count++;

                        if (r == n || c == n)
                        {
                            r--;
                            if (c == n)
                            {
                                r--;
                                c--;
                            }
                            while (r - 1 >= 0 && c - 1 >= 0)
                            {
                                r--;
                                c--;
                            }
                        }
                    }

                    PrintingMatrix(n, matrix);
                    break;
                case "d":
                    r = 0;
                    c = 0;
                    int maxRow = n - 1;
                    int maxCol = n - 1;


                    do
                    {
                        for (int i = r; i <= maxRow; i++)
                        {
                            matrix[i, c] = count;
                            count++;
                        }
                        c++;

                        for (int i = c; i <= maxCol; i++)
                        {
                            matrix[maxRow, i] = count;
                            count++;
                        }
                        maxRow--;

                        for (int i = maxRow; i >= r; i--)
                        {
                            matrix[i, maxCol] = count;
                            count++;
                        }
                        maxCol--;

                        for (int i = maxCol; i >= c; i--)
                        {
                            matrix[r, i] = count;
                            count++;
                        }
                        r++;

                    } while (count <= n * n);
                    PrintingMatrix(n, matrix);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }



            }
        static void PrintingMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {

                    if (col == (n - 1))
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
