using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WoSew.TrainingLibrary.Test.Common.Training.Exceptions
{
    [TestClass]
    public class WoSewExceptionsTest
    {
        [TestMethod]
        public void TryCatchFinally()
        {
            WoSewExceptions wsEXC = new WoSewExceptions();
            wsEXC.TryCatchFinally();
        }


    }
}