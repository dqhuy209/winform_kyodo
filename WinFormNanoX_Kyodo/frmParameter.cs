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
    public partial class frmParameter : Form
    {
        private DatabaseAccess databaseAccess = new DatabaseAccess();

        public frmParameter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load danh sách user từ database vào gridData
        /// </summary>
        private void LoadData()
        {
            try
            {
                // Xóa dữ liệu cũ trong grid
                gridData.Rows.Clear();

                var connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";
                databaseAccess.ConnectionString = connectionString;
                var query = "SELECT * FROM scada.account";
                var dataTable = databaseAccess.ExecuteQuery(query);

                // Load dữ liệu vào grid
                foreach (DataRow row in dataTable.Rows)
                {
                    // Chuyển đổi Option code thành text dễ đọc
                    string option = "View,";
                    string optionCode = row["Option"]?.ToString() ?? "";

                    if (optionCode.Contains("1"))
                    {
                        option = option + " Create/Delete User,";
                    }
                    if (optionCode.Contains("2"))
                    {
                        option = option + " Alarm ACK,";
                    }
                    if (optionCode.Contains("3"))
                    {
                        option = option + " Report Export,";
                    }
                    if (optionCode.Contains("4"))
                    {
                        option = option + " Setting";
                    }

                    // Thêm row vào grid: ID, UserName, Role, Option
                    gridData.Rows.Add(
                        row["ID"],
                        row["UserName"],
                        row["Role"],
                        option
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý khi click button Delete
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var resultDialog = MessageBox.Show(
                "Are you sure you want to delete this account?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (gridData.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = gridData.SelectedCells[0].RowIndex;
                    int idToDelete = Convert.ToInt32(gridData.Rows[selectedRowIndex].Cells["ID"].Value);

                    var connectionString = "Server=localhost;Database=scada;Uid=root;Pwd=1234;";
                    databaseAccess.ConnectionString = connectionString;
                    var query = $"DELETE FROM scada.account WHERE ID = {idToDelete}";

                    try
                    {
                        databaseAccess.ExecuteNonQuery(query);
                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reload danh sách sau khi xóa
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Load dữ liệu khi form được load
        /// </summary>
        private void frmParameter_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
