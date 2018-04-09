using System;

namespace BecomingDev.Test
{
    public class TryCatchException
    {
        public void TryCatch()
        {
            object o2 = null;

            try
            {
                int i2 = (int) o2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }

        public void TryCatch2(string s)
        {
            if (s == null)
            {
                throw new ArgumentException();
            }
        }

        public void TRyCatch3()
        {
            try
            {
                string s = null;
                TryCatch2(s);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} Zero exception caught", e);
            }

            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught", e);
            }
        }

    }

}