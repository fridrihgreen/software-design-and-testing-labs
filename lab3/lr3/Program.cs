/*Дан целочисленный массив A размера 11. Вывести номер первого из
тех его элементов A[i], которые удовлетворяют двойному
неравенству: A[1] < A[i] < A[10]. Если таких элементов нет, то
вывести 0.*/

using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[11];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
            }

            int A = array[1];
            int B = array[10];

            ArrayAnalyzer indexFinder = new ArrayAnalyzer();
            int index = indexFinder.Comparator(A, B, ref array);

            Console.Write("Массив из случайных чисел от 0 до 20: \n");
            foreach (int i in array)
                Console.Write(i + " ");

            Console.WriteLine("\n\nРезультат: ");

            if (index == -1)
                Console.WriteLine("\n00");
            else
                Console.WriteLine("\n" + array[index] + "[" + index + "]");

            Console.ReadLine();
        }
    }
}
