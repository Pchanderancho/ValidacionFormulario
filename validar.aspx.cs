using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroLoginAjax
{
    public partial class validar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rut = Request["rut"];
            string clave = Request["pass"];

            List<Usuario> lista = (List<Usuario>)Session["lista"];
            bool encontrado = false;
            foreach(Usuario u in lista) 
            {
                if (u.Rut == rut && u.Clave == clave)
                    encontrado = true;
            }

            if (encontrado)
                Response.Write("exito");
            else
                Response.Write("error");
        }
    }
}