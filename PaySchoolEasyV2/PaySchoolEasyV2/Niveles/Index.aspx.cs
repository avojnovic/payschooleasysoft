using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlObjects.Niveles
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Carga la grilla con todos los Alumnos y la asocia al tipo dato
            GridView1.DataSource =NivelManager.Get();
            GridView1.DataBind();

        }


        //Evento de grilla para cambiar de pagina y ver todos los elementos
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = NivelManager.Get();
            GridView1.DataBind();
        }
    }
}