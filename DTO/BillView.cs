using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_CanteenManagement.DTO
{
    public class BillView
    {
        private string foodName;
        private int count;
        private int singlePrice;//should be float, do this because of database
        private int totalPrice;//should be float, do this because of database

        public BillView(DataRow row)
        {
            this.FoodName = row["Ten mon"].ToString();
            this.Count = (int)row["So luong"];
            this.SinglePrice = (int)row["Don gia"];
            this.TotalPrice = (int)row["Thanh tien"];
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public int SinglePrice { get => singlePrice; set => singlePrice = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
