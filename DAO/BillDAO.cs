using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetMaxIDBill()
        {

            return (int)DataProvider.Instance.ExecScalar("SELECT MAX(idHoaDon) FROM dbo.HoaDon");
        }

        public void InsertBill(int idNhanvien)
        {
            DataProvider.Instance.ExecNonQuery("EXEC Them_Hoa_Don @IdNhanVien", new object[] { idNhanvien });
        }

        public void RemoveBill(int idBill)
        {
            DataProvider.Instance.ExecNonQuery("Xoa_Hoa_Don_Dang_Tao @IdHoaDon", new object[] { idBill });
        }
    }
}
