using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UI
{
    public partial class RegistrarTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceptarbtn_Click(object sender, EventArgs e)
        {
            if (comprobarDisponibilidadUsuario())
            {
                String email = emailtb.Text;
                String contraseña = contraseñatb.Text;
                String confContraseña = confcontraseñatb.Text;
                String dni = dnitb.Text;
                String nombre = nombretb.Text;
                String apellido = apellidotb.Text;
                String telefono = telefonotb.Text;
                String direccion = direcciontb.Text;

                if (dnitb.Text.Length.Equals(7) != true && dnitb.Text.Length.Equals(8) != true)
                    dniInvalidolb.Visible = true;
                else
                {
                    if (contraseña != confContraseña)
                        contnocoincidenRFV.Visible = true;
                    else
                    {
                        Tutor tutor = PaySchoolEasySoft.buscarTutor(dni);
                        if (tutor == null)
                        {
                            tutor = new Tutor(email, contraseña, dni, apellido, nombre, direccion, telefono);
                            PaySchoolEasySoft.registrarTutor(tutor);
                            Response.Redirect("Default.aspx");
                        }else
                            usuarioRegistradolb.Visible = true;
                    }
                }
            }else
                usuarioRegistradolb.Visible = true;
        }

        protected void cancelarbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void comprobar_Click(object sender, EventArgs e)
        {
            if(emailtb.Text != "")
                comprobarDisponibilidadUsuario();
        }

        public bool comprobarDisponibilidadUsuario()
        {
            String email = emailtb.Text;
            bool disponible = PaySchoolEasySoft.usuarioDisponible(email);
            if (disponible)
            {
                disponiblelb.Visible = true;
                nodisponiblelb.Visible = false;
            }
            else
            {
                nodisponiblelb.Visible = true;
                disponiblelb.Visible = false;
            }
            return disponible;
        }

        protected void emailtb_TextChanged(object sender, EventArgs e)
        {
            if (emailtb.Text != "")
                comprobar.Enabled = true;
            else
                comprobar.Enabled = false;
        }
    }
}
