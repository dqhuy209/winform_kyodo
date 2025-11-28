namespace WinFormNanoX_Kyodo
{
    partial class frmAlarm
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
            this.nanoXConnector1 = new NanoX.SCADA.WinForms.Connector.NanoXConnector(this.components);
            this.alarmViewer1 = new HinoTools.Alarm.Control.AlarmViewer();
            this.alarmServer1 = new HinoTools.Alarm.Control.AlarmServer(this.components);
            this.alarmLogger1 = new HinoTools.Alarm.Control.AlarmLogger(this.components);
            this.alarmBuzzer1 = new HinoTools.Alarm.Control.AlarmBuzzer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBuzzer1)).BeginInit();
            this.SuspendLayout();
            // 
            // alarmViewer1
            // 
            this.alarmViewer1.AlarmHub = this.alarmServer1;
            this.alarmViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.alarmViewer1.BackColor = System.Drawing.SystemColors.Control;
            this.alarmViewer1.Limit = 100;
            this.alarmViewer1.Location = new System.Drawing.Point(0, 0);
            this.alarmViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.alarmViewer1.MinimumSize = new System.Drawing.Size(1178, 208);
            this.alarmViewer1.Name = "alarmViewer1";
            this.alarmViewer1.Size = new System.Drawing.Size(1800, 880);
            this.alarmViewer1.Source = null;
            this.alarmViewer1.TabIndex = 0;
            // 
            // alarmServer1
            // 
            this.alarmServer1.AlarmLimit = 100;
            this.alarmServer1.DatabaseName = "wistron";
            this.alarmServer1.Password = "1234";
            this.alarmServer1.ServerName = "localhost";
            this.alarmServer1.TableLog = "alarmlog";
            this.alarmServer1.TableName = "alarmsettings";
            this.alarmServer1.UserID = "root";
            // 
            // alarmLogger1
            // 
            this.alarmLogger1.AlarmHub = this.alarmServer1;
            this.alarmLogger1.DatabaseName = "wistron";
            this.alarmLogger1.Password = "1234";
            this.alarmLogger1.ServerName = "localhost";
            this.alarmLogger1.TableName = "alarmlog";
            this.alarmLogger1.UserID = "root";
            // 
            // alarmBuzzer1
            // 
            this.alarmBuzzer1.AlarmHub = this.alarmServer1;
            this.alarmBuzzer1.SoundLocation = "~\\alarm.wav";
            // 
            // frmAlarm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 935);
            this.Controls.Add(this.alarmViewer1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.nanoXConnector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBuzzer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NanoX.SCADA.WinForms.Connector.NanoXConnector nanoXConnector1;
        private HinoTools.Alarm.Control.AlarmLogger alarmLogger1;
        private HinoTools.Alarm.Control.AlarmServer alarmServer1;
        private HinoTools.Alarm.Control.AlarmBuzzer alarmBuzzer1;
        private HinoTools.Alarm.Control.AlarmViewer alarmViewer1;
    }
}
