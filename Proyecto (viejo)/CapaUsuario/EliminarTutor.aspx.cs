using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UI
{
    public partial class EliminarTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cancelarbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPpalAdministrador.aspx");
        }

        protected void buscarbtn_Click(object sender, EventArgs e)
        {
            String dni = dnitb.Text;
            Tutor tutor = PaySchoolEasySoft.buscarTutor(dni);
            if (tutor != null)
            {
                Session["tutor"] = tutor;
                apellidotb.Text = tutor.Apellido;
                nombretb.Text = tutor.Nombre;
                telefonotb.Text = tutor.Telefono;
                direcciontb.Text = tutor.Direccion;
                emailtb.Text = tutor.Email;
            }
            else
                tutorInexistentelb.Visible = true;
        }

        protected void eliminarbtn_Click(object sender, EventArgs e)
        {
            ((Tutor)Session["tutor"]).eliminarse();
            Response.Redirect("PaginaPpalAdministrador.aspx");
        }


    }
}
