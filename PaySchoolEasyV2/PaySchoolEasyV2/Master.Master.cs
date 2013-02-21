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

            if (UsuarioLogueado.TipoUsuarioNombre == "Admin")
            {
                MenuItem alumnos = new MenuItem("Alumnos");
                alumnos.Value = "Alumnos";
                alumnos.NavigateUrl = "Alumnos/Index.aspx";
                Menu1.Items.Add(alumnos);
            }

            if (UsuarioLogueado.TipoUsuarioNombre == "Tutor")
            {
                MenuItem Incripcion = new MenuItem("Incripciones");
                Incripcion.Value = "Incripciones";
                Incripcion.NavigateUrl = "Incripciones/Index.aspx";
                Menu1.Items.Add(Incripcion);
            }

            if (UsuarioLogueado.TipoUsuarioNombre == "Admin")
            {
                MenuItem Usuarios = new MenuItem("Usuarios");
                Usuarios.Value = "Usuarios";
                Usuarios.NavigateUrl = "Usuarios/Index.aspx";
                Menu1.Items.Add(Usuarios);
            }


            MenuItem User = new MenuItem(UsuarioLogueado.nombreCompleto);
            User.Value = UsuarioLogueado.nombreCompleto;
            Menu1.Items.Add(User);

            MenuItem Password = new MenuItem("Cambiar Contraseña");
            Password.Value = "Cambiar Contraseña";
            Password.NavigateUrl = "Usuarios/Password.aspx";
            User.ChildItems.Add(Password);


            MenuItem salir = new MenuItem("Logout");
            salir.Value = "Logout";
            salir.NavigateUrl = "Login.aspx";
            Menu1.Items.Add(salir);

        }





    }
}