using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanVeXemPhim.QuanTri.Admin
{
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        public string md = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["md"] != null)
                md = Request.QueryString["md"];
            switch (md)
            {
                case "themphim":
                    plAdminLoadControl.Controls.Add(LoadControl("ThemPhim/ThemPhimLoad.ascx"));
                    break;
                case "suathongtinphim":
                    plAdminLoadControl.Controls.Add(LoadControl("SuaThongTinPhim/SuaThongTinPhimLoad.ascx"));
                    break;
                case "quanlytaikhoan":
                    plAdminLoadControl.Controls.Add(LoadControl("QuanLyTaiKhoan/QuanLyTaiKhoanLoad.ascx"));
                    break;
                case "duyethoidap":
                    plAdminLoadControl.Controls.Add(LoadControl("DuyetHoiDap/DuyetHoiDapLoad.ascx"));
                    break;
                case "chinhsualichchieu":
                    plAdminLoadControl.Controls.Add(LoadControl("ChinhSuaLichChieu/ChinhSuaLichChieuLoad.ascx"));
                    break;
                case "suathongtin":
                    plAdminLoadControl.Controls.Add(LoadControl("SuaThongTinPhim/SuaThongTin.ascx"));
                    break;
                case "sualichchieu":
                    plAdminLoadControl.Controls.Add(LoadControl("ChinhSuaLichChieu/SuaLichChieu.ascx"));
                    break;
                case "xoalichchieu":
                    plAdminLoadControl.Controls.Add(LoadControl("ChinhSuaLichChieu/XoaLichChieu.ascx"));
                    break;
                case "suathongtintaikhoan":
                    plAdminLoadControl.Controls.Add(LoadControl("QuanLyTaiKhoan/SuaThongTinTaiKhoan.ascx"));
                    break;
            }
        }
    }
}