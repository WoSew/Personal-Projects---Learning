using System;
using BecomingDev.Models;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        public User User;
        public IDatabase Database;

        //TDD: Red -> Green -> Refactor
        [SetUp]
        public void Setup()
        {
            User = new User("user1@email.com", "secret");
            Database = new DataBase();
        }

        [Test]
        public void invoking_connect_should_set_is_connected_to_true()
        {
            //Arrange


            //Act
            Database.Connect();

            //Assert
            Assert.IsTrue(Database.IsConnected);
        }
    }
}