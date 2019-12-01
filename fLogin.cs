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
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                fMain f = new fMain();
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
