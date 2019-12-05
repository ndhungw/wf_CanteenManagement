using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_CanteenManagement.DAO;

namespace wf_CanteenManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadFoodList();
            loadData();
        }

        void loadFoodList()
        {
            string query = "SELECT * FROM dbo.MonAn";
            dtgvFood.DataSource = DataProvider.Instance.ExecQuery(query);

            query = "SELECT * FROM dbo.LoaiMonAn";
            dtgvCategory.DataSource = DataProvider.Instance.ExecQuery(query);

            query = "SELECT * FROM dbo.HoaDon";
            dtgvBill.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        // load data từ gridView vào textbox
        void loadData()
        {
            // tab thức ăn
            txbFoodID.DataBindings.Clear(); // Xóa nội dung hiện tại trên textbox
            txbFoodID.DataBindings.Add("Text", dtgvFood.DataSource, "idMonAn");//load data

            txbFoodName.DataBindings.Clear();
            txbFoodName.DataBindings.Add("Text", dtgvFood.DataSource, "Ten");

            nmFoodPrice.DataBindings.Clear();
            nmFoodPrice.DataBindings.Add("Text", dtgvFood.DataSource, "Gia");
            //tab danh mục
            txbCategoryID.DataBindings.Clear();
            txbCategoryID.DataBindings.Add("Text", dtgvCategory.DataSource, "idLoaiMonAn");

            txbCategoryName.DataBindings.Clear();
            txbCategoryName.DataBindings.Add("Text", dtgvCategory.DataSource, "Ten_loai");
        }
        
        private void dtgvFood_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvFood.CurrentRow.Selected = true; // chọn cả dòng dữ liệu
                dtgvCategory.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            string fromDate = dtpkFromDate.Value.ToShortDateString();
            string toDate = dtpkToDate.Value.ToShortDateString();
            
            string query = "Tim_Hoa_Don_Theo_Ngay @BEGIN , @END";
            dtgvBill.DataSource = DataProvider.Instance.ExecQuery(query, new Object[] { fromDate, toDate } );
        }
    }
}
