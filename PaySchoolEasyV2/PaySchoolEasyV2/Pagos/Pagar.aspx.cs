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
using System.Text;


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

             
                //Solo cargos los alumnos inscriptos en este año
                CmbAlumnos.DataTextField = "DNI";
                CmbAlumnos.DataValueField = "Id";
                CmbAlumnos.DataSource = obtenerAlumnosInscriptos() ;
                CmbAlumnos.DataBind();

                setearAlumno();


                CmbPagoDe.Items.Insert(0, new ListItem("Matricula", "0"));
                CmbPagoDe.Items.Insert(1, new ListItem("Matricula y Cuota", "1"));
                CmbPagoDe.Items.Insert(2, new ListItem("Cuota", "2"));
                CmbPagoDe.SelectedIndex = 0;

                setearMontos();

            }



        }

        private List<Alumno> obtenerAlumnosInscriptos()
        {
            var _alumnos = AlumnoManager.GetByTutor(((User)Session["user"]).Id);
            List<Alumno> listAl = new List<Alumno>();

            foreach (Alumno a in _alumnos)
            {
                var inscripcionesList = InscripcionManager.GetByAlumnoAnio(a.Id,DateTime.Today.Year);
                if (inscripcionesList.Count() > 0)
                {
                    listAl.Add(a);
                }

            }

            return listAl;

        }

        private void setearMontos()
        {

            if (CmbAlumnos.Items.Count > 0)
            {
                var alum = AlumnoManager.GetByTutor(((User)Session["user"]).Id);
                Nivel n = obtenerNiveldeAlumno(AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First());
                float descuento = 0;
                bool descuentoMatricula = false;

                if (alum.Count() > 1)
                {
                    int cant = 0;
                    foreach (Alumno a in alum)
                    {
                        Nivel niv = obtenerNiveldeAlumnoInscripto(a.Id);

                        if (niv != null && niv.Id==n.Id)
                        {
                            cant++;
                        }
                    }


                    if (cant >= 2)
                    {
                        descuentoMatricula = true;
                    }
                     
                    descuento = n.Descuento;


                }

                TxtFechaEmision.Text = DateTime.Today.ToShortDateString();

                if (CmbPagoDe.SelectedValue == "0")
                {//Matricula
                    lblCuota.Visible = false;
                    CmbCuota.Visible = false;


                    Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();

                    if (descuentoMatricula)
                        descuento += m.Descuento;
                    TxtDescuento.Text = descuento.ToString();
                    TxtSubTotal.Text = m.Monto.ToString();
                    TxtTotal.Text = (descuento / 100 * m.Monto).ToString();

                }
                else
                {
                    lblCuota.Visible = true;
                    CmbCuota.Visible = true;
                    Cuota a = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                    TxtVencimiento1.Text = a.FechaVenc1.ToShortDateString();
                    TxtVencimiento2.Text = a.FechaVenc2.ToShortDateString();

                    if (CmbPagoDe.SelectedValue == "1")
                    {//Matricula y Cuota


                        Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();
                        if (descuentoMatricula)
                            descuento += m.Descuento;


                        TxtSubTotal.Text = (a.MontoCuota + m.Monto).ToString();
                        TxtDescuento.Text = descuento.ToString();
                        TxtTotal.Text = (descuento / 100 * (m.Monto + a.MontoCuota)).ToString();
                    }
                    else
                    {//Cuota

                        TxtSubTotal.Text = a.MontoCuota.ToString();
                        TxtDescuento.Text = descuento.ToString();
                        TxtTotal.Text = (descuento / 100 * a.MontoCuota).ToString();


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
                setearMontos();
            }

        }


        private void setearCuota(Alumno a)
        {
            LblMensaje.Text = "";

            Nivel n = obtenerNiveldeAlumno(a);
            if (n != null)
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


        private Nivel obtenerNiveldeAlumno(Alumno a)
        {
            var inscripcionesList = InscripcionManager.GetByAlumno(a.Id);
            if (inscripcionesList.Count() > 0)
            {
                var iMax = inscripcionesList.OrderByDescending(item => item.FechaInscripción).First();
                Curso c = CursoManager.Get(iMax.Curso.Id).First();
                return c.Nivel;
            }
            else
            {
                double edad = DateTime.Today.AddTicks(-a.FechaNacimiento.Ticks).Year - 1;
                return NivelManager.GetByEdad(edad).First();
            }
        }

        private Nivel obtenerNiveldeAlumnoInscripto(long id)
        {
            var inscripcionesList = InscripcionManager.GetByAlumno(id);
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
            if (CmbAlumnos.SelectedValue != "")
            {

                Pago a = new Pago();
                a.Confirmado = false;
                a.Alumno = AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First();



                if (CmbPagoDe.SelectedValue == "0")
                {//Matricula
                    a.Cuota = null;

                    Nivel n = obtenerNiveldeAlumno(AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First());
                    Matricula m = MatriculaManager.GetByYearNivel(DateTime.Today.Year, n.Id).First();
                    a.Matricula = m;
                }
                else
                {

                    if (CmbPagoDe.SelectedValue == "1")
                    {//Matricula y Cuota
                        a.Cuota = CuotaManager.Get(int.Parse(CmbCuota.SelectedValue)).First();

                        Nivel n = obtenerNiveldeAlumno(AlumnoManager.Get(int.Parse(CmbAlumnos.SelectedValue)).First());
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
            else
            {
                LblMensaje.Text = "No existen alumnos inscriptos, no se puede realizar la operación";
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

            if (LblMensaje.Text == "")
            {

                User u = ((User)Session["user"]);



                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new System.Net.NetworkCredential("payschooleasysoft@gmail.com", "psespses");
                //smtpClient.UseDefaultCredentials = true;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();


                //Setting From , To and CC
                mail.From = new MailAddress("payschooleasysoft@gmail.com", "Pay School Easy Soft");
                mail.To.Add(new MailAddress(u.Email));

              
                StringBuilder st = new StringBuilder();
                st.AppendLine("<html> <body>");
                st.AppendLine("");
                st.AppendLine("<img src='"+ImgBarCode.ImageUrl +"'>");
                st.AppendLine("</body> </html>");


                mail.IsBodyHtml = true;
                mail.Body = Server.HtmlEncode(st.ToString());
                mail.Subject = "Pago a traves de Pay School Easy Soft";

                smtpClient.Send(mail);

            }
        }


        private void volver()
        {
            Response.Redirect("../Default.aspx");
        }


    }
}