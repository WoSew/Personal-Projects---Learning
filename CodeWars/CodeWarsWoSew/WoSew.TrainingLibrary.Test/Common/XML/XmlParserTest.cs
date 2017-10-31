using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoSew.TrainingLibrary.Common.Base.XML;

namespace WoSew.TrainingLibrary.Test.Common.XML
{
    [TestClass]
    public class XmlParserTest
    {
        [TestMethod]
        public void XmlParserTestMetod()
        {
            XmlParser<Transfers> transferParser = new XmlParser<Transfers>();

            var XmlDataResult =
                transferParser.GetXmlData(
                    @"D:\01_Toci\97_Personal Projects - Learning\CodeWars\CodeWarsWoSew\WoSew.TrainingLibrary\Common\Base\XML\ExampleXML\WoSewXML.xml");
        }
        
    }
}