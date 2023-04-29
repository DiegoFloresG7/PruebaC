using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Managerr.DTO
{
    [DataContract]
    public class DTOGenerico
    {
        /// <summary>
        /// Identificador del catalogo
        /// </summary>
        [DataMember]
        public string ID { get; set; }

        /// <summary>
        /// Descripcion del elemento del catalogo
        /// </summary>
        [DataMember]
        public string Descripcion { get; set; }

    }
}
