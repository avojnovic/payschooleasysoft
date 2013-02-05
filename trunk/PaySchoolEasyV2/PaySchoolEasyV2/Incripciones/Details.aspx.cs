using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlObjects.Incripciones
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar la Inscripción')== false) return false;");
            //Lee el parametro enviado a la página Details
            string id = Request.QueryString["id"];


            //Determina si es la primera vez que se ingresa a la página.
            //Para no recargar toda la página devuelta
            if (!IsPostBack)
            {

                CmbAlumno.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.Get();
                CmbNivel.DataBind();

                if (id != null && id != "")
                {

                    var res = AlumnoManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var alumno = res.First();
                        setearAlumno(alumno);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }

        }


        private void setearAlumno(Alumno alumno)
        {
            TxtApellido.Text = alumno.Apellido;
            TxtDNI.Text = alumno.Dni;
            TxtFecNac.Text = alumno.FechaNacimiento.Value.ToShortDateString();
            TxtMatricula.Text = alumno.NroMatricula.ToString();
            TxtNombre.Text = alumno.Nombre;
            CmbNivel.SelectedValue = alumno.Nivel.Id.ToString();
        }


        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Alumno a = new Alumno();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                a.Id = long.Parse(id);

                setObject(a);

                AlumnoManager.Update(a);
            }
            else
            {
                setObject(a);
                AlumnoManager.Insert(a);
            }

            volver();
        }

        private void setObject(Alumno a)
        {
            a.Nombre = TxtNombre.Text;
            a.Apellido = TxtApellido.Text;
            a.Dni = TxtDNI.Text;
            a.FechaNacimiento = DateTime.Parse(TxtFecNac.Text);
            a.NroMatricula = long.Parse(TxtMatricula.Text);
            a.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Alumno a = new Alumno();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                AlumnoManager.Delete(int.Parse(id));
            }

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}