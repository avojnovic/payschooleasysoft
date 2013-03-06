using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Niveles
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string id = Request.QueryString["id"];

            if (!IsPostBack)
            {
              
                if (id != null && id != "")
                {

                    var res = NivelManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var nivel = res.First();
                        setearNivel(nivel);
                    }

                }
               
            }
        }

        private void setearNivel(Nivel n)
        {
            TxtDescripcion.Text = n.Descripcion;
            TxtDescuento.Text = n.Descuento.ToString("0000.00");
           TxtEdadMaxima.Text = n.EdadMaxima.ToString();
           TxtEdadMinima.Text = n.EdadMinima.ToString();
           TxtRecargoPrimerVencimiento.Text = n.RecargoPrimerVencimiento.ToString("0000.00");
           TxtRecargoSegundoVencimiento.Text = n.RecargoSegundoVencimiento.ToString("0000.00");


        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Nivel n = new Nivel();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                n.Id = long.Parse(id);

                if (setObject(n))
                {

                    NivelManager.Update(n);
                    volver();

                }

            }
            

        }

        private bool setObject(Nivel n)
        {
            LblMensaje.Text = "";
            bool ret = true;

            n.Descripcion = TxtDescripcion.Text;

            if (TxtDescuento.Text.Trim().Replace(".", "").Replace("_", "") != "")
                n.Descuento = float.Parse(TxtDescuento.Text);
            else
            {
                LblMensaje.Text = "Descuento erroneo.";
                ret = false;
            }

            if (n.Descuento <= 0)
            {
                LblMensaje.Text = "Descuento erroneo.";
                ret = false;
            }


            if (TxtEdadMaxima.Text.Trim().Replace(".", "").Replace("_", "") != "")
                n.EdadMaxima = int.Parse(TxtEdadMaxima.Text);
            else
            {
                LblMensaje.Text = "Edad Maxima erronea.";
                ret = false;
            }

            if (n.EdadMaxima <= 0)
            {
                LblMensaje.Text = "Edad Maxima erronea.";
                ret = false;
            }

            if (TxtEdadMinima.Text.Trim().Replace(".", "").Replace("_", "") != "")
                n.EdadMinima = int.Parse(TxtEdadMinima.Text);
            else
            {
                LblMensaje.Text = "Edad Minima erronea.";
                ret = false;
            }

           

            if (TxtRecargoPrimerVencimiento.Text.Trim().Replace(".", "").Replace("_", "") != "")
                n.RecargoPrimerVencimiento = float.Parse(TxtRecargoPrimerVencimiento.Text);
            else
            {
                LblMensaje.Text = "Recargo Primer Vencimiento erroneo.";
                ret = false;
            }

            if (n.RecargoPrimerVencimiento <= 0)
            {
                LblMensaje.Text = "Recargo Primer Vencimiento erroneo.";
                ret = false;
            }

            if (TxtRecargoSegundoVencimiento.Text.Trim().Replace(".", "").Replace("_", "") != "")
                n.RecargoSegundoVencimiento = float.Parse(TxtRecargoSegundoVencimiento.Text);
            else
            {
                LblMensaje.Text = "Recargo Segundo Vencimiento erroneo.";
                ret = false;
            }

            if (n.RecargoSegundoVencimiento <= 0)
            {
                LblMensaje.Text = "Recargo Segundo Vencimiento erroneo.";
                ret = false;
            }

            return ret;

        }


      

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}