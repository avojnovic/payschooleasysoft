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


                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.Get();
                CmbNivel.DataBind();

                if (id != null && id != "")
                {

                    var res = InscripcionManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var inscripcion = res.First();

                        inscripcion.Alumno = AlumnoManager.Get((int)inscripcion.Alumno.Id).First();
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
           
            TxtFecIns.Text = inscripcion.FechaInscripción.Date.ToShortDateString();
            setearAlumno(inscripcion.Alumno);


        }

        private void setearAlumno(Alumno a)
        {
            TxtIdAlumno.Text = a.Id.ToString();
            TxtApellido.Text = a.Apellido;
            TxtDNI.Text = a.Dni;
            TxtFecNac.Text = a.FechaNacimiento.Value.ToShortDateString();
            TxtMatricula.Text = a.NroMatricula.ToString();
            TxtNombre.Text = a.Nombre;



            CmbNivel.SelectedValue = a.Nivel.Id.ToString();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text != "")
            {

                var alu = from a in AlumnoManager.Get()
                          where a.Dni.ToString().Contains(TxtSearch.Text) ||
                           a.nombreCompleto.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                           a.NroMatricula.ToString().ToLower().Contains(TxtSearch.Text.ToLower())
                          select a;

                if (alu.Count() > 0)
                {
                    setearAlumno(alu.First());
                }
                else
                {
                    TxtIdAlumno.Text = "";
                    TxtApellido.Text = "";
                    TxtDNI.Text = "";
                    TxtFecNac.Text = "";
                    TxtMatricula.Text ="";
                    TxtNombre.Text = "";
                }

            }
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

        private void setObject(Inscripcion i)
        {

            i.FechaInscripción = DateTime.Parse(TxtFecIns.Text);
            i.Inscripto = true;

            Alumno alumno = new Alumno();

            alumno.Nombre = TxtNombre.Text;
            alumno.Apellido = TxtApellido.Text;
            alumno.Dni = TxtDNI.Text;
            alumno.FechaNacimiento = DateTime.Parse(TxtFecNac.Text);
            alumno.NroMatricula = long.Parse(TxtMatricula.Text);
            alumno.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();

            if (TxtIdAlumno.Text != "")
            {
                alumno.Id = long.Parse(TxtIdAlumno.Text);
                AlumnoManager.Update(alumno);
            }
            else
            {
                AlumnoManager.Insert(alumno);
            }

          


            i.Alumno = alumno;
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