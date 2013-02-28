using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Incripciones
{
    public partial class DarDeBaja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var ins = InscripcionManager.Get();
            List<long> insBorrar = new List<long>();

            foreach (Inscripcion i in ins)
            {
                var pagos = PagoManager.GetByInscripcionFecha(i.Alumno.Id, i.FechaInscripción);

                if (pagos.Count() > 0 && pagos.First().FechaDePago!=null)
                {

                    TimeSpan? ts = pagos.First().FechaDePago - i.FechaInscripción;

                    if (ts.Value.Days > 30)
                    {
                        insBorrar.Add(i.Id);
                        
                    }
                    
                }

            }



            foreach (long id in insBorrar)
            {
                InscripcionManager.Delete(id);
            }

            LblMensaje.Text = string.Format("Se eliminaron {0} inscripciones con mas de 30 dias sin pagar la matricula",insBorrar.Count());

        }


    }
}