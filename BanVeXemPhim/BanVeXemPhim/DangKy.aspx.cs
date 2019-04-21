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
    public partial class DangKy : System.Web.UI.Page
    {
        private string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sqlselect = "select * from TaiKhoanKhachHang where TenDangNhap = '" + txtTenDangNhap.Text + "'";
            string c = "";
            
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
                            c = "Tên Đăng Nhập Đã Có Vui Lòng Nhập Lại";
                            Label1.Text = c;
                        }
                        else
                        {
                            using (SqlConnection cnn1 = new SqlConnection(constr))
                            {
                                using (SqlCommand cmd1 = cnn1.CreateCommand())
                                {
                                    cmd1.CommandType = CommandType.StoredProcedure;
                                    cmd1.CommandText = "them_khachhang";
                                    cmd1.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                                    cmd1.Parameters.AddWithValue("@cmnd", txtCMND.Text);
                                    cnn1.Open();
                                    cmd1.ExecuteNonQuery();
                                }
                            }
                            using (SqlConnection cnn1 = new SqlConnection(constr))
                            {
                                string sql = "select * from KhachHang where CMND='" + txtCMND.Text + "'";
                                using (SqlCommand cmd1 = new SqlCommand(sql, cnn1))
                                {
                                    using (SqlDataAdapter com = new SqlDataAdapter(cmd1))
                                    {
                                        DataTable da = new DataTable();
                                        com.Fill(da);
                                        if (da.Rows.Count == 1)
                                        {
                                            c = da.Rows[0][0].ToString();
                                        }
                                    }
                                }
                            }
                            using (SqlConnection cnn2 = new SqlConnection(constr))
                            {
                                using (SqlCommand cmd2 = cnn2.CreateCommand())
                                {
                                    string b = "Q2";
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.CommandText = "them_taikhoan";
                                    cmd2.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
                                    cmd2.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                                    cmd2.Parameters.AddWithValue("@idmakhachhang", c);
                                    cmd2.Parameters.AddWithValue("@idquyensudung", b);
                                    cnn2.Open();
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}