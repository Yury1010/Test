using System.Xml.Serialization;
using ABCS.Test.Infrastructure.Datas.Company.Generated;

namespace ABCS.Test.Infrastructure
{
    [XmlRoot("QBXML")]
    public class CompanyInfo
    {
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs { get; set; }
    }
}
