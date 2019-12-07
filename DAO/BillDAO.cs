using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void InsertBill(int idBill, int idFood, int count)
        {
            //-testing
            DataProvider.Instance.ExecNonQuery("exec InsertBill @idHoaDon , @idMonAn , @soLuongMonAn", new object[] { idBill, idFood, count});

            bool isExistBill = false;
            //Bước 1: Kiểm tra hóa đơn đã tồn tại
            if(isExistBill == false)
            {
                //Thực hiện gọi hàm thêm bình thường
                DataProvider.Instance.ExecNonQuery("exec Them_Hoa_Don_Tung_Mon @idHoaDon , @idMonAn , @soLuongMonAn", new object[] { idBill, idFood, count });
            }
            //Bước 2:
            //-endtesting
        }
    }
}
