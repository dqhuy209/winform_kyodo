using NanoX.SCADA.WinForms.Connector;
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
    public partial class frmZeroExport : Form
    {

        public frmZeroExport()
        {
            InitializeComponent();
            
            // Đăng ký sự kiện cho các label click
            lblX1.Click += LblX1_Click;
            lblX2.Click += LblX2_Click;
            lblX3.Click += LblX3_Click;

            

            lblTimer1.Click += LblTimer1_Click;
            lblTimer2.Click += LblTimer2_Click;
            lblTimer3.Click += LblTimer3_Click;

            

            // Đăng ký sự kiện cho các button INV ON/OFF
            btnINV1ON.Click += BtnINV1ON_Click;
            btnINV2ON.Click += BtnINV2ON_Click;
            btnINV3ON.Click += BtnINV3ON_Click;
            btnINV4ON.Click += BtnINV4ON_Click;
            btnINV5ON.Click += BtnINV5ON_Click;
            btnINV6ON.Click += BtnINV6ON_Click;

            btnINV1OFF.Click += BtnINV1OFF_Click;
            btnINV2OFF.Click += BtnINV2OFF_Click;
            btnINV3OFF.Click += BtnINV3OFF_Click;
            btnINV4OFF.Click += BtnINV4OFF_Click;
            btnINV5OFF.Click += BtnINV5OFF_Click;
            btnINV6OFF.Click += BtnINV6OFF_Click;

            // Đăng ký sự kiện cho các button Setting
            btnSettingINV1.Click += BtnSettingINV1_Click;
            btnSettingINV2.Click += BtnSettingINV2_Click;
            btnSettingINV3.Click += BtnSettingINV3_Click;
            btnSettingINV4.Click += BtnSettingINV4_Click;
            btnSettingINV5.Click += BtnSettingINV5_Click;
            btnSettingINV6.Click += BtnSettingINV6_Click;

            // Đăng ký sự kiện cho Auto/Manual
            btnAuto.Click += BtnAuto_Click;
            btnManual.Click += BtnManual_Click;

            // Đăng ký sự kiện cho Open ACB
            btnOpenACB1.Click += BtnOpenACB1_Click;

            // Đăng ký sự kiện cho OK và các label setting
            btnOK.Click += BtnOK_Click;
            lblSetting1.Click += lblSetting1_Click;
            lblSetting2.Click += lblSetting2_Click;
            lblSetting3.Click += lblSetting3_Click;
            lblSetting4.Click += lblSetting4_Click;
            lblSetting5.Click += lblSetting5_Click;
            lblSetting6.Click += lblSetting6_Click;

            // Đăng ký sự kiện cho cảnh báo công suất tải thấp
            lblPower.TextChanged += LblPower_TextChanged;

            // Đăng ký sự kiện Load
            this.Load += frmZeroExport_Load;

            // Khởi tạo timer để kiểm tra trạng thái
            timer1.Tick += timer1_Tick;
        }

        #region Sự kiện khi thay đổi giá trị của setting value (chuyển từ auto về manual)

        private void lblSetting1_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV1.Show();
                InputINV1.BringToFront();
            }
        }

        private void lblSetting2_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV2.Show();
                InputINV2.BringToFront();
            }
        }

        private void lblSetting3_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV3.Show();
                InputINV3.BringToFront();
            }
        }

        private void lblSetting4_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV4.Show();
                InputINV4.BringToFront();
            }
        }

        private void lblSetting5_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV5.Show();
                InputINV5.BringToFront();
            }
        }

        private void lblSetting6_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (ClassStatic.Setting == true)
            {
                InputINV6.Show();
                InputINV6.BringToFront();
            }
        }

        #endregion

        private void BtnOK_Click(object sender, EventArgs e)
        {
            btnOK.MessageEnable = false;
            btnOK.IsManualON = false;
            btnManual.IsEnabled = false;
            grbSetting.Hide();
        }

        #region Thay đổi giá trị setting value

        private void BtnSettingINV1_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV1.Show();
                InputINV1.BringToFront();
            }
        }

        private void BtnSettingINV2_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV2.Show();
                InputINV2.BringToFront();
            }
        }

        private void BtnSettingINV3_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV3.Show();
                InputINV3.BringToFront();
            }
        }

        private void BtnSettingINV4_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV4.Show();
                InputINV4.BringToFront();
            }
        }

        private void BtnSettingINV5_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV5.Show();
                InputINV5.BringToFront();
            }
        }

        private void BtnSettingINV6_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            if (btnManual.BackColor == Color.Red && ClassStatic.Setting == true)
            {
                InputINV6.Show();
                InputINV6.BringToFront();
            }
        }

        #endregion

        #region Bật inverter

        private void BtnINV1ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime) // Để biết đang ở chế độ Auto thì không thay đổi được
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV1ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red) // Để biết đang ở chế độ manual
            {
                btnINV1ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV1ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV1ON.IsEnabled = true;
            }
        }

        private void BtnINV2ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV2ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV2ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV2ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV2ON.IsEnabled = true;
            }
        }

        private void BtnINV3ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV3ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV3ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV3ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV3ON.IsEnabled = true;
            }
        }

        private void BtnINV4ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV4ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV4ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV4ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV4ON.IsEnabled = true;
            }
        }

        private void BtnINV5ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV5ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV5ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV5ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV5ON.IsEnabled = true;
            }
        }

        private void BtnINV6ON_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV6ON.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV6ON.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV6ON.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV6ON.IsEnabled = true;
            }
        }

        #endregion

        #region Tắt Inverter

        private void BtnINV1OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV1OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV1OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV1OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV1OFF.IsEnabled = true;
            }
        }

        private void BtnINV2OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV2OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV2OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV2OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV2OFF.IsEnabled = true;
            }
        }

        private void BtnINV3OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV3OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV3OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV3OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV3OFF.IsEnabled = true;
            }
        }

        private void BtnINV4OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV4OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV4OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV4OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV4OFF.IsEnabled = true;
            }
        }

        private void BtnINV5OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV5OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV5OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV5OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV5OFF.IsEnabled = true;
            }
        }

        private void BtnINV6OFF_Click(object sender, EventArgs e)
        {
            if (btnAuto.BackColor == Color.Lime)
            {
                MessageBox.Show("System mode is auto mode. You can't change status of inverter");
                btnINV6OFF.IsEnabled = false;
                return;
            }
            if (btnManual.BackColor == Color.Red)
            {
                btnINV6OFF.IsEnabled = true;
            }
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change status");
                btnINV6OFF.IsEnabled = false;
                return;
            }
            if (ClassStatic.Setting == true)
            {
                btnINV6OFF.IsEnabled = true;
            }
        }

        #endregion

        #region Tắt ACB

        private void BtnOpenACB1_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                btnOpenACB1.IsEnabled = false;
                return;
            }
            else
            {
                btnOpenACB1.IsEnabled = true;
            }
        }

        #endregion

        #region Cài đặt các tham số của Zero Export

        private void LblTimer3_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }

            inputT3.Show();
            inputT3.BringToFront();

            inputX1.Hide();
            inputX2.Hide();
            inputX3.Hide();
            

            inputT1.Hide();
            inputT2.Hide();
            
        }

        private void LblTimer2_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            inputT2.Show();
            inputT2.BringToFront();

            inputX1.Hide();
            inputX2.Hide();
            inputX3.Hide();
            

            inputT1.Hide();
            inputT3.Hide();
           
        }

        private void LblTimer1_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            inputT1.Show();
            inputT1.BringToFront();

            inputX1.Hide();
            inputX2.Hide();
            inputX3.Hide();

            inputT3.Hide();
            inputT2.Hide();
        }

        

     


        private void LblX3_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            inputX3.Show();
            inputX3.BringToFront();

            inputX1.Hide();
            inputX2.Hide();
            

            inputT1.Hide();
            inputT2.Hide();
            inputT3.Hide();
            
        }

        private void LblX2_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            inputX2.Show();
            inputX2.BringToFront();

            inputX1.Hide();
            inputX3.Hide();
            

            inputT1.Hide();
            inputT2.Hide();
            inputT3.Hide();
           
        }

        private void LblX1_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                return;
            }
            inputX1.Show();
            inputX1.BringToFront();

            inputX2.Hide();
            inputX3.Hide();
            

            inputT1.Hide();
            inputT2.Hide();
            inputT3.Hide();
            
        }

        

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Hiển thị setting khi chuyển sang chế độ Manual
            if (btnManual.IsEnabled == true && btnManual.BackColor == Color.Red)
            {
                grbSetting.Show();
                grbSetting.BringToFront();
            }

            // Làm mờ ô setting khi ở chế độ Auto
            if (btnAuto.BackColor == Color.Lime)
            {
                btnSettingINV1.ForeColor = Color.Silver;
                btnSettingINV2.ForeColor = Color.Silver;
                btnSettingINV3.ForeColor = Color.Silver;
                btnSettingINV4.ForeColor = Color.Silver;
                btnSettingINV5.ForeColor = Color.Silver;
                btnSettingINV6.ForeColor = Color.Silver;
            }

            // Bật màu xanh cho setting khi ở chế độ Manual
            if (btnManual.BackColor == Color.Red)
            {
                btnSettingINV1.ForeColor = Color.Lime;
                btnSettingINV2.ForeColor = Color.Lime;
                btnSettingINV3.ForeColor = Color.Lime;
                btnSettingINV4.ForeColor = Color.Lime;
                btnSettingINV5.ForeColor = Color.Lime;
                btnSettingINV6.ForeColor = Color.Lime;
            }
        }

        private void frmZeroExport_Load(object sender, EventArgs e)
        {
            // Ẩn tất cả các input control
            inputT1.Hide();
            inputT2.Hide();
            inputT3.Hide();
            

            inputX1.Hide();
            inputX2.Hide();
            inputX3.Hide();
            

            InputINV1.Hide();
            InputINV2.Hide();
            InputINV3.Hide();
            InputINV4.Hide();
            InputINV5.Hide();
            InputINV6.Hide();

            grbSetting.Hide();

            pictureBox1.Hide();
         

            timer1.Start();
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                btnManual.IsEnabled = false;
                return;
            }
            else
            {
                btnManual.IsEnabled = true;
            }
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            if (ClassStatic.Setting == false)
            {
                MessageBox.Show("You don't have authority to change value");
                btnAuto.IsEnabled = false;
                return;
            }
            else
            {
                btnAuto.IsEnabled = true;
            }
        }

        // Code chức năng cảnh báo công suất tải thấp
        private void LblPower_TextChanged(object sender, EventArgs e)
        {
            if (lblPower.Text == null || txtSettingValue.Text == null || txtOffset.Text == null)
                return;
            if (double.TryParse(lblPower.Text, out double powervalue) &&
            double.TryParse(txtSettingValue.Text, out double settingvalue) &&
            double.TryParse(txtOffset.Text, out double offsetvalue))
            {
                if (powervalue < settingvalue)
                {
                    lblStatus.BackColor = Color.Red;
                }
                else if (powervalue > (settingvalue + offsetvalue))
                {
                    lblStatus.BackColor = Color.Silver;
                }
            }
        }
    }
}
