//Дано целое число, лежащее в диапазоне от 1 до 9999. 
//Вывести строку — словесное описание данного числа вида "четное двузначное число", "нечетное четырехзначное число" и т.д. 

using System;

namespace lab1
{
    class NumberDescription
    {
        public static void Main()
        {
            NumberAnalyzer analyzer = new NumberAnalyzer();
            Console.Write("Введите число в диапазоне [1;9999]: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = string.Empty;

            str = analyzer.Parity(number, str);
            str = analyzer.CharacterCount(number, str);

            str += "число";
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

