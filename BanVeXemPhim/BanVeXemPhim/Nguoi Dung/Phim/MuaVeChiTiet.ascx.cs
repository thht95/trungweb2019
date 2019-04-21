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
    public partial class MuaVeChiTiet : System.Web.UI.UserControl
    {
        public string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        string a, madangnhap;
        string loaighe, giatien;

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string sql = "select * from TaiKhoanKhachHang where TenDangNhap='" + Session["tendangnhap"].ToString() + "'";
            using (SqlConnection cnn1 = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn1))
                {
                    using (SqlDataAdapter com = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        com.Fill(da);
                        if (da.Rows.Count == 1)
                        {
                            madangnhap = da.Rows[0]["MaDangNhap"].ToString();
                        }
                    }
                }
                using (SqlCommand cmd1 = cnn1.CreateCommand())
                {
                    foreach (DataListItem li in DataList1.Items)
                    {
                        CheckBox check = (CheckBox)li.FindControl("CheckBox2");
                        if (check.Checked)
                        {
                            loaighe = "Vip";
                            giatien = "100000";
                        }
                        else
                        {
                            loaighe = "Thường";
                            giatien = "800000";
                        }
                    }

                    a = Request.QueryString["id"];
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "them_vexemphim";
                    cmd1.Parameters.AddWithValue("@maxuatchieu", a);
                    cmd1.Parameters.AddWithValue("@madangnhao", madangnhap);
                    cmd1.Parameters.AddWithValue("@loaighe", loaighe);
                    cmd1.Parameters.AddWithValue("@giatien", giatien);
                    cnn1.Open();
                    int i = cmd1.ExecuteNonQuery();
                    Response.Write("<script>aleart('Mua Vé Thành Công')</script>");
                }
          
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["trangthaidangnhap"] != null && Session["trangthaidangnhap"].ToString() == "1")
            {
                if (Request.QueryString["id"] != null)
                    a = Request.QueryString["id"];
                string sql = "select TenPhim,TenPhong,GioChieu,MaXuatChieu from XuatChieu inner join Phong on XuatChieu.IDMaPhong=Phong.MaPhong inner join Phim on Phim.MaPhim=XuatChieu.IDMaPhim where MaXuatChieu ='" + a + "'";
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
            }else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}