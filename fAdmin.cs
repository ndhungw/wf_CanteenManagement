using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_CanteenManagement.DAO;

namespace wf_CanteenManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadFoodList();
        }

        void loadFoodList()
        {
            string query = "SELECT * FROM dbo.MonAn";
            DataProvider provider = new DataProvider();

            dtgvFood.DataSource = provider.ExecQuery(query);
        }
    }
}
