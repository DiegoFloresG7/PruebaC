using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Managerr.DTO;
using System.ServiceModel.Activation;

namespace WCFPruebas
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFCatalogo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFCatalogo.svc o WCFCatalogo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFCatalogo
    {
        [OperationContract]
        public void DoWork()
        {
            // Agregue aquí la implementación de la operación
            return;
        }

        [OperationContract]
        /// <summary>
        /// Consulta los empleados
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public DTOEmpleado ConsultaEmpleado(string Nombre)
        {
            return new Managerr.MANAGER.ManagerCatalogo().ConsultaEmpleado(Nombre); 
        }

        [OperationContract]
        /// <summary>
        /// Consulta los roles
        /// </summary>
        /// <returns></returns>
        public List<DTOGenerico> ConsultaROles()
        {
            return new Managerr.MANAGER.ManagerCatalogo().ConsultaRoles();
        }

        [OperationContract]
        /// <summary>
        /// Consulta el id del nuevo empleado
        /// </summary>
        /// <returns></returns>
        public int ConsultaIdNuevoEMpleado()
        {
            return new Managerr.MANAGER.ManagerCatalogo().ConsultaIdNuevoEMpleado();
        }
    }
}
