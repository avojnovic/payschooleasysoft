using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Usuarios
{
    public partial class Password : System.Web.UI.Page
    {
        private User UsuarioLogueado;


        protected void Page_Load(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            UsuarioLogueado = (User)Session["user"];

        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";


            if (TxtContrasena.Text == UsuarioLogueado.Psw)
            {
                if (TxtContrasenaConfirmar.Text == TxtContrasenaNueva.Text)
                {
                    UsuarioLogueado.Psw = TxtContrasenaNueva.Text;
                    UserManager.Update(UsuarioLogueado);

                    LblMensaje.Text = "Contraseña actualizada con éxito";
                }
                else
                {
                    LblMensaje.Text = "La confirmación de Contraseña debe ser igual a la nueva Contraseña";
                }
            }
            else
            {
                LblMensaje.Text = "Contraseña actual incorrecta";
            }
            
        }

        private void volver()
        {
            Response.Redirect("../Default.aspx");
        }
    }
}