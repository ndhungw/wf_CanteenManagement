using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_CanteenManagement.DTO
{
    public class BillInfo
    {
        private int iD;
        private int foodID;
        private int foodCount;

        public int ID { get => iD; set => iD = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int FoodCount { get => foodCount; set => foodCount = value; }

        //public BillInfo(DataRow row)
        //{
        //    this.ID = (int)row["HoaDon_idHoaDon"];
        //    this.FoodID = (int)row["MonAn_idMonAn"];
        //    this.FoodCount = (int)row["SoLuong"];
        //}
    }
}
