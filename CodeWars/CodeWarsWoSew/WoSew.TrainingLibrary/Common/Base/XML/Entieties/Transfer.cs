using System.Xml.Schema;
using System.Xml.Serialization;

namespace WoSew.TrainingLibrary.Common.Base.XML
{
    [XmlRoot("transfers")]
    public class Transfer : TransferBase
    {
        [XmlAttribute("bank")]
        public string Bank { get; set; }

        [XmlElement("owner")]
        public string Owner { get; set; }
        
        [XmlElement("sum")]
        public string Sum { get; set; }
        
        [XmlElement("sourceAccount")]
        public string SourceAccount { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }
    }

    [XmlRoot("transfers")]
    public class Transfers
    {
        [XmlElement("transfer")]
        public Transfer[] TransfersList { get; set; }
    }
}