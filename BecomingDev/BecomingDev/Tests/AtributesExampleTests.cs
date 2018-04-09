using System;
using System.Reflection;
using NUnit.Framework;
using BecomingDev.Test;

namespace Tests
{
    [TestFixture]
    public class AtributesExampleTests
    {
        [Test]
        public void Test()
        {
            User userToTest = new User("ABCD", "Kot");

            var userPasswordAttribute = (UserPasswordAttribute)userToTest.GetType()
                .GetTypeInfo()
                .GetProperty("Password")
                .GetCustomAttributes(typeof(UserPasswordAttribute));

            var IsPasswordValid = userToTest.Password.Length == userPasswordAttribute.Length;

            Console.WriteLine(IsPasswordValid);
        }
    }
}