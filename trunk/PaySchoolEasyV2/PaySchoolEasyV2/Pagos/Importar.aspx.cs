using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using BussinesObjects;

namespace ControlObjects.Pagos
{
    public partial class Importar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                if (FileUploadControl.FileName.Contains(".txt"))
                {
                    try
                    {
                        string filename = Path.GetFileName(FileUploadControl.FileName);
                        FileUploadControl.SaveAs(Server.MapPath("~/Files/") + filename);
                        LblMensaje.Text = "Importación de archivo correcta, procesando información.";

                        procesarArchivo(Server.MapPath("~/Files/") + filename);

                        LblMensaje.Text = "Proceso finalizado con éxito.";
                    }
                    catch (Exception ex)
                    {
                        LblMensaje.Text = "Error el archivo no pudo ser importado. Ocurrio el siguiente error: " + ex.Message;
                    }
                }
                else
                {
                    LblMensaje.Text = "Tipo de archivo invalido, solo se adminten archivos .TXT";
                }
            }
        }

        private void procesarArchivo(string path)
        {

            int nro = 0;
            foreach (string line in File.ReadLines(path))
            {
                nro++;
                long idFactura=0;
                long idpago=0;
                float monto=0;
                DateTime? fecha=null;
                try
                {
                    string[] items = line.Split('-');

                    foreach (String i in items)
                    {

                        if (i.ToLower().Contains("idfactura:"))
                        {
                            string tmp = i.ToLower().Replace("idfactura:", "");
                            idFactura = long.Parse(tmp);
                        }
                        if (i.ToLower().Contains("idpago:"))
                        {
                            string tmp = i.ToLower().Replace("idpago:", "");
                            idpago = long.Parse(tmp);
                        }
                        if (i.ToLower().Contains("monto:"))
                        {
                            string tmp = i.ToLower().Replace("monto:", "");
                            monto = float.Parse(tmp);
                        }
                        if (i.ToLower().Contains("fecha:"))
                        {
                            string tmp = i.ToLower().Replace("fecha:", "");
                            fecha = DateTime.ParseExact(tmp, "dd/MM/yyyy", null);
                        }

                    }
                

                    var pagos = PagoManager.Get(idpago);

                    if (pagos.Count() > 0)
                    {
                        Pago p = pagos.First();

                        if (p.Factura.Id == idFactura)
                        {
                            p.FechaDePago = fecha;
                            p.Confirmado = true;

                            PagoManager.Update(p);
                        }
                        else
                        {
                            LblMensaje.Text = "Numero de Factura erroneo en la linea nro: " + nro.ToString() + " del archivo ";
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LblMensaje.Text = "Error el archivo no pudo ser procesado. Ocurrio el siguiente error: " + ex.Message + " en la linea nro: " + nro.ToString() + " del archivo ";
                }


            }

          

        }


    }
}