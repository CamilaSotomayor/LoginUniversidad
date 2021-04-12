using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(Description = "Listar escuelas")]
        public DataSet Listar()
        {
            Escuela escuela = new Escuela();
            return escuela.Listar();
        }
        [WebMethod(Description ="Buscar una Escuela")]
        public DataSet Buscar(string texto, string criterio)
        {
            Escuela escuela = new Escuela();
            return escuela.Buscar(texto, criterio);
        }
        [WebMethod(Description = "Añadir una Escuela")]
        public String[] Agregar(string codEscuela,string escuela)
        {
            Escuela escuela1 = new Escuela();
            return escuela1.Agregar(codEscuela, escuela);
        }
        [WebMethod(Description = "Eliminar una Escuela")]
        public String[] Eliminar(string codEscuela)
        {
            Escuela escuela = new Escuela();
            return escuela.Eliminar(codEscuela);
        }
        [WebMethod(Description = "Actualizar una Escuela")]
        public String[] Actualizar(string codEscuela, string escuela)
        {
            Escuela escuela1 = new Escuela();
            return escuela1.Actualizar(codEscuela,escuela);
        }
    }
}
