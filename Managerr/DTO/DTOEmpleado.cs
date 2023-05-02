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

        /// <summary>
        /// Numero entregas
        /// </summary>
        [DataMember]
        public int IdEntregas{ get; set; }

        /// <summary>
        /// Numero del mes
        /// </summary>
        [DataMember]
        public int IdMes { get; set; }


        /// <summary>
        /// Salario total
        /// </summary>
        [DataMember]
        public double fTotalSalario { get; set; }



        /// <summary>
        /// Salario 
        /// </summary>
        [DataMember]
        public double fSalario { get; set; }

    

        /// <summary>
        /// Bono total
        /// </summary>
        [DataMember]
        public double fTotalBono { get; set; }

        /// <summary>
        /// Bono
        /// </summary>
        [DataMember]
        public double fBono { get; set; }

        /// <summary>
        /// Total ISR
        /// </summary>
        [DataMember]
        public double fISR { get; set; }


        /// <summary>
        /// Total general
        /// </summary>
        [DataMember]
        public double fTotalGeneral { get; set; }

        /// <summary>
        /// Total Entregas
        /// </summary>
        [DataMember]
        public double fTotalEntregas { get; set; }

        /// <summary>
        /// Entregas
        /// </summary>
        [DataMember]
        public double fEntregas { get; set; }

        /// <summary>
        /// Total general con ISR
        /// </summary>
        [DataMember]
        public double fTotalGeneralConISR { get; set; }
    }
}
