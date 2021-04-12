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
        private Boolean codErrorGeneral;
        public string Mensaje
        
        {
        get{ return mensaje;}
        }
        public Boolean CodErrorGeneral

        {
            get { return codErrorGeneral; }
        }
        public String[] Actualizar(string codEscuela, string escuela)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", codEscuela, escuela);
            Boolean codError = Convert.ToBoolean(fila["CodError"]);
            codErrorGeneral = codError;
            mensaje = fila["Mensaje"].ToString();
            string[] respuesta = new string[2];
            respuesta[0] = codErrorGeneral.ToString();
            respuesta[1] = mensaje;
            return respuesta;
        }

        public String[] Agregar(string codEscuela, string escuela)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", codEscuela, escuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            codErrorGeneral = Convert.ToBoolean(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] respuesta = new string[2];
            respuesta[0] = codErrorGeneral.ToString();
            respuesta[1] = mensaje;
            return respuesta;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEscuela", texto, criterio);
        }

        public String[] Eliminar(string codEscuela)
        {
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", codEscuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            codErrorGeneral = Convert.ToBoolean(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] respuesta = new string[2];
            respuesta[0] = codErrorGeneral.ToString();
            respuesta[1] = mensaje;
            return respuesta;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEscuela");
        }
        
    }
}
