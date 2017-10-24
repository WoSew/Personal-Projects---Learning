using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoSew.TrainingLibrary.Common.Training.Linq;

namespace WoSew.TrainingLibrary.Test.Common.Training.Linq
{
    [TestClass]
    public class LinqSortTest
    {
        [TestMethod]
        public void TestSort()
        {
            LinqSort exampleLinqSort = new LinqSort();
            exampleLinqSort.WoSewOrderBy();
        }
        
    }
}