using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Cursos
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar el Curso')== false) return false;");
            string id = Request.QueryString["id"];

            if (!IsPostBack)
            {
                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.Get();
                CmbNivel.DataBind();

                if (id != null && id != "")
                {

                    var res = CursoManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var curso = res.First();
                        setearCurso(curso);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }
        }

        private void setearCurso(Curso c)
        {
            CmbNivel.SelectedValue = c.Nivel.Id.ToString();
            TxtAnio.Text = c.Anio.ToString();
            TxtCupo.Text = c.Cupo.ToString();
            
        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Curso c = new Curso();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                c.Id = long.Parse(id);

                if (setObject(c))
                {
                  
                        CursoManager.Update(c);
                        volver();
                  
                }

            }
            else
            {
                if (setObject(c))
                {

                    
                        CursoManager.Insert(c);
                        volver();
                   
                }
            }


        }

        private bool setObject(Curso c)
        {
            LblMensaje.Text = "";
            bool ret = true;
            c.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();
            c.Anio = TxtAnio.Text;
            
          
            if (TxtCupo.Text.Trim().Replace(".", "").Replace("_", "") != "")
                c.Cupo = long.Parse(TxtCupo.Text);
            else
            {
                LblMensaje.Text = "Cupo erroneo.";
                ret = false;
            }

            if (c.Cupo <= 0)
            {
                LblMensaje.Text = "Cupo erroneo.";
                ret = false;
            }

           
            return ret;

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Curso c = new Curso();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {
                var ins =InscripcionManager.GetByCurso(long.Parse(id));

                if (ins.Count() == 0)
                {
                    CursoManager.Delete(int.Parse(id));
                    volver();
                }
                else
                {
                    LblMensaje.Text = "No se puede eliminar el curso, ya posee inscripciones registradas";
                }

            }

        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}