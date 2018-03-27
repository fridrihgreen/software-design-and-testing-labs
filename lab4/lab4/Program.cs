//Поменять местами элементы на 3 и 5 позициях 

using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
            }

            Console.Write("Исходный массив: \n");
            foreach (int i in array)
                Console.Write(i + " ");

            ElementsReshuffle reshuffler = new ElementsReshuffle();
            int[] newArray = reshuffler.Reshuffler(array);

            Console.Write("\n\nМассив с перестановкой: \n");
            foreach (int i in newArray)
                Console.Write(i + " ");
            Console.Read();
        }
    }
}
