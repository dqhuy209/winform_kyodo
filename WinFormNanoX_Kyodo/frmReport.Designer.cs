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
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnYearlyReport = new System.Windows.Forms.Button();
            this.btnZeroExport = new System.Windows.Forms.Button();
            this.btnEvenReport = new System.Windows.Forms.Button();
            this.btnAlarmReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.Silver;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.Location = new System.Drawing.Point(421, 451);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(120, 30);
            this.btnMonthlyReport.TabIndex = 80;
            this.btnMonthlyReport.Text = "Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            // 
            // btnYearlyReport
            // 
            this.btnYearlyReport.BackColor = System.Drawing.Color.Silver;
            this.btnYearlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlyReport.Location = new System.Drawing.Point(421, 658);
            this.btnYearlyReport.Name = "btnYearlyReport";
            this.btnYearlyReport.Size = new System.Drawing.Size(120, 30);
            this.btnYearlyReport.TabIndex = 79;
            this.btnYearlyReport.Text = "Report";
            this.btnYearlyReport.UseVisualStyleBackColor = false;
            // 
            // btnZeroExport
            // 
            this.btnZeroExport.BackColor = System.Drawing.Color.Silver;
            this.btnZeroExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroExport.Location = new System.Drawing.Point(1375, 660);
            this.btnZeroExport.Name = "btnZeroExport";
            this.btnZeroExport.Size = new System.Drawing.Size(102, 30);
            this.btnZeroExport.TabIndex = 78;
            this.btnZeroExport.Text = "Report";
            this.btnZeroExport.UseVisualStyleBackColor = false;
            // 
            // btnEvenReport
            // 
            this.btnEvenReport.BackColor = System.Drawing.Color.Silver;
            this.btnEvenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenReport.Location = new System.Drawing.Point(1378, 448);
            this.btnEvenReport.Name = "btnEvenReport";
            this.btnEvenReport.Size = new System.Drawing.Size(102, 30);
            this.btnEvenReport.TabIndex = 77;
            this.btnEvenReport.Text = "Report";
            this.btnEvenReport.UseVisualStyleBackColor = false;
            // 
            // btnAlarmReport
            // 
            this.btnAlarmReport.BackColor = System.Drawing.Color.Silver;
            this.btnAlarmReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmReport.Location = new System.Drawing.Point(1376, 245);
            this.btnAlarmReport.Name = "btnAlarmReport";
            this.btnAlarmReport.Size = new System.Drawing.Size(102, 30);
            this.btnAlarmReport.TabIndex = 76;
            this.btnAlarmReport.Text = "Report";
            this.btnAlarmReport.UseVisualStyleBackColor = false;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.Silver;
            this.btnDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.Location = new System.Drawing.Point(420, 250);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(120, 30);
            this.btnDailyReport.TabIndex = 75;
            this.btnDailyReport.Text = "Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(612, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 54);
            this.label1.TabIndex = 74;
            this.label1.Text = "Zero Export Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 935);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnYearlyReport);
            this.Controls.Add(this.btnZeroExport);
            this.Controls.Add(this.btnEvenReport);
            this.Controls.Add(this.btnAlarmReport);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnYearlyReport;
        private System.Windows.Forms.Button btnZeroExport;
        private System.Windows.Forms.Button btnEvenReport;
        private System.Windows.Forms.Button btnAlarmReport;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}