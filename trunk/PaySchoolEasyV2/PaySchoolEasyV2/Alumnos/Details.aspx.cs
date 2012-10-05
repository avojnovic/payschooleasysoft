using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace PaySchoolEasyV2.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        SchoolDbContext dbContext;

        protected void Page_Load(object sender, EventArgs e)
        {

            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar el Alumno')== false) return false;");
            string id = Request.QueryString["id"];
           
            dbContext = new SchoolDbContext();

            if (!IsPostBack)
            {
             

                var niveles = from n in dbContext.Nivel
                              select n;

                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = niveles.ToList();
                CmbNivel.DataBind();
            }



            if (id != null && id != "")
            {
                var alumno = from c in dbContext.Alumno.Include("Nivel")
                             where c.Id == long.Parse(id)
                             select c;



                //setearAlumno(alumno as Alumno);
            }
            else
            {
                BtnBorrar.Visible = false;
            }
        }


        private void setearAlumno(Alumno alumno)
        {
            TxtApellido.Text = alumno.Apellido;
            TxtDNI.Text = alumno.Dni;
            TxtFecNac.Text = alumno.FechaNacimiento.ToString();
            TxtMatricula.Text = alumno.NroMatricula.ToString();
            TxtNombre.Text = alumno.Nombre;
        }


        protected void BtnSalir_Click(object sender, EventArgs e)
        {

            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            volver();
        }

        
        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}