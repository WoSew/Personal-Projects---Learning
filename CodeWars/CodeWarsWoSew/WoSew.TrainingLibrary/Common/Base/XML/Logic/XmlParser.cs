using System.IO;
using System.Xml.Serialization;

namespace WoSew.TrainingLibrary.Common.Base.XML
{
    public class XmlParser<T>
    {
        public T GetXmlData(string path)
        {
            using (StreamReader str = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T) serializer.Deserialize(str);
            }
        }
    }
}