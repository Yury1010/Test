using System.Xml.Serialization;
using ABCS.Test.Infrastructure.Datas.Check.Generated;

namespace ABCS.Test.Infrastructure
{
    [XmlRoot("QBXML")]
    public class CheckInfo
    {
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs { get; set; }
    }
}
