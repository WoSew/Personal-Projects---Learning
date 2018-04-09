using System.Reflection;

namespace BecomingDev.Test
{
    public class ReflectionExample
    {
        public void TestReflection()
        {
            User userR = new User("abcd", "KasiaKaszanka");

            var typeTest = userR.GetType();
            var typeTest2 = userR.GetType().GetTypeInfo();

            var method = typeTest2.GetMethods();
        }
        

        
    }
}