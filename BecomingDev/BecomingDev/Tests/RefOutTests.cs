using BecomingDev.Test;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests
{
    [TestFixture]
    public class RefOutTests
    {
        [Test]
        public void Test()
        {
            int i = 15;

            RefOut.Test(i);
            RefOut.TestRef(ref i);
            RefOut.TestOut(out i);
        }
    }
}