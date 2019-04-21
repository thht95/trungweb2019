using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim.Nguoi_Dung.PhanHoi
{
    public partial class PhanHoi : System.Web.UI.UserControl
    {
        public string constr = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }
        protected void load()
        {
            string sql = "select * from PhanHoi where DaDuyet='true'";
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
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn1 = new SqlConnection(constr))
            {

                using (SqlCommand cmd1 = cnn1.CreateCommand())
                {
                    string b = "false";
                    DateTime a = DateTime.Now;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "them_phanhoi";
                    cmd1.Parameters.AddWithValue("@noidung", TextBox2.Text);
                    cmd1.Parameters.AddWithValue("@thoigian", a);
                    cmd1.Parameters.AddWithValue("@nguoigui", TextBox1.Text);
                    cmd1.Parameters.AddWithValue("@daduyet", b);
                    cnn1.Open();
                    int i = cmd1.ExecuteNonQuery();
                    Response.Write("<script>aleart('Đã Gửi Phản Hồi');</script>");
                }
            }
        }
    }
}