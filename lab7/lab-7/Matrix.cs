using System;

namespace lab_7
{
    public class Matrix
    {
        public int[,] Replace(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i < j && matrix[i, j] > 0 && matrix[i, j] % 2 != 0) || (i + j > matrix.GetLength(0) - 1 && matrix[i, j] > 0 && matrix[i, j] % 2 != 0))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        public int[,] Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}
