using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BanVeXemPhim.Nguoi_Dung.LichChieu
{
    public partial class LichChieu : System.Web.UI.UserControl
    {
        public string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
             load();
        }
        protected void load()
        {
            string sql = "select TenPhim,TenPhong,GioChieu,MaXuatChieu from XuatChieu inner join Phong on XuatChieu.IDMaPhong=Phong.MaPhong inner join Phim on Phim.MaPhim=XuatChieu.IDMaPhim";
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
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay.Text = Calendar1.SelectedDate.ToShortDateString(); // just use this method to get dd/MM/yyyy  
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select TenPhim,TenPhong,GioChieu,MaXuatChieu from XuatChieu inner join Phong on XuatChieu.IDMaPhong=Phong.MaPhong inner join Phim on Phim.MaPhim=XuatChieu.IDMaPhim where GioChieu='"+txtNgay.Text+"'";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }
    }
}