namespace WinFormNanoX_Kyodo
{
    partial class frmEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nanoXConnector1 = new NanoX.SCADA.WinForms.Connector.NanoXConnector(this.components);
            this.eventViewer1 = new HinoTools.Alarm.Control.EventViewer();
            this.eventServer1 = new HinoTools.Alarm.Control.EventServer(this.components);
            this.eventLogger1 = new HinoTools.Alarm.Control.EventLogger(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eventViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 935);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(114)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1805, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // eventViewer1
            // 
            this.eventViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventViewer1.EventHub = this.eventServer1;
            this.eventViewer1.Limit = 100;
            this.eventViewer1.Location = new System.Drawing.Point(0, 0);
            this.eventViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.eventViewer1.MinimumSize = new System.Drawing.Size(400, 208);
            this.eventViewer1.Name = "eventViewer1";
            this.eventViewer1.Size = new System.Drawing.Size(1800, 880);
            this.eventViewer1.Source = null;
            this.eventViewer1.TabIndex = 0;
            // 
            // eventServer1
            // 
            this.eventServer1.DatabaseName = "wistron";
            this.eventServer1.Limit = 100;
            this.eventServer1.Password = "1234";
            this.eventServer1.ServerName = "localhost";
            this.eventServer1.TableLog = "eventlog";
            this.eventServer1.TableName = "eventsettings";
            this.eventServer1.UserID = "root";
            // 
            // eventLogger1
            // 
            this.eventLogger1.AlarmHub = this.eventServer1;
            this.eventLogger1.DatabaseName = "wistron";
            this.eventLogger1.Password = "1234";
            this.eventLogger1.ServerName = "localhost";
            this.eventLogger1.TableName = "eventlog";
            this.eventLogger1.UserID = "root";
            // 
            // frmEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 935);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private HinoTools.Alarm.Control.EventViewer eventViewer1;
        private HinoTools.Alarm.Control.EventServer eventServer1;
        private HinoTools.Alarm.Control.EventLogger eventLogger1;
        private NanoX.SCADA.WinForms.Connector.NanoXConnector nanoXConnector1;
    }
}