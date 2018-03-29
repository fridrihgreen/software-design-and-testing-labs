namespace lab5
{
    class ArrayInsert
    {
        public int NewLengthDeterm(int[] array, int size)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] % 2 != 0)
                {
                    j++;
                }
            }

            return j;
        }

        public int[] MaxInserter(int j, int[] array, int size, int max)
        {
        int[] newArray = new int[size + j];

            for (int i = 0, k = 0; i < size; i++)
            {
                if (array[i] < 0 && array[i] % 2 != 0)
                {
                    newArray[k] = array[i];
                    newArray[k + 1] = max;
                    k++;
                }
                else
                {
                    newArray[k] = array[i];
                }
                k++;
            }

            return newArray;
        }
    }
}
