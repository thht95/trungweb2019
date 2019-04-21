using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim.QuanTri.Admin.QuanLyTaiKhoan
{
    public partial class QuanLyTaiKhoanLoad : System.Web.UI.UserControl
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM QuyenSuDung INNER JOIN TaiKhoanKhachHang ON QuyenSuDung.MaQuyenSuDung = TaiKhoanKhachHang.IDMaQuyenSuDung", cnn))
                {
                    using (SqlDataAdapter comd = new SqlDataAdapter(cmd))
                    {

                        DataTable da = new DataTable();
                        comd.Fill(da);
                        dtlQuanLyTaiKhoan.DataSource = da;
                        dtlQuanLyTaiKhoan.DataBind();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtMaDangNhap.Text != "")
            {
                string sqlselect = "select * from TaiKhoanKhachHang where MaDangNhap = '" + txtMaDangNhap.Text + "'";
                string sqlselect1 = "select * from TaiKhoanKhachHang where TenDangNhap = '" + txtTenDangNhap.Text + "'";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlselect, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                string a = "Mã đăng nhập Đã Có Vui Lòng Nhập Lại";
                                lbMaPhim.Text = a;
                            }
                            else
                            {
                                using (SqlConnection cnn2 = new SqlConnection(constr))
                                {
                                    using (SqlCommand cmd2 = new SqlCommand(sqlselect, cnn2))
                                    {
                                        cmd2.CommandType = CommandType.Text;
                                        cnn2.Open();
                                        using (SqlDataReader r1 = cmd2.ExecuteReader())
                                        {
                                            if (r.Read())
                                            {
                                                string a1 = "Tên Đăng nhập Đã Có Vui Lòng Nhập Lại";
                                                lbMaPhim.Text = a1;
                                            }
                                            else
                                            {
                                                using (SqlConnection cnn1 = new SqlConnection(constr))
                                                {

                                                    using (SqlCommand cmd1 = cnn1.CreateCommand())
                                                    {
                                                        cmd1.CommandType = CommandType.StoredProcedure;
                                                        cmd1.CommandText = "them_taikhoan";
                                                        cmd1.Parameters.AddWithValue("@madangnhap", txtMaDangNhap.Text);
                                                        cmd1.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
                                                        cmd1.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                                                        cmd1.Parameters.AddWithValue("@idquyensudung", txtQuyenSuDung.Text);

                                                        cnn1.Open();
                                                        int i = cmd1.ExecuteNonQuery();
                                                        load();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}