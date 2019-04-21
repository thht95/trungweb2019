using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim
{
    public partial class Login : System.Web.UI.Page
    {
        private string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql="select * from TaiKhoanKhachHang where TenDangNhap='"+txtTenDangNhap.Text+"' and MatKhau='"+txtMatKhau.Text+"'";
            using(SqlConnection cnn=new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter com = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        com.Fill(da);
                        if(da.Rows.Count == 1)
                        {
                            Session["tendangnhap"] = da.Rows[0]["TenDangNhap"] ;
                            Session["matkhau"] = da.Rows[0]["MatKhau"];
                            string a = da.Rows[0][4].ToString();
                            if (a == "Q1")
                            {
                                Session["trangthaidangnhap"] = "1";
                                Response.Redirect("Admin.aspx");
                            }
                            else
                            {
                                Session["trangthaidangnhap"] = "1";
                                Response.Redirect("TrangChu.aspx");
                            }
                        }
                        else
                        {
                            Response.Write(da.Rows.Count.ToString());
                            Response.Write("<script>alert('Đăng Nhập Không Thành Công');</script>");
                        }
                    }
                }
            }
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            Response.Redirect("DangKy.aspx");
        }
    }
}