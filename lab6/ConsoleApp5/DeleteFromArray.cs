using System;
using System.Collections.Generic;

namespace lab6
{
    public class DeleteFromArray
    {

        public List<int> DeleteElement(List<int> array)
        {
            int first = Math.Abs(array[0]);

            for (int i = 1; i < array.Count; i++)
            {

                if (array[i] % first == 0)
                {
                    array.RemoveAt(i);
                }
            }

            return array;
        }


    }
}