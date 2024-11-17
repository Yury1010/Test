namespace ABCS.Test.Infrastructure.Datas.Bill.Generated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class QBXML
    {

        private QBXMLQBXMLMsgsRs qBXMLMsgsRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs
        {
            get
            {
                return this.qBXMLMsgsRsField;
            }
            set
            {
                this.qBXMLMsgsRsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRs
    {

        private QBXMLQBXMLMsgsRsBillQueryRs billQueryRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsBillQueryRs BillQueryRs
        {
            get
            {
                return this.billQueryRsField;
            }
            set
            {
                this.billQueryRsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsBillQueryRs
    {

        private QBXMLQBXMLMsgsRsBillQueryRsBillRet[] billRetField;

        private byte requestIDField;

        private byte statusCodeField;

        private string statusSeverityField;

        private string statusMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillRet")]
        public QBXMLQBXMLMsgsRsBillQueryRsBillRet[] BillRet
        {
            get
            {
                return this.billRetField;
            }
            set
            {
                this.billRetField = value;
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
    public class QBXMLQBXMLMsgsRsBillQueryRsBillRet
    {

        private string txnIDField;

        private System.DateTime timeCreatedField;

        private System.DateTime timeModifiedField;

        private uint editSequenceField;

        private ushort txnNumberField;

        private QBXMLQBXMLMsgsRsBillQueryRsBillRetVendorRef vendorRefField;

        private QBXMLQBXMLMsgsRsBillQueryRsBillRetAPAccountRef aPAccountRefField;

        private System.DateTime txnDateField;

        private System.DateTime dueDateField;

        private decimal amountDueField;

        private string refNumberField;

        private QBXMLQBXMLMsgsRsBillQueryRsBillRetTermsRef termsRefField;

        private string memoField;

        private bool isPaidField;

        private decimal openAmountField;

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
        public QBXMLQBXMLMsgsRsBillQueryRsBillRetVendorRef VendorRef
        {
            get
            {
                return this.vendorRefField;
            }
            set
            {
                this.vendorRefField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsBillQueryRsBillRetAPAccountRef APAccountRef
        {
            get
            {
                return this.aPAccountRefField;
            }
            set
            {
                this.aPAccountRefField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        public decimal AmountDue
        {
            get
            {
                return this.amountDueField;
            }
            set
            {
                this.amountDueField = value;
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
        public QBXMLQBXMLMsgsRsBillQueryRsBillRetTermsRef TermsRef
        {
            get
            {
                return this.termsRefField;
            }
            set
            {
                this.termsRefField = value;
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
        public bool IsPaid
        {
            get
            {
                return this.isPaidField;
            }
            set
            {
                this.isPaidField = value;
            }
        }

        /// <remarks/>
        public decimal OpenAmount
        {
            get
            {
                return this.openAmountField;
            }
            set
            {
                this.openAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsBillQueryRsBillRetVendorRef
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
    public class QBXMLQBXMLMsgsRsBillQueryRsBillRetAPAccountRef
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
    public class QBXMLQBXMLMsgsRsBillQueryRsBillRetTermsRef
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
}
