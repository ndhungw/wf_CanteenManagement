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
            try
            {
                return (int)DataProvider.Instance.ExecScalar("SELECT MAX(idHoaDon) FROM dbo.HoaDon");
            }
            catch
            {
                return 1;
            }
        }

        public void InsertBill()
        {
            DataProvider.Instance.ExecNonQuery("EXEC Them_Hoa_Don @IdNhanVien", new object[] { 1 });
        }
    }
}
