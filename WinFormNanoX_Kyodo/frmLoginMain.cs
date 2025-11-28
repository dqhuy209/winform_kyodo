using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class frmLoginMain : Form
    {
        private DatabaseAccess databaseAccess = new DatabaseAccess();
        private string[] roles;
        private frmOverview frmOverview;
        public frmLoginMain(string[] roles)
        {
            InitializeComponent();
            this.roles = roles;
            this.btnLogin.Click += BtnLogin_Click; ;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnMinimize.Click += BtnMinimize_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to stop system?",
               "",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //public class Session
        //{
        //    public static bool IsCheck { get; set; }

        //    public static string UserName { get; set; }

        //    public static string Role { get; set; }

        //    public static string Password { get; set; }
        //}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userName = this.txtUserName.Text.Trim();
            var password = this.txtPassword.Text.Trim();
            //  var role = this.cbxRoles.Text.Trim();
            var option = "";

            if (string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(userName))
            //string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please input infomation of account");
                return;
            }

            var connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";

            databaseAccess.ConnectionString = connectionString;
            var query = $"Select * from scada.account where `UserName`='{userName}' and `Password` = '{password}' ";
            var dataTable = databaseAccess.ExecuteQuery(query);


            if (!CheckUser(userName, password))
            {
                MessageBox.Show("Incorrect Username/Password, please recheck or contact to suplier (Phone nummer: +84387419012) !", "THK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.DialogResult = DialogResult.OK;
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy Option theo tên cột để tránh lỗi khi thay đổi thứ tự cột
                option = row["Option"]?.ToString() ?? "";
            }
            if (option.Contains("1"))
            {
                ClassStatic.CreateUser = true;
            }
            if (option.Contains("2"))
            {
                ClassStatic.AlarmACK = true;
            }
            if (option.Contains("3"))
            {
                ClassStatic.ReportExport = true;
            }
            if (option.Contains("4"))
            {
                ClassStatic.Setting = true;
            }


            // if (role=="Admin")
            // {

            //    ClassStatic.AlarmACK = true;
            //    ClassStatic.CreateUser = true;
            //    ClassStatic.ReportExport = true;
            //    ClassStatic.Setting = true;
            // }
            Session.UserName = userName;

            Session.Password = password;
            Session.IsCheck = true;
            // Ép full quyền
            ClassStatic.CreateUser = true;
            ClassStatic.AlarmACK = true;
            ClassStatic.ReportExport = true;
            ClassStatic.Setting = true;
            // 
            ClassStatic.islogin = true;
            switchtab();

        }


        private void frmLoginMain_Load(object sender, EventArgs e)
        {
            //this.cbxRoles.Items.Add("Admin");
            //this.cbxRoles.Items.Add("Operator");
            //this.cbxRoles.Items.Add("Guest");

            //this.cbxRoles.Text = this.cbxRoles.Items[0].ToString();



        }
        private bool CheckUser(string userName, string password)
        {
            var connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select count(*) from `account` where `UserName`='{userName}' and `Password` = '{password}' ";

                    return Convert.ToInt16(cmd.ExecuteScalar()) > 0;
                }
            }


        }


        private void switchtab()
        {

            this.Hide();

            // Mở form SCADA
            SCADA form2 = new SCADA();
            form2.Closed += (s, args) => this.Close(); // Đóng form login sau khi đóng form SCADA
            form2.Show(); // Sử dụng ShowDialog() để form SCADA chắc chắn được đóng trước khi tiếp tục

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //}
    }
}
