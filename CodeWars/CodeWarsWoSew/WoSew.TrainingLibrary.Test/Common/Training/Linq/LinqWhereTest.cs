using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoSew.TrainingLibrary.Common.Training.Linq;

namespace WoSew.TrainingLibrary.Test.Common.Training.Linq
{
    [TestClass]
    public class LinqWhereTest
    {
        [TestMethod]
        public void LinqDeferredExecution()
        {
           Assert.IsTrue(LinqWhere.WoSewWhere());    
            
        }

    }
}