using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Matriculas
{
    public partial class Details : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar la Matricula')== false) return false;");
            string id = Request.QueryString["id"];

            if (!IsPostBack)
            {
                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.Get();
                CmbNivel.DataBind();

                if (id != null && id != "")
                {

                    var res = MatriculaManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var matricula = res.First();
                        setearMatricula(matricula);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }
        }

        private void setearMatricula(Matricula m)
        {

            CmbNivel.SelectedValue = m.Nivel.Id.ToString();
            TxtAnio.Text = m.Año.ToString();
            TxtMonto.Text = m.Monto.ToString();
            TxtDescuento.Text = m.Descuento.ToString();

        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Matricula m = new Matricula();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                m.Id = long.Parse(id);

                setObject(m);

                if (MatriculaManager.Validar(m, true))
                {
                    MatriculaManager.Update(m);
                    volver();
                }
                else
                {
                    LblMensaje.Text = "La Matricula para el Año y Nivel ya existe";
                }
            }
            else
            {
                setObject(m);

                if (MatriculaManager.Validar(m, false))
                {
                    MatriculaManager.Insert(m);
                    volver();
                }
                else
                {
                    LblMensaje.Text = "La Matricula para el Año y Nivel ya existe";
                }
            }


        }

        private void setObject(Matricula m)
        {

            m.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();
            m.Año = long.Parse(TxtAnio.Text);
            m.Descuento = float.Parse(TxtDescuento.Text);
            m.Monto = float.Parse(TxtMonto.Text);
   
        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Matricula m = new Matricula();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                MatriculaManager.Delete(int.Parse(id));
            }

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}