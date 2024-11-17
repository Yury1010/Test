namespace ABCS.Test.Infrastructure.Datas.Check.Generated
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRs
    {

        private QBXMLQBXMLMsgsRsCheckQueryRs checkQueryRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRs CheckQueryRs
        {
            get
            {
                return this.checkQueryRsField;
            }
            set
            {
                this.checkQueryRsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRs
    {

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRet[] checkRetField;

        private byte requestIDField;

        private byte statusCodeField;

        private string statusSeverityField;

        private string statusMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CheckRet")]
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRet[] CheckRet
        {
            get
            {
                return this.checkRetField;
            }
            set
            {
                this.checkRetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte requestID
        {
            get
            {
                return this.requestIDField;
            }
            set
            {
                this.requestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string statusSeverity
        {
            get
            {
                return this.statusSeverityField;
            }
            set
            {
                this.statusSeverityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string statusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRet
    {

        private string txnIDField;

        private System.DateTime timeCreatedField;

        private System.DateTime timeModifiedField;

        private uint editSequenceField;

        private ushort txnNumberField;

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAccountRef accountRefField;

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRetPayeeEntityRef payeeEntityRefField;

        private string refNumberField;

        private System.DateTime txnDateField;

        private decimal amountField;

        private string memoField;

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddress addressField;

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddressBlock addressBlockField;

        private bool isToBePrintedField;

        private QBXMLQBXMLMsgsRsCheckQueryRsCheckRetLinkedTxn linkedTxnField;

        /// <remarks/>
        public string TxnID
        {
            get
            {
                return this.txnIDField;
            }
            set
            {
                this.txnIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime TimeCreated
        {
            get
            {
                return this.timeCreatedField;
            }
            set
            {
                this.timeCreatedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime TimeModified
        {
            get
            {
                return this.timeModifiedField;
            }
            set
            {
                this.timeModifiedField = value;
            }
        }

        /// <remarks/>
        public uint EditSequence
        {
            get
            {
                return this.editSequenceField;
            }
            set
            {
                this.editSequenceField = value;
            }
        }

        /// <remarks/>
        public ushort TxnNumber
        {
            get
            {
                return this.txnNumberField;
            }
            set
            {
                this.txnNumberField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAccountRef AccountRef
        {
            get
            {
                return this.accountRefField;
            }
            set
            {
                this.accountRefField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRetPayeeEntityRef PayeeEntityRef
        {
            get
            {
                return this.payeeEntityRefField;
            }
            set
            {
                this.payeeEntityRefField = value;
            }
        }

        /// <remarks/>
        public string RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TxnDate
        {
            get
            {
                return this.txnDateField;
            }
            set
            {
                this.txnDateField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string Memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddressBlock AddressBlock
        {
            get
            {
                return this.addressBlockField;
            }
            set
            {
                this.addressBlockField = value;
            }
        }

        /// <remarks/>
        public bool IsToBePrinted
        {
            get
            {
                return this.isToBePrintedField;
            }
            set
            {
                this.isToBePrintedField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCheckQueryRsCheckRetLinkedTxn LinkedTxn
        {
            get
            {
                return this.linkedTxnField;
            }
            set
            {
                this.linkedTxnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAccountRef
    {

        private string listIDField;

        private string fullNameField;

        /// <remarks/>
        public string ListID
        {
            get
            {
                return this.listIDField;
            }
            set
            {
                this.listIDField = value;
            }
        }

        /// <remarks/>
        public string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRetPayeeEntityRef
    {

        private string listIDField;

        private string fullNameField;

        /// <remarks/>
        public string ListID
        {
            get
            {
                return this.listIDField;
            }
            set
            {
                this.listIDField = value;
            }
        }

        /// <remarks/>
        public string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddress
    {

        private string addr1Field;

        private string addr2Field;

        private string addr3Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

        private bool postalCodeFieldSpecified;

        /// <remarks/>
        public string Addr1
        {
            get
            {
                return this.addr1Field;
            }
            set
            {
                this.addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return this.addr2Field;
            }
            set
            {
                this.addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return this.addr3Field;
            }
            set
            {
                this.addr3Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostalCodeSpecified
        {
            get
            {
                return this.postalCodeFieldSpecified;
            }
            set
            {
                this.postalCodeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRetAddressBlock
    {

        private string addr1Field;

        private string addr2Field;

        private string addr3Field;

        private string addr4Field;

        /// <remarks/>
        public string Addr1
        {
            get
            {
                return this.addr1Field;
            }
            set
            {
                this.addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return this.addr2Field;
            }
            set
            {
                this.addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return this.addr3Field;
            }
            set
            {
                this.addr3Field = value;
            }
        }

        /// <remarks/>
        public string Addr4
        {
            get
            {
                return this.addr4Field;
            }
            set
            {
                this.addr4Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QBXMLQBXMLMsgsRsCheckQueryRsCheckRetLinkedTxn
    {

        private string txnIDField;

        private string txnTypeField;

        private System.DateTime txnDateField;

        private ushort refNumberField;

        private string linkTypeField;

        private decimal amountField;

        /// <remarks/>
        public string TxnID
        {
            get
            {
                return this.txnIDField;
            }
            set
            {
                this.txnIDField = value;
            }
        }

        /// <remarks/>
        public string TxnType
        {
            get
            {
                return this.txnTypeField;
            }
            set
            {
                this.txnTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TxnDate
        {
            get
            {
                return this.txnDateField;
            }
            set
            {
                this.txnDateField = value;
            }
        }

        /// <remarks/>
        public ushort RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        public string LinkType
        {
            get
            {
                return this.linkTypeField;
            }
            set
            {
                this.linkTypeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

}
