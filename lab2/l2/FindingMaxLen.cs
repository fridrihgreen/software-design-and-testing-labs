using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2
{
    public class FindingMaxLen
    {
        public string MaxLength(string input)
        {
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            return str[index];
        }
    }
}
