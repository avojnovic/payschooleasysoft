﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlObjects.Usuarios
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource =UserManager.Get();
            GridView1.DataBind();
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Details.aspx");
        }

    
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = UserManager.Get();
            GridView1.DataBind();
        }
    }
}