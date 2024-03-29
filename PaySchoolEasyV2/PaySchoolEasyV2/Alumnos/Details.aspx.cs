﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;
using ControlObjects;

namespace PaySchoolEasyV2.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar el Alumno')== false) return false;");
            string id = Request.QueryString["id"];



            if (!IsPostBack)
            {
                CmbTutor.DataTextField = "nombreCompleto";
                CmbTutor.DataValueField = "Id";
                CmbTutor.DataSource = UserManager.GetTutor();
                CmbTutor.DataBind();

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
            TxtMatricula.Text = alumno.Id.ToString();
            TxtApellido.Text = alumno.Apellido;
            TxtDNI.Text = alumno.Dni;
            TxtFecNac.Text = alumno.FechaNacimiento.ToString("dd/MM/yyyy");
            TxtNombre.Text = alumno.Nombre;
            CmbTutor.SelectedValue = alumno.Usuario.Id.ToString();

        }


        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

            Alumno a = new Alumno();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                a.Id = long.Parse(id);

                setObject(a);
                if (AlumnoManager.Validar(a, true))
                {
                    AlumnoManager.Update(a);

                    volver();
                }
                else
                {
                    LblMensaje.Text = "El DNI ya esta registrado";
                }
            }
            else
            {
                setObject(a);
                if (AlumnoManager.Validar(a, false))
                {
                    AlumnoManager.Insert(a);

                    TxtMatricula.Text = a.Id.ToString();

                    BtnGuardar.Visible = false;
                    BtnBorrar.Visible = false;
                }
                else
                {
                    LblMensaje.Text = "El DNI ya esta registrado";
                }
            }

          
        }

        private void setObject(Alumno a)
        {
            a.Nombre = TxtNombre.Text;
            a.Apellido = TxtApellido.Text;
            a.Dni = TxtDNI.Text;
            a.FechaNacimiento = DateTime.ParseExact(TxtFecNac.Text, "dd/MM/yyyy", null);
            a.Usuario = UserManager.Get(long.Parse(CmbTutor.SelectedValue)).First();

            
        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Alumno a = new Alumno();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                var ins = InscripcionManager.GetByAlumno(long.Parse(id));
                var pag = PagoManager.GetByAlumno(long.Parse(id));

                if (ins.Count() == 0 )
                {
                    if (pag.Count() == 0)
                    {
                        AlumnoManager.Delete(int.Parse(id));
                        volver();
                    }
                    else
                    {
                        LblMensaje.Text = "No se puede eliminar al alumno, ya que posee Pagos registrados";
                    }
                }
                else
                {
                    LblMensaje.Text = "No se puede eliminar al alumno, ya que posee inscripciones registradas";
                }

               
            }


        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}