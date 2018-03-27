namespace lab4
{
    class ElementsReshuffle
    {
        public int[] Reshuffler(int[] array)
        {
            int temp = array[2];
            array[2] = array[4];
            array[4] = temp;

            return  array;
        }
    }
}
