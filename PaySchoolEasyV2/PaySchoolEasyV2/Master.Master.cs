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

            if (UsuarioLogueado.TipoUsuarioNombre == "Tutor")
            {
                MenuItem Incripcion = new MenuItem("Incripciones");
                Incripcion.Value = "Incripciones";
                Incripcion.NavigateUrl = "Incripciones/Index.aspx";
                Menu1.Items.Add(Incripcion);

                MenuItem Pagos = new MenuItem("Pagar");
                Pagos.Value = "pagar";
                Pagos.NavigateUrl = "Pagos/Pagar.aspx";
                Menu1.Items.Add(Pagos);


            }

            if (UsuarioLogueado.TipoUsuarioNombre == "Admin")
            {
                MenuItem niveles = new MenuItem("Niveles");
                niveles.Value = "Niveles";
                niveles.NavigateUrl = "Niveles/Index.aspx";
                Menu1.Items.Add(niveles);

                MenuItem alumnos = new MenuItem("Alumnos");
                alumnos.Value = "Alumnos";
                alumnos.NavigateUrl = "Alumnos/Index.aspx";
                Menu1.Items.Add(alumnos);

                MenuItem cursos = new MenuItem("Cursos");
                cursos.Value = "Cursos";
                cursos.NavigateUrl = "Cursos/Index.aspx";
                Menu1.Items.Add(cursos);

                MenuItem cuotas = new MenuItem("Cuotas");
                cuotas.Value = "Cuotas";
                cuotas.NavigateUrl = "Cuotas/Index.aspx";
                Menu1.Items.Add(cuotas);

                MenuItem matriculas = new MenuItem("Matriculas");
                matriculas.Value = "Matriculas";
                matriculas.NavigateUrl = "Matriculas/Index.aspx";
                Menu1.Items.Add(matriculas);


                MenuItem pagos = new MenuItem("Pagos");

                MenuItem import = new MenuItem("Importar");
                import.Value = "Importar";
                import.NavigateUrl = "Pagos/Importar.aspx";
                pagos.ChildItems.Add(import);

                MenuItem verpagos = new MenuItem("Ver Pagos");
                verpagos.Value = "Ver Pagos";
                verpagos.NavigateUrl = "Pagos/Index.aspx";
                pagos.ChildItems.Add(verpagos);


                Menu1.Items.Add(pagos);



                MenuItem Ins = new MenuItem("Inscripciones");

                MenuItem eliminar = new MenuItem("Eliminar Inscripciones vencidas");
                eliminar.Value = "Eliminar Inscripciones vencidas";
                eliminar.NavigateUrl = "Incripciones/DarDeBaja.aspx";
                Ins.ChildItems.Add(eliminar);

                MenuItem Incripcion = new MenuItem("Confimar Inscripciones");
                Incripcion.Value = "Confimar Inscripciones";
                Incripcion.NavigateUrl = "Incripciones/Confirmar.aspx";
                Ins.ChildItems.Add(Incripcion);

                Menu1.Items.Add(Ins);


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