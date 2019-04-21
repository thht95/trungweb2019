using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanVeXemPhim.Nguoi_Dung
{
    public partial class NguoiDungLoad : System.Web.UI.UserControl
    {
        string md = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["md"] != null)
                md = Request.QueryString["md"];
            switch (md)
            {
                case "phim":
                    plUserLoadControl.Controls.Add(LoadControl("Phim/Phim.ascx"));
                    break;
                case "muave":
                    plUserLoadControl.Controls.Add(LoadControl("Phim/MuaVe.ascx"));
                    break;
                case "muavechitiet":
                    plUserLoadControl.Controls.Add(LoadControl("Phim/MuaVeChiTiet.ascx"));
                    break;
                case "lichchieu":
                    plUserLoadControl.Controls.Add(LoadControl("LichChieu/LichChieu.ascx"));
                    break;
                case "phanhoi":
                    plUserLoadControl.Controls.Add(LoadControl("PhanHoi/PhanHoi.ascx"));
                    break;
            }
        }
    }
}