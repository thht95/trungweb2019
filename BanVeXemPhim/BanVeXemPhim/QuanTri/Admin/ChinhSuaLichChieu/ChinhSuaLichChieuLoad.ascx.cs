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
    public partial class ChinhSuaLichChieuLoad : System.Web.UI.UserControl
    {
        private string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }
        protected void load()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from XuatChieu", cnn))
                {
                    using (SqlDataAdapter comd = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        comd.Fill(da);
                        dtlChinhSuaLichChieu.DataSource = da;
                        dtlChinhSuaLichChieu.DataBind();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn1 = new SqlConnection(constr))
            {

                using (SqlCommand cmd1 = cnn1.CreateCommand())
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "them_xuatchieu";
                    cmd1.Parameters.AddWithValue("@maxuatchieu", txtMaXuatChieu.Text);
                    cmd1.Parameters.AddWithValue("@maphong", txtTenPhong.Text);
                    cmd1.Parameters.AddWithValue("@maphim", txtTenPhim.Text);
                    cmd1.Parameters.AddWithValue("@giochieu", txtGioChieu.Text);
                    cmd1.Parameters.AddWithValue("@soluongghevip", txtSoLuongGheVip.Text);
                    cmd1.Parameters.AddWithValue("@soluongghethuong", txtSoLuongGheThuong.Text);
                    cnn1.Open();
                    int i = cmd1.ExecuteNonQuery();
                }
            }
        }
    }
}