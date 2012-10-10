using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

using System.Web.Security;
using ControlObjects;

namespace PaySchoolEasyV2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {

            string usertxt=TxtUsuario.Text.Trim();
            string pswtxt=TxtPassword.Text.Trim();

            var user = UserManager.Get(usertxt, pswtxt);
            

            if (user.Count()==1)
            {

                Session["user"] = (User)user.First();

                FormsAuthentication.RedirectFromLoginPage(TxtUsuario.Text, false);

            }
            else
            {
                if (user.Count() > 1)
                {
                    TxtAviso.Text = "Usuario y Contraseña duplicados";
                }
                else
                {
                    TxtAviso.Text = "Usuario o Contraseña incorrecto";
                }
            }
        }
    }
}