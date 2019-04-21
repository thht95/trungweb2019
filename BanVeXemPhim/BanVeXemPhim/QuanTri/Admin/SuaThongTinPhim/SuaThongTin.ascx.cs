using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BanVeXemPhim.QuanTri.Admin.SuaThongTinPhim
{
    public partial class SuaThongTin : System.Web.UI.UserControl
    {
        private string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["id"];
            string sql = "select * from Phim where MaPhim='" + a + "'";
            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            txtMaPhim.Text = ds.Rows[0][0].ToString();
            txtTenPhim.Text = ds.Rows[0][1].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection cnn1 = new SqlConnection(constr))
            {
                using (SqlCommand cmd1 = cnn1.CreateCommand())
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "update_phim";
                    cmd1.Parameters.AddWithValue("@maphim", txtMaPhim.Text);
                    cmd1.Parameters.AddWithValue("@tenphim", txtTenPhim.Text);
                    cnn1.Open();
                    cmd1.ExecuteNonQuery();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string a = Request.QueryString["id"];
                string deletedStr = "Delete from Phim where MaPhim ='" + a + "'";
                using (SqlCommand cmd = new SqlCommand(deletedStr, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}