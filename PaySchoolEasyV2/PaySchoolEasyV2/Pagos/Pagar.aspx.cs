﻿using System;
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

               if (CmbAlumnos.Items.Count > 0)
                {
                    TxtFechaEmision.Text = DateTime.Today.ToShortDateString();

                    if (CmbPagoDe.SelectedValue == "0")
                    {//Matricula
                        lblCuota.Visible = false;
                        CmbCuota.Visible = false;

                        Nivel n= obtenerNiveldeAlumno(long.Parse( CmbAlumnos.SelectedValue));
                        Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year,n.Id).First();

                        TxtSubTotal.Text = m.Monto.ToString();
                        TxtDescuento.Text = m.Descuento.ToString();
                        TxtTotal.Text = (m.Monto - m.Descuento).ToString();

                    }
                    else
                    {
                        lblCuota.Visible = true;
                        CmbCuota.Visible = true;

                        if (CmbPagoDe.SelectedValue == "1")
                        {//Matricula y Cuota
                           
                            Nivel n = obtenerNiveldeAlumno(long.Parse(CmbAlumnos.SelectedValue));
                            Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();

                            Cuota a = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                            TxtVencimiento1.Text = a.FechaVenc1.ToShortDateString();
                            TxtVencimiento2.Text = a.FechaVenc2.ToShortDateString();

                            TxtSubTotal.Text = (a.MontoCuota + m.Monto).ToString();
                            TxtDescuento.Text = m.Descuento.ToString();

                            TxtTotal.Text = (a.MontoCuota + m.Monto - m.Descuento).ToString();

                        }
                        else
                        {//Cuota


                            Cuota a = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                            TxtVencimiento1.Text = a.FechaVenc1.ToShortDateString();
                            TxtVencimiento2.Text = a.FechaVenc2.ToShortDateString();
                            TxtDescuento.Text = "";

                            TxtSubTotal.Text = a.MontoCuota.ToString();
                            TxtTotal.Text = a.MontoCuota.ToString();

                            
                        }
                    }

                }

               
            
        }


        private void generarCodigo(string codigo)
        {

            ImgBarCode.ImageUrl = "http://barcode.tec-it.com/barcode.ashx?code=Code128&modulewidth=fit&data=" + codigo + "&dpi=96&imagetype=gif&rotation=0&color=&bgcolor=&fontcolor=&quiet=0&qunit=mm";
            ImgBarCode.Visible = true;

            CmbAlumnos.Enabled = false;
            CmbCuota.Enabled = false;
            CmbPagoDe.Enabled = false;

        }


        protected void CmbAlumnos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
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

                setearCuota(a);
               
            }

        }


        private void setearCuota(Alumno a)
        {
            LblMensaje.Text = "";
          
            Nivel n=obtenerNiveldeAlumno(a.Id);
            if(n!=null)
            {
          
                CmbCuota.DataTextField = "Mes";
                CmbCuota.DataValueField = "Id";
                CmbCuota.DataSource = CuotaManager.GetByYearNivel(DateTime.Today.Year, n.Id);
                CmbCuota.DataBind();

                if (CmbCuota.Items.Count > 0)
                {
                    BtnEmail.Visible = true;
                    BtnPrint.Visible = true;
                }
                else
                {
                    LblMensaje.Text = "No existen cuotas disponibles para pagar.";
                }
            }
            else
            {
                LblMensaje.Text = "El alumno seleccionado no esta inscripto en ningun curso.";
                BtnEmail.Visible = false;
                BtnPrint.Visible = false;
            }
        }


        private Nivel obtenerNiveldeAlumno(long idAlumno)
        {
            var inscripcionesList = InscripcionManager.GetByAlumno(idAlumno);
            if (inscripcionesList.Count() > 0)
            {
                var iMax = inscripcionesList.OrderByDescending(item => item.FechaInscripción).First();
                Curso c = CursoManager.Get(iMax.Curso.Id).First();
                return c.Nivel;
            }
            else
            {
                return null;
            }
        }

        protected void CmbPagoDe_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            setearMontos();
        }

        protected void CmbCuota_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            setearMontos();
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        private void guardar()
        {

            Pago a = new Pago();
            a.Confirmado = false;
            a.Alumno = AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First();

          

            if (CmbPagoDe.SelectedValue == "0")
            {//Matricula
                a.Cuota = null;

                Nivel n = obtenerNiveldeAlumno(long.Parse(CmbAlumnos.SelectedValue));
                Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();
                a.Matricula = m;
            }
            else
            {

                if (CmbPagoDe.SelectedValue == "1")
                {//Matricula y Cuota
                    a.Cuota = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                    Nivel n = obtenerNiveldeAlumno(long.Parse(CmbAlumnos.SelectedValue));
                    Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();
                    a.Matricula = m;
                }
                else
                {//Cuota
                    a.Cuota = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();
                    a.Matricula = null;
                }
            }


            if (validar(a))
            {
                Factura f = new Factura();
                f.FechaEmisión = DateTime.Today;
                f.ImporteTotal = float.Parse(TxtTotal.Text);
                a.Factura = f;
                PagoManager.Insert(a);


                string codigo = f.Id.ToString() + "-" + a.Id.ToString();
                generarCodigo(codigo);
            }

        }


        private bool validar(Pago a)
        {
            bool guardar = true;
            if (CmbPagoDe.SelectedValue == "0")
            {
                var pago = PagoManager.GetByMatricula(a.Matricula.Id, a.Alumno.Id);
                if (pago.Count() > 0)
                {
                    guardar = false;
                    LblMensaje.Text = "La Matricula seleccionada ya se encuentra paga";
                }
            }
            else
            {
                if (CmbPagoDe.SelectedValue == "1")
                {
                    var pago = PagoManager.GetByMatricula(a.Matricula.Id, a.Alumno.Id);
                    if (pago.Count() > 0)
                    {
                        guardar = false;
                        LblMensaje.Text = "La Matricula seleccionada ya se encuentra paga";
                    }
                    else
                    {
                        var pago2 = PagoManager.GetByCuota(a.Cuota.Id, a.Alumno.Id);
                        if (pago2.Count() > 0)
                        {
                            guardar = false;
                            LblMensaje.Text = "La Cuota seleccionada ya se encuentra paga";
                        }
                    }
                }
                else
                {
                    var pago2 = PagoManager.GetByCuota(a.Cuota.Id, a.Alumno.Id);
                    if (pago2.Count() > 0)
                    {
                        guardar = false;
                        LblMensaje.Text = "La Cuota seleccionada ya se encuentra paga";
                    }

                }
            }
            return guardar;
        }

        protected void BtnPrint_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

            if (ImgBarCode.Visible == false)
            {
                guardar();
            }

            if (LblMensaje.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "PrintPage", "<script language='javascript'>window.print()</script>");
            }
        }

        protected void BtnEmail_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "";

            if (ImgBarCode.Visible == false)
            {
                guardar();
            }

          

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
             
            }

        }


        private void volver()
        {
            Response.Redirect("../Default.aspx");
        }


    }
}