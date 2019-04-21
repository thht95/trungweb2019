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
    public partial class MuaVe : System.Web.UI.UserControl
    {
        public string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "";
            if (Request.QueryString["id"] != null)
            {
                a = Request.QueryString["id"];
            }
            string sql = "select * from Phim where MaPhim='" + a + "'" ;
            string sql1 = "select TenPhong,MaXuatChieu,GioChieu from XuatChieu inner join Phong on XuatChieu.IDMaPhong=Phong.MaPhong inner join Phim on Phim.MaPhim=XuatChieu.IDMaPhim where MaPhim ='" + a + "'";
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
                using (SqlCommand cmd1 = new SqlCommand(sql1, cnn))
                {
                    using (SqlDataAdapter com1 = new SqlDataAdapter(cmd1))
                    {
                        DataTable da1 = new DataTable();
                        com1.Fill(da1);
                        DataList2.DataSource = da1;
                        DataList2.DataBind();
                    }
                }
            }
        }
    }
}