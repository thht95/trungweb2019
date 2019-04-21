using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BanVeXemPhim.Nguoi_Dung.Phim
{
    public partial class Phim : System.Web.UI.UserControl
    {
        public string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from Phim";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter com = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        com.Fill(da);
                        DataList1.DataSource = da;
                        DataList1.DataBind();
                    }
                }
            }
        }
        private void LoadDataToDropDownList()
        {
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}