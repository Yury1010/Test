using System.Xml.Serialization;
using ABCS.Test.Infrastructure.Datas.ItemSales.Generated;

namespace ABCS.Test.Infrastructure
{
    [XmlRoot("QBXML")]
    public sealed class ItemSalesInfo
    {
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs { get; set; }
    }


}
