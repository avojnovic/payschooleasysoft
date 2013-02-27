using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Incripciones
{
    public partial class Confirmar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var ins = InscripcionManager.Get();

                foreach (Inscripcion i in ins)
                {
                    i.Curso = CursoManager.Get(i.Curso.Id).First();
                }

                GridView1.DataSource = ins;

                GridView1.DataBind();
            }

        }

       
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }



        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Confirmar")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];


                Label Id = row.FindControl("lblId") as Label;
               


                if (Id.Text.Trim() != "")
                {
                    Inscripcion i = InscripcionManager.Get(long.Parse(Id.Text.Trim())).First();

                    i.Inscripto = true;
                    i.EnListaDeEspera = false;

                    InscripcionManager.Update(i);

                }
            }

            if (e.CommandName == "Borrar")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];


                Label Id = row.FindControl("lblId") as Label;



                if (Id.Text.Trim() != "")
                {
                    Inscripcion i = InscripcionManager.Get(long.Parse(Id.Text.Trim())).First();
                    InscripcionManager.Delete(i.Id);

                }
            }


            Response.Redirect("Confirmar.aspx");


        }





    }
}