﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanVeXemPhim
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["trangthaidangnhap"]!=null && Session["trangthaidangnhap"].ToString() == "1")
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}