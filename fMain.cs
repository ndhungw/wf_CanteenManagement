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

            lbCurrentBillWorkOn.Text = BillDAO.Instance.GetMaxIDBill().ToString();

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
        //

        
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
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
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
            foreach(DTO.BillView item in listMenu)
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

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            lsvBill.Items.Clear();

            int idBill = BillDAO.Instance.GetMaxIDBill();//Lấy idBill mới
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            lbCurrentBillWorkOn.Text = idBill.ToString();

            if (count < 0)
            {
                if (BillInfoDAO.Instance.CheckBillInfoExists(idBill)==0)//Không có chi tiết hóa đơn
                {
                    MessageBox.Show("Số lượng không được âm khi món này chưa tồn tại trong hóa đơn");
                    return;
                }
            }
            
            BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            ShowBill(idBill);
        }

        bool isCheckedOut = true;
        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            if (isCheckedOut == false)
            {
                
                DialogResult CancelCheckOut = MessageBox.Show("Hóa đơn chưa thanh toán\nVẫn tạo mới hóa đơn?", "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (CancelCheckOut == DialogResult.OK)
                {
                    BillDAO.Instance.RemoveBill(int.Parse(lbCurrentBillWorkOn.Text));//Hủy CTHĐ và HĐ
                }
            }
            else
            {
                BillDAO.Instance.InsertBill();//Tạo bill mới
                isCheckedOut = false;
                lbCurrentBillWorkOn.Text = BillDAO.Instance.GetMaxIDBill().ToString();
                lsvBill.Items.Clear();
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            //Bill chưa tồn tại

            //Bill đã thanh toán

            //Bill chưa thanh toán
            //Hỏi xác nhận
            DialogResult CheckOutConfirm = MessageBox.Show("Xác nhận thanh toán?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (CheckOutConfirm == DialogResult.OK)
            {
                isCheckedOut = true;
                MessageBox.Show("Thanh toán thành công!");
                return;
            }
        }
    }
}
