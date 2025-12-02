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
    public partial class frmInverter3 : Form
    {
        public frmInverter3()
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
            AutoScrollMinSize = new Size(maxRight + 200, maxBottom + 200);
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

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 2;
            Color borderColor = Color.Black;

            // Lấy PictureBox từ sender
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                // Sử dụng rectangle của PictureBox, không phải form
                Rectangle borderRect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);

                ControlPaint.DrawBorder(
                    e.Graphics,
                    borderRect,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid
                );
            }
        }
    }
}
