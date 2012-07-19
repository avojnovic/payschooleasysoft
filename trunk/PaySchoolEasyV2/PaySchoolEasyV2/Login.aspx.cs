using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;
using CapaDatos;
using System.Web.Security;

namespace PaySchoolEasyV2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            User r = UserDatos.verificarUsuario(TxtUsuario.Text, TxtPassword.Text);

            if (r != null)
            {

                Session["user"] = r;
                FormsAuthentication.RedirectFromLoginPage(TxtUsuario.Text, false);

            }
            else
            {

                TxtAviso.Text = "Usuario o Contraseña incorrecto";
            }
        }
    }
}