using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DAO;

namespace wf_CanteenManagement.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime dateCreated;
        private int totalPrice;
        private int iDStaff;

        public int ID { get => iD; set => iD = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int IDStaff { get => iDStaff; set => iDStaff = value; }

        //public Bill(DataRow row)
        //{
        //    this.ID = (int)row["idHoaDon"];
        //    this.DateCreated = (DateTime)row["NgayLap"];
        //    this.TotalPrice = (int)row["TongTien"];
        //    this.IDStaff = (int)row["NhanVien_idNhanVien"];
        //}

    }
}
