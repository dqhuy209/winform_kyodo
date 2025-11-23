namespace WinFormNanoX_Kyodo
{
    partial class frmSingleLineDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingleLineDC));
            this.pnlInverter = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAllInverter = new System.Windows.Forms.Button();
            this.btnAllInverterActive = new System.Windows.Forms.Button();
            this.btnInverter1 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.btnInverter2 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.btnInverter3 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.btnInverter4 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.btnInverter5 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.btnInverter6 = new NanoX.SCADAToolLibrary.XButton.XINVButtonStatus();
            this.SuspendLayout();
            // 
            // pnlInverter
            // 
            this.pnlInverter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInverter.BackColor = System.Drawing.Color.White;
            this.pnlInverter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInverter.Location = new System.Drawing.Point(0, 74);
            this.pnlInverter.Name = "pnlInverter";
            this.pnlInverter.Size = new System.Drawing.Size(1920, 800);
            this.pnlInverter.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // btnAllInverter
            // 
            this.btnAllInverter.BackColor = System.Drawing.Color.Transparent;
            this.btnAllInverter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAllInverter.FlatAppearance.BorderSize = 0;
            this.btnAllInverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllInverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAllInverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllInverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllInverter.ForeColor = System.Drawing.Color.Black;
            this.btnAllInverter.Image = ((System.Drawing.Image)(resources.GetObject("btnAllInverter.Image")));
            this.btnAllInverter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAllInverter.Location = new System.Drawing.Point(536, -2);
            this.btnAllInverter.Name = "btnAllInverter";
            this.btnAllInverter.Size = new System.Drawing.Size(98, 74);
            this.btnAllInverter.TabIndex = 26;
            this.btnAllInverter.Text = "All INV";
            this.btnAllInverter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllInverter.UseVisualStyleBackColor = false;
            // 
            // btnAllInverterActive
            // 
            this.btnAllInverterActive.BackColor = System.Drawing.Color.Transparent;
            this.btnAllInverterActive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAllInverterActive.FlatAppearance.BorderSize = 0;
            this.btnAllInverterActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllInverterActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAllInverterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllInverterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllInverterActive.ForeColor = System.Drawing.Color.Black;
            this.btnAllInverterActive.Image = ((System.Drawing.Image)(resources.GetObject("btnAllInverterActive.Image")));
            this.btnAllInverterActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAllInverterActive.Location = new System.Drawing.Point(536, -2);
            this.btnAllInverterActive.Name = "btnAllInverterActive";
            this.btnAllInverterActive.Size = new System.Drawing.Size(98, 74);
            this.btnAllInverterActive.TabIndex = 27;
            this.btnAllInverterActive.Text = "All INV";
            this.btnAllInverterActive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllInverterActive.UseVisualStyleBackColor = false;
            // 
            // btnInverter1
            // 
            this.btnInverter1.Location = new System.Drawing.Point(699, 0);
            this.btnInverter1.Name = "btnInverter1";
            this.btnInverter1.Size = new System.Drawing.Size(75, 70);
            this.btnInverter1.TabIndex = 29;
            this.btnInverter1.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter1.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter1.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter1.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter1.TextValue = "INV 1";
            // 
            // btnInverter2
            // 
            this.btnInverter2.Location = new System.Drawing.Point(876, 0);
            this.btnInverter2.Name = "btnInverter2";
            this.btnInverter2.Size = new System.Drawing.Size(75, 70);
            this.btnInverter2.TabIndex = 30;
            this.btnInverter2.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter2.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter2.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter2.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter2.TextValue = "INV 2";
            // 
            // btnInverter3
            // 
            this.btnInverter3.Location = new System.Drawing.Point(1053, 0);
            this.btnInverter3.Name = "btnInverter3";
            this.btnInverter3.Size = new System.Drawing.Size(75, 70);
            this.btnInverter3.TabIndex = 31;
            this.btnInverter3.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter3.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter3.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter3.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter3.TextValue = "INV 3";
            // 
            // btnInverter4
            // 
            this.btnInverter4.Location = new System.Drawing.Point(1230, 0);
            this.btnInverter4.Name = "btnInverter4";
            this.btnInverter4.Size = new System.Drawing.Size(75, 70);
            this.btnInverter4.TabIndex = 32;
            this.btnInverter4.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter4.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter4.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter4.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter4.TextValue = "INV 4";
            // 
            // btnInverter5
            // 
            this.btnInverter5.Location = new System.Drawing.Point(1407, 0);
            this.btnInverter5.Name = "btnInverter5";
            this.btnInverter5.Size = new System.Drawing.Size(75, 70);
            this.btnInverter5.TabIndex = 33;
            this.btnInverter5.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter5.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter5.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter5.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter5.TextValue = "INV 5";
            // 
            // btnInverter6
            // 
            this.btnInverter6.Location = new System.Drawing.Point(1584, 0);
            this.btnInverter6.Name = "btnInverter6";
            this.btnInverter6.Size = new System.Drawing.Size(75, 70);
            this.btnInverter6.TabIndex = 34;
            this.btnInverter6.TagFault = "[Connection]/Folder/Tag1";
            this.btnInverter6.TagStandby = "[Connection]/Folder/Tag2";
            this.btnInverter6.TagStart = "[Connection]/Folder/Tag3";
            this.btnInverter6.TagStop = "[Connection]/Folder/Tag4";
            this.btnInverter6.TextValue = "INV 6";
            // 
            // frmSingleLineDC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1900, 870);
            this.Controls.Add(this.btnInverter6);
            this.Controls.Add(this.btnInverter5);
            this.Controls.Add(this.btnInverter4);
            this.Controls.Add(this.btnInverter3);
            this.Controls.Add(this.btnInverter2);
            this.Controls.Add(this.btnInverter1);
            this.Controls.Add(this.pnlInverter);
            this.Controls.Add(this.btnAllInverter);
            this.Controls.Add(this.btnAllInverterActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSingleLineDC";
            this.Text = "frmSingleLineDC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInverter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAllInverter;
        private System.Windows.Forms.Button btnAllInverterActive;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter1;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter2;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter3;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter4;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter5;
        private NanoX.SCADAToolLibrary.XButton.XINVButtonStatus btnInverter6;
    }
}