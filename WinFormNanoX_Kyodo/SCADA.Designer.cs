namespace WinFormNanoX_Kyodo
{
    partial class SCADA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCADA));
            this.btnVisitor = new System.Windows.Forms.Button();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnParameter = new System.Windows.Forms.Button();
            this.btnVisitorInActive = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnParameterActive = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnZeroExport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRecordActive = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnEventActive = new System.Windows.Forms.Button();
            this.btnSingleLine = new System.Windows.Forms.Button();
            this.btnReportActive = new System.Windows.Forms.Button();
            this.btnBillingActive = new System.Windows.Forms.Button();
            this.btnInverterActive = new System.Windows.Forms.Button();
            this.btnSingleLineActive = new System.Windows.Forms.Button();
            this.btnOverviewActive = new System.Windows.Forms.Button();
            this.btnGraphActive = new System.Windows.Forms.Button();
            this.btnAlarmActive = new System.Windows.Forms.Button();
            this.btnZeroExportActive = new System.Windows.Forms.Button();
            this.pnlVisitor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nanoXConnector1 = new NanoX.SCADA.WinForms.Connector.NanoXConnector(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.White;
            this.btnVisitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisitor.BackgroundImage")));
            this.btnVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVisitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVisitor.ForeColor = System.Drawing.Color.Black;
            this.btnVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVisitor.Location = new System.Drawing.Point(1620, 65);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(148, 70);
            this.btnVisitor.TabIndex = 1780;
            this.btnVisitor.Text = "         Visitor \r\n         Screen";
            this.btnVisitor.UseVisualStyleBackColor = false;
            // 
            // lblAlarm
            // 
            this.lblAlarm.BackColor = System.Drawing.Color.Red;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlarm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAlarm.Location = new System.Drawing.Point(589, 17);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(808, 31);
            this.lblAlarm.TabIndex = 1779;
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(1775, 82);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(38, 38);
            this.btnLogout.TabIndex = 1778;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnParameter
            // 
            this.btnParameter.BackColor = System.Drawing.Color.White;
            this.btnParameter.FlatAppearance.BorderSize = 0;
            this.btnParameter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnParameter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnParameter.ForeColor = System.Drawing.Color.Black;
            this.btnParameter.Image = ((System.Drawing.Image)(resources.GetObject("btnParameter.Image")));
            this.btnParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnParameter.Location = new System.Drawing.Point(1460, 63);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(157, 72);
            this.btnParameter.TabIndex = 1766;
            this.btnParameter.Text = "      User\r\n         Settings";
            this.btnParameter.UseVisualStyleBackColor = false;
            // 
            // btnVisitorInActive
            // 
            this.btnVisitorInActive.BackColor = System.Drawing.Color.White;
            this.btnVisitorInActive.FlatAppearance.BorderSize = 0;
            this.btnVisitorInActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVisitorInActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVisitorInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVisitorInActive.ForeColor = System.Drawing.Color.Black;
            this.btnVisitorInActive.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitorInActive.Image")));
            this.btnVisitorInActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVisitorInActive.Location = new System.Drawing.Point(1619, 63);
            this.btnVisitorInActive.Name = "btnVisitorInActive";
            this.btnVisitorInActive.Size = new System.Drawing.Size(148, 72);
            this.btnVisitorInActive.TabIndex = 1781;
            this.btnVisitorInActive.Text = "         Visitor \r\n         Screen\r\n";
            this.btnVisitorInActive.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.White;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRecord.ForeColor = System.Drawing.Color.Black;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRecord.Location = new System.Drawing.Point(877, 63);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(147, 72);
            this.btnRecord.TabIndex = 1768;
            this.btnRecord.Text = "          Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            // 
            // btnParameterActive
            // 
            this.btnParameterActive.BackColor = System.Drawing.Color.White;
            this.btnParameterActive.FlatAppearance.BorderSize = 0;
            this.btnParameterActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnParameterActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnParameterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnParameterActive.ForeColor = System.Drawing.Color.Black;
            this.btnParameterActive.Image = ((System.Drawing.Image)(resources.GetObject("btnParameterActive.Image")));
            this.btnParameterActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnParameterActive.Location = new System.Drawing.Point(1460, 63);
            this.btnParameterActive.Name = "btnParameterActive";
            this.btnParameterActive.Size = new System.Drawing.Size(142, 72);
            this.btnParameterActive.TabIndex = 1767;
            this.btnParameterActive.Text = "      User\r\n         Setting";
            this.btnParameterActive.UseVisualStyleBackColor = false;
            // 
            // btnInverter
            // 
            this.btnInverter.BackColor = System.Drawing.Color.White;
            this.btnInverter.FlatAppearance.BorderSize = 0;
            this.btnInverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInverter.ForeColor = System.Drawing.Color.Black;
            this.btnInverter.Image = ((System.Drawing.Image)(resources.GetObject("btnInverter.Image")));
            this.btnInverter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInverter.Location = new System.Drawing.Point(292, 63);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(152, 72);
            this.btnInverter.TabIndex = 1763;
            this.btnInverter.Text = "        Inverter";
            this.btnInverter.UseVisualStyleBackColor = false;
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.White;
            this.btnBilling.FlatAppearance.BorderSize = 0;
            this.btnBilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBilling.ForeColor = System.Drawing.Color.Black;
            this.btnBilling.Image = ((System.Drawing.Image)(resources.GetObject("btnBilling.Image")));
            this.btnBilling.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBilling.Location = new System.Drawing.Point(1170, 63);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(142, 72);
            this.btnBilling.TabIndex = 1776;
            this.btnBilling.Text = "         Billing";
            this.btnBilling.UseVisualStyleBackColor = false;
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.White;
            this.btnOverview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOverview.ForeColor = System.Drawing.Color.Black;
            this.btnOverview.Image = ((System.Drawing.Image)(resources.GetObject("btnOverview.Image")));
            this.btnOverview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOverview.Location = new System.Drawing.Point(4, 63);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(142, 72);
            this.btnOverview.TabIndex = 1751;
            this.btnOverview.Text = "     Over\r\n     view";
            this.btnOverview.UseVisualStyleBackColor = false;
            // 
            // btnZeroExport
            // 
            this.btnZeroExport.BackColor = System.Drawing.Color.White;
            this.btnZeroExport.FlatAppearance.BorderSize = 0;
            this.btnZeroExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZeroExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZeroExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZeroExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnZeroExport.ForeColor = System.Drawing.Color.Black;
            this.btnZeroExport.Image = ((System.Drawing.Image)(resources.GetObject("btnZeroExport.Image")));
            this.btnZeroExport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroExport.Location = new System.Drawing.Point(1314, 63);
            this.btnZeroExport.Name = "btnZeroExport";
            this.btnZeroExport.Size = new System.Drawing.Size(142, 72);
            this.btnZeroExport.TabIndex = 1756;
            this.btnZeroExport.Text = "         Zero\r\n         Export";
            this.btnZeroExport.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReport.Location = new System.Drawing.Point(1024, 63);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(142, 72);
            this.btnReport.TabIndex = 1752;
            this.btnReport.Text = "        Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(1773, 1062);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 16);
            this.lblTime.TabIndex = 1757;
            this.lblTime.Text = "2:19 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(1763, 1070);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 16);
            this.lblDate.TabIndex = 1758;
            this.lblDate.Text = "2022/7/5";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(1826, 82);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 1755;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(1880, 82);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 1750;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.White;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEvent.ForeColor = System.Drawing.Color.Black;
            this.btnEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnEvent.Image")));
            this.btnEvent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEvent.Location = new System.Drawing.Point(734, 63);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(142, 72);
            this.btnEvent.TabIndex = 1773;
            this.btnEvent.Text = "         Events";
            this.btnEvent.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WinFormNanoX_Kyodo.Properties.Resources.HeaderKyodo;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1920, 62);
            this.pictureBox2.TabIndex = 1775;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.White;
            this.btnAlarm.FlatAppearance.BorderSize = 0;
            this.btnAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarm.Image")));
            this.btnAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlarm.Location = new System.Drawing.Point(592, 63);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(144, 72);
            this.btnAlarm.TabIndex = 1753;
            this.btnAlarm.Text = "       Alarms";
            this.btnAlarm.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.pnlMain.Location = new System.Drawing.Point(0, 140);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1920, 1262);
            this.pnlMain.TabIndex = 1769;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxRole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblTittle);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(665, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(17, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 37);
            this.label10.TabIndex = 40;
            this.label10.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 10);
            this.label4.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 10);
            this.label2.TabIndex = 1;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "Admin",
            "Operator",
            "Guest"});
            this.cbxRole.Location = new System.Drawing.Point(105, 136);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(213, 34);
            this.cbxRole.TabIndex = 37;
            this.cbxRole.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Role";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(218, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTittle.Location = new System.Drawing.Point(18, 17);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(110, 32);
            this.lblTittle.TabIndex = 27;
            this.lblTittle.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(105, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 25);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(18, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(154, 32);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(18, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(137, 32);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(213, 34);
            this.txtPassword.TabIndex = 32;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(105, 66);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(213, 34);
            this.txtUserName.TabIndex = 31;
            // 
            // btnRecordActive
            // 
            this.btnRecordActive.BackColor = System.Drawing.Color.White;
            this.btnRecordActive.FlatAppearance.BorderSize = 0;
            this.btnRecordActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecordActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecordActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRecordActive.ForeColor = System.Drawing.Color.Black;
            this.btnRecordActive.Image = ((System.Drawing.Image)(resources.GetObject("btnRecordActive.Image")));
            this.btnRecordActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRecordActive.Location = new System.Drawing.Point(877, 63);
            this.btnRecordActive.Name = "btnRecordActive";
            this.btnRecordActive.Size = new System.Drawing.Size(147, 72);
            this.btnRecordActive.TabIndex = 1770;
            this.btnRecordActive.Text = "          Record";
            this.btnRecordActive.UseVisualStyleBackColor = false;
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.White;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGraph.ForeColor = System.Drawing.Color.Black;
            this.btnGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnGraph.Image")));
            this.btnGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGraph.Location = new System.Drawing.Point(446, 63);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(142, 72);
            this.btnGraph.TabIndex = 1762;
            this.btnGraph.Text = "         Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            // 
            // btnEventActive
            // 
            this.btnEventActive.BackColor = System.Drawing.Color.White;
            this.btnEventActive.FlatAppearance.BorderSize = 0;
            this.btnEventActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEventActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEventActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEventActive.ForeColor = System.Drawing.Color.Black;
            this.btnEventActive.Image = ((System.Drawing.Image)(resources.GetObject("btnEventActive.Image")));
            this.btnEventActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEventActive.Location = new System.Drawing.Point(734, 63);
            this.btnEventActive.Name = "btnEventActive";
            this.btnEventActive.Size = new System.Drawing.Size(142, 72);
            this.btnEventActive.TabIndex = 1774;
            this.btnEventActive.Text = "         Event";
            this.btnEventActive.UseVisualStyleBackColor = false;
            // 
            // btnSingleLine
            // 
            this.btnSingleLine.BackColor = System.Drawing.Color.White;
            this.btnSingleLine.FlatAppearance.BorderSize = 0;
            this.btnSingleLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSingleLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSingleLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSingleLine.ForeColor = System.Drawing.Color.Black;
            this.btnSingleLine.Image = ((System.Drawing.Image)(resources.GetObject("btnSingleLine.Image")));
            this.btnSingleLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSingleLine.Location = new System.Drawing.Point(148, 63);
            this.btnSingleLine.Name = "btnSingleLine";
            this.btnSingleLine.Size = new System.Drawing.Size(142, 72);
            this.btnSingleLine.TabIndex = 1771;
            this.btnSingleLine.Text = "       Single\r\n     line";
            this.btnSingleLine.UseVisualStyleBackColor = false;
            // 
            // btnReportActive
            // 
            this.btnReportActive.BackColor = System.Drawing.Color.White;
            this.btnReportActive.FlatAppearance.BorderSize = 0;
            this.btnReportActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReportActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReportActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReportActive.ForeColor = System.Drawing.Color.Black;
            this.btnReportActive.Image = ((System.Drawing.Image)(resources.GetObject("btnReportActive.Image")));
            this.btnReportActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReportActive.Location = new System.Drawing.Point(1024, 63);
            this.btnReportActive.Name = "btnReportActive";
            this.btnReportActive.Size = new System.Drawing.Size(142, 72);
            this.btnReportActive.TabIndex = 1760;
            this.btnReportActive.Text = "         Report";
            this.btnReportActive.UseVisualStyleBackColor = false;
            // 
            // btnBillingActive
            // 
            this.btnBillingActive.BackColor = System.Drawing.Color.White;
            this.btnBillingActive.FlatAppearance.BorderSize = 0;
            this.btnBillingActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillingActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBillingActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBillingActive.ForeColor = System.Drawing.Color.Black;
            this.btnBillingActive.Image = ((System.Drawing.Image)(resources.GetObject("btnBillingActive.Image")));
            this.btnBillingActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBillingActive.Location = new System.Drawing.Point(1168, 63);
            this.btnBillingActive.Name = "btnBillingActive";
            this.btnBillingActive.Size = new System.Drawing.Size(142, 72);
            this.btnBillingActive.TabIndex = 1777;
            this.btnBillingActive.Text = "         Billing";
            this.btnBillingActive.UseVisualStyleBackColor = false;
            // 
            // btnInverterActive
            // 
            this.btnInverterActive.BackColor = System.Drawing.Color.White;
            this.btnInverterActive.FlatAppearance.BorderSize = 0;
            this.btnInverterActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInverterActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInverterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInverterActive.ForeColor = System.Drawing.Color.Black;
            this.btnInverterActive.Image = ((System.Drawing.Image)(resources.GetObject("btnInverterActive.Image")));
            this.btnInverterActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInverterActive.Location = new System.Drawing.Point(292, 63);
            this.btnInverterActive.Name = "btnInverterActive";
            this.btnInverterActive.Size = new System.Drawing.Size(152, 72);
            this.btnInverterActive.TabIndex = 1764;
            this.btnInverterActive.Text = "        Inverter";
            this.btnInverterActive.UseVisualStyleBackColor = false;
            // 
            // btnSingleLineActive
            // 
            this.btnSingleLineActive.BackColor = System.Drawing.Color.White;
            this.btnSingleLineActive.FlatAppearance.BorderSize = 0;
            this.btnSingleLineActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSingleLineActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSingleLineActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleLineActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSingleLineActive.ForeColor = System.Drawing.Color.Black;
            this.btnSingleLineActive.Image = ((System.Drawing.Image)(resources.GetObject("btnSingleLineActive.Image")));
            this.btnSingleLineActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSingleLineActive.Location = new System.Drawing.Point(148, 63);
            this.btnSingleLineActive.Name = "btnSingleLineActive";
            this.btnSingleLineActive.Size = new System.Drawing.Size(142, 72);
            this.btnSingleLineActive.TabIndex = 1772;
            this.btnSingleLineActive.Text = "       Single\r\n     line";
            this.btnSingleLineActive.UseVisualStyleBackColor = false;
            // 
            // btnOverviewActive
            // 
            this.btnOverviewActive.BackColor = System.Drawing.Color.White;
            this.btnOverviewActive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOverviewActive.FlatAppearance.BorderSize = 0;
            this.btnOverviewActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOverviewActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOverviewActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverviewActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOverviewActive.ForeColor = System.Drawing.Color.Black;
            this.btnOverviewActive.Image = ((System.Drawing.Image)(resources.GetObject("btnOverviewActive.Image")));
            this.btnOverviewActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOverviewActive.Location = new System.Drawing.Point(4, 63);
            this.btnOverviewActive.Name = "btnOverviewActive";
            this.btnOverviewActive.Size = new System.Drawing.Size(142, 72);
            this.btnOverviewActive.TabIndex = 1754;
            this.btnOverviewActive.Text = "     Over\r\n     view";
            this.btnOverviewActive.UseVisualStyleBackColor = false;
            // 
            // btnGraphActive
            // 
            this.btnGraphActive.BackColor = System.Drawing.Color.White;
            this.btnGraphActive.FlatAppearance.BorderSize = 0;
            this.btnGraphActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGraphActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGraphActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGraphActive.ForeColor = System.Drawing.Color.Black;
            this.btnGraphActive.Image = ((System.Drawing.Image)(resources.GetObject("btnGraphActive.Image")));
            this.btnGraphActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGraphActive.Location = new System.Drawing.Point(446, 63);
            this.btnGraphActive.Name = "btnGraphActive";
            this.btnGraphActive.Size = new System.Drawing.Size(142, 72);
            this.btnGraphActive.TabIndex = 1765;
            this.btnGraphActive.Text = "         Graph";
            this.btnGraphActive.UseVisualStyleBackColor = false;
            // 
            // btnAlarmActive
            // 
            this.btnAlarmActive.BackColor = System.Drawing.Color.White;
            this.btnAlarmActive.FlatAppearance.BorderSize = 0;
            this.btnAlarmActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlarmActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlarmActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAlarmActive.ForeColor = System.Drawing.Color.Black;
            this.btnAlarmActive.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarmActive.Image")));
            this.btnAlarmActive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlarmActive.Location = new System.Drawing.Point(592, 63);
            this.btnAlarmActive.Name = "btnAlarmActive";
            this.btnAlarmActive.Size = new System.Drawing.Size(144, 72);
            this.btnAlarmActive.TabIndex = 1759;
            this.btnAlarmActive.Text = "       Alarm";
            this.btnAlarmActive.UseVisualStyleBackColor = false;
            // 
            // btnZeroExportActive
            // 
            this.btnZeroExportActive.BackColor = System.Drawing.Color.White;
            this.btnZeroExportActive.FlatAppearance.BorderSize = 0;
            this.btnZeroExportActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZeroExportActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZeroExportActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZeroExportActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnZeroExportActive.ForeColor = System.Drawing.Color.Black;
            this.btnZeroExportActive.Image = ((System.Drawing.Image)(resources.GetObject("btnZeroExportActive.Image")));
            this.btnZeroExportActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroExportActive.Location = new System.Drawing.Point(1312, 63);
            this.btnZeroExportActive.Name = "btnZeroExportActive";
            this.btnZeroExportActive.Size = new System.Drawing.Size(142, 72);
            this.btnZeroExportActive.TabIndex = 1761;
            this.btnZeroExportActive.Text = "         Zero\r\n         Export";
            this.btnZeroExportActive.UseVisualStyleBackColor = false;
            // 
            // pnlVisitor
            // 
            this.pnlVisitor.Location = new System.Drawing.Point(0, -1);
            this.pnlVisitor.Name = "pnlVisitor";
            this.pnlVisitor.Size = new System.Drawing.Size(1920, 1080);
            this.pnlVisitor.TabIndex = 1782;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SCADA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnVisitor);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnParameter);
            this.Controls.Add(this.btnVisitorInActive);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnParameterActive);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnZeroExport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnRecordActive);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnEventActive);
            this.Controls.Add(this.btnSingleLine);
            this.Controls.Add(this.btnReportActive);
            this.Controls.Add(this.btnBillingActive);
            this.Controls.Add(this.btnInverterActive);
            this.Controls.Add(this.btnSingleLineActive);
            this.Controls.Add(this.btnOverviewActive);
            this.Controls.Add(this.btnGraphActive);
            this.Controls.Add(this.btnAlarmActive);
            this.Controls.Add(this.btnZeroExportActive);
            this.Controls.Add(this.pnlVisitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SCADA";
            this.Text = "SCADA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.Button btnVisitorInActive;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnParameterActive;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnZeroExport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnRecordActive;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnEventActive;
        private System.Windows.Forms.Button btnSingleLine;
        private System.Windows.Forms.Button btnReportActive;
        private System.Windows.Forms.Button btnBillingActive;
        private System.Windows.Forms.Button btnInverterActive;
        private System.Windows.Forms.Button btnSingleLineActive;
        private System.Windows.Forms.Button btnOverviewActive;
        private System.Windows.Forms.Button btnGraphActive;
        private System.Windows.Forms.Button btnAlarmActive;
        private System.Windows.Forms.Button btnZeroExportActive;
        private System.Windows.Forms.Panel pnlVisitor;
        private System.Windows.Forms.Timer timer1;
        private NanoX.SCADA.WinForms.Connector.NanoXConnector nanoXConnector1;
    }
}