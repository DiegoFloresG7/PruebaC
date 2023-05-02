using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Managerr.DTO;

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

        public int GuardaNuevoEMpleado(DTOEmpleado datos)
        {
            DB.PruebasEntities db = new DB.PruebasEntities();
            db.Configuration.LazyLoadingEnabled = false;

            int Id = Convert.ToInt32(db.Empleado_C_datos(datos.IdEmpleado, datos.Nombre, datos.IdRol).FirstOrDefault());

            db.Dispose();

            return Id;
        }


        public DTOEmpleado ConsultaEmpleadoBYId (int IdEMpleado)
        {
            DB.PruebasEntities db = new DB.PruebasEntities();
            db.Configuration.LazyLoadingEnabled = false;

            DTOEmpleado DatosEmpleado = new DTOEmpleado();
            var resultadoStore = db.Empleado_R_IdEMPLEADO(IdEMpleado);


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


        public int GuardaEntregasEMpleado(DTOEmpleado datos)
        {
            DB.PruebasEntities db = new DB.PruebasEntities();
            db.Configuration.LazyLoadingEnabled = false;

            int Id = Convert.ToInt32(db.CantidadEntregasPorMes_C_datos(datos.IdEmpleado, datos.IdMes, datos.IdEntregas).FirstOrDefault());

            db.Dispose();

            return Id;
        }



        public  List<DTOEmpleado> CosnultaNomina(DTOEmpleado Datos)
        {
            DB.PruebasEntities db = new DB.PruebasEntities();
            db.Configuration.LazyLoadingEnabled = false;
            List<DTOEmpleado> ListNomina = new List<DTO.DTOEmpleado>();
            DTOEmpleado DatosEmpleado = new DTOEmpleado();
            var resultadoStore = db.Empleado_R_Nomina(Datos.IdEmpleado, Datos.IdMes);


            if (resultadoStore != null)
            {
                    //Convierto el objeto a uno definido en la aplicacion
                    ListNomina = resultadoStore.Select(p => new DTO.DTOEmpleado
                    {   
                        Nombre = p.NombreEmpleado.ToString(),
                        DescripcionRol = p.DesRol,
                        fBono = Convert.ToDouble(p.TotalBono),
                        fSalario = Convert.ToDouble(p.Salario),
                        fTotalBono = Convert.ToDouble(p.TotalBono) * Convert.ToInt32(p.TOTALENTREGA),
                        fTotalSalario = (((Convert.ToDouble(p.Salario) * 8) * 6) * 4),
                        fEntregas = Convert.ToDouble(p.TOTALENTREGA),
                        fTotalEntregas = Convert.ToDouble(p.TOTALENTREGA) * Convert.ToInt32(p.IdCantEnetregas),
                      
                    }).ToList();

                    foreach (var item in ListNomina)
                    {
                        item.fTotalGeneral = item.fTotalBono + item.fTotalSalario + item.fTotalEntregas;
                        if (item.fTotalGeneral <= 100000)
                        {
                            item.fISR = item.fTotalGeneral * .09;
                            item.fTotalGeneralConISR = item.fTotalGeneral - item.fISR;

                        }
                        else
                        {
                            item.fISR = item.fTotalGeneral * .12;
                            item.fTotalGeneralConISR = item.fTotalGeneral - item.fISR;
                        }
                    }
            }

       



            db.Dispose();

            return ListNomina;
        }

    }
}
