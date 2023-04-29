using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Managerr.DTO
{
    [DataContract]
    public class DTOEmpleado
    {
        /// <summary>
        /// Clave del usuario
        /// </summary>
         [DataMember]
        public int IdEmpleado{ get; set; }

        /// <summary>
        /// Clave del usuario
        /// </summary>
        [DataMember]
        public string Nombre { get; set; }

        /// <summary>
        /// Clave del usuario
        /// </summary>
         [DataMember]
        public int IdRol { get; set; }


        /// <summary>
        /// Clave del usuario
        /// </summary>
        [DataMember]
        public string DescripcionRol { get; set; }
    }
}
