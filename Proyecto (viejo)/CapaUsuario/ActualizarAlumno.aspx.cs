using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ActualizarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cancelarbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPpalAdministrador.aspx");
        }

        protected void actualizarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
