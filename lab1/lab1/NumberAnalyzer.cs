namespace lab1
{
    class NumberAnalyzer
    {
        public string Parity(int number, string str)
        {
            if (number % 2 == 0)
            {
                str += "Четное ";
            }
            else
            {
                str += "Нечетное ";
            }
            return str;
        }

        public string CharacterCount(int number, string str)
        {
            switch (number.ToString().Length)
            {
                case 1:
                    {
                        str += "однозначное ";
                        break;
                    }
                case 2:
                    {
                        str += "двузначное ";
                        break;
                    }
                case 3:
                    {
                        str += "трехзначное ";
                        break;
                    }
                case 4:
                    {
                        str += "четырехзначное ";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            return str;
        }

    }
}
