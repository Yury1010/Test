using System.Xml.Serialization;
using ABCS.Test.Infrastructure.Datas.Bill.Generated;

namespace ABCS.Test.Infrastructure
{
    [XmlRoot("QBXML")]
    public class BillInfo
    {
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs { get; set; }
    }
}
