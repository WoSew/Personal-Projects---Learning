using System;
using BecomingDev.Models;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class OrderProcessorTests
    {
        public User User;
        public Order Order;

        public Mock<IDatabase> DatabaseMock;

        public Mock<IEmailSender> EmailSenderMock;

        public IOrdrerProcessor OrderProcessor;     //SUT - system under test
        
        //TDD: Red -> Green -> Refactor
        [SetUp]
        public void Setup()
        {
            User = new User("user1@email.com", "secret");
            Order = new Order(1,10);
            DatabaseMock = new Mock<IDatabase>();
            EmailSenderMock = new Mock<IEmailSender>();

            DatabaseMock.Setup( x => x.GetUser(It.IsAny<string>()))
                .Returns(User);
            DatabaseMock.Setup( x => x.GetOrder(It.IsAny<int>()))
                .Returns(Order);

            OrderProcessor = new OrderProcessor(DatabaseMock.Object, EmailSenderMock.Object);
        }

        [Test]
        public void process_order_should_succeed()
        {
            //Arrange
            User.IncreaseFunds(100);

            //Act
            OrderProcessor.ProcessOdrer(User.Email, Order.Id);

            //Assert

            //checks whether the method has been performed
            DatabaseMock.Verify(x=>x.GetUser(It.IsAny<string>()), Times.Once);
            DatabaseMock.Verify(x=>x.GetOrder(It.IsAny<int>()), Times.Once);

            Assert.IsTrue(Order.IsPurchased);

            //fluent assertion
            Order.IsPurchased.Should().BeTrue();
        }
    }
}