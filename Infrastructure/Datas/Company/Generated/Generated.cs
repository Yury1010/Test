namespace ABCS.Test.Infrastructure.Datas.Company.Generated
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRs
    {

        private QBXMLQBXMLMsgsRsCompanyQueryRs companyQueryRsField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRs CompanyQueryRs
        {
            get
            {
                return this.companyQueryRsField;
            }
            set
            {
                this.companyQueryRsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRs
    {

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRet companyRetField;

        private byte requestIDField;

        private byte statusCodeField;

        private string statusSeverityField;

        private string statusMessageField;

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRet CompanyRet
        {
            get
            {
                return this.companyRetField;
            }
            set
            {
                this.companyRetField = value;
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
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRet
    {

        private bool isSampleCompanyField;

        private string companyNameField;

        private string legalCompanyNameField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddress addressField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddressBlock addressBlockField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetLegalAddress legalAddressField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressForCustomer companyAddressForCustomerField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressBlockForCustomer companyAddressBlockForCustomerField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string companyWebSiteField;

        private string firstMonthFiscalYearField;

        private string firstMonthIncomeTaxYearField;

        private string companyTypeField;

        private string eINField;

        private string taxFormField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetService[] subscribedServicesField;

        private QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAccountantCopy accountantCopyField;

        /// <remarks/>
        public bool IsSampleCompany
        {
            get
            {
                return this.isSampleCompanyField;
            }
            set
            {
                this.isSampleCompanyField = value;
            }
        }

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public string LegalCompanyName
        {
            get
            {
                return this.legalCompanyNameField;
            }
            set
            {
                this.legalCompanyNameField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddress Address
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
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddressBlock AddressBlock
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
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetLegalAddress LegalAddress
        {
            get
            {
                return this.legalAddressField;
            }
            set
            {
                this.legalAddressField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressForCustomer CompanyAddressForCustomer
        {
            get
            {
                return this.companyAddressForCustomerField;
            }
            set
            {
                this.companyAddressForCustomerField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressBlockForCustomer CompanyAddressBlockForCustomer
        {
            get
            {
                return this.companyAddressBlockForCustomerField;
            }
            set
            {
                this.companyAddressBlockForCustomerField = value;
            }
        }

        /// <remarks/>
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string CompanyWebSite
        {
            get
            {
                return this.companyWebSiteField;
            }
            set
            {
                this.companyWebSiteField = value;
            }
        }

        /// <remarks/>
        public string FirstMonthFiscalYear
        {
            get
            {
                return this.firstMonthFiscalYearField;
            }
            set
            {
                this.firstMonthFiscalYearField = value;
            }
        }

        /// <remarks/>
        public string FirstMonthIncomeTaxYear
        {
            get
            {
                return this.firstMonthIncomeTaxYearField;
            }
            set
            {
                this.firstMonthIncomeTaxYearField = value;
            }
        }

        /// <remarks/>
        public string CompanyType
        {
            get
            {
                return this.companyTypeField;
            }
            set
            {
                this.companyTypeField = value;
            }
        }

        /// <remarks/>
        public string EIN
        {
            get
            {
                return this.eINField;
            }
            set
            {
                this.eINField = value;
            }
        }

        /// <remarks/>
        public string TaxForm
        {
            get
            {
                return this.taxFormField;
            }
            set
            {
                this.taxFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", IsNullable = false)]
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetService[] SubscribedServices
        {
            get
            {
                return this.subscribedServicesField;
            }
            set
            {
                this.subscribedServicesField = value;
            }
        }

        /// <remarks/>
        public QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAccountantCopy AccountantCopy
        {
            get
            {
                return this.accountantCopyField;
            }
            set
            {
                this.accountantCopyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddress
    {

        private string addr1Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

        private string countryField;

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
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAddressBlock
    {

        private string addr1Field;

        private string addr2Field;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetLegalAddress
    {

        private string addr1Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

        private string countryField;

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
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressForCustomer
    {

        private string addr1Field;

        private string cityField;

        private string stateField;

        private uint postalCodeField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetCompanyAddressBlockForCustomer
    {

        private string addr1Field;

        private string addr2Field;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetService
    {

        private string nameField;

        private string domainField;

        private string serviceStatusField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public string ServiceStatus
        {
            get
            {
                return this.serviceStatusField;
            }
            set
            {
                this.serviceStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class QBXMLQBXMLMsgsRsCompanyQueryRsCompanyRetAccountantCopy
    {

        private bool accountantCopyExistsField;

        /// <remarks/>
        public bool AccountantCopyExists
        {
            get
            {
                return this.accountantCopyExistsField;
            }
            set
            {
                this.accountantCopyExistsField = value;
            }
        }
    }

}
