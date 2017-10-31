using System.Xml.Serialization;

namespace WoSew.TrainingLibrary.Common.Base.XML
{
    [XmlRoot("transfers")]
    public class TransferBase
    {
        [XmlElement("account")]
        public string Account { get; set; }
    }
}