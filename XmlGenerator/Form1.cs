using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "所有檔案(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇檔案路徑";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                textBox2.Text =foldPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            IWorkbook workbook = null;
            ISheet sheet = null;
            var trainfo = new Transfer_information();
            var summary = new Summary();
            var constituentEnts = new List<ConstituentEntities>();

            using (var fileStream = File.Open(textBox1.Text, FileMode.Open, FileAccess.ReadWrite))
            {
                XSSFWorkbook hssfwb = new XSSFWorkbook(fileStream); //XSSFWorkBook will read 2007 Excel format  
                sheet = hssfwb.GetSheetAt(0); //get first Excel sheet from workbook   

                trainfo = new Transfer_information
                {
                    TransmittingCountry = sheet.GetRow(0).GetCell(1).StringCellValue,
                    SendingEntityIN = sheet.GetRow(1).GetCell(1).StringCellValue,
                    ReporingRole = sheet.GetRow(2).GetCell(1).StringCellValue,
                    ReceivingCountry = sheet.GetRow(3).GetCell(1).StringCellValue,
                    CbCID = sheet.GetRow(4).GetCell(1).StringCellValue,
                    UTR = sheet.GetRow(5).GetCell(1).NumericCellValue.ToString()
                };

                sheet = hssfwb.GetSheetAt(1);
                summary = new Summary
                {
                    Name = sheet.GetRow(2).GetCell(1).StringCellValue,
                    FiscalyearStart = Convert.ToDateTime(sheet.GetRow(3).GetCell(1).StringCellValue),
                    FiscalyearEnd = Convert.ToDateTime(sheet.GetRow(4).GetCell(1).StringCellValue),
                    Currency = sheet.GetRow(5).GetCell(1).StringCellValue,
                    Address = sheet.GetRow(6).GetCell(1).StringCellValue,
                    TaxJurisdictions = new List<TaxJurisdictionInfo>()
                };



                for (int row = 9; row <= sheet.LastRowNum; row++) //Loop the records upto filled row  
                {
                    var taxJur = new TaxJurisdictionInfo();
                    if (sheet.GetRow(row) != null) //null is when the row only contains empty cells   
                    {
                        taxJur.TaxJurisdiction = sheet.GetRow(row).GetCell(0).StringCellValue;
                        taxJur.RevenuesUnrelated = (int)sheet.GetRow(row).GetCell(1).NumericCellValue;
                        taxJur.RevenuesRelated = (int)sheet.GetRow(row).GetCell(2).NumericCellValue;
                        taxJur.RevenuesTotal = (int)sheet.GetRow(row).GetCell(3).NumericCellValue;
                        taxJur.Profit = (int)sheet.GetRow(row).GetCell(4).NumericCellValue;
                        taxJur.IncomeTaxPaid = (int)sheet.GetRow(row).GetCell(5).NumericCellValue;
                        taxJur.IncomeTaxAccrued = (int)sheet.GetRow(row).GetCell(6).NumericCellValue;
                        taxJur.StatedCapital = (long)sheet.GetRow(row).GetCell(7).NumericCellValue;
                        taxJur.Earnings = (int)sheet.GetRow(row).GetCell(8).NumericCellValue;
                        taxJur.NumberEmployees = (int)sheet.GetRow(row).GetCell(9).NumericCellValue;
                        taxJur.TangibleAssets = (int)sheet.GetRow(row).GetCell(10).NumericCellValue;
                        // string value = sheet.GetRow(row).GetCell(1).StringCellValue; //Here for sample , I just save the value in "value" field, Here you can write your custom logics...  
                    }
                    summary.TaxJurisdictions.Add(taxJur);
                }
                sheet = hssfwb.GetSheetAt(2);



                for (int row = 6; row < sheet.LastRowNum; row++) //Loop the records upto filled row  
                {
                    var consEnt = new ConstituentEntities();
                    if (sheet.GetRow(row) != null) //null is when the row only contains empty cells   
                    {
                        consEnt.TaxJurisdictionEnt = sheet.GetRow(row).GetCell(0).StringCellValue;
                        consEnt.TaxResident = sheet.GetRow(row).GetCell(1).StringCellValue;
                        try
                        {
                            consEnt.TIN = sheet.GetRow(row).GetCell(2).NumericCellValue.ToString();
                        }
                        catch
                        {
                            consEnt.TIN = sheet.GetRow(row).GetCell(2).StringCellValue;
                        }

                        var busAct = new List<string>();
                        for (int cell = 8; cell <= 20; cell++)
                        {
                            if (sheet.GetRow(row).GetCell(cell).StringCellValue == "V")
                            {
                                switch (cell)
                                {
                                    case 8:
                                        busAct.Add("CBC501");
                                        break;
                                    case 9:
                                        busAct.Add("CBC502");
                                        break;
                                    case 10:
                                        busAct.Add("CBC503");
                                        break;
                                    case 11:
                                        busAct.Add("CBC504");
                                        break;
                                    case 12:
                                        busAct.Add("CBC505");
                                        break;
                                    case 13:
                                        busAct.Add("CBC506");
                                        break;
                                    case 14:
                                        busAct.Add("CBC507");
                                        break;
                                    case 15:
                                        busAct.Add("CBC508");
                                        break;
                                    case 16:
                                        busAct.Add("CBC509");
                                        break;
                                    case 17:
                                        busAct.Add("CBC510");
                                        break;
                                    case 18:
                                        busAct.Add("CBC511");
                                        break;
                                    case 19:
                                        busAct.Add("CBC512");
                                        break;
                                    case 20:
                                        busAct.Add("CBC513");
                                        break;
                                    default:
                                        break;

                                }
                            }
                        }
                        consEnt.BusAct = busAct;
                    }
                    constituentEnts.Add(consEnt);
                }

                sheet = hssfwb.GetSheetAt(3);
                var additionalInfo = new AdditionalInfo();
                additionalInfo.AddtionInf = sheet.GetRow(4).GetCell(0).StringCellValue;
                CreateXMLFunction createXML = new CreateXMLFunction();
                createXML.CreateXml(trainfo, summary, constituentEnts, additionalInfo,textBox2.Text);
            }

            MessageBox.Show("XML已產生", "檔案產生提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
    }
