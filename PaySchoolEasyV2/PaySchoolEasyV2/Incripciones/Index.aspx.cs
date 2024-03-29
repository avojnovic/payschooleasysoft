﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Incripciones
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var ins = InscripcionManager.GetByTutor((((User)Session["user"])));
            GridView1.DataSource = ins;
            GridView1.DataBind();

        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Details.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            var ins = InscripcionManager.GetByTutor((((User)Session["user"])));
            GridView1.DataSource = ins;
            GridView1.DataBind();
        }
    }
}