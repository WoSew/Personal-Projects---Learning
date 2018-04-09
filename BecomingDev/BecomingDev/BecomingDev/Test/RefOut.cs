using System;

namespace BecomingDev.Test
{
    public static class RefOut
    {
        public static void Test(int i)
        {
            i += 10;
        }

        public static void TestRef(ref int i)
        {
            i += 10;
        }

        public static void TestOut(out int i)
        {
            i = 0;
            i += 10;
        }
    }
}