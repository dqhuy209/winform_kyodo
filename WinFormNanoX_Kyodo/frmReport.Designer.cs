namespace WinFormNanoX_Kyodo
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nanoXConnector1 = new NanoX.SCADA.WinForms.Connector.NanoXConnector(this.components);
            this.nanoXCommonReport1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReport();
            this.nanoXAlarmReport1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXAlarmReport();
            this.nanoXCommonReportMonthly1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReportMonthly();
            this.nanoXCommonReportYearly1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReportYearly();
            this.nanoXEventReport1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXEventReport();
            this.nanoXEnergyReportCommon1 = new NanoX.SCADAToolLibrary.MGraphic.NanoXEnergyReportCommon();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            // 
            // nanoXCommonReport1
            // 
            this.nanoXCommonReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXCommonReport1.Collection = new string[0];
            this.nanoXCommonReport1.Connector = this.nanoXConnector1;
            this.nanoXCommonReport1.Database = "scada";
            this.nanoXCommonReport1.Location = new System.Drawing.Point(42, 44);
            this.nanoXCommonReport1.Name = "nanoXCommonReport1";
            this.nanoXCommonReport1.NameReport = "Common Report";
            this.nanoXCommonReport1.Password = "1234";
            this.nanoXCommonReport1.Server = "localhost";
            this.nanoXCommonReport1.Size = new System.Drawing.Size(888, 200);
            this.nanoXCommonReport1.TabIndex = 81;
            this.nanoXCommonReport1.TableName = "data_common_report";
            this.nanoXCommonReport1.TagNameTime = "ITNCommonReport.Time";
            this.nanoXCommonReport1.TimerName = this.timer1;
            this.nanoXCommonReport1.UserName = "root";
            // 
            // nanoXAlarmReport1
            // 
            this.nanoXAlarmReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(199)))));
            this.nanoXAlarmReport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nanoXAlarmReport1.Database = "scada";
            this.nanoXAlarmReport1.Location = new System.Drawing.Point(1020, 44);
            this.nanoXAlarmReport1.Name = "nanoXAlarmReport1";
            this.nanoXAlarmReport1.NameReport = "AlarmReport";
            this.nanoXAlarmReport1.Password = "1234";
            this.nanoXAlarmReport1.Server = "localhost";
            this.nanoXAlarmReport1.Size = new System.Drawing.Size(888, 131);
            this.nanoXAlarmReport1.TabIndex = 82;
            this.nanoXAlarmReport1.TableName = "alarmlog";
            this.nanoXAlarmReport1.UserName = "root";
            // 
            // nanoXCommonReportMonthly1
            // 
            this.nanoXCommonReportMonthly1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.nanoXCommonReportMonthly1.Connector = this.nanoXConnector1;
            this.nanoXCommonReportMonthly1.Database = "scada";
            this.nanoXCommonReportMonthly1.Location = new System.Drawing.Point(42, 230);
            this.nanoXCommonReportMonthly1.Name = "nanoXCommonReportMonthly1";
            this.nanoXCommonReportMonthly1.NameReport = "CommonReportMonthly";
            this.nanoXCommonReportMonthly1.Password = "1234";
            this.nanoXCommonReportMonthly1.Server = "localhost";
            this.nanoXCommonReportMonthly1.Size = new System.Drawing.Size(888, 131);
            this.nanoXCommonReportMonthly1.TabIndex = 83;
            this.nanoXCommonReportMonthly1.TableName = "proc_commondata_month";
            this.nanoXCommonReportMonthly1.TagNameCO2 = null;
            this.nanoXCommonReportMonthly1.TagNameNormal = null;
            this.nanoXCommonReportMonthly1.TagNamePeak = null;
            this.nanoXCommonReportMonthly1.TimerName = this.timer1;
            this.nanoXCommonReportMonthly1.UserName = "root";
            // 
            // nanoXCommonReportYearly1
            // 
            this.nanoXCommonReportYearly1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.nanoXCommonReportYearly1.Connector = this.nanoXConnector1;
            this.nanoXCommonReportYearly1.Database = "scada";
            this.nanoXCommonReportYearly1.Location = new System.Drawing.Point(42, 421);
            this.nanoXCommonReportYearly1.Name = "nanoXCommonReportYearly1";
            this.nanoXCommonReportYearly1.NameReport = "CommonReportYearly";
            this.nanoXCommonReportYearly1.Password = "1234";
            this.nanoXCommonReportYearly1.Server = "localhost";
            this.nanoXCommonReportYearly1.Size = new System.Drawing.Size(888, 131);
            this.nanoXCommonReportYearly1.TabIndex = 84;
            this.nanoXCommonReportYearly1.TableName = "proc_commondata_year";
            this.nanoXCommonReportYearly1.TagNameCO2 = null;
            this.nanoXCommonReportYearly1.TagNameNormal = null;
            this.nanoXCommonReportYearly1.TagNamePeak = null;
            this.nanoXCommonReportYearly1.UserName = "root";
            // 
            // nanoXEventReport1
            // 
            this.nanoXEventReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(199)))));
            this.nanoXEventReport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nanoXEventReport1.Database = "scada";
            this.nanoXEventReport1.Location = new System.Drawing.Point(1020, 230);
            this.nanoXEventReport1.Name = "nanoXEventReport1";
            this.nanoXEventReport1.NameReport = "EventReport";
            this.nanoXEventReport1.Password = "1234";
            this.nanoXEventReport1.Server = "192.168.2.11";
            this.nanoXEventReport1.Size = new System.Drawing.Size(888, 131);
            this.nanoXEventReport1.TabIndex = 85;
            this.nanoXEventReport1.TableName = "eventlog";
            this.nanoXEventReport1.UserName = "root";
            // 
            // nanoXEnergyReportCommon1
            // 
            this.nanoXEnergyReportCommon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(199)))));
            this.nanoXEnergyReportCommon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nanoXEnergyReportCommon1.Collection = new string[0];
            this.nanoXEnergyReportCommon1.Database = "data";
            this.nanoXEnergyReportCommon1.Location = new System.Drawing.Point(1020, 421);
            this.nanoXEnergyReportCommon1.Name = "nanoXEnergyReportCommon1";
            this.nanoXEnergyReportCommon1.NameReport = "EnergyReport";
            this.nanoXEnergyReportCommon1.Password = "1234";
            this.nanoXEnergyReportCommon1.Server = "localhost";
            this.nanoXEnergyReportCommon1.Size = new System.Drawing.Size(888, 131);
            this.nanoXEnergyReportCommon1.TabIndex = 86;
            this.nanoXEnergyReportCommon1.TableName = "proc_zero_export_day";
            this.nanoXEnergyReportCommon1.UserName = "root";
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 935);
            this.Controls.Add(this.nanoXEnergyReportCommon1);
            this.Controls.Add(this.nanoXEventReport1);
            this.Controls.Add(this.nanoXCommonReportYearly1);
            this.Controls.Add(this.nanoXCommonReportMonthly1);
            this.Controls.Add(this.nanoXAlarmReport1);
            this.Controls.Add(this.nanoXCommonReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReport nanoXCommonReport1;
        private NanoX.SCADA.WinForms.Connector.NanoXConnector nanoXConnector1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXAlarmReport nanoXAlarmReport1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReportMonthly nanoXCommonReportMonthly1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXCommonReportYearly nanoXCommonReportYearly1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXEventReport nanoXEventReport1;
        private NanoX.SCADAToolLibrary.MGraphic.NanoXEnergyReportCommon nanoXEnergyReportCommon1;
    }
}