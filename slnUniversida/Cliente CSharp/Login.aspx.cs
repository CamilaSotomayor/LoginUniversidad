using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ServiceReferenceUsuario.wsLoginSoapClient servicio = new ServiceReferenceUsuario.wsLoginSoapClient();
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string usuario = Login1.UserName;
            string password = Login1.Password;
            string[] valores = servicio.Login(usuario, password).ToArray();
            if (valores[0] == "0" && valores[1] == "Alumno")
            {
                FormsAuthentication.RedirectFromLoginPage(usuario, false);
            }
            else if (valores[0] == "0" && valores[1] == "Docente")
            {
                Login1.FailureText = "Usted es docente, no tiene acceso al sistema";
            }
            else
                Login1.FailureText = valores[1];
        }
    }
}