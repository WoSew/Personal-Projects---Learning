using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BecomingDev.Models;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WebTests
    {
        public HttpClient HttpClient;



        //TDD: Red -> Green -> Refactor
        [SetUp]
        public void Setup()
        {
            HttpClient = new HttpClient();

        }

        [Test]
        public async Task http_response_should_have_204_status_code()
        {
            //Arrange
            

            //Act
            var response = await HttpClient.GetAsync("http://httpstat.us/204");

            //Assert

            //checks whether the method has been performed
         
            response.Should().NotBeNull();
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.NoContent);
        }
    }
}