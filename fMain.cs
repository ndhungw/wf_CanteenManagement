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
    public partial class fMain : Form
    {
        private Session sessionInfo = null;

        public fMain(Session sessionInfo)
        {
            InitializeComponent();

            this.sessionInfo = sessionInfo;

            lbDisplayName.Text = sessionInfo.DisplayName;

            lbDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

            lbCurrentBillWorkOn.Text = IDBillWorkingOn.ToString();

            LoadCategory();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
            return;
        }


        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(sessionInfo);
            f.ShowDialog();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sessionInfo.Username == "admin")
            {
                fAdmin f = new fAdmin();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ admin mới có quyền truy cập vào chức năng này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        void ShowBill(int idBill)
        {
            List<DTO.BillView> listMenu = BillViewDAO.Instance.GetListMenuByBill(idBill);
            int totalPriceOfBill = 0;
            foreach (DTO.BillView item in listMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.SinglePrice.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
                totalPriceOfBill += item.TotalPrice;
            }
            txbToTalPriceOfBill.Text = totalPriceOfBill.ToString();
        }

        int IDBillWorkingOn = 0;
        bool isAddingFood = false;
        bool isCheckedOut = true;

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            if (isAddingFood == true)
            {
                lsvBill.Items.Clear();

                int idBill = BillDAO.Instance.GetMaxIDBill();//Lấy idBill mới
                int foodID = (cbFood.SelectedItem as Food).ID;
                int count = (int)nmFoodCount.Value;

                lbCurrentBillWorkOn.Text = idBill.ToString();

                if (count < 0)//có bao giờ chạy tới dòng này?
                {
                    if (BillInfoDAO.Instance.CheckBillInfoExists(idBill) == 0)//Không có chi tiết hóa đơn
                    {
                        MessageBox.Show("Số lượng không được âm khi món này chưa tồn tại trong hóa đơn");
                        return;
                    }
                }

                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                ShowBill(idBill);
            }
            else
            {
                MessageBox.Show("Chưa tạo hóa đơn, không thể thêm món !");
            }
        }

        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            if (isCheckedOut == true && isAddingFood == false)//hóa đơn đầu/đã thanh toán
            {
                BillDAO.Instance.InsertBill();//Tạo bill mới
                IDBillWorkingOn = BillDAO.Instance.GetMaxIDBill();//Lấy ID của bill mới

                lbCurrentBillWorkOn.Text = IDBillWorkingOn.ToString();
                lsvBill.Items.Clear();
                isAddingFood = true;//Bật cờ phép thêm bớt món ăn
                isCheckedOut = false;//Tắt cờ hiệu báo đã thanh toán
            }
            else if (isCheckedOut == false && isAddingFood == true)//Nếu chưa thanh toán
            {
                int FoodCountOnBill = BillInfoDAO.Instance.CheckBillInfoExists(IDBillWorkingOn);//Số lượng món hiện đang trong bill

                if (FoodCountOnBill == 0)
                {
                    MessageBox.Show("Hóa đơn hiện không có gì, không cần tạo mới!");
                    return;
                }
                else
                {
                    DialogResult CancelCheckOut = MessageBox.Show("Hóa đơn chưa thanh toán\nHủy hóa đơn này và tạo mới hóa đơn khác?", "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (CancelCheckOut == DialogResult.OK)
                    {
                        BillInfoDAO.Instance.RemoveBillInfo(int.Parse(lbCurrentBillWorkOn.Text));//Hủy CTHĐ
                        lsvBill.Items.Clear();
                        isAddingFood = true;//Bật cờ phép thêm bớt món ăn
                        isCheckedOut = false;//Tắt cờ hiệu báo đã thanh toán
                    }
                }
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            //Bill không tồn tại (chưa tạo mới bill)
            if (isCheckedOut == true)
            {
                MessageBox.Show("Hóa đơn chưa dược tạo mới, không thể thanh toán");
            }
            //Kiểm tra trong hóa đơn nếu không có dữ liệu thì không cho thanh toán
            else
            {
                int FoodCountOnBill = BillInfoDAO.Instance.CheckBillInfoExists(IDBillWorkingOn);//Số lượng món hiện đang trong bill

                if (FoodCountOnBill == 0)
                {
                    MessageBox.Show("Hóa đơn hiện không có gì, không thể thanh toán!");
                }
                //Bill chưa thanh toán
                else if (isCheckedOut == false)
                {
                    //Hỏi xác nhận
                    DialogResult CheckOutConfirm = MessageBox.Show("Xác nhận thanh toán?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (CheckOutConfirm == DialogResult.OK)
                    {
                        lbCurrentBillWorkOn.Text += " - Đã thanh toán";
                        isCheckedOut = true;//Đánh dấu đã thanh toán
                        IDBillWorkingOn = 0;//Chỉnh idbill về trạng thái không hợp lệ-
                        isAddingFood = false;//Không cho phép thêm món
                        MessageBox.Show("Thanh toán thành công!");
                        return;
                    }
                }
            }
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isCheckedOut==false)//Chưa thanh toán
            {
                if(MessageBox.Show("Hóa đơn hiện tại chưa được hoàn thành\nVẫn thoát ra?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    BillDAO.Instance.RemoveBill(IDBillWorkingOn);//Xóa hóa đơn đã tạo nhưng chưa được hoàn thành trong phiên làm việc
                    MessageBox.Show("Đã xóa hóa đơn hiện tại\n Chương trình sẽ trở về màn hình đăng nhập!");
                }
            }
            else
            {
                if (MessageBox.Show("Bạn muốn trở về màn hình đăng nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
