using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Escuela : System.Web.UI.Page
    {
        private SrEscuela10.WebService1SoapClient servicio;
        private void Listar()
        {
            servicio = new SrEscuela10.WebService1SoapClient();
            gvEscuela.DataSource = servicio.Listar();
            gvEscuela.DataBind();
        }

        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            servicio = new SrEscuela10.WebService1SoapClient();
            String texto = txtTexto.Text.Trim();
            String criterio = ddlCriterio.Text.Trim();
            gvEscuela.DataSource = servicio.Buscar(texto,criterio);
            gvEscuela.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            servicio = new SrEscuela10.WebService1SoapClient();
            String codEscuela = TextBox3.Text.Trim();
            String escuela = TextBox4.Text.Trim();
            String[] bandera = servicio.Agregar(codEscuela, escuela);
            if (Convert.ToBoolean(bandera[0]) == false)
            {
                Response.Write("<script>alert('Agregado Correctamente');</script>");
            }
            else if (Convert.ToBoolean(bandera[0]) == true)
            {
                Response.Write("<script>alert('No se pudo agregar :(');</script>");
            }
            Listar();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            servicio = new SrEscuela10.WebService1SoapClient();
            String codEscuela = TextBox3.Text.Trim();
            string[] respuesta = servicio.Eliminar(codEscuela);
            if (Convert.ToBoolean(respuesta[0]) == false)
            {
                Response.Write("<script>alert('CodError = 0');</script>");
                Response.Write(respuesta[1]);
               
            }
            else if(Convert.ToBoolean(respuesta[0]) == true)
            {
                Response.Write("<script>alert('CodError = 1');</script>");
                Response.Write(respuesta[1]);
            }
            Listar();


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            servicio = new SrEscuela10.WebService1SoapClient();
            String codEscuela = TextBox3.Text.Trim();
            String escuela = TextBox4.Text.Trim();
            String [] bandera = servicio.Actualizar(codEscuela, escuela);
            if (Convert.ToBoolean(bandera[0]) == false) {           
                Response.Write("<script>alert('Actualizado Correctamente');</script>");
            }
            else if (Convert.ToBoolean(bandera[0]) == true)
            {
                Response.Write("<script>alert('No se pudo Actualizar :(');</script>");
            }
            Listar();
        }

        protected void gvEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}