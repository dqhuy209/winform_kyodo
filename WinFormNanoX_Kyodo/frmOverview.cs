using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormNanoX_Kyodo
{
    public partial class frmOverview : Form
    {
        public frmOverview()
        {
            InitializeComponent();
            nanoXLabel_ValueSolar.TextChanged += ValueSolar_TextChanged;
            nanoXLabel_ValueGrid.TextChanged += ValueSolar_TextChanged;
            nanoXLabel_ValueIrradiance.TextChanged += ValueSolar_TextChanged;
            nanoXLabel_ValueCo2.Click += ValueCo2_Click;
            nanoXLabel_ValueMoney.Click += ValueMoney_Click;

            // Thêm sự kiện cập nhật realtime cho nanoXLabelValue
            nanoXLabel_ValueGrid.TextChanged += UpdateNanoXLabelValue;
            nanoXLabel_ValueSolar.TextChanged += UpdateNanoXLabelValue;
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            mInputCO2Rate1.Hide();
            mInputCO2Rate1.SendToBack();

            mInputMoneyConstant1.Hide();
            mInputMoneyConstant1.SendToBack();

            // Khởi tạo giá trị Load ngay khi mở form
            ValueSolar_TextChanged(this, EventArgs.Empty);
        }

        private void mSignateAreaLineChart1_Load(object sender, EventArgs e)
        {
        }

        // ValueSolar thay đổi - tính IER 
        private void ValueSolar_TextChanged(object sender, EventArgs e)
        {
            // TÍNH IER: chỉ tính khi có cả Irradiance VÀ Solar hợp lệ
            if (double.TryParse(nanoXLabel_ValueIrradiance.Text, out double irradiance) && 
                double.TryParse(nanoXLabel_ValueSolar.Text, out double power))
            {
                double.TryParse(nanoXLabel_ValueGrid.Text, out double grid);
                double powerreduce = Math.Round(irradiance * 0.9 * 706.32 / 1000 - power, 0);
                if (powerreduce < 0 || grid > 140) powerreduce = 0;
                nanoXLabel_ValueIER.Text = $"-{powerreduce} kW";
            }
        }

        private void ValueCo2_Click(object sender, EventArgs e)
        {
            bool show = !mInputCO2Rate1.Visible;
            if (show)
            {
                mInputCO2Rate1.Show();
                mInputCO2Rate1.BringToFront();
            }
            else
            {
                mInputCO2Rate1.Hide();
            }
        }

        private void ValueMoney_Click(object sender, EventArgs e)
        {
            bool show = !mInputMoneyConstant1.Visible;
            if (show)
            {
                mInputMoneyConstant1.Show();
                mInputMoneyConstant1.BringToFront();
            }
            else
            {
                mInputMoneyConstant1.Hide();
            }
        }

        // Hàm cập nhật giá trị nanoXLabelValue
        private void UpdateNanoXLabelValue(object sender, EventArgs e)
        {
            if (double.TryParse(nanoXLabel_ValueGrid.Text, out double grid) &&
                double.TryParse(nanoXLabel_ValueSolar.Text, out double solar))
            {
                nanoXLabelValue.Text = (grid + solar).ToString("F2");
            }
            else
            {
                nanoXLabelValue.Text = "N/A"; // Hiển thị "N/A" nếu không thể tính toán
            }
        }
    }
}
