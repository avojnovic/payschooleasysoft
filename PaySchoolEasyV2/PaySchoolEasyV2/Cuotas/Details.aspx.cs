using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Cuotas
{
    public partial class Details : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar la Cuota')== false) return false;");
            string id = Request.QueryString["id"];

            if (!IsPostBack)
            {
                CmbNivel.DataTextField = "Descripcion";
                CmbNivel.DataValueField = "Id";
                CmbNivel.DataSource = NivelManager.Get();
                CmbNivel.DataBind();

                if (id != null && id != "")
                {

                    var res = CuotaManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var cuota = res.First();
                        setearCuota(cuota);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }
        }

        private void setearCuota(Cuota cuota)
        {
            CmbNivel.SelectedValue = cuota.Nivel.Id.ToString();
            TxtAnio.Text = cuota.Anio.ToString();
            TxtMes.Text = cuota.Mes.ToString();
            TxtMonto.Text = cuota.MontoCuota.ToString();
            TxtVenc1.Text = cuota.FechaVenc1.ToShortDateString();
            TxtVenc2.Text = cuota.FechaVenc2.ToShortDateString();

        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Cuota c = new Cuota();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                c.Id = long.Parse(id);

                setObject(c);
                if (CuotaManager.Validar(c, true))
                {
                    CuotaManager.Update(c);
                    volver();
                }
                else
                {
                    LblMensaje.Text = "La Cuota para el Año, Mes y Nivel ya existe";
                }

               
            }
            else
            {
                setObject(c);

                if (CuotaManager.Validar(c, false))
                {
                    CuotaManager.Insert(c);
                    volver();
                }
                else
                {
                    LblMensaje.Text = "La Cuota para el Año, Mes y Nivel ya existe";
                }
            }


        }

        private void setObject(Cuota cuota)
        {

            cuota.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();
            cuota.Anio = long.Parse(TxtAnio.Text);
            cuota.Mes = long.Parse(TxtMes.Text);
            cuota.MontoCuota = float.Parse(TxtMonto.Text);
            cuota.FechaVenc1 = DateTime.Parse(TxtVenc1.Text);
            cuota.FechaVenc2 = DateTime.Parse(TxtVenc2.Text);

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Cuota c = new Cuota();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                CuotaManager.Delete(int.Parse(id));
            }

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}