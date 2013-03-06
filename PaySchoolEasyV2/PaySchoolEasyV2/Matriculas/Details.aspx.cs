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
            TxtAnio.Text = m.Anio.ToString();
            TxtMonto.Text = m.Monto.ToString("0000.00");
            TxtDescuento.Text = m.Descuento.ToString("0000.00");

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

                if (setObject(m))
                {

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
            }
            else
            {
                if (setObject(m))
                {

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


        }

        private bool setObject(Matricula m)
        {
            LblMensaje.Text = "";
            bool ret = true;

            m.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();
            m.Anio = long.Parse(TxtAnio.Text);
          


            if (TxtDescuento.Text.Trim().Replace(".", "").Replace("_", "") != "")
                m.Descuento = float.Parse(TxtDescuento.Text);
            else
            {
                LblMensaje.Text = "Descuento erroneo.";
                ret = false;
            }

            if (m.Descuento <= 0)
            {
                LblMensaje.Text = "Descuento erroneo.";
                ret = false;
            }


            if (TxtMonto.Text.Trim().Replace(".", "").Replace("_", "") != "")
                m.Monto = float.Parse(TxtMonto.Text);
            else
            {
                LblMensaje.Text = "Monto erroneo.";
                ret = false;
            }

            if (m.Monto <= 0)
            {
                LblMensaje.Text = "Monto erroneo.";
                ret = false;
            }


            return ret;
   
        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Matricula m = new Matricula();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {
                var pagos = PagoManager.GetByCuota(long.Parse(id));

                if (pagos.Count() == 0)
                {
                    MatriculaManager.Delete(int.Parse(id));
                    volver();
                }
                else
                {
                    LblMensaje.Text = "No se puede eliminar la matricula, ya que posee pagos registrados";
                }

              
            }

          
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}