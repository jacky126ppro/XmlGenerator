using System;
using System.Collections.Generic;
using System.Text;

namespace XmlGenerator
{
    class Summary
    {
        public string Name { get; set; }
        public DateTime FiscalyearStart { get; set; }
        public DateTime FiscalyearEnd { get; set; }
        public string Currency { get; set; }
        public string Address { get; set; }
        public List<TaxJurisdictionInfo> TaxJurisdictions { get; set; }

    }

    class TaxJurisdictionInfo
    {
        public string TaxJurisdiction { get; set; }
        public long RevenuesUnrelated { get; set; }
        public long RevenuesRelated { get; set; }
        public long RevenuesTotal { get; set; }
        public long Profit { get; set; }
        public long IncomeTaxPaid { get; set; }
        public long IncomeTaxAccrued { get; set; }
        public long StatedCapital { get; set; }
        public long Earnings { get; set; }
        public int NumberEmployees { get; set; }
        public long TangibleAssets { get; set; }
    }
}