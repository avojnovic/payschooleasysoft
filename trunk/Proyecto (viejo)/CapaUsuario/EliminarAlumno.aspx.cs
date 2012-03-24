using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UI
{
    public partial class EliminarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cancelarbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPpalAdministrador.aspx");
        }

        protected void eliminarbtn_Click(object sender, EventArgs e)
        {

        }

        protected void buscarbtn_Click(object sender, EventArgs e)
        {
            String nromatricula = nromatriculatb.Text;
            Alumno alumno = PaySchoolEasySoft.buscarAlumno(nromatricula);
            if (alumno != null)
            {
                Session["alumno"] = alumno;
                dnitb.Text = (alumno.Dni).ToString;
                apellidotb.Text = alumno.darApellido;
                nombretb.Text = alumno.Nombre;
                fechanacimientotb.Text = alumno.FechaNacimiento;
               niveltb.Text = alumno.darNivel;
                cursotb.Text = alumno.darCurso;
            }
            else
                alumnoInexistentelb.Visible = true;
        }
    }
}
