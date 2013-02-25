using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
                try
                {
                    string filename = Path.GetFileName(FileUploadControl.FileName);
                    FileUploadControl.SaveAs(Server.MapPath("~/Files/") + filename);
                    LblMensaje.Text = "Importación de archivo correcta, procesando información.";

                    procesarArchivo(Server.MapPath("~/Files/") + filename);
                }
                catch (Exception ex)
                {
                    LblMensaje.Text = "Error el archivo no pudo ser importado. Ocurrio el siguiente error: " + ex.Message;
                }
            }
        }

        private void procesarArchivo(string p)
        {
            
            
        }


    }
}