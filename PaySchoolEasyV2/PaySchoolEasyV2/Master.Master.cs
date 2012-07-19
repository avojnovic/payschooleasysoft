using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace PaySchoolEasyV2
{
    public partial class Master : System.Web.UI.MasterPage
    {
        private User UsuarioLogueado;

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioLogueado = (User)Session["user"];

            if (!IsPostBack)
            {
                if (!Page.Request.Url.ToString().ToLower().Contains("login.aspx") && !Page.Request.Url.ToString().ToLower().Contains("error.aspx"))
                {

                    if (UsuarioLogueado == null)
                    {
                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        this.divMenu.Visible = true;
                        generarMenu();
                    }
                }
                else
                {
                    this.divMenu.Visible = false;
                }
            }
        }

        protected void ScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            ScriptManager1.AsyncPostBackErrorMessage = e.Exception.Message;
            Response.Redirect(Request.Url.ToString());
        }

        private void generarMenu()
        {

            MenuItem home = new MenuItem("Home");
            home.Value = "Home";
            home.NavigateUrl = "Default.aspx";
            Menu1.Items.Add(home);

            MenuItem alumnos = new MenuItem("Alumnos");
            alumnos.Value = "Alumnos";
            alumnos.NavigateUrl = "Alumnos.aspx";
            Menu1.Items.Add(alumnos);

            MenuItem salir = new MenuItem("Logout");
            salir.Value = "Logout";
            salir.NavigateUrl = "Login.aspx";
            Menu1.Items.Add(salir);

        }





    }
}