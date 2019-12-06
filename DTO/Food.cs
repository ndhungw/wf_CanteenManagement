using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_CanteenManagement.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int categoryID;
        private float price;
        //description - bo?
        //Image - bo?
        //

        public Food(DataRow row)
        {
            this.ID = (int)row["idMonAn"];
            this.Name = row["Ten"].ToString();
            this.CategoryID = (int)row["idLoaiMonAn"];//them vao CSDL SAU
            this.Price = (int)Convert.ToDouble(row["Gia"].ToString());
        }


        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
