using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace PaySchoolEasyV2.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var alumnos = from a in dbContext.Alumno.Include("Nivel")
                          select a;

            
            GridView1.DataSource =(List<Alumno>) alumnos.ToList();

            GridView1.DataBind();

        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alumnos/New.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}