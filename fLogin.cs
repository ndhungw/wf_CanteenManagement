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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //DialogResult kg = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (kg==DialogResult.OK)
                Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            if (Login(username, password))
            {
                var query = $"SELECT * FROM dbo.Account WHERE UserName = '{username}'";
                var data = DataProvider.Instance.ExecQuery(query);

                fMain f = new fMain(new Session(username, password, data.Rows[0][1].ToString()));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else{
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
    }
}
