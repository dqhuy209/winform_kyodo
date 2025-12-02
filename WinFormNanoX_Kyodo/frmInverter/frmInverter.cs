using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormNanoX_Kyodo
{
    public partial class frmInverter : Form
    {
        public frmInverter()
        {
            InitializeComponent();
            ConfigureScrolling();
        }
        private void ConfigureScrolling()
        {
            // Tìm control có vị trí xa nhất
            int maxRight = 0;
            int maxBottom = 0;

            foreach (Control control in Controls)
            {
                // Chỉ tính các control hiện thị
                if (control.Visible)
                {
                    maxRight = Math.Max(maxRight, control.Right);
                    maxBottom = Math.Max(maxBottom, control.Bottom);
                }
            }

            // Đặt kích thước scroll với padding tối thiểu
            AutoScrollMinSize = new Size(maxRight + 150, maxBottom + 150);
            AutoScroll = true;

            // Tăng tốc độ scroll
            if (VerticalScroll != null)
                VerticalScroll.SmallChange = 50;
            if (HorizontalScroll != null)
                HorizontalScroll.SmallChange = 50;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Tính lại sau khi form load hoàn tất
            ConfigureScrolling();
        }

        // Windows API constants để ẩn scrollbar
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        /// <summary>
        /// Override OnVisibleChanged để ẩn scrollbar khi form được hiển thị
        /// </summary>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                // Ẩn scrollbar sau khi form hiển thị
                HideScrollBars();
            }
        }

        /// <summary>
        /// Override WndProc để liên tục ẩn scrollbar khi Windows cố gắng hiển thị chúng
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            
            // Ẩn scrollbar sau các message liên quan đến resize hoặc paint
            if (m.Msg == 0x0005 || m.Msg == 0x000F || m.Msg == 0x0085) // WM_SIZE, WM_PAINT, WM_NCPAINT
            {
                HideScrollBars();
            }
        }

        /// <summary>
        /// Phương thức helper để ẩn cả thanh cuộn ngang và dọc
        /// </summary>
        private void HideScrollBars()
        {
            if (this.Handle != IntPtr.Zero)
            {
                ShowScrollBar(this.Handle, SB_HORZ, false);
                ShowScrollBar(this.Handle, SB_VERT, false);
            }
        }

        private void nanoXLamp1_Load(object sender, EventArgs e)
        {

        }
    }
}
