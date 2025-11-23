namespace WinFormNanoX_Kyodo
{
    partial class frmOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverview));
            this.label10 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.ValueLoad = new System.Windows.Forms.Label();
            this.labelSaving = new System.Windows.Forms.Label();
            this.labelSolar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPVTemp = new System.Windows.Forms.Label();
            this.labelCo2 = new System.Windows.Forms.Label();
            this.labelTotalYield = new System.Windows.Forms.Label();
            this.labelIrradiance = new System.Windows.Forms.Label();
            this.labelAbTemp = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.nanoXConnector1 = new NanoX.SCADA.WinForms.Connector.NanoXConnector(this.components);
            this.labelLoadYealy = new System.Windows.Forms.Label();
            this.labelLoadMonthly = new System.Windows.Forms.Label();
            this.mInputMoneyConstant1 = new NanoX.SCADAToolLibrary.MGraphic.MInputMoneyConstant();
            this.mInputCO2Rate1 = new NanoX.SCADAToolLibrary.MGraphic.MInputCO2Rate();
            this.nanoXLabel_ValueMoney = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueCo2 = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueTotalYield = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueIrradiance = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueAbTemp = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValuePVTemp = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueGrid = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueIER = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueSaving = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.nanoXLabel_ValueSolar = new NanoX.SCADAToolLibrary.XLabel.NanoXLabel();
            this.mSignateAreaChart_Monthly = new NanoX.SCADAToolLibrary.MGraphic.MSignateAreaChart();
            this.mSignateColumnChart_Yearly = new NanoX.SCADAToolLibrary.MGraphic.MSignateColumnChart();
            this.mSignateAreaLineChart_Daily = new NanoX.SCADAToolLibrary.MGraphic.MSignateAreaLineChart();
            this.mPicturePower1 = new NanoX.SCADAToolLibrary.MGraphic.MPicturePower();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1172, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 36);
            this.label10.TabIndex = 2125;
            this.label10.Text = "Total Yield";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPower
            // 
            this.lblPower.BackColor = System.Drawing.SystemColors.Window;
            this.lblPower.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(135, 7);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(243, 36);
            this.lblPower.TabIndex = 2119;
            this.lblPower.Text = "Current Power";
            this.lblPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueLoad
            // 
            this.ValueLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.ValueLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ValueLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.ValueLoad.Location = new System.Drawing.Point(25, 242);
            this.ValueLoad.Name = "ValueLoad";
            this.ValueLoad.Size = new System.Drawing.Size(83, 23);
            this.ValueLoad.TabIndex = 2118;
            this.ValueLoad.Text = "-";
            this.ValueLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSaving
            // 
            this.labelSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaving.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelSaving.Location = new System.Drawing.Point(285, 71);
            this.labelSaving.Name = "labelSaving";
            this.labelSaving.Size = new System.Drawing.Size(147, 33);
            this.labelSaving.TabIndex = 2117;
            this.labelSaving.Text = "Saving";
            this.labelSaving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSolar
            // 
            this.labelSolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelSolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolar.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelSolar.Location = new System.Drawing.Point(48, 71);
            this.labelSolar.Name = "labelSolar";
            this.labelSolar.Size = new System.Drawing.Size(147, 33);
            this.labelSolar.TabIndex = 2116;
            this.labelSolar.Text = "Solar";
            this.labelSolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(82, 820);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(900, 57);
            this.pictureBox8.TabIndex = 2115;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LimeGreen;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(363, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 23);
            this.label13.TabIndex = 2101;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(122, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 2102;
            this.label2.Text = "kW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 282);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1050, 645);
            this.pictureBox5.TabIndex = 2112;
            this.pictureBox5.TabStop = false;
            // 
            // labelMoney
            // 
            this.labelMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelMoney.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.ForeColor = System.Drawing.Color.White;
            this.labelMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMoney.Location = new System.Drawing.Point(1675, 236);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(224, 27);
            this.labelMoney.TabIndex = 2111;
            this.labelMoney.Text = "mVND";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1662, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 280);
            this.pictureBox1.TabIndex = 2110;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(107, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 2109;
            this.label9.Text = "kW";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(407, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 2108;
            this.label1.Text = "kW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPVTemp
            // 
            this.labelPVTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelPVTemp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVTemp.ForeColor = System.Drawing.Color.White;
            this.labelPVTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPVTemp.Location = new System.Drawing.Point(516, 236);
            this.labelPVTemp.Name = "labelPVTemp";
            this.labelPVTemp.Size = new System.Drawing.Size(188, 29);
            this.labelPVTemp.TabIndex = 2107;
            this.labelPVTemp.Text = "°C";
            this.labelPVTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCo2
            // 
            this.labelCo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelCo2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCo2.ForeColor = System.Drawing.Color.White;
            this.labelCo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCo2.Location = new System.Drawing.Point(1420, 236);
            this.labelCo2.Name = "labelCo2";
            this.labelCo2.Size = new System.Drawing.Size(224, 27);
            this.labelCo2.TabIndex = 2106;
            this.labelCo2.Text = "Tons";
            this.labelCo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalYield
            // 
            this.labelTotalYield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelTotalYield.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalYield.ForeColor = System.Drawing.Color.White;
            this.labelTotalYield.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalYield.Location = new System.Drawing.Point(1167, 236);
            this.labelTotalYield.Name = "labelTotalYield";
            this.labelTotalYield.Size = new System.Drawing.Size(224, 28);
            this.labelTotalYield.TabIndex = 2105;
            this.labelTotalYield.Text = "MWh";
            this.labelTotalYield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIrradiance
            // 
            this.labelIrradiance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelIrradiance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIrradiance.ForeColor = System.Drawing.Color.White;
            this.labelIrradiance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelIrradiance.Location = new System.Drawing.Point(951, 236);
            this.labelIrradiance.Name = "labelIrradiance";
            this.labelIrradiance.Size = new System.Drawing.Size(183, 28);
            this.labelIrradiance.TabIndex = 2104;
            this.labelIrradiance.Text = "W/m²";
            this.labelIrradiance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAbTemp
            // 
            this.labelAbTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.labelAbTemp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbTemp.ForeColor = System.Drawing.Color.White;
            this.labelAbTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAbTemp.Location = new System.Drawing.Point(731, 236);
            this.labelAbTemp.Name = "labelAbTemp";
            this.labelAbTemp.Size = new System.Drawing.Size(191, 29);
            this.labelAbTemp.TabIndex = 2103;
            this.labelAbTemp.Text = "°C";
            this.labelAbTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1408, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 280);
            this.pictureBox4.TabIndex = 2100;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1154, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 280);
            this.pictureBox3.TabIndex = 2099;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 280);
            this.pictureBox2.TabIndex = 2098;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1060, 602);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(850, 325);
            this.pictureBox7.TabIndex = 2114;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1060, 282);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(850, 318);
            this.pictureBox6.TabIndex = 2113;
            this.pictureBox6.TabStop = false;
            // 
            // labelLoadYealy
            // 
            this.labelLoadYealy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadYealy.Location = new System.Drawing.Point(1550, 617);
            this.labelLoadYealy.Name = "labelLoadYealy";
            this.labelLoadYealy.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.labelLoadYealy.Size = new System.Drawing.Size(40, 18);
            this.labelLoadYealy.TabIndex = 2139;
            this.labelLoadYealy.Text = "Load";
            // 
            // labelLoadMonthly
            // 
            this.labelLoadMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadMonthly.Location = new System.Drawing.Point(1551, 298);
            this.labelLoadMonthly.Name = "labelLoadMonthly";
            this.labelLoadMonthly.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.labelLoadMonthly.Size = new System.Drawing.Size(40, 18);
            this.labelLoadMonthly.TabIndex = 2139;
            this.labelLoadMonthly.Text = "Load";
            // 
            // mInputMoneyConstant1
            // 
            this.mInputMoneyConstant1.BackColor = System.Drawing.SystemColors.Control;
            this.mInputMoneyConstant1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mInputMoneyConstant1.Database = "scada";
            this.mInputMoneyConstant1.Location = new System.Drawing.Point(1507, 355);
            this.mInputMoneyConstant1.Name = "mInputMoneyConstant1";
            this.mInputMoneyConstant1.Password = "1234";
            this.mInputMoneyConstant1.ProcName = "proc_total_energy_for_money_save";
            this.mInputMoneyConstant1.Server = "localhost";
            this.mInputMoneyConstant1.Size = new System.Drawing.Size(333, 169);
            this.mInputMoneyConstant1.TabIndex = 2141;
            this.mInputMoneyConstant1.TableName = "constant_money";
            this.mInputMoneyConstant1.TagResult = null;
            this.mInputMoneyConstant1.TimerName = null;
            this.mInputMoneyConstant1.UserName = "root";
            // 
            // mInputCO2Rate1
            // 
            this.mInputCO2Rate1.BackColor = System.Drawing.SystemColors.Control;
            this.mInputCO2Rate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mInputCO2Rate1.Database = "scada";
            this.mInputCO2Rate1.Location = new System.Drawing.Point(1154, 355);
            this.mInputCO2Rate1.Name = "mInputCO2Rate1";
            this.mInputCO2Rate1.Password = "1234";
            this.mInputCO2Rate1.ProcName = "proc_total_energy_year_for_co2";
            this.mInputCO2Rate1.Server = "localhost";
            this.mInputCO2Rate1.Size = new System.Drawing.Size(337, 169);
            this.mInputCO2Rate1.TabIndex = 2140;
            this.mInputCO2Rate1.TableName = "constant_co2";
            this.mInputCO2Rate1.TagCO2Rate = null;
            this.mInputCO2Rate1.TagResult = null;
            this.mInputCO2Rate1.TimerName = null;
            this.mInputCO2Rate1.UserName = "root";
            // 
            // nanoXLabel_ValueMoney
            // 
            this.nanoXLabel_ValueMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueMoney.Decimal = null;
            this.nanoXLabel_ValueMoney.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueMoney.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValueMoney.Location = new System.Drawing.Point(1690, 209);
            this.nanoXLabel_ValueMoney.Name = "nanoXLabel_ValueMoney";
            this.nanoXLabel_ValueMoney.NodePath = "[Connection]/Folder/Tag6";
            this.nanoXLabel_ValueMoney.PropertyName = "EngValue";
            this.nanoXLabel_ValueMoney.scale = 1D;
            this.nanoXLabel_ValueMoney.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValueMoney.TabIndex = 2138;
            this.nanoXLabel_ValueMoney.Text = "--";
            this.nanoXLabel_ValueMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueCo2
            // 
            this.nanoXLabel_ValueCo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueCo2.Decimal = null;
            this.nanoXLabel_ValueCo2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueCo2.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValueCo2.Location = new System.Drawing.Point(1435, 209);
            this.nanoXLabel_ValueCo2.Name = "nanoXLabel_ValueCo2";
            this.nanoXLabel_ValueCo2.NodePath = "[Connection]/Folder/Tag5";
            this.nanoXLabel_ValueCo2.PropertyName = "EngValue";
            this.nanoXLabel_ValueCo2.scale = 1D;
            this.nanoXLabel_ValueCo2.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValueCo2.TabIndex = 2137;
            this.nanoXLabel_ValueCo2.Text = "--";
            this.nanoXLabel_ValueCo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueTotalYield
            // 
            this.nanoXLabel_ValueTotalYield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueTotalYield.Decimal = null;
            this.nanoXLabel_ValueTotalYield.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueTotalYield.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValueTotalYield.Location = new System.Drawing.Point(1177, 209);
            this.nanoXLabel_ValueTotalYield.Name = "nanoXLabel_ValueTotalYield";
            this.nanoXLabel_ValueTotalYield.NodePath = "[Connection]/Folder/Tag4";
            this.nanoXLabel_ValueTotalYield.PropertyName = "EngValue";
            this.nanoXLabel_ValueTotalYield.scale = 1D;
            this.nanoXLabel_ValueTotalYield.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValueTotalYield.TabIndex = 2136;
            this.nanoXLabel_ValueTotalYield.Text = "--";
            this.nanoXLabel_ValueTotalYield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueIrradiance
            // 
            this.nanoXLabel_ValueIrradiance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueIrradiance.Decimal = null;
            this.nanoXLabel_ValueIrradiance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueIrradiance.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValueIrradiance.Location = new System.Drawing.Point(941, 208);
            this.nanoXLabel_ValueIrradiance.Name = "nanoXLabel_ValueIrradiance";
            this.nanoXLabel_ValueIrradiance.NodePath = "[Connection]/Folder/Tag3";
            this.nanoXLabel_ValueIrradiance.PropertyName = "EngValue";
            this.nanoXLabel_ValueIrradiance.scale = 1D;
            this.nanoXLabel_ValueIrradiance.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValueIrradiance.TabIndex = 2135;
            this.nanoXLabel_ValueIrradiance.Text = "--";
            this.nanoXLabel_ValueIrradiance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueAbTemp
            // 
            this.nanoXLabel_ValueAbTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueAbTemp.Decimal = null;
            this.nanoXLabel_ValueAbTemp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueAbTemp.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValueAbTemp.Location = new System.Drawing.Point(729, 208);
            this.nanoXLabel_ValueAbTemp.Name = "nanoXLabel_ValueAbTemp";
            this.nanoXLabel_ValueAbTemp.NodePath = "[Connection]/Folder/Tag2";
            this.nanoXLabel_ValueAbTemp.PropertyName = "EngValue";
            this.nanoXLabel_ValueAbTemp.scale = 1D;
            this.nanoXLabel_ValueAbTemp.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValueAbTemp.TabIndex = 2134;
            this.nanoXLabel_ValueAbTemp.Text = "--";
            this.nanoXLabel_ValueAbTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValuePVTemp
            // 
            this.nanoXLabel_ValuePVTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValuePVTemp.Decimal = null;
            this.nanoXLabel_ValuePVTemp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValuePVTemp.ForeColor = System.Drawing.Color.White;
            this.nanoXLabel_ValuePVTemp.Location = new System.Drawing.Point(516, 202);
            this.nanoXLabel_ValuePVTemp.Name = "nanoXLabel_ValuePVTemp";
            this.nanoXLabel_ValuePVTemp.NodePath = "[Connection]/Folder/Tag6";
            this.nanoXLabel_ValuePVTemp.PropertyName = "EngValue";
            this.nanoXLabel_ValuePVTemp.scale = 1D;
            this.nanoXLabel_ValuePVTemp.Size = new System.Drawing.Size(193, 30);
            this.nanoXLabel_ValuePVTemp.TabIndex = 2133;
            this.nanoXLabel_ValuePVTemp.Text = "--";
            this.nanoXLabel_ValuePVTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueGrid
            // 
            this.nanoXLabel_ValueGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueGrid.Decimal = null;
            this.nanoXLabel_ValueGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueGrid.ForeColor = System.Drawing.Color.Red;
            this.nanoXLabel_ValueGrid.Location = new System.Drawing.Point(341, 237);
            this.nanoXLabel_ValueGrid.Name = "nanoXLabel_ValueGrid";
            this.nanoXLabel_ValueGrid.NodePath = "";
            this.nanoXLabel_ValueGrid.PropertyName = "EngValue";
            this.nanoXLabel_ValueGrid.scale = 1D;
            this.nanoXLabel_ValueGrid.Size = new System.Drawing.Size(60, 28);
            this.nanoXLabel_ValueGrid.TabIndex = 2132;
            this.nanoXLabel_ValueGrid.Text = "--";
            this.nanoXLabel_ValueGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueIER
            // 
            this.nanoXLabel_ValueIER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueIER.Decimal = null;
            this.nanoXLabel_ValueIER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueIER.ForeColor = System.Drawing.Color.Aqua;
            this.nanoXLabel_ValueIER.Location = new System.Drawing.Point(93, 129);
            this.nanoXLabel_ValueIER.Name = "nanoXLabel_ValueIER";
            this.nanoXLabel_ValueIER.NodePath = "";
            this.nanoXLabel_ValueIER.PropertyName = "EngValue";
            this.nanoXLabel_ValueIER.scale = 1D;
            this.nanoXLabel_ValueIER.Size = new System.Drawing.Size(60, 28);
            this.nanoXLabel_ValueIER.TabIndex = 2131;
            this.nanoXLabel_ValueIER.Text = "-";
            this.nanoXLabel_ValueIER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nanoXLabel_ValueSaving
            // 
            this.nanoXLabel_ValueSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueSaving.Decimal = null;
            this.nanoXLabel_ValueSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueSaving.ForeColor = System.Drawing.Color.LimeGreen;
            this.nanoXLabel_ValueSaving.Location = new System.Drawing.Point(307, 105);
            this.nanoXLabel_ValueSaving.Name = "nanoXLabel_ValueSaving";
            this.nanoXLabel_ValueSaving.NodePath = "";
            this.nanoXLabel_ValueSaving.PropertyName = "EngValue";
            this.nanoXLabel_ValueSaving.scale = 1D;
            this.nanoXLabel_ValueSaving.Size = new System.Drawing.Size(60, 28);
            this.nanoXLabel_ValueSaving.TabIndex = 2131;
            this.nanoXLabel_ValueSaving.Text = "--";
            this.nanoXLabel_ValueSaving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nanoXLabel_ValueSolar
            // 
            this.nanoXLabel_ValueSolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.nanoXLabel_ValueSolar.Decimal = null;
            this.nanoXLabel_ValueSolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nanoXLabel_ValueSolar.ForeColor = System.Drawing.Color.LimeGreen;
            this.nanoXLabel_ValueSolar.Location = new System.Drawing.Point(28, 105);
            this.nanoXLabel_ValueSolar.Name = "nanoXLabel_ValueSolar";
            this.nanoXLabel_ValueSolar.NodePath = "[Connection]/Folder/Tag1";
            this.nanoXLabel_ValueSolar.PropertyName = "EngValue";
            this.nanoXLabel_ValueSolar.scale = 1D;
            this.nanoXLabel_ValueSolar.Size = new System.Drawing.Size(95, 24);
            this.nanoXLabel_ValueSolar.TabIndex = 2130;
            this.nanoXLabel_ValueSolar.Text = "--";
            this.nanoXLabel_ValueSolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mSignateAreaChart_Monthly
            // 
            this.mSignateAreaChart_Monthly.BackColor = System.Drawing.SystemColors.Window;
            this.mSignateAreaChart_Monthly.Collection = new string[0];
            this.mSignateAreaChart_Monthly.Database = "scada";
            this.mSignateAreaChart_Monthly.Location = new System.Drawing.Point(1075, 289);
            this.mSignateAreaChart_Monthly.Name = "mSignateAreaChart_Monthly";
            this.mSignateAreaChart_Monthly.Password = "1234";
            this.mSignateAreaChart_Monthly.Server = "localhost";
            this.mSignateAreaChart_Monthly.Size = new System.Drawing.Size(821, 308);
            this.mSignateAreaChart_Monthly.TabIndex = 2129;
            this.mSignateAreaChart_Monthly.TableName = "proc_signage_month";
            this.mSignateAreaChart_Monthly.UserName = "root";
            // 
            // mSignateColumnChart_Yearly
            // 
            this.mSignateColumnChart_Yearly.BackColor = System.Drawing.SystemColors.Window;
            this.mSignateColumnChart_Yearly.Collection = new string[0];
            this.mSignateColumnChart_Yearly.Database = "scada";
            this.mSignateColumnChart_Yearly.Location = new System.Drawing.Point(1075, 609);
            this.mSignateColumnChart_Yearly.Name = "mSignateColumnChart_Yearly";
            this.mSignateColumnChart_Yearly.Password = "1234";
            this.mSignateColumnChart_Yearly.Server = "localhost";
            this.mSignateColumnChart_Yearly.Size = new System.Drawing.Size(819, 300);
            this.mSignateColumnChart_Yearly.TabIndex = 2128;
            this.mSignateColumnChart_Yearly.TableName = "proc_signage_year";
            this.mSignateColumnChart_Yearly.UserName = "root";
            // 
            // mSignateAreaLineChart_Daily
            // 
            this.mSignateAreaLineChart_Daily.BackColor = System.Drawing.SystemColors.Window;
            this.mSignateAreaLineChart_Daily.Collection = new string[0];
            this.mSignateAreaLineChart_Daily.Database = "scada";
            this.mSignateAreaLineChart_Daily.Location = new System.Drawing.Point(25, 282);
            this.mSignateAreaLineChart_Daily.Name = "mSignateAreaLineChart_Daily";
            this.mSignateAreaLineChart_Daily.Password = "1234";
            this.mSignateAreaLineChart_Daily.Server = "localhost";
            this.mSignateAreaLineChart_Daily.Size = new System.Drawing.Size(1029, 607);
            this.mSignateAreaLineChart_Daily.TabIndex = 2127;
            this.mSignateAreaLineChart_Daily.TableName = "proc_signateAreaLinechart1";
            this.mSignateAreaLineChart_Daily.UserName = "root";
            this.mSignateAreaLineChart_Daily.Load += new System.EventHandler(this.mSignateAreaLineChart1_Load);
            // 
            // mPicturePower1
            // 
            this.mPicturePower1.Location = new System.Drawing.Point(6, 0);
            this.mPicturePower1.Name = "mPicturePower1";
            this.mPicturePower1.NodePath = "[Connection]/Folder/Tag1";
            this.mPicturePower1.PropertyName = "EngValue";
            this.mPicturePower1.scale = 1D;
            this.mPicturePower1.Size = new System.Drawing.Size(499, 283);
            this.mPicturePower1.TabIndex = 2126;
            // 
            // frmOverview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1920, 958);
            this.Controls.Add(this.mInputMoneyConstant1);
            this.Controls.Add(this.mInputCO2Rate1);
            this.Controls.Add(this.labelLoadMonthly);
            this.Controls.Add(this.labelLoadYealy);
            this.Controls.Add(this.nanoXLabel_ValueMoney);
            this.Controls.Add(this.nanoXLabel_ValueCo2);
            this.Controls.Add(this.nanoXLabel_ValueTotalYield);
            this.Controls.Add(this.nanoXLabel_ValueIrradiance);
            this.Controls.Add(this.nanoXLabel_ValueAbTemp);
            this.Controls.Add(this.nanoXLabel_ValuePVTemp);
            this.Controls.Add(this.nanoXLabel_ValueGrid);
            this.Controls.Add(this.nanoXLabel_ValueIER);
            this.Controls.Add(this.nanoXLabel_ValueSaving);
            this.Controls.Add(this.nanoXLabel_ValueSolar);
            this.Controls.Add(this.mSignateAreaChart_Monthly);
            this.Controls.Add(this.mSignateColumnChart_Yearly);
            this.Controls.Add(this.mSignateAreaLineChart_Daily);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.ValueLoad);
            this.Controls.Add(this.labelSaving);
            this.Controls.Add(this.labelSolar);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPVTemp);
            this.Controls.Add(this.labelCo2);
            this.Controls.Add(this.labelTotalYield);
            this.Controls.Add(this.labelIrradiance);
            this.Controls.Add(this.labelAbTemp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.mPicturePower1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOverview";
            this.Text = "frmOverview";
            this.Load += new System.EventHandler(this.frmOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label ValueLoad;
        private System.Windows.Forms.Label labelSaving;
        private System.Windows.Forms.Label labelSolar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPVTemp;
        private System.Windows.Forms.Label labelCo2;
        private System.Windows.Forms.Label labelTotalYield;
        private System.Windows.Forms.Label labelIrradiance;
        private System.Windows.Forms.Label labelAbTemp;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private NanoX.SCADAToolLibrary.MGraphic.MPicturePower mPicturePower1;
        private NanoX.SCADAToolLibrary.MGraphic.MSignateAreaLineChart mSignateAreaLineChart_Daily;
        private NanoX.SCADAToolLibrary.MGraphic.MSignateColumnChart mSignateColumnChart_Yearly;
        private NanoX.SCADAToolLibrary.MGraphic.MSignateAreaChart mSignateAreaChart_Monthly;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueSolar;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueSaving;
        private NanoX.SCADA.WinForms.Connector.NanoXConnector nanoXConnector1;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueGrid;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValuePVTemp;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueAbTemp;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueIrradiance;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueTotalYield;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueCo2;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueMoney;
        private NanoX.SCADAToolLibrary.XLabel.NanoXLabel nanoXLabel_ValueIER;
        private System.Windows.Forms.Label labelLoadYealy;
        private System.Windows.Forms.Label labelLoadMonthly;
        private NanoX.SCADAToolLibrary.MGraphic.MInputCO2Rate mInputCO2Rate1;
        private NanoX.SCADAToolLibrary.MGraphic.MInputMoneyConstant mInputMoneyConstant1;
    }
}