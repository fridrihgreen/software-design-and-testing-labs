//Заменить нулями все положительные нечетные элементы под побочной и над главной диагоналями.

using System;


namespace lab_7
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Matrix mtx = new Matrix();
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-9, 9);
                }
            }
            Console.WriteLine("Исходная матрица: ");
            mtx.Print(matrix);

            matrix = mtx.Replace(matrix);

            Console.WriteLine("\nИзмененная матрица: ");
            mtx.Print(matrix);
            Console.Read();
        }
    }
}
