using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Xml.Linq;
using CapaNegocio;

namespace UI
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        protected void aceptarbtn_Click(object sender, EventArgs e)
        {
            contincorrectaRFV.Visible = false;
            contnocoincidenRFV.Visible = false;
            Usuario usuario = (Usuario)Session["usuarioLogueado"];

            String pass = contraseña.Text;
            String newPass = nuevacontraseña.Text;
            String confNewPass = confirmarcontraseña.Text;

            if (pass == usuario.Contraseña)
            {
                if (newPass == confNewPass)
                {
                    if (usuario.cambiarContraseña(newPass, usuario.Email))
                    {
                        usuario.Contraseña = newPass;
                        Response.Redirect("PaginaPpalTutor.aspx");
                    }
                }
                else
                {
                    contnocoincidenRFV.Visible = true;
                }
            }
            else
            {
                contincorrectaRFV.Visible = true;
            }
        }

        protected void cancelarbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPpalTutor.aspx");
        }
          
    
    }
}

