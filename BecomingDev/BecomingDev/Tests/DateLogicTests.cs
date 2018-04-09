using System;
using BecomingDev.DateMakingWaves;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DateLogicTests
    {
        private readonly DateLogic dateLogic = new DateLogic();

        [Test]
        public void GivenValidDateShouldSucceed()
        {
            //arrange
            var dateToValid = "02.03.2000";
            DateTime exceptedDateTime = new DateTime(2000, 3, 2);

            //act
            var validatedDate = dateLogic.DateValidator(dateToValid);

            //assert
            Assert.AreEqual(validatedDate, exceptedDateTime);
        }

        [Test]
       // [ExpectedException(typeof(Exception))]
        public void DateValidatorGivenInvalidDateShouldThrowAnException()
        {
            var dateToValid = "41.22.2222";

            //act
            try
            {
                dateLogic.DateValidator(dateToValid);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid date, please retry", e.Message);
                throw;
            }
        }
    }
}