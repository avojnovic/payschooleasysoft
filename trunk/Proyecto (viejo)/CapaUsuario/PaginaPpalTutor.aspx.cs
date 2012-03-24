using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class PaginaPpalTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cambiarcontraseñalbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambiarContraseña.aspx");
        }

        protected void cerrarsesionlbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void inscribiralumnolbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InscribirAlumno.aspx");
        }

        protected void pagarlbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagarMatriculaCuota.aspx");
        }
    }
}
