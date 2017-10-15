namespace CodeWarsWoSew
{
    public class kyu6
    {
        public static int Persistence(long n)
        {
            string sizeCandidate = n.ToString();
            int count = 0;

            while (sizeCandidate.Length > 1)
            {
                count++;
                int result = 1;
                for (int i = 0; i < sizeCandidate.Length; i++)
                {
                    result *= sizeCandidate[i];
                }
                sizeCandidate = result.ToString();
            }

            return count;
        }
    }
}