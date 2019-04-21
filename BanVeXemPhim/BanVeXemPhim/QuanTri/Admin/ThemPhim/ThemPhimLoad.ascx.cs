using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim.QuanTri.Admin.ThemPhim
{
    public partial class ThemPhimLoad : System.Web.UI.UserControl
    {
        private string constr= ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }

        protected void load()
        {
            using(SqlConnection cnn=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand("select MaPhim as 'Mã Phim',TenPhim as 'Tên Phim' from Phim", cnn))
                {
                    using(SqlDataAdapter comd=new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        comd.Fill(da);
                        grvThemPhim.DataSource = da;
                        grvThemPhim.DataBind();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtMaPhim.Text != "")
            {
                string sqlselect = "select * from Phim where MaPhim = '" + txtMaPhim.Text + "'";

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
                                string a = "Mã Phim Đã Có Vui Lòng Nhập Lại";
                                lbMaPhim.Text = a;
                            }
                            else
                            {

                                using (SqlConnection cnn1 = new SqlConnection(constr))
                                {

                                    using (SqlCommand cmd1 = cnn1.CreateCommand())
                                    {
                                        cmd1.CommandType = CommandType.StoredProcedure;
                                        cmd1.CommandText = "them_phim";
                                        cmd1.Parameters.AddWithValue("@maphim", txtMaPhim.Text);
                                        cmd1.Parameters.AddWithValue("@tenphim", txtTenPhim.Text);
                                        cnn1.Open();
                                        int i = cmd1.ExecuteNonQuery();
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