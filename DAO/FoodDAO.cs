using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO(); return FoodDAO.instance;
            }
            private set
            {
                FoodDAO.instance = value;
            }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query =  "SELECT MA.* " +
                            "FROM MonAn MA, MonAn_thuoc_LoaiMon MATLM WHERE MATLM.LoaiMonAn_idLoaiMonAn = " + id +
                            "AND MA.idMonAn = MATLM.MonAn_idMonAn";

            DataTable data = DataProvider.Instance.ExecQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
    }
}
