using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNanoX_Kyodo
{
    public partial class SCADA : Form
    {
        #region MOVE FORM

        private bool dragging = false;

        private Point dragCursorPoint;

        private Point dragFormPoint;

        #endregion



        private Button activeButton;

        private frmOverview frmOverview;
        private frmSingleLine frmSingleLine;
        private frmInverter frmInverter;
        private frmGraph frmGraph;
        private frmAlarm frmAlarm;
        private frmEvent frmEvent;
        private frmReport frmReport;
        private frmZeroExport frmZeroExport;
        private frmRecord frmRecord;
        private frmParameter frmParameter;
        private frmBilling frmBilling;
        private frmLogout frmLogout;
        private frmVisitor frmVisitor;
        int indexAlarm = 0;
        public SCADA()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Load += SCADA_Load;

            //this.btnVie.Click += BtnVie_Click;
            //this.btnEng.Click += BtnEng_Click;
            
            this.KeyPreview = true;
            this.KeyDown += SCADA_KeyDown;

            this.btnOverview.Click += btnOverview_Click;
            this.btnSingleLine.Click += BtnSingleLine_Click;
            this.btnInverter.Click += BtnInverter_Click;
            this.btnGraph.Click += BtnGraph_Click;
            this.btnAlarm.Click += btnAlarm_Click;
            this.btnEvent.Click += BtnEvent_Click;
            this.btnReport.Click += btnReport_Click;
            this.btnZeroExport.Click += BtnZeroExport_Click;
            this.btnRecord.Click += BtnRecord_Click;
            this.btnParameter.Click += BtnParameter_Click;
            this.btnBilling.Click += BtnBilling_Click;
            

            this.btnLogout.Click += BtnLogout_Click;
            this.btnVisitor.Click += BtnVisitor_Click;

            this.btnMinimize.Click += btnMinimize_Click;
            this.btnClose.Click += btnClose_Click;

            this.btnLogin.Click += btnLogin_Click;
            this.btnCancel.Click += btnCancel_Click;

            this.btnOverview.Enabled = false;
            this.btnSingleLine.Enabled = false;
            this.btnInverter.Enabled = false;
            this.btnAlarm.Enabled = false;
            this.btnEvent.Enabled = false;
            this.btnReport.Enabled = false;
            this.btnGraph.Enabled = false;
            this.btnZeroExport.Enabled = false;
            this.btnRecord.Enabled = false;
            this.btnParameter.Enabled = false;
            this.btnBilling.Enabled = false;
            this.btnVisitor.Enabled = false;


            SetActionButton(this.btnOverview);
            SetActionButton(this.btnSingleLine);
            SetActionButton(this.btnInverter);
            SetActionButton(this.btnGraph);
            SetActionButton(this.btnAlarm);
            SetActionButton(this.btnEvent);
            SetActionButton(this.btnReport);
            SetActionButton(this.btnZeroExport);
            SetActionButton(this.btnRecord);
            SetActionButton(this.btnParameter);
            SetActionButton(this.btnBilling);
            SetActionButton(this.btnLogout);
            SetActionButton(this.btnVisitor);
            //InitMoveForm(this.pnlHeader);
        }

        private void SCADA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && pnlVisitor.Visible)
            {
                this.frmVisitor.Hide();
                this.btnVisitor.Show();
                this.btnVisitor.BringToFront();
                this.activeButton = null;
                pnlVisitor.Hide();
                pnlMain.Show();
                pnlMain.BringToFront();
            }
        }



        //private void BtnEng_Click(object sender, EventArgs e)
        //{
        //    ClassStatic.language = 0;
        //    btnOverview.Text = "     Over\n      view";
        //    btnOverviewActive.Text= "     Over\n      view";
        //    btnSingleLine.Text = "       Single\n     line";
        //    btnSingleLineActive.Text = "       Single\n     line";
        //    btnInverter.Text = "         Inverter";
        //    btnInverterActive.Text = "         Inverter";
        //    btnInverterActive.Text = "         Biến tần";
        //    btnGraph.Text = "         Graph";
        //    btnGraphActive.Text = "         Graph";
        //    btnAlarm.Text = "       Alarm";
        //    btnAlarmActive.Text = "       Alarm";
        //    btnEvent.Text = "         Event";
        //    btnEventActive.Text = "         Event";
        //    btnRecord.Text="         Record";
        //    btnRecordActive.Text = "         Record";
        //    btnReport.Text = "         Report";
        //    btnReportActive.Text = "         Report";
        //    btnBilling.Text = "        Billing";
        //    btnBillingActive.Text = "        Billing";
        //    btnParameter.Text = "      User\n         Setting";
        //    btnParameterActive.Text = "      User\n         Setting";
        //}

        //private void BtnVie_Click(object sender, EventArgs e)
        //{
        //    ClassStatic.language = 1;
        //    btnOverview.Text = "     Tổng\n      quan";
        //    btnOverviewActive.Text = "     Tổng\n      quan";
        //    btnSingleLine.Text = "       Sơ đồ\n     1 sợi";
        //    btnSingleLineActive.Text = "       Sơ đồ\n     1 sợi";
        //    btnInverter.Text = "         Biến tần";
        //    btnInverterActive.Text = "         Biến tần";
        //    btnGraph.Text = "         Biểu\n      đồ";
        //    btnGraphActive.Text = "         Biểu\n      đồ";
        //    btnAlarm.Text = "       Cảnh\n     báo";
        //    btnAlarmActive.Text = "       Cảnh\n     báo";
        //    btnEvent.Text = "     Sự\n       kiện";
        //    btnEventActive.Text = "     Sự\n       kiện";
        //    btnRecord.Text = "      Ghi\n      chú";
        //    btnRecordActive.Text = "      Ghi\n      chú";
        //    btnReport.Text = "       Báo\n      cáo";
        //    btnReportActive.Text = "       Báo\n      cáo";
        //    btnBilling.Text = "      Tính\n      tiền";
        //    btnBillingActive.Text = "      Tính\n      tiền";
        //    btnParameter.Text = "         Cài đặt";
        //    btnParameterActive.Text = "         Cài đặt";
        //}

        

        private void SCADA_Load(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 1;
            // Màu nút chuyển trang khi khởi động
            groupBox1.Hide();
            label2.Hide();



            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    CreateChildForm();
                    return;
                }));

                return;
            }
            //  this.activeButton = btnOverview;
            //  NavigateToOverview();
            CreateChildForm();

            this.frmOverview.BringToFront();

        }
        
        private void CreateChildForm()
        {

            if (this.frmOverview is null)
            {
                this.btnOverview.Enabled = true;
                this.frmOverview = new frmOverview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmOverview.Hide();
                this.pnlMain.Controls.Add(this.frmOverview);
            }

            if (this.frmSingleLine is null)
            {
                this.btnSingleLine.Enabled = true;
                this.frmSingleLine = new frmSingleLine() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmSingleLine.Hide();
                this.pnlMain.Controls.Add(this.frmSingleLine);
            }

            if (this.frmInverter is null)
            {
                this.btnInverter.Enabled = true;
                this.frmInverter = new frmInverter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmInverter.Hide();
                this.pnlMain.Controls.Add(this.frmInverter);
            }


            if (this.frmGraph is null)
            {
                this.btnGraph.Enabled = true;
                this.frmGraph = new frmGraph() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmGraph.Hide();
                this.pnlMain.Controls.Add(this.frmGraph);
            }

            if (this.frmAlarm is null)
            {
                this.btnAlarm.Enabled = true;
                this.frmAlarm = new frmAlarm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmAlarm.Hide();
                this.pnlMain.Controls.Add(this.frmAlarm);
            }

            if (this.frmEvent is null)
            {
                this.btnEvent.Enabled = true;
                this.frmEvent = new frmEvent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmEvent.Hide();
                this.pnlMain.Controls.Add(this.frmEvent);
            }

            if (this.frmReport is null)
            {
                this.btnReport.Enabled = true;
                this.frmReport = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmReport.Hide();
                this.pnlMain.Controls.Add(this.frmReport);
            }

            if (this.frmZeroExport is null)
            {
                this.btnZeroExport.Enabled = true;
                this.frmZeroExport = new frmZeroExport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmZeroExport.Hide();
                this.pnlMain.Controls.Add(this.frmZeroExport);
            }

            if (this.frmRecord is null)
            {
                this.btnRecord.Enabled = true;
                this.frmRecord = new frmRecord() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmRecord.Hide();
                this.pnlMain.Controls.Add(this.frmRecord);
            }

            if (this.frmParameter is null)
            {
                this.btnParameter.Enabled = true;
                this.frmParameter = new frmParameter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmParameter.Hide();
                this.pnlMain.Controls.Add(this.frmParameter);
            }
            if (this.frmBilling is null)
            {
                this.btnBilling.Enabled = true;
                this.frmBilling = new frmBilling() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmBilling.Hide();
                this.pnlMain.Controls.Add(this.frmBilling);
            }

            if (this.frmLogout is null)
            {
                this.btnLogout.Enabled = true;
                this.frmLogout = new frmLogout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmLogout.Hide();
                this.pnlMain.Controls.Add(this.frmLogout);
            }

            if (this.frmVisitor is null)
            {
                this.btnVisitor.Enabled = true;
                this.frmVisitor = new frmVisitor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmVisitor.Hide();
                this.pnlVisitor.Controls.Add(this.frmVisitor);
            }

            this.activeButton = btnOverview;
            NavigateToOverview();

        }

        private void SetActionButton(Button button)
        {
            if (button is null) return;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.BackColorChanged += (s, e) =>
            {
                button.FlatAppearance.MouseOverBackColor = button.BackColor;
            };
        }

        public void UpdateLogout()
        {
            ClassStatic.NumberScreen = 1;
            if (this.activeButton == this.btnOverview) return;
            this.activeButton = btnOverview;
            this.btnOverview.BackColor = Color.Transparent;
            NavigateToOverview();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 1;
            if (this.activeButton == this.btnOverview) return;
            this.activeButton = btnOverview;
            this.btnOverview.BackColor = Color.Transparent;
            NavigateToOverview();
        }

        private void BtnSingleLine_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 21;
            if (this.activeButton == this.btnSingleLine) return;
            this.activeButton = btnSingleLine;
            this.btnSingleLine.BackColor = Color.Transparent;
            NavigateToSingleLine();
        }
        private void BtnInverter_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 3;
            if (this.activeButton == this.btnInverter) return;
            this.activeButton = btnInverter;
            NavigateToInverter();
        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 4;
            if (this.activeButton == this.btnGraph) return;
            this.activeButton = btnGraph;
            NavigateToGraph();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 5;
            if (this.activeButton == this.btnAlarm) return;
            this.activeButton = btnAlarm;
            NavigateToAlarm();
        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 6;
            if (this.activeButton == this.btnEvent) return;
            this.activeButton = btnEvent;
            NavigateToEvent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 7;
            if (this.activeButton == this.btnReport) return;
            this.activeButton = btnReport;
            NavigateToReport();
        }

        private void BtnZeroExport_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 8;
            if (this.activeButton == this.btnZeroExport) return;
            this.activeButton = btnZeroExport;
            NavigateToZeroExport();
        }

        private void BtnParameter_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 9;
            if (this.activeButton == this.btnParameter) return;
            label2.Show();
            label2.BringToFront();
            groupBox1.Show();
            groupBox1.BringToFront();
        }
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 10;
            if (this.activeButton == this.btnRecord) return;
            this.activeButton = btnRecord;
            NavigateToRecord();
        }
        private void BtnBilling_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 11;
            if (this.activeButton == this.btnBilling) return;
            this.activeButton = btnBilling;
            NavigateToBilling();
        }

        private void BtnVisitor_Click(object sender, EventArgs e)
        {
            ClassStatic.NumberScreen = 12;
            if (this.activeButton == this.btnVisitor) return;
            this.activeButton = btnVisitor;
            NavigateToVisitor();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            ClassStatic.islogin = false;
            ClassStatic.count = 0;
            ClassStatic.NumberScreen = 12;
            if (this.activeButton == this.btnLogout) return;
            this.activeButton = btnLogout;
            btnOverviewActive.BringToFront();
            btnSingleLineActive.BringToFront();
            btnGraphActive.BringToFront();
            btnInverterActive.BringToFront();
            btnAlarmActive.BringToFront();
            btnEventActive.BringToFront();
            btnReportActive.BringToFront();
            btnZeroExportActive.BringToFront();
            btnRecordActive.BringToFront();
            btnParameterActive.BringToFront();
            btnBillingActive.BringToFront();

            ClassStatic.AlarmACK = false;
            ClassStatic.CreateUser = false;
            ClassStatic.Setting = false;
            ClassStatic.ReportExport = false;
            NavigateToLogout();
        }



        private void NavigateToOverview()
        {
            if (this.frmOverview is null) return;
            this.frmOverview?.Show();
            this.frmOverview?.BringToFront();

            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToSingleLine()
        {
            if (this.frmSingleLine is null) return;
            this.frmSingleLine?.Show();
            this.frmSingleLine?.BringToFront();

            this.frmOverview?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToInverter()
        {
            if (this.frmInverter is null) return;
            this.frmInverter?.Show();
            this.frmInverter?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }

        private void NavigateToGraph()
        {
            if (this.frmGraph is null) return;
            this.frmGraph?.Show();
            this.frmGraph?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToAlarm()
        {
            if (this.frmAlarm is null) return;
            this.frmAlarm?.Show();
            this.frmAlarm?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToEvent()
        {
            if (this.frmEvent is null) return;
            this.frmEvent?.Show();
            this.frmEvent?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmReport?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToReport()
        {
            if (this.frmReport is null) return;
            this.frmReport?.Show();
            this.frmReport?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmZeroExport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToZeroExport()
        {
            if (this.frmZeroExport is null) return;
            this.frmZeroExport?.Show();
            this.frmZeroExport?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmRecord?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToRecord()
        {
            if (this.frmRecord is null) return;
            this.frmRecord?.Show();
            this.frmRecord?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToParameter()
        {
            if (this.frmParameter is null) return;

            this.frmParameter?.Show();
            this.frmParameter?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmRecord?.Hide();
            this.frmZeroExport?.Hide();
            this.frmBilling?.Hide();
            this.frmLogout?.Hide();
        }
        private void NavigateToBilling()
        {
            if (this.frmBilling is null) return;
            this.frmBilling?.Show();
            this.frmBilling?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmRecord?.Hide();
            this.frmZeroExport?.Hide();
            this.frmParameter?.Hide();
            this.frmLogout?.Hide();
        }

        private void NavigateToLogout()
        {
            if (this.frmLogout is null) return;
            this.frmLogout?.Show();
            this.frmLogout?.BringToFront();

            this.frmOverview?.Hide();
            this.frmSingleLine?.Hide();
            this.frmInverter?.Hide();
            this.frmGraph?.Hide();
            this.frmAlarm?.Hide();
            this.frmEvent?.Hide();
            this.frmReport?.Hide();
            this.frmRecord?.Hide();
            this.frmZeroExport?.Hide();
            this.frmParameter?.Hide();
            this.frmBilling?.Hide();
        }

        private void NavigateToVisitor()
        {
            if (this.frmVisitor is null) return;
            this.frmVisitor?.Show();
            this.frmVisitor?.BringToFront();
            pnlVisitor.Show();
            pnlVisitor.BringToFront();
            pnlMain.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to stop system?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (ClassStatic.isAlarm == true)
            {
                if (indexAlarm == 0)
                {
                    lblAlarm.BackColor = Color.Red;
                    indexAlarm = 1;
                }
                else
                {
                    lblAlarm.BackColor = Color.Silver;
                    indexAlarm = 0;
                }
                lblAlarm.Text = ClassStatic.des;
                lblAlarm.Show();
                lblAlarm.BringToFront();


            }
            else
            {
                lblAlarm.Hide();
            }

            if (ClassStatic.count == 1)
            {
                UpdateLogout();
                ClassStatic.count = 2;
            }

            if (ClassStatic.islogin == true)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 1)
            {
                btnOverviewActive.BringToFront();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 21)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.BringToFront();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 3)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.BringToFront();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 4)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.BringToFront();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 5)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.BringToFront();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 6)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.BringToFront();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 7)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.BringToFront();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 8)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.BringToFront();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 9)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.BringToFront();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 10)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.BringToFront();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }
            if (ClassStatic.NumberScreen == 11)
            {
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.SendToBack();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.BringToFront();

            }
            //Display DateTime Now
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            if (ClassStatic.NumberScreen == 32)// Chuyển screen InverterNext
            {
                this.activeButton = btnInverter;
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.BringToFront();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();

                NavigateToInverter();
            }
            else if (ClassStatic.NumberScreen == 31)// Chuyển screen Inverter
            {
                this.activeButton = btnInverter;
                btnOverviewActive.SendToBack();
                btnSingleLineActive.SendToBack();
                btnGraphActive.SendToBack();
                btnInverterActive.BringToFront();
                btnAlarmActive.SendToBack();
                btnEventActive.SendToBack();
                btnReportActive.SendToBack();
                btnZeroExportActive.SendToBack();
                btnRecordActive.SendToBack();
                btnParameterActive.SendToBack();
                btnBillingActive.SendToBack();
            }

            //  btnRole.Text = ClassStatic.Role;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = this.txtUserName.Text.Trim();
            var password = this.txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(userName)) return;

            if (!CheckUser(userName, password))
            {
                MessageBox.Show("Incorrect Username/Password !", "THK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.activeButton = btnParameter;
            this.txtUserName.Text = null;
            this.txtPassword.Text = null;
            NavigateToParameter();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            label2.Hide();
        }

        private bool CheckUser(string userName, string password)
        {
            // Cho phép role = "1" hoặc role = "Admin" để truy cập Parameter
            const string AdminRoleValue = "1";
            const string AdminRoleText = "Admin";
            var connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Kiểm tra user có role = "1" hoặc role = "Admin"
                    cmd.CommandText = $"select count(*) from `account` where `UserName`=@UserName and `Password`=@Password and (`Role`=@Role1 or `Role`=@Role2)";
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role1", AdminRoleValue);
                    cmd.Parameters.AddWithValue("@Role2", AdminRoleText);

                    return Convert.ToInt16(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }
}
