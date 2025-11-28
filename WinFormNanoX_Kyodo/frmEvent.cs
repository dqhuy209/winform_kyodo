using HinoTools.Alarm.Control;
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
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
            TryStartEventServer();
        }
        private void TryStartEventServer()
        {
            try
            {
                eventServer1?.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to start event server: {ex.Message}", "Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
