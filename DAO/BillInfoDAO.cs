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

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecNonQuery("EXEC Them_Hoa_Don_Tung_Mon @IdHoaDon , @IdMonAn , @SoLuongThemVao , @IdNhanVien", new object[] { idBill, idFood, count, 1 });
        }

        public void RemoveBillInfo(int idBill)
        {
            DataProvider.Instance.ExecNonQuery("Huy_Hoa_Don_Dang_Tao @IdHoaDon", new object[] { idBill });
        }

        public int CheckBillInfoExists(int idBill)
        {
            return (int)DataProvider.Instance.ExecScalar("SELECT COUNT(*) FROM dbo.ChiTietHoaDon WHERE HoaDon_idHoaDon = " + idBill);
        }
    }
}
