namespace lr3
{
    class ArrayAnalyzer
    {
        public int Comparator(int A, int B, ref int[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > A && B > array[i])
                {
                    index = i;
                }

                else continue;
            }
            return index;
        }

    }
}
