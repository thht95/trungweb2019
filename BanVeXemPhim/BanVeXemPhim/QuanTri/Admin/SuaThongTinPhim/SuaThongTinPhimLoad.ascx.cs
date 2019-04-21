using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeXemPhim.QuanTri.Admin.SuaThongTinPhim
{
    public partial class SuaThongTinPhimLoad : System.Web.UI.UserControl
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
                using (SqlCommand cmd = new SqlCommand("select * from Phim", cnn))
                {
                    using (SqlDataAdapter comd = new SqlDataAdapter(cmd))
                    {
                        DataTable da = new DataTable();
                        comd.Fill(da);
                        dtlSuaThongTinPhim.DataSource = da;
                        dtlSuaThongTinPhim.DataBind();
                    }
                }
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}