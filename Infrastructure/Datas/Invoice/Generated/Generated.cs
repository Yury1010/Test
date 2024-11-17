using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCS.Test.Infrastructure.Datas.Invoice.Generated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public class QBXML
    {

        private QBXMLQBXMLMsgsRs qBXMLMsgsRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRs QBXMLMsgsRs
        {
            get
            {
                return qBXMLMsgsRsField;
            }
            set
            {
                qBXMLMsgsRsField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRs
    {

        private QBXMLQBXMLMsgsRsInvoiceQueryRs invoiceQueryRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRs InvoiceQueryRs
        {
            get
            {
                return invoiceQueryRsField;
            }
            set
            {
                invoiceQueryRsField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRs
    {

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRet[] invoiceRetField;

        private byte requestIDField;

        private byte statusCodeField;

        private string statusSeverityField;

        private string statusMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InvoiceRet")]
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRet[] InvoiceRet
        {
            get
            {
                return invoiceRetField;
            }
            set
            {
                invoiceRetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
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
        [System.Xml.Serialization.XmlAttribute()]
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
        [System.Xml.Serialization.XmlAttribute()]
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
        [System.Xml.Serialization.XmlAttribute()]
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
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRet
    {

        private string txnIDField;

        private DateTime timeCreatedField;

        private DateTime timeModifiedField;

        private uint editSequenceField;

        private ushort txnNumberField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerRef customerRefField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetClassRef classRefField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetARAccountRef aRAccountRefField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTemplateRef templateRefField;

        private DateTime txnDateField;

        private string refNumberField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddress billAddressField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddressBlock billAddressBlockField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddress shipAddressField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddressBlock shipAddressBlockField;

        private bool isPendingField;

        private bool isFinanceChargeField;

        private string pONumberField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTermsRef termsRefField;

        private DateTime dueDateField;

        private DateTime shipDateField;

        private decimal subtotalField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetItemSalesTaxRef itemSalesTaxRefField;

        private decimal salesTaxPercentageField;

        private decimal salesTaxTotalField;

        private decimal appliedAmountField;

        private decimal balanceRemainingField;

        private string memoField;

        private bool isPaidField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerMsgRef customerMsgRefField;

        private bool isToBePrintedField;

        private bool isToBeEmailedField;

        private QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerSalesTaxCodeRef customerSalesTaxCodeRefField;

        private decimal suggestedDiscountAmountField;

        private bool suggestedDiscountAmountFieldSpecified;

        private DateTime suggestedDiscountDateField;

        private bool suggestedDiscountDateFieldSpecified;

        /// <remarks/>
        public string TxnID
        {
            get
            {
                return txnIDField;
            }
            set
            {
                txnIDField = value;
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
        public ushort TxnNumber
        {
            get
            {
                return txnNumberField;
            }
            set
            {
                txnNumberField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerRef CustomerRef
        {
            get
            {
                return customerRefField;
            }
            set
            {
                customerRefField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetClassRef ClassRef
        {
            get
            {
                return classRefField;
            }
            set
            {
                classRefField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetARAccountRef ARAccountRef
        {
            get
            {
                return aRAccountRefField;
            }
            set
            {
                aRAccountRefField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTemplateRef TemplateRef
        {
            get
            {
                return templateRefField;
            }
            set
            {
                templateRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public DateTime TxnDate
        {
            get
            {
                return txnDateField;
            }
            set
            {
                txnDateField = value;
            }
        }

        /// <remarks/>
        public string RefNumber
        {
            get
            {
                return refNumberField;
            }
            set
            {
                refNumberField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddress BillAddress
        {
            get
            {
                return billAddressField;
            }
            set
            {
                billAddressField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddressBlock BillAddressBlock
        {
            get
            {
                return billAddressBlockField;
            }
            set
            {
                billAddressBlockField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddress ShipAddress
        {
            get
            {
                return shipAddressField;
            }
            set
            {
                shipAddressField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddressBlock ShipAddressBlock
        {
            get
            {
                return shipAddressBlockField;
            }
            set
            {
                shipAddressBlockField = value;
            }
        }

        /// <remarks/>
        public bool IsPending
        {
            get
            {
                return isPendingField;
            }
            set
            {
                isPendingField = value;
            }
        }

        /// <remarks/>
        public bool IsFinanceCharge
        {
            get
            {
                return isFinanceChargeField;
            }
            set
            {
                isFinanceChargeField = value;
            }
        }

        /// <remarks/>
        public string PONumber
        {
            get
            {
                return pONumberField;
            }
            set
            {
                pONumberField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTermsRef TermsRef
        {
            get
            {
                return termsRefField;
            }
            set
            {
                termsRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public DateTime DueDate
        {
            get
            {
                return dueDateField;
            }
            set
            {
                dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public DateTime ShipDate
        {
            get
            {
                return shipDateField;
            }
            set
            {
                shipDateField = value;
            }
        }

        /// <remarks/>
        public decimal Subtotal
        {
            get
            {
                return subtotalField;
            }
            set
            {
                subtotalField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetItemSalesTaxRef ItemSalesTaxRef
        {
            get
            {
                return itemSalesTaxRefField;
            }
            set
            {
                itemSalesTaxRefField = value;
            }
        }

        /// <remarks/>
        public decimal SalesTaxPercentage
        {
            get
            {
                return salesTaxPercentageField;
            }
            set
            {
                salesTaxPercentageField = value;
            }
        }

        /// <remarks/>
        public decimal SalesTaxTotal
        {
            get
            {
                return salesTaxTotalField;
            }
            set
            {
                salesTaxTotalField = value;
            }
        }

        /// <remarks/>
        public decimal AppliedAmount
        {
            get
            {
                return appliedAmountField;
            }
            set
            {
                appliedAmountField = value;
            }
        }

        /// <remarks/>
        public decimal BalanceRemaining
        {
            get
            {
                return balanceRemainingField;
            }
            set
            {
                balanceRemainingField = value;
            }
        }

        /// <remarks/>
        public string Memo
        {
            get
            {
                return memoField;
            }
            set
            {
                memoField = value;
            }
        }

        /// <remarks/>
        public bool IsPaid
        {
            get
            {
                return isPaidField;
            }
            set
            {
                isPaidField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerMsgRef CustomerMsgRef
        {
            get
            {
                return customerMsgRefField;
            }
            set
            {
                customerMsgRefField = value;
            }
        }

        /// <remarks/>
        public bool IsToBePrinted
        {
            get
            {
                return isToBePrintedField;
            }
            set
            {
                isToBePrintedField = value;
            }
        }

        /// <remarks/>
        public bool IsToBeEmailed
        {
            get
            {
                return isToBeEmailedField;
            }
            set
            {
                isToBeEmailedField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerSalesTaxCodeRef CustomerSalesTaxCodeRef
        {
            get
            {
                return customerSalesTaxCodeRefField;
            }
            set
            {
                customerSalesTaxCodeRefField = value;
            }
        }

        /// <remarks/>
        public decimal SuggestedDiscountAmount
        {
            get
            {
                return suggestedDiscountAmountField;
            }
            set
            {
                suggestedDiscountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool SuggestedDiscountAmountSpecified
        {
            get
            {
                return suggestedDiscountAmountFieldSpecified;
            }
            set
            {
                suggestedDiscountAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public DateTime SuggestedDiscountDate
        {
            get
            {
                return suggestedDiscountDateField;
            }
            set
            {
                suggestedDiscountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool SuggestedDiscountDateSpecified
        {
            get
            {
                return suggestedDiscountDateFieldSpecified;
            }
            set
            {
                suggestedDiscountDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetClassRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetARAccountRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTemplateRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddress
    {

        private string addr1Field;

        private string addr2Field;

        private string addr3Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

        /// <remarks/>
        public string Addr1
        {
            get
            {
                return addr1Field;
            }
            set
            {
                addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return addr2Field;
            }
            set
            {
                addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return addr3Field;
            }
            set
            {
                addr3Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return cityField;
            }
            set
            {
                cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return stateField;
            }
            set
            {
                stateField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return postalCodeField;
            }
            set
            {
                postalCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetBillAddressBlock
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
                return addr1Field;
            }
            set
            {
                addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return addr2Field;
            }
            set
            {
                addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return addr3Field;
            }
            set
            {
                addr3Field = value;
            }
        }

        /// <remarks/>
        public string Addr4
        {
            get
            {
                return addr4Field;
            }
            set
            {
                addr4Field = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddress
    {

        private string addr1Field;

        private string addr2Field;

        private string addr3Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

        private string noteField;

        /// <remarks/>
        public string Addr1
        {
            get
            {
                return addr1Field;
            }
            set
            {
                addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return addr2Field;
            }
            set
            {
                addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return addr3Field;
            }
            set
            {
                addr3Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return cityField;
            }
            set
            {
                cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return stateField;
            }
            set
            {
                stateField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return postalCodeField;
            }
            set
            {
                postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetShipAddressBlock
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
                return addr1Field;
            }
            set
            {
                addr1Field = value;
            }
        }

        /// <remarks/>
        public string Addr2
        {
            get
            {
                return addr2Field;
            }
            set
            {
                addr2Field = value;
            }
        }

        /// <remarks/>
        public string Addr3
        {
            get
            {
                return addr3Field;
            }
            set
            {
                addr3Field = value;
            }
        }

        /// <remarks/>
        public string Addr4
        {
            get
            {
                return addr4Field;
            }
            set
            {
                addr4Field = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetTermsRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetItemSalesTaxRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerMsgRef
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsInvoiceQueryRsInvoiceRetCustomerSalesTaxCodeRef
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
