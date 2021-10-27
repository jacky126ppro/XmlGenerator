using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlGenerator
{
    // 注意: 產生的程式碼可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oecd:ties:cbc:v2", IsNullable = false)]

    public partial class CBC_OECD
    {
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "urn:oecd:ties:cbc:v2 CbcXML_v2.0.xsd";
        private CBC_OECDMessageSpec messageSpecField;

        private CBC_OECDCbcBody cbcBodyField;

        private decimal versionField;

        /// <remarks/>
        public CBC_OECDMessageSpec MessageSpec
        {
            get
            {
                return this.messageSpecField;
            }
            set
            {
                this.messageSpecField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBody CbcBody
        {
            get
            {
                return this.cbcBodyField;
            }
            set
            {
                this.cbcBodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDMessageSpec
    {

        private string sendingEntityINField;

        private string transmittingCountryField;

        private string receivingCountryField;

        private string messageTypeField;

        private string languageField;

        private string messageRefIdField;

        private string messageTypeIndicField;

        private System.DateTime reportingPeriodField;

        private string timestampField;

        /// <remarks/>
        public string SendingEntityIN
        {
            get
            {
                return this.sendingEntityINField;
            }
            set
            {
                this.sendingEntityINField = value;
            }
        }

        /// <remarks/>
        public string TransmittingCountry
        {
            get
            {
                return this.transmittingCountryField;
            }
            set
            {
                this.transmittingCountryField = value;
            }
        }

        /// <remarks/>
        public string ReceivingCountry
        {
            get
            {
                return this.receivingCountryField;
            }
            set
            {
                this.receivingCountryField = value;
            }
        }

        /// <remarks/>
        public string MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string MessageRefId
        {
            get
            {
                return this.messageRefIdField;
            }
            set
            {
                this.messageRefIdField = value;
            }
        }

        /// <remarks/>
        public string MessageTypeIndic
        {
            get
            {
                return this.messageTypeIndicField;
            }
            set
            {
                this.messageTypeIndicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ReportingPeriod
        {
            get
            {
                return this.reportingPeriodField;
            }
            set
            {
                this.reportingPeriodField = value;
            }
        }

        /// <remarks/>
        public string Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBody
    {

        private CBC_OECDCbcBodyReportingEntity reportingEntityField;

        private List<CBC_OECDCbcBodyCbcReports> cbcReportsField;

        private CBC_OECDCbcBodyAdditionalInfo additionalInfoField;

        /// <remarks/>
        public CBC_OECDCbcBodyReportingEntity ReportingEntity
        {
            get
            {
                return this.reportingEntityField;
            }
            set
            {
                this.reportingEntityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CbcReports")]
        public List<CBC_OECDCbcBodyCbcReports> CbcReports
        {
            get
            {
                return this.cbcReportsField;
            }
            set
            {
                this.cbcReportsField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyAdditionalInfo AdditionalInfo
        {
            get
            {
                return this.additionalInfoField;
            }
            set
            {
                this.additionalInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyReportingEntity
    {

        private CBC_OECDCbcBodyReportingEntityEntity entityField;

        private string reportingRoleField;

        private CBC_OECDCbcBodyReportingEntityReportingPeriod reportingPeriodField;

        private CBC_OECDCbcBodyReportingEntityDocSpec docSpecField;

        /// <remarks/>
        public CBC_OECDCbcBodyReportingEntityEntity Entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public string ReportingRole
        {
            get
            {
                return this.reportingRoleField;
            }
            set
            {
                this.reportingRoleField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyReportingEntityReportingPeriod ReportingPeriod
        {
            get
            {
                return this.reportingPeriodField;
            }
            set
            {
                this.reportingPeriodField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyReportingEntityDocSpec DocSpec
        {
            get
            {
                return this.docSpecField;
            }
            set
            {
                this.docSpecField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyReportingEntityEntity
    {

        private string resCountryCodeField;

        private uint tINField;

        private string nameField;

        /// <remarks/>
        public string ResCountryCode
        {
            get
            {
                return this.resCountryCodeField;
            }
            set
            {
                this.resCountryCodeField = value;
            }
        }

        /// <remarks/>
        public uint TIN
        {
            get
            {
                return this.tINField;
            }
            set
            {
                this.tINField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyReportingEntityReportingPeriod
    {

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyReportingEntityDocSpec
    {

        private string docTypeIndicField;

        private string docRefIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocTypeIndic
        {
            get
            {
                return this.docTypeIndicField;
            }
            set
            {
                this.docTypeIndicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocRefId
        {
            get
            {
                return this.docRefIdField;
            }
            set
            {
                this.docRefIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReports
    {

        private CBC_OECDCbcBodyCbcReportsDocSpec docSpecField;

        private string resCountryCodeField;

        private CBC_OECDCbcBodyCbcReportsSummary summaryField;

        private List<CBC_OECDCbcBodyCbcReportsConstEntities> constEntitiesField;

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsDocSpec DocSpec
        {
            get
            {
                return this.docSpecField;
            }
            set
            {
                this.docSpecField = value;
            }
        }

        /// <remarks/>
        public string ResCountryCode
        {
            get
            {
                return this.resCountryCodeField;
            }
            set
            {
                this.resCountryCodeField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummary Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConstEntities")]
        public List<CBC_OECDCbcBodyCbcReportsConstEntities> ConstEntities
        {
            get
            {
                return this.constEntitiesField;
            }
            set
            {
                this.constEntitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsDocSpec
    {

        private string docTypeIndicField;

        private string docRefIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocTypeIndic
        {
            get
            {
                return this.docTypeIndicField;
            }
            set
            {
                this.docTypeIndicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocRefId
        {
            get
            {
                return this.docRefIdField;
            }
            set
            {
                this.docRefIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummary
    {

        private CBC_OECDCbcBodyCbcReportsSummaryRevenues revenuesField;

        private CBC_OECDCbcBodyCbcReportsSummaryProfitOrLoss profitOrLossField;

        private CBC_OECDCbcBodyCbcReportsSummaryTaxPaid taxPaidField;

        private CBC_OECDCbcBodyCbcReportsSummaryTaxAccrued taxAccruedField;

        private CBC_OECDCbcBodyCbcReportsSummaryCapital capitalField;

        private CBC_OECDCbcBodyCbcReportsSummaryEarnings earningsField;

        private int nbEmployeesField;

        private CBC_OECDCbcBodyCbcReportsSummaryAssets assetsField;

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryRevenues Revenues
        {
            get
            {
                return this.revenuesField;
            }
            set
            {
                this.revenuesField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryProfitOrLoss ProfitOrLoss
        {
            get
            {
                return this.profitOrLossField;
            }
            set
            {
                this.profitOrLossField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryTaxPaid TaxPaid
        {
            get
            {
                return this.taxPaidField;
            }
            set
            {
                this.taxPaidField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryTaxAccrued TaxAccrued
        {
            get
            {
                return this.taxAccruedField;
            }
            set
            {
                this.taxAccruedField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryCapital Capital
        {
            get
            {
                return this.capitalField;
            }
            set
            {
                this.capitalField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryEarnings Earnings
        {
            get
            {
                return this.earningsField;
            }
            set
            {
                this.earningsField = value;
            }
        }

        /// <remarks/>
        public int NbEmployees
        {
            get
            {
                return this.nbEmployeesField;
            }
            set
            {
                this.nbEmployeesField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryAssets Assets
        {
            get
            {
                return this.assetsField;
            }
            set
            {
                this.assetsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryRevenues
    {

        private CBC_OECDCbcBodyCbcReportsSummaryRevenuesUnrelated unrelatedField;

        private CBC_OECDCbcBodyCbcReportsSummaryRevenuesRelated relatedField;

        private CBC_OECDCbcBodyCbcReportsSummaryRevenuesTotal totalField;

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryRevenuesUnrelated Unrelated
        {
            get
            {
                return this.unrelatedField;
            }
            set
            {
                this.unrelatedField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryRevenuesRelated Related
        {
            get
            {
                return this.relatedField;
            }
            set
            {
                this.relatedField = value;
            }
        }

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsSummaryRevenuesTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryRevenuesUnrelated
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryRevenuesRelated
    {

        private string currCodeField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryRevenuesTotal
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryProfitOrLoss
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryTaxPaid
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryTaxAccrued
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryCapital
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryEarnings
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsSummaryAssets
    {

        private string currCodeField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsConstEntities
    {

        private CBC_OECDCbcBodyCbcReportsConstEntitiesConstEntity constEntityField;

        private List<string> bizActivitiesField;

        /// <remarks/>
        public CBC_OECDCbcBodyCbcReportsConstEntitiesConstEntity ConstEntity
        {
            get
            {
                return this.constEntityField;
            }
            set
            {
                this.constEntityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BizActivities")]
        public List<string> BizActivities
        {
            get
            {
                return this.bizActivitiesField;
            }
            set
            {
                this.bizActivitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyCbcReportsConstEntitiesConstEntity
    {

        private string resCountryCodeField;

        private string tINField;

        private string nameField;

        /// <remarks/>
        public string ResCountryCode
        {
            get
            {
                return this.resCountryCodeField;
            }
            set
            {
                this.resCountryCodeField = value;
            }
        }

        /// <remarks/>
        public string TIN
        {
            get
            {
                return this.tINField;
            }
            set
            {
                this.tINField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyAdditionalInfo
    {

        private CBC_OECDCbcBodyAdditionalInfoDocSpec docSpecField;

        private string otherInfoField;

        /// <remarks/>
        public CBC_OECDCbcBodyAdditionalInfoDocSpec DocSpec
        {
            get
            {
                return this.docSpecField;
            }
            set
            {
                this.docSpecField = value;
            }
        }

        /// <remarks/>
        public string OtherInfo
        {
            get
            {
                return this.otherInfoField;
            }
            set
            {
                this.otherInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oecd:ties:cbc:v2")]
    public partial class CBC_OECDCbcBodyAdditionalInfoDocSpec
    {

        private string docTypeIndicField;

        private string docRefIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocTypeIndic
        {
            get
            {
                return this.docTypeIndicField;
            }
            set
            {
                this.docTypeIndicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oecd:ties:cbcstf:v5")]
        public string DocRefId
        {
            get
            {
                return this.docRefIdField;
            }
            set
            {
                this.docRefIdField = value;
            }
        }
    }

}
