using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cerrarsesionlbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void eliminaralumnolbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarAlumno.aspx");
        }      

        protected void actualizaralumnolbtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarAlumno.aspx");
        }

        protected void eliminartutorlbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarTutor.aspx");
        }

        protected void actualizartutorlbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarTutor.aspx");
        }

        protected void actualizarvaloreslbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarValoresMonetarios.aspx");
        }

        protected void registrarpagorealizadolbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarPagoRealizado.aspx");
        }
    }
}
