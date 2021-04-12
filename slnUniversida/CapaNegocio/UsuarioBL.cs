using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class UsuarioBL : Interfaces.IUsuario
    {
        private Datos datos = new DatosSQL();

        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool Login(UsuarioE usuario)
        {
            DataRow fila = datos.TraerDataRow("spLogin", usuario._Usuario, usuario._Contraseña);
            byte CodError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (CodError == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
