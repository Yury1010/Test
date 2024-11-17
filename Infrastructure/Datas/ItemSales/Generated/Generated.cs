using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCS.Test.Infrastructure.Datas.ItemSales.Generated
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRs
    {

        private QBXMLQBXMLMsgsRsItemSalesTaxQueryRs itemSalesTaxQueryRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsItemSalesTaxQueryRs ItemSalesTaxQueryRs
        {
            get
            {
                return this.itemSalesTaxQueryRsField;
            }
            set
            {
                this.itemSalesTaxQueryRsField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsItemSalesTaxQueryRs
    {

        private QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRet[] itemSalesTaxRetField;

        private byte requestIDField;

        private byte statusCodeField;

        private string statusSeverityField;

        private string statusMessageField;

        /// <remarks/>
        [XmlElement("ItemSalesTaxRet")]
        public QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRet[] ItemSalesTaxRet
        {
            get
            {
                return itemSalesTaxRetField;
            }
            set
            {
                itemSalesTaxRetField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public byte requestID
        {
            get
            {
                return requestIDField;
            }
            set
            {
                requestIDField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public byte statusCode
        {
            get
            {
                return statusCodeField;
            }
            set
            {
                statusCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string statusSeverity
        {
            get
            {
                return statusSeverityField;
            }
            set
            {
                statusSeverityField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string statusMessage
        {
            get
            {
                return statusMessageField;
            }
            set
            {
                statusMessageField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRet
    {

        private string listIDField;

        private DateTime timeCreatedField;

        private DateTime timeModifiedField;

        private uint editSequenceField;

        private string nameField;

        private bool isActiveField;

        private string itemDescField;

        private decimal taxRateField;

        private QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRetTaxVendorRef taxVendorRefField;

        /// <remarks/>
        public string ListID
        {
            get
            {
                return listIDField;
            }
            set
            {
                listIDField = value;
            }
        }

        /// <remarks/>
        public DateTime TimeCreated
        {
            get
            {
                return timeCreatedField;
            }
            set
            {
                timeCreatedField = value;
            }
        }

        /// <remarks/>
        public DateTime TimeModified
        {
            get
            {
                return timeModifiedField;
            }
            set
            {
                timeModifiedField = value;
            }
        }

        /// <remarks/>
        public uint EditSequence
        {
            get
            {
                return editSequenceField;
            }
            set
            {
                editSequenceField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        public bool IsActive
        {
            get
            {
                return isActiveField;
            }
            set
            {
                isActiveField = value;
            }
        }

        /// <remarks/>
        public string ItemDesc
        {
            get
            {
                return itemDescField;
            }
            set
            {
                itemDescField = value;
            }
        }

        /// <remarks/>
        public decimal TaxRate
        {
            get
            {
                return taxRateField;
            }
            set
            {
                taxRateField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRetTaxVendorRef TaxVendorRef
        {
            get
            {
                return taxVendorRefField;
            }
            set
            {
                taxVendorRefField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsItemSalesTaxQueryRsItemSalesTaxRetTaxVendorRef
    {

        private string listIDField;

        private string fullNameField;

        /// <remarks/>
        public string ListID
        {
            get
            {
                return listIDField;
            }
            set
            {
                listIDField = value;
            }
        }

        /// <remarks/>
        public string FullName
        {
            get
            {
                return fullNameField;
            }
            set
            {
                fullNameField = value;
            }
        }
    }
}
