using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CapaNegocio;

namespace UI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.Focus();
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                 String email = Login1.UserName.ToString();
                 String password = Login1.Password.ToString();
                 Usuario usuario = PaySchoolEasySoft.validarLoginUsuario(email, password);
                 Session["usuarioLogueado"] = usuario;
                 if (usuario != null)
                 {
                     if (usuario.sosTutor())
                     {
                         Response.Redirect("PaginaPpalTutor.aspx");
                     }
                     else
                     {
                         Response.Redirect("PaginaPpalAdministrador.aspx");
                     }
                 }
            }catch (Exception ex)
            {
                 Response.Write(ex.Message);
            }
        }

        protected void registrarseahoraLB_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarTutor.aspx");
        }
       
    }
}
