using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Managerr.DB;
using Managerr.DTO;

namespace Managerr.MANAGER
{
   public class ManagerCatalogo   
    {
       public ManagerCatalogo Instance
       {
           get
           {
               return new ManagerCatalogo();
           }
       }

       public int ConsultaIdNuevoEMpleado()
       {
           DB.PruebasEntities db = new DB.PruebasEntities();
           db.Configuration.LazyLoadingEnabled = false;

           int Id = Convert.ToInt32(db.Empleado_R_NuevoRegistro().FirstOrDefault());

           db.Dispose();

           return Id;
       }


       public List<DTOGenerico> ConsultaRoles()
       {
           DB.PruebasEntities db = new DB.PruebasEntities();
           db.Configuration.LazyLoadingEnabled = false;
           List<DTOGenerico> ListRoles = new List<DTOGenerico>();
           DTOGenerico Datos = new DTOGenerico();
           var resultadoStore = db.CtRol_R_datos();

           if (resultadoStore != null)
           {
               //Convierto el objeto a uno definido en la aplicacion
               ListRoles = resultadoStore.Select(p => new DTO.DTOGenerico
               {
                   ID = p.IdRol.ToString(),
                   Descripcion = p.DescripcionRol
               }).ToList();
             
           }
           ListRoles.Insert(0, new DTO.DTOGenerico() { ID = "0", Descripcion = "Seleccione" });

           db.Dispose();

           return ListRoles;
       }



       public DTOEmpleado ConsultaEmpleado(string Nombre)
       {
           DB.PruebasEntities db = new DB.PruebasEntities();
           db.Configuration.LazyLoadingEnabled = false;
        
           DTOEmpleado DatosEmpleado = new DTOEmpleado();
           var resultadoStore = db.Empleado_R_datos(Nombre);


           if (resultadoStore != null)
           {
               foreach (var item in resultadoStore)
               {
                   DatosEmpleado.Nombre = item.Nombre;
                   DatosEmpleado.IdEmpleado = item.IdEmpleado;
                   DatosEmpleado.IdRol = Convert.ToInt32(item.IdRol);


               }
           }

            db.Dispose();

           return DatosEmpleado;
       }

    }
}
