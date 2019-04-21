using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BanVeXemPhim.QuanTri.Admin.ChinhSuaLichChieu
{
    public partial class SuaLichChieu : System.Web.UI.UserControl
    {
        private string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["id"];
            string sql = "select * from XuatChieu where MaXuatChieu='" + a + "'";
            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            txtMaPhong.Text = ds.Rows[0][1].ToString();
            txtMaPhim.Text = ds.Rows[0][2].ToString();
            txtGioChieu.Text = ds.Rows[0][3].ToString();
            txtSoLuongGheVip.Text = ds.Rows[0][4].ToString();
            txtSoLuongGheThuong.Text = ds.Rows[0][5].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn1 = new SqlConnection(constr))
            {
                using (SqlCommand cmd1 = cnn1.CreateCommand())
                {
                    String c = Request.QueryString["id"];
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "update_xuatchieu";
                    cmd1.Parameters.AddWithValue("@maxuatchieu", c);
                    cmd1.Parameters.AddWithValue("@maphong", txtMaPhong.Text);
                    cmd1.Parameters.AddWithValue("@maphim", txtMaPhim.Text);
                    cmd1.Parameters.AddWithValue("@giochieu", txtGioChieu.Text);
                    cmd1.Parameters.AddWithValue("@soluongghevip",txtSoLuongGheVip.Text);
                    cmd1.Parameters.AddWithValue("@soluongghethuong",txtSoLuongGheThuong.Text);
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
                string deletedStr = "Delete from XuatChieu where MaXuatChieu ='" + a + "'";
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