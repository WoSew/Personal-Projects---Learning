using BecomingDev.Test;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ReflectionExampleTest
    {
        [Test]
        public void Test()
        {
            ReflectionExample reffff = new ReflectionExample();

            reffff.TestReflection();
        }
    }
}