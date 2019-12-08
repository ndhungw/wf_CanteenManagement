using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_CanteenManagement.DAO;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement
{
    public partial class fAccountProfile : Form
    {
        private Session sessionInfo = null;

        public fAccountProfile(Session sessionInfo)
        {
            InitializeComponent();

            this.sessionInfo = sessionInfo;
            txtUsername.Text = sessionInfo.Username;
            txtPassword.Text = sessionInfo.Password;
            txtDisplayName.Text = sessionInfo.DisplayName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var displayName = txtDisplayName.Text;
                var password = txtPassword.Text;
                var confirmPass = txtPassConfirm.Text;

                if (confirmPass != password)
                {
                    MessageBox.Show("Mật khẩu xác nhận không hợp lệ", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $"UPDATE dbo.Account SET UserName = '{username}', DisplayName = '{displayName}', PassWord = '{password}' WHERE UserName = '{sessionInfo.Username}' AND PassWord = '{sessionInfo.Password}';";

                DataProvider.Instance.ExecNonQuery(query);
                MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
          
}
    }
}
