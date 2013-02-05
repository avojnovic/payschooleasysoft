using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;
using ControlObjects;

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

                CmbAlumno.DataTextField = "Alumno";
                CmbAlumno.DataValueField = "Id";
                CmbAlumno.DataSource = InscripcionManager.Get();
                CmbAlumno.DataBind();

                if (id != null && id != "")
                {

                    var res = InscripcionManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var inscripcion = res.First();
                        setearInscripcion(inscripcion);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }

        }


        private void setearInscripcion(Inscripcion inscripcion)
        {
            //TxtFecIns.Text = inscripcion.FechaInscripción.Value.ToShortDateString();
            TxtFecIns.Text = inscripcion.FechaInscripción.Date.ToShortDateString();
            CmbAlumno.SelectedValue = inscripcion.Alumno.Id.ToString();
        }


        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Inscripcion a = new Inscripcion();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                a.Id = long.Parse(id);

                setObject(a);

                InscripcionManager.Update(a);
            }
            else
            {
                setObject(a);
                InscripcionManager.Insert(a);
            }

            volver();
        }

        private void setObject(Inscripcion a)
        {
            a.FechaInscripción = DateTime.Parse(TxtFecIns.Text);
            a.Alumno = AlumnoManager.Get(int.Parse(CmbAlumno.SelectedValue)).First();

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Inscripcion a = new Inscripcion();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                InscripcionManager.Delete(int.Parse(id));
            }

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}