using System.Xml.Serialization;
using ABCS.Test.Infrastructure.Datas.Invoice.Generated;

namespace ABCS.Test.Infrastructure
{
    [XmlRoot("QBXML")]
    public class InvoiceInfo
    {
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs { get; set; }
    }
}
