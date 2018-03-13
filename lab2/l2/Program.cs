//Дана строка-предложение на русском языке.
//Вывести самое длинное слово в предложении (если таких слов несколько, то вывести первое из них). 

using System;

namespace l2
{
    public class Program
    {
        static void Main(string[] args)
         {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            
            FindingMaxLen word = new FindingMaxLen();

            string str = word.MaxLength(input);

                Console.Write("Самое длинное слово: {0}", str);
                Console.WriteLine();
                Console.ReadLine();
         }
    }
}
