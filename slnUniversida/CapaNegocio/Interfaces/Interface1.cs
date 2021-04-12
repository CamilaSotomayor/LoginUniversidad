using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio.Interfaces
{
    interface Interface1
    {
        DataSet Listar();
        String[] Agregar(string codEscuela, string escuela);
        String[] Eliminar(string codEscuela);
        String[] Actualizar(string codEscuela, string escuela);
        DataSet Buscar(string texto, string criterio);
    }
}
