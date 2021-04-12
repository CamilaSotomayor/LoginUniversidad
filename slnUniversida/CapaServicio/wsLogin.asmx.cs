using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocio;
using CapaEntidad;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsLogin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsLogin : System.Web.Services.WebService
    {

        [WebMethod(Description = "Login del Usuario")]
        public string[] Login (String _Usuario, string _Contraseña)
        {
            UsuarioE usuario = new UsuarioE();
            UsuarioBL usuarioBL = new UsuarioBL();
            usuario._Usuario = _Usuario;
            usuario._Contraseña = _Contraseña;
            bool CodError = usuarioBL.Login(usuario);
            string[] valores = new string[2];
            if (CodError == true) valores[0] = "0";
            else valores[0] = "1";
            valores[1] = usuarioBL.Mensaje;
            return valores;
        }
    }
}
