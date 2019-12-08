using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement.DAO
{
    public class BillViewDAO
    {
        private static BillViewDAO instance;

        public static BillViewDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillViewDAO(); return BillViewDAO.instance;
            }
            private set
            {
                BillViewDAO.instance = value;
            }
        }

        private BillViewDAO() { }

        public List<BillView> GetListMenuByBill(int idBill)
        {
            List<BillView> listMenu = new List<BillView>();

            string query = "SELECT MA.Ten as [Ten mon], CT.SoLuong as [So luong], MA.Gia as [Don gia], MA.Gia*CT.SoLuong as [Thanh tien] " +
                "FROM dbo.ChiTietHoaDon CT, dbo.HoaDon HD, dbo.MonAn MA " +
                "WHERE CT.HoaDon_idHoaDon = HD.idHoaDon AND CT.MonAn_idMonAn = MA.idMonAn " +
                "AND HD.idHoaDon = " + idBill;

            DataTable data = DataProvider.Instance.ExecQuery(query);

            foreach(DataRow item in data.Rows)
            {
                BillView menu = new BillView(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
