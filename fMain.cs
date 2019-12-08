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
        public fMain()
        {
            InitializeComponent();

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
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

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
            lsvBill.Items.Clear();
            List<DTO.BillView> listMenu = BillViewDAO.Instance.GetListMenuByBill(idBill);
            foreach(DTO.BillView item in listMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.SinglePrice.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
            }
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.InsertBill();//Tạo bill mới

            int idBill = BillDAO.Instance.GetMaxIDBill();//Lấy idbill mới
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);

            ShowBill(idBill);
        }


    }
}
