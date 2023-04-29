using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managerr.MANAGER
{
    public class ManagerEmpleado
    {

        public ManagerEmpleado Instance
        {
            get
            {
                return new ManagerEmpleado();
            }
        }

        public int GuardaNuevoEMpleado(DTO.DTOEmpleado datos)
        {
            DB.PruebasEntities db = new DB.PruebasEntities();
            db.Configuration.LazyLoadingEnabled = false;

            int Id = Convert.ToInt32(db.Empleado_C_datos(datos.Nombre, datos.IdRol).FirstOrDefault());

            db.Dispose();

            return Id;
        }
    }
}
