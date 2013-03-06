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
            TxtMonto.Text = cuota.MontoCuota.ToString("0000.00");
            TxtVenc1.Text = cuota.FechaVenc1.ToString("dd/MM/yyyy");
            TxtVenc2.Text = cuota.FechaVenc2.ToString("dd/MM/yyyy");

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

                if (setObject(c))
                {
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
               
            }
            else
            {
                if (setObject(c))
                {

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


        }

        private bool setObject(Cuota cuota)
        {
            LblMensaje.Text = "";
            bool ret = true;
            cuota.Nivel = NivelManager.Get(int.Parse(CmbNivel.SelectedValue)).First();
            cuota.Anio = long.Parse(TxtAnio.Text);
            cuota.Mes = long.Parse(TxtMes.Text);

            if (TxtMonto.Text.Trim().Replace(".", "").Replace("_","") != "")
                cuota.MontoCuota = float.Parse(TxtMonto.Text);
            else
            {
                LblMensaje.Text = "Monto erroneo.";
                ret = false;
            }

            if (cuota.MontoCuota <= 0)
            {
                LblMensaje.Text = "Monto erroneo.";
                ret = false;
            }

            if (cuota.Mes > 12)
            {
                LblMensaje.Text =LblMensaje.Text + " - El Mes debe ser menor o igual a 12.";
                ret = false;
            }

            cuota.FechaVenc1 = DateTime.ParseExact(TxtVenc1.Text, "dd/MM/yyyy", null);
            cuota.FechaVenc2 = DateTime.ParseExact(TxtVenc2.Text, "dd/MM/yyyy", null);

            if (cuota.FechaVenc2 <= cuota.FechaVenc1)
            {
                LblMensaje.Text = LblMensaje.Text + " - La fecha de vencimiento 2 debe ser posterior a la 1.";
            }

            return ret;

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            Cuota c = new Cuota();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {
                var pagos = PagoManager.GetByCuota(long.Parse(id));

                if (pagos.Count() == 0)
                {
                    CuotaManager.Delete(int.Parse(id));
                    volver();
                }
                else
                {
                    LblMensaje.Text = "No se puede eliminar la cuota, ya que posee pagos registrados";
                }
                
            }

        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}