//Вставить максимальное положительное после каждого нечетного
//отрицательного.

using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = -100;
            int size = 0;
            while (size <= 0)
            {
                Console.WriteLine("Введите количество элементов:");
                size = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (size <= 0) Console.WriteLine("Ошибка ввода!");
            }

            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
           
            ArrayInsert inserter = new ArrayInsert();
            int newIndex = inserter.NewLengthDeterm(array, size);
            int[] newArray = inserter.MaxInserter(newIndex, array, size, max);


            Console.Write("Исходный массив: \n");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n\nНовый массив: \n");
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
