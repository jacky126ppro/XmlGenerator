using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XmlGenerator
{
    class CreateXMLFunction
    {
        public void CreateXml(Transfer_information _Information, Summary summary, List<ConstituentEntities> constituentEntities, AdditionalInfo additionalInfo,string filepath)
        {
            string DocRefid = $"GB{summary.FiscalyearStart.Year }GB{_Information.SendingEntityIN}CBC401{DateTime.Now.ToString("yyyyMMddTHHmmss")}001";
            string createionTime = DateTime.Now.ToString("yyyyMMddTHHmmss");
            int seq = 2;

            XmlSerializer serializer = new XmlSerializer(typeof(CBC_OECD));
            CBC_OECD _OECD = new CBC_OECD();

            CBC_OECDMessageSpec _OECDMessageSpec = new CBC_OECDMessageSpec()
            {
                SendingEntityIN = _Information.SendingEntityIN,
                TransmittingCountry = _Information.TransmittingCountry,
                ReceivingCountry = _Information.ReceivingCountry,
                MessageType = "CBC",
                ReportingPeriod = summary.FiscalyearEnd,
                Timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                MessageRefId = $"GB{summary.FiscalyearStart.Year }GB{_Information.SendingEntityIN}CBC401{DateTime.Now.ToString("yyyyMMddTHHmmss")}001",
                MessageTypeIndic = "CBC401",
                Language = "EN"
            };
            _OECD.MessageSpec = _OECDMessageSpec;
            _OECD.version = 2.0M;

            CBC_OECDCbcBody _OECDCbcBody = new CBC_OECDCbcBody()
            {
                ReportingEntity = new CBC_OECDCbcBodyReportingEntity()
                {
                    Entity = new CBC_OECDCbcBodyReportingEntityEntity()
                    {
                        ResCountryCode = "GB",
                        Name = summary.Name,
                        TIN = uint.Parse(_Information.UTR)
                    },
                    ReportingRole = "CBC702",
                    ReportingPeriod = new CBC_OECDCbcBodyReportingEntityReportingPeriod()
                    {
                        StartDate = summary.FiscalyearStart,
                        EndDate = summary.FiscalyearEnd
                    },
                    DocSpec = new CBC_OECDCbcBodyReportingEntityDocSpec()
                    {
                        DocTypeIndic = "OECD1",
                        DocRefId=$"{DocRefid}_{_Information.UTR}OECD1ENT{createionTime}{seq.ToString().PadLeft(3,'0')}"
                    }

                }, AdditionalInfo = new CBC_OECDCbcBodyAdditionalInfo()
                {
                    DocSpec = new CBC_OECDCbcBodyAdditionalInfoDocSpec()
                    {
                        DocRefId  = $"{DocRefid}_{_Information.UTR}OECD1ADD{createionTime}012",
                        DocTypeIndic = "OECD1"
                    },
                    OtherInfo = additionalInfo.AddtionInf
                }
            };
            seq++;

            List<CBC_OECDCbcBodyCbcReports> _OECDCbcBodyCbcReportss =new  List<CBC_OECDCbcBodyCbcReports>();
            int index = 0;
            foreach (var item in summary.TaxJurisdictions)
            {
                CBC_OECDCbcBodyCbcReports _OECDCbcBodyCbcReports = new CBC_OECDCbcBodyCbcReports()
                {
                    DocSpec = new CBC_OECDCbcBodyCbcReportsDocSpec()
                    {
                        DocTypeIndic = "OECD1",
                        DocRefId = $"{DocRefid}_{_Information.UTR}OECD1REP{createionTime}{seq.ToString().PadLeft(3, '0')}"
                    },
                    ResCountryCode = item.TaxJurisdiction,
                    Summary = new CBC_OECDCbcBodyCbcReportsSummary()
                    {
                        Revenues = new CBC_OECDCbcBodyCbcReportsSummaryRevenues()
                        {
                            Unrelated = new CBC_OECDCbcBodyCbcReportsSummaryRevenuesUnrelated()
                            {
                                currCode = "GBP",
                                Value = item.RevenuesUnrelated
                            },
                            Related = new CBC_OECDCbcBodyCbcReportsSummaryRevenuesRelated()
                            {
                                currCode = "GBP",
                                Value = Convert.ToUInt32(item.RevenuesRelated)
                            },
                            Total = new CBC_OECDCbcBodyCbcReportsSummaryRevenuesTotal()
                            {
                                currCode = "GBP",
                                Value = item.RevenuesTotal
                            }
                        },
                        NbEmployees = item.NumberEmployees,
                        Assets = new CBC_OECDCbcBodyCbcReportsSummaryAssets() { currCode = "GBP", Value = item.TangibleAssets },
                        Capital = new CBC_OECDCbcBodyCbcReportsSummaryCapital() {currCode="GBP", Value=item.StatedCapital }  ,
                        Earnings = new CBC_OECDCbcBodyCbcReportsSummaryEarnings() { currCode="GBP",Value=item.Earnings} ,
                        ProfitOrLoss = new CBC_OECDCbcBodyCbcReportsSummaryProfitOrLoss() { currCode="GBP", Value = item.Profit },
                        TaxAccrued = new CBC_OECDCbcBodyCbcReportsSummaryTaxAccrued() { currCode="GBP", Value = item.IncomeTaxAccrued},
                        TaxPaid = new CBC_OECDCbcBodyCbcReportsSummaryTaxPaid() { currCode="GBP",Value=item.IncomeTaxPaid}
                    },
                    ConstEntities = new List<CBC_OECDCbcBodyCbcReportsConstEntities>()
                };

                foreach(var conEnt in constituentEntities)
                {
                    if (item.TaxJurisdiction == conEnt.TaxJurisdictionEnt)
                    {
                        CBC_OECDCbcBodyCbcReportsConstEntities _OECDCbcBodyCbcReportsConstEntities = new CBC_OECDCbcBodyCbcReportsConstEntities()
                        {
                            ConstEntity = new CBC_OECDCbcBodyCbcReportsConstEntitiesConstEntity()
                            {
                                ResCountryCode = conEnt.TaxJurisdictionEnt,
                                Name = conEnt.TaxResident,
                                TIN = conEnt.TIN
                            },
                            BizActivities = conEnt.BusAct
                        };
                        _OECDCbcBodyCbcReports.ConstEntities.Add(_OECDCbcBodyCbcReportsConstEntities);
                    };
                }
                _OECDCbcBodyCbcReportss.Add(_OECDCbcBodyCbcReports);
                seq++;
            }
            _OECDCbcBody.CbcReports = _OECDCbcBodyCbcReportss;
            _OECD.CbcBody = _OECDCbcBody;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("stf", "urn:oecd:ties:cbcstf:v5");
            ns.Add("iso", "urn:oecd:ties:isocbctypes:v1");
            ns.Add("cbc", "urn:oecd:ties:cbc:v2");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");


            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"//{DocRefid}.xml";
            var path = filepath + $"//{DocRefid}.xml";
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                //ConformanceLevel = ConformanceLevel.Document,
                //OmitXmlDeclaration = false,
                //CloseOutput = true,
                //Indent = true,
                //IndentChars = "  ",
                //NewLineHandling = NewLineHandling.Replace,
            };
            XmlWriter writer = XmlWriter.Create(path, settings);
            serializer.Serialize(writer, _OECD, ns);
            writer.Close();

            Console.WriteLine("Xml Create Completed");
        }

    }
}

