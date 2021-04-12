using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Escuela : Interfaces.Interface1
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
        get{ return mensaje;}
        }
        public bool Actualizar(string codEscuela, string escuela)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", codEscuela, escuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar(string codEscuela, string escuela)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", codEscuela, escuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spListarEscuela", texto, criterio);
        }

        public bool Eliminar(string codEscuela)
        {
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", codEscuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEscuela");
        }
    }
}
