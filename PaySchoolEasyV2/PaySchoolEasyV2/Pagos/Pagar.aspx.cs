using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;
using System.Drawing.Text;
using System.Net.Mail;
using System.Net;


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


                CmbPagoDe.Items.Insert(0, new ListItem("Matricula", "0"));
                CmbPagoDe.Items.Insert(1, new ListItem("Matricula y Cuota", "1"));
                CmbPagoDe.Items.Insert(2, new ListItem("Cuota", "2"));
                CmbPagoDe.SelectedIndex = 0;




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


                if (CmbPagoDe.SelectedValue == "0")
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

                    if (CmbPagoDe.SelectedValue == "1")
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


                

                CmbCuota.DataTextField = "Mes";
                CmbCuota.DataValueField = "Id";
                CmbCuota.DataSource = CuotaManager.GetByYear(DateTime.Today.Year);
                CmbCuota.DataBind();
                CmbCuota.SelectedIndex = DateTime.Today.Month - 1;
            }

        }


        private void obtenerNiveldeAlumno(Alumno a)
        {

            var inscripcionesList = InscripcionManager.GetByAlumno(a.Id);

            var iMax = inscripcionesList.OrderByDescending(item => item.FechaInscripción).First();
            
        }

        protected void CmbPagoDe_OnSelectedIndexChanged(object sender, EventArgs e)
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
            guardar();

        }


        private void guardar()
        {

            Factura f = new Factura();

            f.FechaEmisión = DateTime.Today;
            f.ImporteTotal = float.Parse(TxtTotal.Text);


            Pago a = new Pago();
            a.Confirmado = false;
            a.Alumno = AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First();
         
            a.Factura = f;

            if (CmbPagoDe.SelectedValue == "0")
            {//Matricula
                a.Cuota = null;
                a.Matricula = MatriculaManager.GetByYear(DateTime.Today.Year).First();
            }
            else
            {
               
                if (CmbPagoDe.SelectedValue == "1")
                {//Matricula y Cuota
                    a.Cuota = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();
                    a.Matricula = MatriculaManager.GetByYear(DateTime.Today.Year).First();
                }
                else
                {//Cuota
                    a.Cuota = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();
                    a.Matricula = null;
                }
            }

            PagoManager.Insert(a);
         
            volver();
        
        }

        protected void BtnEmail_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

            var fromAddress = new MailAddress("from@gmail.com", "From Name");
            var toAddress = new MailAddress("to@example.com", "To Name");
            const string fromPassword = "fromPassword";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
                guardar();
            }

        }


        private void volver()
        {
            Response.Redirect("../Default.aspx");
        }


    }
}