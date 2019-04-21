using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim.QuanTri.Admin.DuyetHoiDap
{
    public partial class DuyetHoiDapLoad : System.Web.UI.UserControl
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
                using (SqlCommand cmd = new SqlCommand("select * from PhanHoi where DaDuyet='false'", cnn))
                {
                    using (SqlDataAdapter comd = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        comd.Fill(da);
                        GridView1.DataSource = da;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "duyet")
            {
                int i = int.Parse(e.CommandArgument.ToString());
                using (SqlConnection cnn1 = new SqlConnection(constr))
                {
                    using (SqlCommand cmd1 = cnn1.CreateCommand())
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.CommandText = "update_duyet";
                        cmd1.Parameters.AddWithValue("@maphanhoi",i);
                        cnn1.Open();
                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            if (e.CommandName == "xoa")
            {
                int i = int.Parse(e.CommandArgument.ToString());
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string a = Request.QueryString["id"];
                    string deletedStr = "Delete from PhanHoi where MaPhanHoi ='" + i + "'";
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
}