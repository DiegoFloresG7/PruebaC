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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFEmpleado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFEmpleado.svc o WCFEmpleado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFEmpleado 
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
        public int GuardaEMpleados(DTOEmpleado datos)
        {
            return new Managerr.MANAGER.ManagerEmpleado().GuardaNuevoEMpleado(datos);
        }

        [OperationContract]
        /// <summary>
        /// Consulta los empleados
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public DTOEmpleado ConsultaEmpleado(int IdEmpleado)
        {
            return new Managerr.MANAGER.ManagerEmpleado().ConsultaEmpleadoBYId(IdEmpleado);
        }

        [OperationContract]
        /// <summary>
        /// Guarda entregas
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public int GuardaEntregasEMpleados(DTOEmpleado datos)
        {
            return new Managerr.MANAGER.ManagerEmpleado().GuardaEntregasEMpleado(datos);
        }


        [OperationContract]
        /// <summary>
        /// Consulta la nomina de empleados
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public List<DTOEmpleado> ConsultaNominao(DTOEmpleado Datos)
        {
            return new Managerr.MANAGER.ManagerEmpleado().CosnultaNomina(Datos);
        }


    }
}
