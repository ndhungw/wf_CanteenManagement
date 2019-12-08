using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        //public List<BillInfo> GetListBillInfo()
        //{
        //    List<BillInfo> listBill = new List<BillInfo>();

        //    DataTable data = DataProvider.Instance.ExecQuery(
        //        "SELECT * FROM ChiTietHoaDon WHERE HoaDon_idHoaDon = " + BillDAO.Instance.GetMaxIDBill());

        //    foreach (DataRow item in data.Rows)
        //    {
        //        BillInfo bill = new BillInfo(item);
        //        listBill.Add(bill);
        //    }
        //    return listBill;
        //}

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecNonQuery("EXEC Them_Hoa_Don_Tung_Mon @IdHoaDon , @IdMonAn , @SoLuongThemVao , @IdNhanVien", new object[] { idBill, idFood, count, 1 });
        }

        public int CheckBillInfoExists(int idBill)
        {
            return (int)DataProvider.Instance.ExecScalar("SELECT COUNT(*) FROM dbo.ChiTietHoaDon WHERE HoaDon_idHoaDon = " + idBill);
        }
    }
}
