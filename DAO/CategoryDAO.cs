using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_CanteenManagement.DTO;

namespace wf_CanteenManagement.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance;
            }
            private set
            {
                CategoryDAO.instance = value;
            }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT * FROM dbo.LoaiMonAn";

            DataTable data = DataProvider.Instance.ExecQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
    }
}
