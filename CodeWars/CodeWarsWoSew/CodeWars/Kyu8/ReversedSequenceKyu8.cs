namespace CodeWars.Kyu8
{
    public static class ReversedSequenceKyu8
    {
        public static int[] ReverseSeq(int n)
        {
            int[] result = new int[n];
            var temp = n;

            for (int i = 0; i < n; i++)
            {
                result[i] = temp;
                temp--;
            }
            return result;
        }
    }
}