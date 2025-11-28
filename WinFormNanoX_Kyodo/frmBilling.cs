using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormNanoX_Kyodo
{
    public partial class frmBilling : Form
    {
        private readonly DatabaseAccess databaseAccess = new DatabaseAccess();
        private string connectionString;
        private string startTime;
        private string endTime;
        private double peak1, normal1, peak2, normal2;
        private readonly double[] peakEnergyBuffer = new double[32];
        private DateTime previousDay;

        private class EnergyData
        {
            public double[] PeakEnergy { get; set; }
            public double Value { get; set; }
        }

        public frmBilling()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";
            databaseAccess.ConnectionString = connectionString;

            btnExport.Click += BtnExport_Click;
            this.Load += FrmBilling_Load;
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            DateFrom.Value = DateTime.Today;
            DateTo.Value = DateTime.Today;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (DateTo.Value < DateFrom.Value)
            {
                MessageBox.Show("To Date must be greater than or equal to From Date.", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = new SaveFileDialog
            {
                Title = "HinoSystech - Billing Report",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 0,
                RestoreDirectory = true,
                FileName = $"Billing_{DateFrom.Value:yyyyMMdd}_{DateTo.Value:yyyyMMdd}.xlsx"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            var filePath = dialog.FileName;
            var inclusiveEnd = DateTo.Value > DateFrom.Value
                ? DateTo.Value.AddDays(-1)
                : DateFrom.Value;
            startTime = GetStartTime(DateFrom.Value);
            endTime = GetEndTime(inclusiveEnd);

            var queryFrom = $"Select DateTime,TotalSolarEnergy from `data_common_report` where (DateTime < '{startTime}')";
            var dataFrom = databaseAccess.ExecuteQuery(queryFrom);

            var queryTo = $"Select DateTime,TotalSolarEnergy from `data_common_report` where (DateTime < '{endTime}')";
            var dataTo = databaseAccess.ExecuteQuery(queryTo);

            ExportExcel(dataFrom, dataTo, filePath);
        }

        private string GetStartTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd 00:00:00");
        }

        private string GetEndTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd 23:59:59");
        }

        private void ExportExcel(DataTable dataFrom, DataTable dataTo, string filePath)
        {
            double preValuePeak = 0;
            double lastValuePeak = 0;

            var dataEnergyFrom = GetDataEnergy(dataFrom);
            foreach (var number in dataEnergyFrom.PeakEnergy)
            {
                preValuePeak += number;
            }
            var preValueNormal = dataEnergyFrom.Value - preValuePeak;

            var dataEnergyTo = GetDataEnergy(dataTo);
            foreach (var number in dataEnergyTo.PeakEnergy)
            {
                lastValuePeak += number;
            }
            var lastValueNormal = dataEnergyTo.Value - lastValuePeak;

            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "Billing_Report.xlsx");
            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Billing template not found in Template folder.", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var excelPackage = new ExcelPackage(new FileInfo(templatePath)))
                {
                    excelPackage.Workbook.Properties.Author = "Hino";
                    excelPackage.Workbook.Properties.Title = "Energy Report";
                    excelPackage.Workbook.Properties.Subject = "Energy report";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;

                    var worksheet = excelPackage.Workbook.Worksheets["Data"];
                    worksheet.Cells["D23"].Value = preValuePeak.ToString();
                    worksheet.Cells["E23"].Value = lastValuePeak.ToString();
                    worksheet.Cells["I23"].Value = txtPeakMoney.Text;

                    worksheet.Cells["D24"].Value = preValueNormal.ToString();
                    worksheet.Cells["E24"].Value = lastValueNormal.ToString();
                    worksheet.Cells["I24"].Value = txtNormalMoney.Text;

                    worksheet.Cells["E18"].Value = startTime;
                    worksheet.Cells["E19"].Value = endTime;

                    var resultFile = new FileInfo(filePath);
                    excelPackage.SaveAs(resultFile);
                }

                MessageBox.Show("Excel file exported successfully!", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Excel file is currently open. Please close it and try again.", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed: {ex.Message}", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EnergyData GetDataEnergy(DataTable dataTable)
        {
            int day = 0;
            double total = 0;
            int index = 0;
            double min = 0;
            Array.Clear(peakEnergyBuffer, 0, peakEnergyBuffer.Length);
            var startTime1 = new TimeSpan(9, 30, 0);
            var endTime1 = new TimeSpan(11, 30, 0);
            var startTime2 = new TimeSpan(17, 0, 0);
            var endTime2 = new TimeSpan(20, 0, 0);

            foreach (DataRow row in dataTable.Rows)
            {
                var value1 = row[0].ToString();
                double.TryParse(row[1].ToString(), out double value2);

                var dateTime = DateTime.Parse(value1);
                var date = dateTime.Date;

                if (index == 0)
                {
                    min = value2;
                    previousDay = date;
                    index = 1;
                }

                var currentTimeOfDay = dateTime.TimeOfDay;
                day = dateTime.Day;
                if (previousDay.CompareTo(date) < 0)
                {
                    peakEnergyBuffer[day - 1] += (peak1 - normal1) + (peak2 - normal2);
                    if (peakEnergyBuffer[day - 1] < 0)
                    {
                        peakEnergyBuffer[day - 1] = 0;
                    }
                    normal1 = 0;
                    normal2 = 0;
                    peak1 = 0;
                    peak2 = 0;
                    previousDay = date;
                }

                var isSunday = dateTime.DayOfWeek == DayOfWeek.Sunday;
                if (!isSunday)
                {
                    if (currentTimeOfDay < startTime1)
                    {
                        normal1 = value2;
                    }
                    else if (currentTimeOfDay >= startTime1 && currentTimeOfDay <= endTime1)
                    {
                        peak1 = value2;
                    }
                    else if (currentTimeOfDay < startTime2 && currentTimeOfDay > endTime1)
                    {
                        normal2 = value2;
                    }
                    else if (currentTimeOfDay >= startTime2 && currentTimeOfDay <= endTime2)
                    {
                        peak2 = value2;
                    }
                    if (normal1 == 0)
                    {
                        normal1 = peak1;
                    }
                    if (normal2 == 0)
                    {
                        normal2 = peak2;
                    }
                }

                total = value2 - min;
            }

            peakEnergyBuffer[day] += (peak1 - normal1) + (peak2 - normal2);

            return new EnergyData
            {
                PeakEnergy = peakEnergyBuffer.ToArray(),
                Value = total
            };
        }
    }
}
