using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNanoX_Kyodo
{
    public partial class frmAllInverter : Form
    {
        public frmAllInverter()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 2;
            Color borderColor = Color.Black;

            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                int width = pictureBox.Width;
                int height = pictureBox.Height;
                
                Region oldClip = e.Graphics.Clip;
                e.Graphics.ResetClip();
                
                try
                {
                    using (SolidBrush borderBrush = new SolidBrush(borderColor))
                    {
                        e.Graphics.FillRectangle(borderBrush, 0, 0, width, borderWidth);
                        if (height > borderWidth)
                            e.Graphics.FillRectangle(borderBrush, 0, height - borderWidth, width, borderWidth);
                        if (height > borderWidth * 2)
                            e.Graphics.FillRectangle(borderBrush, 0, borderWidth, borderWidth, height - borderWidth * 2);
                        if (width > borderWidth && height > borderWidth * 2)
                            e.Graphics.FillRectangle(borderBrush, width - borderWidth, borderWidth, borderWidth, height - borderWidth * 2);
                    }
                }
                finally
                {
                    e.Graphics.Clip = oldClip;
                }
            }
        }
    }
}
