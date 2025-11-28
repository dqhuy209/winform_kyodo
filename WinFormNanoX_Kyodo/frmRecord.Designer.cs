namespace WinFormNanoX_Kyodo
{
    partial class frmRecord
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.recordViewer1 = new HinoTools.Alarm.Control.RecordViewer();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordViewer1
            // 
            this.recordViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recordViewer1.BackColor = System.Drawing.Color.White;
            this.recordViewer1.Database = "scada";
            this.recordViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.recordViewer1.Limit = 100;
            this.recordViewer1.Location = new System.Drawing.Point(0, 0);
            this.recordViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.recordViewer1.MinimumSize = new System.Drawing.Size(400, 208);
            this.recordViewer1.Name = "recordViewer1";
            this.recordViewer1.Password = "1234";
            this.recordViewer1.Port = 3306;
            this.recordViewer1.Server = "localhost";
            this.recordViewer1.Size = new System.Drawing.Size(1900, 935);
            this.recordViewer1.TabIndex = 0;
            this.recordViewer1.Table = "record";
            this.recordViewer1.User = "root";
            // 
            // frmRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1900, 935);
            this.Controls.Add(this.recordViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecord";
            this.Text = "frmRecord";
            ((System.ComponentModel.ISupportInitialize)(this.recordViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private HinoTools.Alarm.Control.RecordViewer recordViewer1;
    }
}