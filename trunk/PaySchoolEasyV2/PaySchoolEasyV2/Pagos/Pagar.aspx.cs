using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;
using System.Drawing.Text;

namespace ControlObjects.Pagos
{
    public partial class Pagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ImgBarCode.Visible = false;

                TxtApellido.Text = ((User)Session["user"]).Apellido;

                CmbAlumnos.DataTextField = "DNI";
                CmbAlumnos.DataValueField = "Id";
                CmbAlumnos.DataSource = AlumnoManager.GetByTutor(((User)Session["user"]).Id);
                CmbAlumnos.DataBind();
               
                setearAlumno();


                CmbFactura.Items.Insert(0, new ListItem("Matricula", "0"));
                CmbFactura.Items.Insert(1, new ListItem("Matricula y Cuota", "1"));
                CmbFactura.Items.Insert(2, new ListItem("Cuota", "2"));
                CmbFactura.SelectedIndex = 0;



                CmbCuota.DataTextField = "Mes";
                CmbCuota.DataValueField = "Id";
                CmbCuota.DataSource = CuotaManager.GetByYear(DateTime.Today.Year);
                CmbCuota.DataBind();
                CmbCuota.SelectedIndex = DateTime.Today.Month - 1;

                setearMontos();

            }



        }

        private void setearMontos()
        {

            string codigo="";
            
            if (CmbAlumnos.Items.Count > 0)
            {
                ImgBarCode.Visible = true;

                TxtFechaEmision.Text = DateTime.Today.ToShortDateString();


                if (CmbFactura.SelectedValue == "0")
                {//Matricula
                    lblCuota.Visible = false;
                    CmbCuota.Visible = false;

                    Matricula m = MatriculaManager.GetByYear(DateTime.Today.Year).First();

                    TxtSubTotal.Text = m.Monto.ToString();
                    TxtDescuento.Text = m.Descuento.ToString();
                    TxtTotal.Text = (m.Monto - m.Descuento).ToString();

                    codigo = "0" + "-" + DateTime.Today.Year.ToString()+ "-" + "00" + "-" + TxtMatricula.Text + "-" + TxtTotal.Text;
                }
                else
                {
                    lblCuota.Visible = true;
                    CmbCuota.Visible = true;

                    if (CmbFactura.SelectedValue == "1")
                    {//Matricula y Cuota
                        Matricula m = MatriculaManager.GetByYear(DateTime.Today.Year).First();
                        Cuota a = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                        TxtVencimiento1.Text = a.FechaVenc1.ToShortDateString();
                        TxtVencimiento2.Text = a.FechaVenc2.ToShortDateString();

                        TxtSubTotal.Text = (a.MontoCuota + m.Monto).ToString();
                        TxtDescuento.Text = m.Descuento.ToString();

                        TxtTotal.Text = (a.MontoCuota + m.Monto - m.Descuento).ToString();

                        codigo = "1" + "-" + DateTime.Today.Year.ToString() + "-" + a.Mes.ToString("00") + "-" + TxtMatricula.Text + "-" + TxtTotal.Text;
                    }
                    else
                    {//Cuota


                        Cuota a = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();


                        TxtVencimiento1.Text = a.FechaVenc1.ToShortDateString();
                        TxtVencimiento2.Text = a.FechaVenc2.ToShortDateString();
                        TxtDescuento.Text = "";

                        TxtSubTotal.Text = a.MontoCuota.ToString();
                        TxtTotal.Text = a.MontoCuota.ToString();

                        codigo = "2" + "-" + DateTime.Today.Year.ToString() + "-" + a.Mes.ToString("00") + "-" + TxtMatricula.Text + "-" + TxtTotal.Text;
                    }
                }

            }

            ImgBarCode.ImageUrl = "http://barcode.tec-it.com/barcode.ashx?code=Code128&modulewidth=fit&data=" + codigo + "&dpi=96&imagetype=gif&rotation=0&color=&bgcolor=&fontcolor=&quiet=0&qunit=mm";
        }




        protected void CmbAlumnos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            setearAlumno();

        }

        private void setearAlumno()
        {


            if (CmbAlumnos.Items.Count > 0)
            {
                Alumno a = AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First();


                TxtApellido.Text = a.Apellido;
                TxtMatricula.Text = a.NroMatricula.ToString();
                TxtNombre.Text = a.Nombre;

            }

        }
        protected void CmbFactura_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setearMontos();
        }

        protected void CmbCuota_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setearMontos();
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }


        protected void BtnPrint_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";


        }

        protected void BtnEmail_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

        }


        private void volver()
        {
            Response.Redirect("../Default.aspx");
        }


    }
}