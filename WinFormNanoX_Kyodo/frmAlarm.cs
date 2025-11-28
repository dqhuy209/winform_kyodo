using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HinoTools.Alarm.Model.Alarm;
using HinoTools.Alarm.Model;

namespace WinFormNanoX_Kyodo
{
    public partial class frmAlarm : Form
    {
        public frmAlarm()
        {
            InitializeComponent();
            TryStartAlarmServer();
        }

        private void TryStartAlarmServer()
        {
            try
            {
                alarmServer1?.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to start alarm server: {ex.Message}", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
