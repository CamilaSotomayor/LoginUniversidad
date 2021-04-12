using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;

namespace CapaEntidad
{
    [DataContract]
    public class UsuarioE
    {
        [DataMember]
        public string _Usuario
        {
            get; set;
        }

        public string _Contraseña
        {
            get; set;
        }
    }
}
