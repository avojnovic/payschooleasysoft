using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObjects;

namespace ControlObjects.Usuarios
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnBorrar.Attributes.Add("OnClick", "javascript:if(confirm('Esta seguro que desea borrar el Alumno')== false) return false;");
            string id = Request.QueryString["id"];
            LblMensaje.Text = "";


            if (!IsPostBack)
            {
                CmbTipo.DataTextField = "Descripcion";
                CmbTipo.DataValueField = "Id";
                CmbTipo.DataSource = UserTypeManager.Get();
                CmbTipo.DataBind();


                if (id != null && id != "")
                {

                    var res = UserManager.Get(int.Parse(id));
                    if (res.Count() > 0)
                    {
                        var usuario = res.First();
                        setearUsuario(usuario);
                    }

                }
                else
                {
                    BtnBorrar.Visible = false;
                }
            }



        }

        private void setearUsuario(User usuario)
        {
            TxtApellido.Text = usuario.Apellido;
            TxtDNI.Text = usuario.Dni;
            TxtContrasena.Text = usuario.Psw;
            TxtNombreUsuario.Text = usuario.Email;
            TxtTelefono.Text = usuario.Telefono;
            TxtDireccion.Text = usuario.Direccion;
            TxtNombre.Text = usuario.Nombre;

            CmbTipo.SelectedValue = usuario.TipoUsuario.Id.ToString();
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            volver();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            User u = new User();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                u.Id = long.Parse(id);

                setObject(u);

                if (NoExisteUsuario(u, true))
                {
                    UserManager.Update(u);
                       volver();
                }
                
                 
            }
            else
            {
                setObject(u);

                if (NoExisteUsuario(u, false))
                {
                    UserManager.Insert(u);
                    volver();
                }
   
                    

            }

           
        }


        private bool NoExisteUsuario(User u, bool update)
        {

            if (update)
            {
                var res = UserManager.CheckUserName(u.Id, u.Email);
                if (res.Count() > 0)
                {
                    LblMensaje.Text = "El Email ingresado corresponde a otro usuario";
                    return false;
                }
            }
            else
            {
                var res = UserManager.CheckUserName(u.Email);
                if (res.Count() > 0)
                {
                    LblMensaje.Text = "El Email ingresado corresponde a otro usuario";
                    return false;
                }
            }

            return true;
        }

        private void setObject(User u)
        {
            u.Nombre = TxtNombre.Text;
            u.Apellido = TxtApellido.Text;
            u.Dni = TxtDNI.Text;
            u.Psw = TxtContrasena.Text;
            u.Email = TxtNombreUsuario.Text;
            u.Telefono = TxtTelefono.Text;
            u.Direccion = TxtDireccion.Text;
            u.TipoUsuario =UserTypeManager.Get(int.Parse(CmbTipo.SelectedValue)).First();

        }


        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            User u = new User();
            string id = Request.QueryString["id"];
            if (id != null && id != "")
            {

                UserManager.Delete(int.Parse(id));
            }

            volver();
        }

        private void volver()
        {
            Response.Redirect("Index.aspx");
        }
    }
}