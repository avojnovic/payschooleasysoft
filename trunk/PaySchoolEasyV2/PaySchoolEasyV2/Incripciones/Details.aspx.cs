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


                CmbAlumnos.DataTextField = "nombreCompleto";
                CmbAlumnos.DataValueField = "Id";
                CmbAlumnos.DataSource = AlumnoManager.GetByTutor(((User)Session["user"]).Id);
                CmbAlumnos.DataBind();
                CmbAlumnos.Items.Insert(0, new ListItem("Sin Seleccionar", "0"));
                CmbAlumnos.SelectedIndex = 0;

               

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
                    TxtApellido.Text = ((User)Session["user"]).Apellido;
                    TxtFecIns.Text = DateTime.Today.ToShortDateString();
                    
                }
            }

        }



        private void ObtenerNiveles()
        {

            if (TxtFecNac.Text != "")
            {
                DateTime nacimiento = DateTime.Parse(TxtFecNac.Text);
                double edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;


                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.GetByEdad(edad);
                CmbNivel.DataBind();

                ObtenerCursos();
            }
            else
            {
                CmbCurso.Items.Clear();
                CmbCurso.DataSource = null;
                CmbCurso.DataBind();
                CmbNivel.Items.Clear();
                CmbNivel.DataSource = null;
                CmbNivel.DataBind();
            }
        }


        private void ObtenerCursos()
        {
            if (CmbNivel.Items.Count > 0)
            {
                Nivel n = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();

                CmbCurso.DataTextField = "Anio";
                CmbCurso.DataValueField = "Id";
                CmbCurso.DataSource = CursoManager.GetByNivel(n.Id);
                CmbCurso.DataBind();
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
            TxtFecNac.Text = a.FechaNacimiento.ToShortDateString();
            TxtMatricula.Text = a.NroMatricula.ToString();
            TxtNombre.Text = a.Nombre;

            ObtenerNiveles();
        }



        protected void CmbAlumnos_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (int.Parse(CmbAlumnos.SelectedValue) == 0)
            {
                TxtIdAlumno.Text ="";
                TxtApellido.Text = "";
                TxtDNI.Text = "";
                TxtFecNac.Text = "";
                TxtMatricula.Text = "";
                TxtNombre.Text = "";

                ObtenerNiveles();

            }
            else
            {
                Alumno a = AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First();
                setearAlumno(a);
               
            }
        }

        protected void Btn_Niveles_Click(object sender, EventArgs e)
        {
            ObtenerNiveles();
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


        protected void CmbNivel_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerCursos();
        }
        
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

            Inscripcion i = new Inscripcion();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                i.Id = long.Parse(id);

                setObject(i);

                if (LblMensaje.Text == "")
                {
                    InscripcionManager.Update(i);
                    volver();
                }
            }
            else
            {
                setObject(i);

                if (LblMensaje.Text == "")
                {
                    InscripcionManager.Insert(i);
                    volver();
                }
            }

          
        }

        private void setObject(Inscripcion i)
        {

            i.FechaInscripción = DateTime.Parse(TxtFecIns.Text);


            i.Curso = CursoManager.Get(int.Parse(CmbCurso.SelectedValue)).First();


            if (CmbCurso.SelectedItem.Text.ToUpper().Contains("SIN CUPO"))
            {
                i.EnListaDeEspera = true;
            }
            else
            {
                i.EnListaDeEspera = false;
            }

            i.Inscripto = false;
            

            Alumno a = new Alumno();

            a.Nombre = TxtNombre.Text;
            a.Apellido = TxtApellido.Text;
            a.Dni = TxtDNI.Text;
            a.FechaNacimiento = DateTime.Parse(TxtFecNac.Text);
            a.NroMatricula = long.Parse(TxtMatricula.Text);
            a.Usuario = (User)Session["user"];


            if (TxtIdAlumno.Text != "")
            {
                a.Id = long.Parse(TxtIdAlumno.Text);
               


                if (AlumnoManager.Validar(a, true))
                {
                    var ins = InscripcionManager.GetByAlumnoAnio(a.Id, DateTime.Today.Year);

                    if (ins.Count() > 0)
                    {
                        LblMensaje.Text = "El Alumno ya posee una inscripcion para este año";
                    }
                    else
                    {
                        AlumnoManager.Update(a);
                    }
                }
                else
                {
                    LblMensaje.Text = "El DNI ya esta registrado";
                }

            }
            else
            {
                if (AlumnoManager.Validar(a, false))
                {
                    AlumnoManager.Insert(a);
               
                }
                else
                {
                    LblMensaje.Text = "El DNI ya esta registrado";
                }
            }

          


            i.Alumno = a;
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